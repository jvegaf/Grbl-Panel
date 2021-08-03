using System;
using System.IO;
using System.Windows.Forms;
using GrblPanel.My.Resources;
using Microsoft.VisualBasic;

namespace GrblPanel
{
    public partial class GrblGui
    {
        public class GrblGcode
        {
            // A Class to handle reading, parsing, removing white space
            // - Handles the sending to Grbl using either the simple or advanced protocols
            // - Handles introducing canned cycles (M06, G81/2/3)
            // While we are sending the file, lock out manual functions
            private GrblGui _gui;
            private bool _wtgForAck = false;         // 
            private bool _runMode = true;            // 
            private bool _stepMode = false;              // for single stepping gcode
            private bool _sendAnotherLine = false;   // 
            private int _lineCount = 0;               // No of lines left to send
            private int _linesDone = 0;
            private bool _m30Flag = false;             // M30 detected in gcode stream

            // Handle file read (Gcode in) and Write (Gcode save)
            private StreamReader _inputfh;
            private int _inputcount;

            // For timings
            private Elapsed _elapsed;

            public GrblGcode(ref GrblGui gui)
            {
                _gui = gui;
                _elapsed = new Elapsed(_gui.lblElapsedTime);
            }

            public void enableGCode(bool action)
            {
                // Can't use new if we need to reference _gui as it causes Form creation errors
                _gui.gbGcode.Enabled = action;
                if (action == true)
                {
                    // Enable looking at responses now, for use by manual commands
                    _gui.grblPort.addRcvDelegate(_gui.processLineEvent);
                    _gui.btnFileSelect.Enabled = true;
                }
                else
                {
                    _gui.grblPort.deleteRcvDelegate(_gui.processLineEvent);
                }
            }

            public bool loadGCodeFile(string file)
            {
                string data;
                // Start from clean slate
                ResetGcode(true);
                // Load the file, count lines
                _inputfh = My.MyProject.Computer.FileSystem.OpenTextFileReader(file);
                // count the lines while loading up
                _inputcount = 0;
                while (!_inputfh.EndOfStream)
                {
                    data = _inputfh.ReadLine();    // Issue #20, ignore '%'
                    if (data != "%")
                    {
                        gcodeview.Insert(data, "File", (_inputcount + 1).ToString());         // Plan B
                        _inputcount += 1;
                    }
                }

                lineCount = _inputcount;
                _gui.lblTotalLines.Text = _inputcount.ToString();      // Issue #60
                gcodeview.RefreshView(lineCount); // refresh data to the DataGridView
                if (!Information.IsNothing(_inputfh))
                {
                    _inputfh.Close();
                }        // Issue #19

                return true;
            }

            public void closeGCodeFile()
            {
                if (!Information.IsNothing(_inputfh))
                {
                    _inputfh.Close();
                }

                _gui.tbGcodeFile.Text = "";
                _inputcount = 0;
            }

            public void sendGcodeFile()
            {
                _elapsed.BeginTimer();

                // Workflow:
                // Disable other panels to prevent operator error
                _gui.setSubPanels("GCodeStream");
                // set sendAnotherLine
                // raise processLineEvent
                lineCount = _inputcount;
                linesDone = 0;
                wtgForAck = false;
                runMode = true;
                sendAnotherLine = true;
                gcodeview.fileMode = true;
                _gui.processLineEvent("");              // Prime the pump
            }

            public void sendGCodeLine(string data)
            {
                // Send a line immediately
                // This can only happen when not sending a file, buttons are interlocked
                _runMode = false;
                gcodeview.fileMode = false;
                if (data.StartsWith("$J") | !(data.StartsWith("$") | data.StartsWith("?")))
                {
                    // add to display
                    // _gui.gcodeview.Insert(data, 0)
                    {
                        var withBlock = gcodeview;
                        withBlock.Insert(data, "MDI", 0.ToString());
                        gcode.lineCount += 1;
                        // we are always be the last item in manual mode
                        withBlock.UpdateGcodeSent(-1);
                    }
                    // Expect a response from Grbl
                    wtgForAck = true;
                }

                _gui.state.ProcessGCode(data);            // Keep Gcode State object in the loop
                _gui.grblPort.sendData(data);
            }

            public void sendGCodeFilePause()
            {
                _elapsed.StopTimer();

                // Pause the file send
                _sendAnotherLine = false;
                _runMode = false;
            }

            public void sendGCodeFileResume()
            {
                _elapsed.ResumeTimer();

                // Resume sending of file
                _sendAnotherLine = true;
                _runMode = true;
                _stepMode = false;
                gcodeview.fileMode = true;
                _gui.processLineEvent("");              // Prime the pump again
            }

            public void sendGCodeFileStep()
            {
                // Single Step Line from file
                _sendAnotherLine = true;
                _runMode = false;
                _stepMode = true;
                gcodeview.fileMode = true;
                _gui.processLineEvent("");              // Prime the pump again
            }

            public void sendGCodeFileStop()
            {
                _elapsed.StopTimer();

                // reset state variables
                if (runMode)
                {
                    wtgForAck = false;
                    runMode = false;
                    sendAnotherLine = false;
                    gcodeview.fileMode = false;        // allow manual mode gcode send

                    // Make the fileStop button go click, to stop the file send
                    // and set the buttons
                    _gui.btnFileGroup_Click(_gui.btnFileStop, null);
                }
            }

            public void sendGCodeFileRewind()
            {
                _elapsed.StopTimer();

                // reset state variables
                if (runMode)
                {
                    wtgForAck = false;
                    runMode = false;
                    sendAnotherLine = false;
                    gcodeview.fileMode = false;        // allow manual mode gcode send
                    gcode.sendGCodeFilePause();
                    // gcode.closeGCodeFile()
                    {
                        var withBlock = _gui;
                        // Re-enable manual control
                        withBlock.setSubPanels(Resources.GrblGui_btnConnDisconnect_Click_Idle);
                        withBlock.btnFileSelect.Enabled = true;
                        withBlock.btnFileSend.Tag = "Send";
                        withBlock.btnFileSend.Enabled = true;
                        withBlock.btnFilePause.Enabled = false;
                        withBlock.btnFileStop.Enabled = false;
                        withBlock.btnFileReload.Enabled = true;
                        withBlock.lblCurrentLine.Text = "0";          // Issue #60
                    }
                }

                gcodeview.Rewind();
            }

            public void shutdown()
            {
                // Close up shop
                ResetGcode(true);
            }

            public void ResetGcode(bool fullstop)
            {
                // Clear out all variables etc to initial state
                lineCount = 0;
                linesDone = 0;
                _gui.lblTotalLines.Text = "";
                _gui.lblCurrentLine.Text = "0";
                _gui.tbGCodeMessage.Text = "";
                _elapsed.ResetTimer();

                // reset state variables
                wtgForAck = false;
                runMode = false;
                sendAnotherLine = false;
                if (fullstop)
                {
                    // clear out the file name etc
                    closeGCodeFile();
                    // Clear the list of gcode block sent
                    gcodeview.Clear();
                }
            }

            #region Properties

            public bool runMode
            {
                get
                {
                    return _runMode;
                }

                set
                {
                    _runMode = value;
                }
            }

            public bool wtgForAck
            {
                get
                {
                    return _wtgForAck;
                }

                set
                {
                    _wtgForAck = value;
                }
            }

            public bool stepMode
            {
                get
                {
                    return _stepMode;
                }

                set
                {
                    _stepMode = value;
                }
            }

            public bool sendAnotherLine
            {
                get
                {
                    return _sendAnotherLine;
                }

                set
                {
                    _sendAnotherLine = value;
                }
            }

            public int linesDone
            {
                get
                {
                    return _linesDone;
                }

                set
                {
                    _linesDone = value;
                }
            }

            public int lineCount
            {
                get
                {
                    return _lineCount;
                }

                set
                {
                    _lineCount = value;
                }
            }

            public bool m30Flag
            {
                get
                {
                    return _m30Flag;
                }

                set
                {
                    _m30Flag = value;
                }
            }

            #endregion

        }

        public void processLineEvent(string data)
        {

            // This event handles processing and sending GCode lines from the file as well as ok/error responses from Grbl
            // Implements simple protocol (send block, wait for ok/error loop)
            // It runs on the UI thread, and is raised for each line received from Grbl
            // even when there is no file to send, e.g. due to status poll response

            // we need this to run in the UI thread so:
            // Console.WriteLine("processLineEvent: " + data)

            // are we waiting for Ack?
            if (gcode.wtgForAck)
            {
                // is recvData ok or error?

                if (data.StartsWith("ok") | data.StartsWith("error"))
                {
                    // Mark gcode item as ok/error
                    gcodeview.UpdateGCodeStatus(data, gcode.linesDone - 1);
                    // No longer waiting for Ack
                    gcode.wtgForAck = false;
                    // Handle rewind of gcode if this ack/ok was for an M30
                    if (gcode.m30Flag == true)
                    {
                        gcode.m30Flag = false;
                        gcode.sendGCodeFileRewind(); // reset to beginning
                    }

                    if (gcode.runMode)               // if not paused or stopped
                    {
                        // Mark sendAnotherLine
                        gcode.sendAnotherLine = true;
                    }
                }
            }
            // Do we have another line to send?
            if (gcode.runMode == true | gcode.stepMode == true)                    // if not paused or stopped
            {
                if (gcode.sendAnotherLine)
                {
                    gcode.sendAnotherLine = false;
                    // if count > 0
                    if (gcode.lineCount > 0)
                    {
                        string line;
                        // Read another line
                        line = gcodeview.readGcode(gcode.lineCount, gcode.linesDone);
                        if (!line.StartsWith("EOF"))  // We never hit this but is here just in case the file gets truncated
                        {
                            // count - 1
                            gcode.lineCount -= 1;
                            // show as sent
                            gcodeview.UpdateGcodeSent(gcode.linesDone);                  // Mark line as sent
                            gcode.linesDone += 1;
                            lblCurrentLine.Text = gcode.linesDone.ToString();              // Issue #60
                            state.ProcessGCode(line);
                            // Set Message if it starts with (
                            if (line.StartsWith("("))
                            {
                                string templine = line;
                                templine = templine.Remove(0, 1);
                                templine = templine.Remove(templine.Length - 1, 1);
                                tbGCodeMessage.Text = templine;
                            }

                            if (line.StartsWith("m30") | line.StartsWith("M30"))
                            {
                                // Set M30 flag to rewind on 'ok'
                                gcode.m30Flag = true;
                            }
                            // Remove all whitespace
                            line = line.Replace(" ", "");
                            // set wtg for Ack
                            gcode.wtgForAck = true;
                            // Ship it Dano!
                            grblPort.sendData(line);
                        }
                    }
                    else
                    {
                        // We reached the EOF aka linecount=0, yippee
                        gcode.sendGCodeFileStop();
                    }
                }
            }
            // Check for status responses that we need to handle here
            // Extract status
            var status = Strings.Split(data, ",");
            if (status[0] == "<Alarm" | status[0].StartsWith("ALARM"))
            {
                // Major problem so cancel the file
                // GrblStatus has set the Alarm indicator etc
                gcode.sendGCodeFileStop();
            }

            if (status[0].StartsWith("error"))
            {
                // We pause file send to allow operator to determine proceed or not
                if (cbSettingsPauseOnError.Checked)
                {
                    btnFilePause.PerformClick();
                }
            }
        }

        private void btnCheckMode_Click(object sender, EventArgs e)
        {
            // Enable/disable Check mode in Grbl
            // Just send a $C, this toggles Check state in Grbl
            grblPort.sendData("$C");
        }

        private void btnFileGroup_Click(object sender, EventArgs e)
        {
            // This event handler deals with the gcode file related buttons
            // Implements a simple state machine to keep user from clicking the wrong buttons
            // Uses button.tag instead of .text so the text doesn't mess up the images on the buttons
            Button args = (Button)sender;
            switch ((string)args.Tag ?? "")
            {
                case "File":
                    {
                        string str = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                        ofdGcodeFile.InitialDirectory = Path.Combine(Path.GetFullPath(str), "*");
                        if (!string.IsNullOrEmpty(tbSettingsDefaultExt.Text))
                        {
                            ofdGcodeFile.Filter = string.Format("Gcode |*.{0}|All Files |*.*", tbSettingsDefaultExt.Text);
                            ofdGcodeFile.DefaultExt = string.Format(".{0}", tbSettingsDefaultExt.Text);
                        }

                        ofdGcodeFile.FileName = "File";
                        if (ofdGcodeFile.ShowDialog() == DialogResult.OK)
                        {
                            // gcode.openGCodeFile(ofdGcodeFile.FileName)
                            gcode.loadGCodeFile(ofdGcodeFile.FileName);
                            tbGcodeFile.Text = ofdGcodeFile.FileName;
                            lblTotalLines.Text = gcode.lineCount.ToString();
                            btnFileSelect.Enabled = true;    // Allow changing your mind about the file
                            btnFileSend.Enabled = true;
                            btnFileStep.Enabled = true;
                            btnFilePause.Enabled = false;
                            btnFileStop.Enabled = false;
                            btnFileReload.Enabled = false;
                            // reset filter in case user changes ext on Settings tab
                            ofdGcodeFile.Filter = "";
                            ofdGcodeFile.DefaultExt = "";
                        }

                        break;
                    }

                case "Send":
                    {
                        // Send a gcode file to Grbl
                        gcode.sendGcodeFile();
                        btnFileSelect.Enabled = false;
                        btnFileSend.Enabled = false;
                        btnFilePause.Enabled = true;
                        btnFileStop.Enabled = true;
                        btnFileReload.Enabled = false;
                        break;
                    }

                case "Step":
                    {
                        gcode.sendGCodeFileStep();
                        btnFileSend.Tag = "Resume";
                        btnFileSend.Enabled = true;
                        btnFileSelect.Enabled = false;
                        btnFilePause.Enabled = true;
                        btnFileStop.Enabled = true;
                        btnFileReload.Enabled = false;
                        break;
                    }

                case "Pause":
                    {
                        gcode.sendGCodeFilePause();
                        btnFileSelect.Enabled = false;
                        btnFileSend.Tag = "Resume";
                        btnFileSend.Enabled = true;
                        btnFilePause.Enabled = false;
                        btnFileStop.Enabled = true;
                        btnFileReload.Enabled = false;
                        break;
                    }

                case "Stop":
                    {
                        gcode.sendGCodeFilePause();
                        gcode.closeGCodeFile();
                        // Re-enable manual control
                        setSubPanels(Resources.GrblGui_btnConnDisconnect_Click_Idle);
                        btnFileSelect.Enabled = true;
                        btnFileSend.Tag = "Send";
                        btnFileSend.Enabled = false;
                        btnFilePause.Enabled = false;
                        btnFileStop.Enabled = false;
                        btnFileReload.Enabled = true;
                        break;
                    }

                case "Resume":
                    {
                        gcode.sendGCodeFileResume();
                        btnFileSelect.Enabled = false;
                        btnFileSend.Tag = "Send";
                        btnFileSend.Enabled = false;
                        btnFilePause.Enabled = true;
                        btnFileStop.Enabled = true;
                        btnFileReload.Enabled = false;
                        break;
                    }

                case "Reload":
                    {
                        // Reload the same file 
                        gcode.loadGCodeFile(ofdGcodeFile.FileName);
                        tbGcodeFile.Text = ofdGcodeFile.FileName;
                        lblTotalLines.Text = gcode.lineCount.ToString();
                        btnFileSelect.Enabled = true;    // Allow changing your mind about the file
                        btnFileSend.Enabled = true;
                        btnFilePause.Enabled = false;
                        btnFileStop.Enabled = false;
                        btnFileReload.Enabled = false;
                        // ensure display is at top of gcode
                        gcodeview.DisplayTop();
                        break;
                    }
            }
        }
    }
}