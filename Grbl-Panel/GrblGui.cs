using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using GrblPanel.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GrblPanel
{

    // TODO BG Generic Note: maybe it would be nice if a GCode file could call in a macro. But I have no idea how to get that to work! Well, In fact, maybe I have....:-)
    public partial class GrblGui
    {
        public int GrblVersion;           // 0 for 0.x, 1 for 1.x version
        public GrblIF grblPort;    // Public so that the timer thread can see grblPort
        private GrblStatus status;            // For status polling
        private GrblJogging jogging;          // for jogging control
        private GrblPosition position;        // for machine and work positioning
        public static GrblGcode gcode;        // For processing gcode file
        public static GrblGcodeView gcodeview;       // for display of gcode
        public GrblOffsets offsets;           // for handling of offsets
        public GrblState state;              // to track gcode state
        public GrblSettings settings;         // To handle Settings related ops
        public GrblOverrides ovrrides;       // to display overrides
        public GrblPins pins;               // to display Pin states
        public GrblInfo info;                 // to display Grbl information
        private bool _exitClicked = false;   // to separate Close (x) from File/Exit

        public void myhandler(object sender, UnhandledExceptionEventArgs args)
        {
            // Show exception in usable manner
            Exception e = (Exception)args.ExceptionObject;
            MessageBox.Show("Exception: " + e.Message + Constants.vbLf + e.InnerException.Message + Constants.vbLf + e.StackTrace);
        }

        private void grblgui_Load(object sender, EventArgs e)
        {
            // Use handler below to trap wierd problems at Form creation, e.g. when going from .Net 4 to 3.5
            AppDomain.CurrentDomain.UnhandledException += myhandler;

            // Ensure that we always interpret things such as '.' as decimal (instead of ',' in EU)
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-CA");

            // Set user preferences/defaults
            Application.EnableVisualStyles();

            // Check to see if this is a new install, if so then copy Settings from previous version
            if (My.MySettingsProperty.Settings.UpgradeSettings)
            {
                My.MySettingsProperty.Settings.Upgrade();
                My.MySettingsProperty.Settings.UpgradeSettings = false;
                My.MySettingsProperty.Settings.Save();
            }

            // Trick the Settings tab page into loading its controls so that
            // the config settings are avail to rest of program. Seems kludgy but  there is no other solution
            // if you want to use Tab pages this way. It makes sense as controls are not run until they get focus.
            tabPgSettings.Show();
            tabPgInterface.Show();

            // Are we right handed?

            SwitchSides(cbSettingsLeftHanded.Checked);
            grblPort = new GrblIF();
            var arggui = this;
            settings = new GrblSettings(ref arggui);
            var arggui1 = this;
            status = new GrblStatus(ref arggui1);
            var arggui2 = this;
            jogging = new GrblJogging(ref arggui2);
            var arggui3 = this;
            position = new GrblPosition(ref arggui3);
            var arggui4 = this;
            gcode = new GrblGcode(ref arggui4);
            var argview = dgvGcode;
            gcodeview = new GrblGcodeView(ref argview);
            dgvGcode = argview;
            var arggui5 = this;
            offsets = new GrblOffsets(ref arggui5);
            var arggui6 = this;
            state = new GrblState(ref arggui6);
            var arggui7 = this;
            ovrrides = new GrblOverrides(ref arggui7);
            var arggui8 = this;
            pins = new GrblPins(ref arggui8);
            var arggui9 = this;
            info = new GrblInfo(ref arggui9);
            rescanPorts();
            if (!string.IsNullOrEmpty(My.MySettingsProperty.Settings.Port))
            {
                cbPorts.SelectedIndex = cbPorts.FindStringExact(My.MySettingsProperty.Settings.Port);
            }

            cbBaud.SelectedText = My.MySettingsProperty.Settings.Baud;
            grblPort.baudrate = Convert.ToInt32(My.MySettingsProperty.Settings.Baud);
            tcConnection.SelectedIndex = Conversions.ToInteger(My.MySettingsProperty.Settings.ConnectionType);
            tbIPAddress.Text = My.MySettingsProperty.Settings.IPAddress;
            if (cbSettingsConnectOnLoad.Checked)
            {
                // auto connect
                btnConnDisconnect_Click(btnConnect, null);
            }

            EnableMacroButtons();

            // Capture all keyboard events so that we get to see arrow keys. If we don't do this then
            // the various controls keep the arrow keys if one gets focus
            var argowner = this;
            Application.AddMessageFilter(new MsgFilter(ref argowner));
        }

        private void grblgui_unload(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (_exitClicked)  // from File/Exit
            {
                tidyClose();
                return;
            }
            // Ignore attempt to exit
            else if (Interaction.MsgBox(Resources.GrblGui_grblgui_unload_AreYouCertainThatYouWantToClose, MsgBoxStyle.OkCancel) == MsgBoxResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // The only valid way to exit
            _exitClicked = true;
            tidyClose();
        }

        private void tidyClose()
        {
            // Close down in a tidy fashion
            grblPort.Disconnect();
            gcode.shutdown();
            status.shutdown();
            jogging.shutdown();
            position.shutdown();
            Application.Exit();
        }

        public class MsgFilter : IMessageFilter
        {
            private GrblGui _gui;

            public MsgFilter(ref GrblGui owner)
            {
                _gui = owner;
            }

            /// <summary>
        /// Handle key press overrides and keyboard mapping
        /// </summary>
        /// <param name="msg"></param>
        /// <returns>True if key msg was handled</returns>
            bool IMessageFilter.PreFilterMessage(ref Message msg)
            {
                bool handled = false;
                if (msg.Msg == 0x100)  // We have a KeyDown event
                {
                    if (_gui.gbJogging.Enabled & !_gui.tbSendData.ContainsFocus)
                    {
                        if (_gui.cbSettingsKeyboardJogging.Checked)
                        {
                            switch (msg.WParam)   // ignoring modifiers for now
                            {
                                case 37:
                                    {
                                        _gui.btnXMinus.PerformClick();
                                        handled = true;
                                        break;
                                    }

                                case 39:
                                    {
                                        _gui.btnXPlus.PerformClick();
                                        handled = true;
                                        break;
                                    }

                                case 38:
                                    {
                                        _gui.btnYPlus.PerformClick();
                                        handled = true;
                                        break;
                                    }

                                case 40:
                                    {
                                        _gui.btnYMinus.PerformClick();
                                        handled = true;
                                        break;
                                    }

                                case 33:
                                    {
                                        _gui.btnZPlus.PerformClick();
                                        handled = true;
                                        break;
                                    }

                                case 34:
                                    {
                                        _gui.btnZMinus.PerformClick();
                                        handled = true;
                                        break;
                                    }
                            }

                            if (handled)
                            {
                                return true;
                            }
                        }
                    }

                    // Non-jog mappings
                    if (!_gui.tbSendData.ContainsFocus & !_gui.gbEditor.ContainsFocus & !_gui.gbSettingsMisc.ContainsFocus & !_gui.gbSettingsJogging.ContainsFocus & !_gui.gbSettingsPosition.ContainsFocus & !_gui.tbWorkX.ContainsFocus & !_gui.tbWorkY.ContainsFocus & !_gui.tbWorkZ.ContainsFocus) // in case user is working in MDI
                    {
                        switch (msg.WParam)
                        {
                            case 107:
                            // Act on Distance Increment keyboard requests
                            case var @case when @case == ((int)Keys.Oemplus & Conversions.ToInteger(My.MyProject.Computer.Keyboard.ShiftKeyDown)):
                                {
                                    _gui.changeDistanceIncrement(true);
                                    handled = true;
                                    break;
                                }

                            case 109:
                            case 189:
                                {
                                    _gui.changeDistanceIncrement(false);
                                    handled = true;
                                    break;
                                }

                            case 111:

                            // Act on Feed Rate keyboard requests
                            case 0xBF:
                                {
                                    _gui.changeFeedRate(true);
                                    handled = true;
                                    break;
                                }

                            case 106:
                            case var case1 when case1 == ((int)Keys.D8 & Conversions.ToInteger(My.MyProject.Computer.Keyboard.ShiftKeyDown)):
                                {
                                    _gui.changeFeedRate(false);
                                    handled = true;
                                    break;
                                }

                            // Reset x,y,z axis to 0
                            case var case2 when case2 == ((int)Keys.X & Conversions.ToInteger(!My.MyProject.Computer.Keyboard.CtrlKeyDown)):
                                {
                                    _gui.btnWorkX0.PerformClick();
                                    handled = true;
                                    break;
                                }

                            case 89:
                                {
                                    _gui.btnWorkY0.PerformClick();
                                    handled = true;
                                    break;
                                }

                            case 90:
                                {
                                    _gui.btnWorkZ0.PerformClick();

                                    // Reset all axes to 0
                                    handled = true;
                                    break;
                                }

                            case 45:
                                {
                                    break;
                                }

                            case 65:
                                {
                                    _gui.btnWork0.PerformClick();

                                    // Motion
                                    handled = true;
                                    break;
                                }

                            case 32:
                                {
                                    if (_gui.btnStartResume.Text == "Start")
                                    {
                                        _gui.btnHold.PerformClick();
                                    }
                                    else
                                    {
                                        _gui.btnStartResume.PerformClick();
                                    }

                                    handled = true;
                                    break;
                                }

                            case var case3 when case3 == ((int)Keys.R & Conversions.ToInteger(My.MyProject.Computer.Keyboard.CtrlKeyDown)):
                                {
                                    // Start sending the file
                                    _gui.btnFileSend.PerformClick();

                                    // Single Step
                                    handled = true;
                                    break;
                                }

                            case 79:
                                {
                                    _gui.btnFileStep.PerformClick();

                                    // Macro 1 execute
                                    handled = true;
                                    break;
                                }

                            case 113:
                                {
                                    var macro1 = _gui.IsMacroBtn(1);
                                    if (!Information.IsNothing(macro1))
                                    {
                                        macro1.PerformClick();
                                        handled = true;
                                    }

                                    break;
                                }

                            case 114:
                                {
                                    var macro1 = _gui.IsMacroBtn(2);
                                    if (!Information.IsNothing(macro1))
                                    {
                                        macro1.PerformClick();
                                        handled = true;
                                    }

                                    break;
                                }

                            case 115:
                                {
                                    var macro1 = _gui.IsMacroBtn(3);
                                    if (!Information.IsNothing(macro1))
                                    {
                                        macro1.PerformClick();
                                        handled = true;
                                    }

                                    break;
                                }

                            case 116:
                                {
                                    var macro1 = _gui.IsMacroBtn(4);
                                    if (!Information.IsNothing(macro1))
                                    {
                                        macro1.PerformClick();
                                        handled = true;
                                    }

                                    break;
                                }

                            case 117:
                                {
                                    var macro1 = _gui.IsMacroBtn(5);
                                    if (!Information.IsNothing(macro1))
                                    {
                                        macro1.PerformClick();
                                        handled = true;
                                    }

                                    break;
                                }

                            // Grbl State
                            case var case4 when case4 == ((int)Keys.H & Conversions.ToInteger(My.MyProject.Computer.Keyboard.CtrlKeyDown)):
                                {
                                    _gui.btnHold.PerformClick();
                                    handled = true;
                                    break;
                                }

                            case var case5 when case5 == ((int)Keys.U & Conversions.ToInteger(My.MyProject.Computer.Keyboard.CtrlKeyDown)):
                                {
                                    _gui.btnUnlock.PerformClick();
                                    handled = true;
                                    break;
                                }

                            case var case6 when case6 == ((int)Keys.X & Conversions.ToInteger(My.MyProject.Computer.Keyboard.CtrlKeyDown)):
                                {
                                    _gui.btnReset.PerformClick();
                                    handled = true;
                                    break;
                                }

                            // Overrides
                            case var case7 when case7 == ((int)Keys.F & Conversions.ToInteger(My.MyProject.Computer.Keyboard.ShiftKeyDown)):
                                {
                                    _gui.btnFeedPlus.PerformClick();
                                    handled = true;
                                    break;
                                }

                            case var case8 when case8 == ((int)Keys.F & Conversions.ToInteger(!(My.MyProject.Computer.Keyboard.ShiftKeyDown | My.MyProject.Computer.Keyboard.CtrlKeyDown))):
                                {
                                    _gui.btnFeedMinus.PerformClick();
                                    handled = true;
                                    break;
                                }

                            case var case9 when case9 == ((int)Keys.F & Conversions.ToInteger(My.MyProject.Computer.Keyboard.CtrlKeyDown)):
                                {
                                    _gui.btnFeedOverrideReset.PerformClick();
                                    handled = true;
                                    break;
                                }

                            case var case10 when case10 == ((int)Keys.S & Conversions.ToInteger(My.MyProject.Computer.Keyboard.ShiftKeyDown)):
                                {
                                    _gui.btnSpindlePlus.PerformClick();
                                    handled = true;
                                    break;
                                }

                            case var case11 when case11 == ((int)Keys.S & Conversions.ToInteger(!(My.MyProject.Computer.Keyboard.ShiftKeyDown | My.MyProject.Computer.Keyboard.CtrlKeyDown))):
                                {
                                    _gui.btnSpindleMinus.PerformClick();
                                    handled = true;
                                    break;
                                }

                            case var case12 when case12 == ((int)Keys.S & Conversions.ToInteger(My.MyProject.Computer.Keyboard.CtrlKeyDown)):
                                {
                                    _gui.btnSpindleOverrideReset.PerformClick();
                                    handled = true;
                                    break;
                                }

                            case var case13 when case13 == ((int)Keys.R & Conversions.ToInteger(My.MyProject.Computer.Keyboard.ShiftKeyDown)):
                                {
                                    _gui.btnRapidOverrideReset.PerformClick();
                                    handled = true;
                                    break;
                                }

                            case var case14 when case14 == ((int)Keys.R & Conversions.ToInteger(My.MyProject.Computer.Keyboard.CtrlKeyDown)):
                                {
                                    _gui.btnRapidOverride25.PerformClick();
                                    handled = true;
                                    break;
                                }

                            case var case15 when case15 == ((int)Keys.R & Conversions.ToInteger(!(My.MyProject.Computer.Keyboard.ShiftKeyDown | My.MyProject.Computer.Keyboard.CtrlKeyDown))):
                                {
                                    _gui.btnRapidOverride50.PerformClick();

                                    // Miscellaneous mappings
                                    handled = true;     // Go Home
                                    break;
                                }

                            case 72:
                                {
                                    _gui.btnHome.PerformClick();
                                    handled = true;
                                    break;
                                }

                            case var case16 when case16 == ((int)Keys.D1 & Conversions.ToInteger(My.MyProject.Computer.Keyboard.CtrlKeyDown)):
                                {
                                    _gui.btnWorkSoftHome.PerformClick();
                                    handled = true;
                                    break;
                                }

                            case var case17 when case17 == ((int)Keys.D2 & Conversions.ToInteger(My.MyProject.Computer.Keyboard.CtrlKeyDown)):
                                {
                                    _gui.btnWorkSpclPosition.PerformClick();
                                    handled = true;
                                    break;
                                }

                            case var case18 when case18 == ((int)Keys.C & Conversions.ToInteger(My.MyProject.Computer.Keyboard.CtrlKeyDown)):
                                {
                                    _gui.btnConnect.PerformClick();
                                    handled = true;
                                    break;
                                }
                        }
                    }

                    if (handled)
                    {
                        return true;
                    }
                }

                // We didn't handle event so pass it along
                return false;
            }
        }

        /// <summary>
    /// Override key handling for Enter
    /// </summary>
    /// <param name="msg"></param>
    /// <param name="keyData"></param>
    /// <returns></returns>
    /// We do this to capture Enter key for some controls, so that users can use Enter instead of Double Click
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Return True if we handled the key press
            if (keyData == Keys.Enter)
            {
                var ctrl = ActiveControl;
                if (ctrl.Parent.Name == "tpOffsets")
                {
                    // we are editing the offsets
                    SendOffsets((string)ctrl.Tag, ctrl.Text);
                    return true;
                }

                if (dgGrblSettings.IsCurrentCellDirty)
                {
                    // we are editing in the Grbl Settings grid
                    if (!Information.IsNothing(dgGrblSettings.CurrentRow))
                    {
                        // we have something to change (aka ignore errant double clicks)
                        string param = dgGrblSettings.CurrentRow.Cells[0].Value.ToString() + "=" + dgGrblSettings.CurrentCell.EditedFormattedValue.ToString();
                        gcode.sendGCodeLine(param);
                        Thread.Sleep(200);              // Have to wait for EEProm write
                        gcode.sendGCodeLine("$$");   // Refresh
                        return true;
                    }
                }
                // Process setting of offset from main display
                if (tbWorkX.ContainsFocus)
                {
                    SendOffsets(lblPositionCurrentOffset.Text + "X", tbWorkX.Text);
                    tabCtlPosition.Focus();
                    return true;
                }

                if (tbWorkY.ContainsFocus)
                {
                    SendOffsets(lblPositionCurrentOffset.Text + "Y", tbWorkY.Text);
                    tabCtlPosition.Focus();
                    return true;
                }

                if (tbWorkZ.ContainsFocus)
                {
                    SendOffsets(lblPositionCurrentOffset.Text + "Z", tbWorkZ.Text);
                    tabCtlPosition.Focus();
                    return true;
                }
            }

            // we didn't do anything with the key so pass it on
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void SwitchSides(bool side)
        {
            // We switch GUI sides

            Control ctl;

            // Get existing locations for X      ' Issue #17,18 and others fix
            int left_X;
            int right_X;
            left_X = gbJogging.Width + 3;
            right_X = gbPosition.Width + 3;
            if (side)    // we are going left handed
            {
                foreach (Control currentCtl in new[] { gbGrbl, gbJogging, gbGcode })
                {
                    ctl = currentCtl;
                    ctl.Location = new Point(3, ctl.Location.Y);
                }

                gbMDI.Location = new Point(3 + gbGrbl.Width + 3, gbMDI.Location.Y);
                foreach (Control currentCtl1 in new[] { gbPosition, gbStatus, gbControl })
                {
                    ctl = currentCtl1;
                    ctl.Location = new Point(3 + left_X, ctl.Location.Y);
                }
            }
            else
            {
                foreach (Control currentCtl2 in new[] { gbGrbl, gbJogging, gbGcode })
                {
                    ctl = currentCtl2;
                    ctl.Location = new Point(3 + right_X, ctl.Location.Y);
                }

                gbMDI.Location = new Point(3 + right_X + gbGrbl.Width + 3, gbMDI.Location.Y);
                foreach (Control currentCtl3 in new[] { gbPosition, gbStatus, gbControl })
                {
                    ctl = currentCtl3;
                    ctl.Location = new Point(3, ctl.Location.Y);
                }
            }
        }

        private void cbSettingsLeftHanded_CheckedChanged(object sender, EventArgs e)
        {
            // Use is switching sides
            SwitchSides(cbSettingsLeftHanded.Checked);
        }

        private void lbPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            // set desired com port
            // always remember as new default
            // allow re-connect to new port
            grblPort.comport = Conversions.ToString(cbPorts.SelectedItem);
            // Set as new default
            My.MySettingsProperty.Settings.Port = Conversions.ToString(cbPorts.SelectedItem);
            btnConnect.Enabled = true;
        }

        private void cbBaud_SelectedIndexChanged(object sender, EventArgs e)
        {
            // set desired baud rate
            grblPort.baudrate = Conversions.ToInteger(cbBaud.SelectedItem.ToString());
            My.MySettingsProperty.Settings.Baud = grblPort.baudrate.ToString(); // always remember as new default
            My.MySettingsProperty.Settings.Save();
            btnConnect.Enabled = true;
        }

        private void btnConnDisconnect_Click(object sender, EventArgs e)
        {
            // Open connection to Grbl
            // This routine is used for both Com and IP connections. Buttons are differentiated by using Tag property.

            Button btn = (Button)sender;
            var connected = default(bool);
            switch (btn.Text ?? "")
            {
                case var @case when @case == (Resources.Button_Connection_Text_Connect ?? ""):
                    {
                        switch ((string)btn.Tag ?? "")
                        {
                            case "COM":
                                {
                                    connected = grblPort.Connect(GrblIF.ConnectionType.Serial);
                                    if (connected == true)
                                    {
                                        // disable other Connect button to prevent reconnects
                                        btn.Text = Resources.GrblGui_btnConnDisconnect_Click_Disconnect;
                                        btnIPConnect.Enabled = false;
                                    }
                                    else
                                    {
                                        MessageBox.Show(Resources.GrblGui_btnConnDisconnect_Click_PleaseSelectAComPort + Constants.vbCr + Resources.GrblGui_btnConnDisconnect_Click_OrConnectTheCable, Resources.GrblGui_btnConnDisconnect_Click_Connect_Error, MessageBoxButtons.OK);
                                        grblPort.rescan();
                                        return;
                                    }

                                    break;
                                }

                            case "IP":
                                {
                                    if (tbIPAddress.TextLength <= 0)
                                    {
                                        MessageBox.Show(Resources.GrblGui_btnConnDisconnect_Click_PleaseEnterAnIPAddress + Constants.vbCr + Resources.GrblGui_btnConnDisconnect_Click_AndAPortNumberInTheFormat + Constants.vbCr + "\"<ip address>:<port number>\"", Resources.GrblGui_btnConnDisconnect_Click_Connect_Error, MessageBoxButtons.OK);
                                        return;
                                    }

                                    var address = tbIPAddress.Text.Split(new[] { ":" }, StringSplitOptions.RemoveEmptyEntries);
                                    grblPort.ipaddress = System.Net.IPAddress.Parse(address[0]);
                                    grblPort.portnum = int.Parse(address[1]);
                                    if (grblPort.portnum == 0)
                                    {
                                        MessageBox.Show(Resources.GrblGui_btnConnDisconnect_Click_PleaseEnterAnIPAddress + Constants.vbCr + Resources.GrblGui_btnConnDisconnect_Click_AndAPortNumberInTheFormat + Constants.vbCr + "\"<ip address>:<port number>\"", Resources.GrblGui_btnConnDisconnect_Click_Connect_Error, MessageBoxButtons.OK);
                                        return;
                                    }
                                    // finally we try to connect
                                    connected = grblPort.Connect(GrblIF.ConnectionType.IP);
                                    if (connected == true)
                                    {
                                        // disable other Connect button to prevent reconnects
                                        btn.Text = Resources.GrblGui_btnConnDisconnect_Click_Disconnect;
                                        btnConnect.Enabled = false;
                                    }
                                    else
                                    {
                                        MessageBox.Show(Resources.GrblGui_btnConnDisconnect_Click_PleaseEnterAnIPAddress + Constants.vbCr + Resources.GrblGui_btnConnDisconnect_Click_AndAPortNumberInTheFormat + Constants.vbCr + "\"<ip address>:<port number>\"", Resources.GrblGui_btnConnDisconnect_Click_Connect_Error, MessageBoxButtons.OK);
                                        return;
                                    }

                                    break;
                                }
                        }

                        if (connected == true)
                        {
                            // Wake up the subsystems
                            // TODO Replace these calls with Event Connected handling in each object
                            status.enableStatus(true);
                            Thread.Sleep((int)Math.Round(Conversions.ToDouble(tbSettingsStartupDelay.Text) * 1000d));             // Give Grbl time to wake up from Reset
                            gcode.enableGCode(true);
                            jogging.enableJogging(true);
                            position.enablePosition(true);
                            offsets.enableOffsets(true);
                            state.EnableState(true);
                            settings.EnableState(true);
                            connected?.Invoke("Connected");      // tell everyone of the happy event
                            setSubPanels(Resources.GrblGui_btnConnDisconnect_Click_Idle);
                            // Start the status poller
                            statusPrompt(Resources.MsgFilter_PreFilterMessage_Start);
                        }

                        break;
                    }

                case var case1 when case1 == (Resources.GrblGui_btnConnDisconnect_Click_Disconnect ?? ""):
                    {
                        // it must be a disconnect
                        grblPort.Disconnect();
                        btnConnect.Text = Resources.Button_Connection_Text_Connect;
                        btnIPConnect.Text = Resources.Button_Connection_Text_Connect;
                        btnConnect.Enabled = true;
                        btnIPConnect.Enabled = true;

                        // Stop the status poller
                        // TODO Replace these calls with Event Disconnected handling in each object
                        statusPrompt(Resources.GrblGui_btnConnDisconnect_Click_End);
                        status.enableStatus(false);
                        jogging.enableJogging(false);
                        position.enablePosition(false);
                        gcode.enableGCode(false);
                        offsets.enableOffsets(false);
                        state.EnableState(false);
                        settings.EnableState(false);
                        connected?.Invoke("Disconnected");
                        setSubPanels(Resources.GrblGui_btnConnDisconnect_Click_Disconnected); // block GUI 
                        return;
                    }
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            // Send a line to Grbl
            gcode.sendGCodeLine(tbSendData.Text);
        }

        private void tbSendData_KeyDown(object sender, KeyEventArgs e)
        {
            // Do same as clicking Send button
            if (e.KeyCode == Keys.Return)
            {
                // Send a line to Grbl
                gcode.sendGCodeLine(tbSendData.Text);
            }
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.AboutBox.ShowDialog();
            My.MyProject.Forms.AboutBox.BringToFront();
        }

        private void OptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabControl1.SelectedTab = tabPgSettings;
            TabControl1.SelectedTab.Show();
        }

        private void btnFileSend_MouseHover(object sender, EventArgs e)
        {
        }

        private void rescanPorts()
        {
            {
                var withBlock = cbPorts;
                withBlock.Items.Clear();
                withBlock.Items.AddRange(grblPort.rescan());
            }
        }

        private void btnRescanPorts_Click(object sender, EventArgs e)
        {
            // Refresh the list of ports
            rescanPorts();
        }

        public void enableGrbl(bool action)
        {
            // enable the Grbl connect group
            gbGrbl.Enabled = action;
        }

        public void setSubPanels(string active)
        {
            // enable/disable the various groups/panels on the GUI
            // This prevents user from doing things such as jogging while running a gcode file
            switch (active ?? "")
            {
                case "GCodeStream":
                    {
                        // We are running a file
                        gbJogging.Enabled = false;
                        gbPosition.Enabled = false;
                        gbMDI.Enabled = false;
                        gbGrbl.Enabled = false;
                        gbState.Enabled = false;
                        gbSettingsJogging.Enabled = false;
                        gbSettingsMisc.Enabled = false;
                        gbSettingsOffsets.Enabled = false;
                        gbSettingsPosition.Enabled = false;
                        gbGrblSettings.Enabled = false;
                        btnStatusClearPins.Enabled = false;
                        break;
                    }

                case var @case when @case == (Resources.GrblGui_btnConnDisconnect_Click_Disconnected ?? ""):
                    {
                        // We are not connected so not much you can do
                        gbJogging.Enabled = false;
                        gbPosition.Enabled = false;
                        gbMDI.Enabled = false;
                        gbGrbl.Enabled = true;   // Allow only Connect
                        gbState.Enabled = false;
                        gbSettingsJogging.Enabled = false;
                        gbSettingsMisc.Enabled = false;
                        gbSettingsOffsets.Enabled = false;
                        gbSettingsPosition.Enabled = false;
                        gbGrblSettings.Enabled = false;
                        btnStatusClearPins.Enabled = false;
                        break;
                    }

                case var case1 when case1 == (Resources.GrblGui_btnConnDisconnect_Click_Idle ?? ""):
                    {
                        // General use, no gcode streaming
                        gbJogging.Enabled = true;
                        gbPosition.Enabled = true;
                        gbMDI.Enabled = true;
                        gbGrbl.Enabled = true;
                        gbState.Enabled = true;
                        gbSettingsJogging.Enabled = true;
                        gbSettingsMisc.Enabled = true;
                        gbSettingsOffsets.Enabled = true;
                        gbSettingsPosition.Enabled = true;
                        gbGrblSettings.Enabled = true;
                        btnStatusClearPins.Enabled = true;
                        break;
                    }
            }
        }

        // Event Handler definitions

        // These are used to tell other objects that something meaningful happened

        // Raised when we succesfully connected to Grbl
        public event ConnectedEventHandler Connected;

        public delegate void ConnectedEventHandler(string msg);
        // Event template for Settings Retrieved indication
        public event GrblSettingsRetrievedEventHandler GrblSettingsRetrieved;

        public delegate void GrblSettingsRetrievedEventHandler();


        // Private Sub MacroButtonEditorToolStripMenuItem_Click(sender As Object, e As EventArgs)
        // GrblMacroButtons.ShowDialog()
        // EnableMacroButtons()
        // End Sub

        private void EnableMacroButtons()
        {
            Button b;
            var iButtonCounter = default(int);
            int iButtonMargin = 7;
            int iButtonRowSum = 0;
            int iButtonRowTop = 62;
            var DefaultDimension = new Size(58, 20);
            string[] macro;

            // make sure there are no macro buttons in the group before we add new ones
            for (int iLoopCounter = gbMDI.Controls.Count - 1; iLoopCounter >= 0; iLoopCounter -= 1)
            {
                var mButton = gbMDI.Controls[iLoopCounter];
                if (LikeOperator.LikeString(mButton.Name, "btnMacro*", CompareMethod.Binary))
                {
                    gbMDI.Controls.Remove(mButton);
                    mButton.Dispose();
                }
            }


            // now start adding buttons for each macro item in the registry
            // If Not (instance Is Nothing) Then
            foreach (string item in macroNames)
            {
                macro = Strings.Split(Conversions.ToString(My.MySettingsProperty.Settings[item]), ":");
                if (macro.Count() == 2)
                {
                    b = new Button();
                    b.Size = DefaultDimension;
                    b.Location = new Point(iButtonRowSum + iButtonMargin, iButtonRowTop);
                    b.Name = "btnMacro" + iButtonCounter;
                    b.Text = macro[0].ToString();
                    b.Tag = macro[1].ToString();
                    b.Click += MacroButton_Click;
                    gbMDI.Controls.Add(b);
                    iButtonRowSum += iButtonMargin + b.Width;
                    iButtonCounter += 1;
                }
            }
            // End If
        }

        private void MacroButton_Click(object sender, EventArgs e)
        {
            int iCounter;
            string[] aData;
            aData = Strings.Split(Strings.Trim(Conversions.ToString(((Button)sender).Tag)), Constants.vbCrLf); // split the gcode in case the user uses multiple lines 
            var loopTo = aData.Count() - 1;
            for (iCounter = 0; iCounter <= loopTo; iCounter++)
                gcode.sendGCodeLine(aData[iCounter]);
        }

        private void tbWorkX_TextChanged(object sender, EventArgs e)
        {
            string Index = "";
            TextBox sndr = (TextBox)sender;
            switch (lblPositionCurrentOffset.Text.Substring(0, 3) ?? "") // Get the offset value
            {
                case "G54":
                    {
                        Index = "P1";
                        break;
                    }

                case "G55":
                    {
                        Index = "P2";
                        break;
                    }

                case "G56":
                    {
                        Index = "P3";
                        break;
                    }

                case "G57":
                    {
                        Index = "P4";
                        break;
                    }

                case "G58":
                    {
                        Index = "P5";
                        break;
                    }

                case "G59":
                    {
                        Index = "P6";
                        break;
                    }
            }

            gcode.sendGCodeLine("G10 L2 " + Index + " " + sndr.Tag.ToString() + sndr.Text);
        }
    }
}