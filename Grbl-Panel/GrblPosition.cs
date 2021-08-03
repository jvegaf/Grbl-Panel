using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GrblPanel
{
    public partial class GrblGui
    {
        public class GrblPosition
        {
            private GrblGui _gui;

            public GrblPosition(ref GrblGui gui)
            {
                _gui = gui;
                // For Connected events
                My.MyProject.Forms.GrblGui.Connected += GrblConnected;
                _gui.settings.GrblSettingsRetrievedEvent += GrblSettingsRetrieved;
            }

            public void enablePosition(bool action)
            {
                _gui.gbPosition.Enabled = action;
                if (action == true)
                {
                    _gui.grblPort.addRcvDelegate(_gui.showGrblPositions);
                }
                else
                {
                    _gui.grblPort.deleteRcvDelegate(_gui.showGrblPositions);
                }
            }

            public void shutdown()
            {
                // Close up shop
                enablePosition(false);
            }

            private void GrblConnected(string msg)     // Handles GrblGui.Connected Event
            {
                if (msg == "Connected")
                {

                    // We are connected to Grbl so highlight need for Homing Cycle
                    _gui.btnHome.BackColor = Color.Crimson;
                }
            }

            private void GrblSettingsRetrieved()  // Handles the named event
            {
                // Settings from Grbl are now available to query
                if (_gui.settings.IsHomingEnabled == 1)
                {
                    // Enable the Home Cycle button
                    _gui.btnHome.Visible = true;
                }

                _gui.cbUnits.Checked = _gui.settings.IsGrblMetric;
            }

            private decimal _wcoX;

            public decimal WcoX
            {
                get
                {
                    return _wcoX;
                }

                set
                {
                    _wcoX = value;
                }
            }

            private decimal _wcoY;

            public decimal WcoY
            {
                get
                {
                    return _wcoY;
                }

                set
                {
                    _wcoY = value;
                }
            }

            private decimal _wcoZ;

            public decimal WcoZ
            {
                get
                {
                    return _wcoZ;
                }

                set
                {
                    _wcoZ = value;
                }
            }
        }

        public void showGrblPositions(string data)
        {
            string[] positions;

            // Show data in the Positions group (from our own thread)
            if ((data ?? "") == Constants.vbCrLf)
                return;
            if (GrblVersion == 0)
            {
                // Grbl versions 0.x, assume/expect $10=3 or equivalent 
                data = data.Remove(data.Length - 3, 3);   // Remove the "> " at end
                if (data.Contains("MPos:"))
                {
                    // Lets display the values
                    positions = Strings.Split(data, ":");
                    // MPos will always be first
                    var machPos = Strings.Split(positions[1], ",");
                    tbMachX.Text = machPos[0].ToString();
                    tbMachY.Text = machPos[1].ToString();
                    tbMachZ.Text = machPos[2].ToString();
                    // Set same values into the repeater view on Offsets page
                    tbOffSetsMachX.Text = machPos[0].ToString();
                    tbOffSetsMachY.Text = machPos[1].ToString();
                    tbOffSetsMachZ.Text = machPos[2].ToString();
                }

                if (data.Contains("WPos:"))
                {
                    string[] workPos;
                    positions = Strings.Split(data, ":");
                    // WPos might be first or it might be second (if MPos is also present)
                    if (positions.Count() == 2)
                    {
                        workPos = Strings.Split(positions[1], ",");
                    }
                    else
                    {
                        workPos = Strings.Split(positions[2], ",");
                    }

                    tbWorkX.Text = workPos[0].ToString();
                    tbWorkY.Text = workPos[1].ToString();
                    tbWorkZ.Text = workPos[2].ToString();
                }
            }

            if (GrblVersion == 1)
            {
                // Grbl/Gnea versions 1.x
                if (data.StartsWith("<"))
                {
                    data = data.Remove(data.Length - 3, 3);
                    var statusMessage = Strings.Split(data, "|");
                    foreach (string item in statusMessage)
                    {
                        var portion = Strings.Split(item, ":");
                        // Pn, Ov, T are handled in their respective objects
                        switch (portion[0] ?? "")
                        {
                            case "WCO":
                                {
                                    // WCO appears now and then or if it changes
                                    var wco = Strings.Split(portion[1], ",");
                                    position.WcoX = Conversions.ToDecimal(wco[0]);
                                    position.WcoY = Conversions.ToDecimal(wco[1]);
                                    position.WcoZ = Conversions.ToDecimal(wco[2]);
                                    break;
                                }

                            case "MPos":
                                {
                                    // We get Mpos but no WPos depending on $10
                                    var machPos = Strings.Split(portion[1], ",");
                                    tbMachX.Text = TruncRound(Convert.ToDecimal(machPos[0])).ToString();
                                    tbMachY.Text = TruncRound(Convert.ToDecimal(machPos[1])).ToString();
                                    tbMachZ.Text = TruncRound(Convert.ToDecimal(machPos[2])).ToString();
                                    if (!tbWorkX.ContainsFocus)
                                    {
                                        tbWorkX.Text = TruncRound(Convert.ToDecimal(machPos[0]) - position.WcoX).ToString();
                                    }

                                    if (!tbWorkY.ContainsFocus)
                                    {
                                        tbWorkY.Text = TruncRound(Convert.ToDecimal(machPos[1]) - position.WcoY).ToString();
                                    }

                                    if (!tbWorkZ.ContainsFocus)
                                    {
                                        tbWorkZ.Text = TruncRound(Convert.ToDecimal(machPos[2]) - position.WcoZ).ToString();
                                    }
                                    // Set same values into the repeater view on Offsets page
                                    tbOffSetsMachX.Text = tbMachX.Text;
                                    tbOffSetsMachY.Text = tbMachY.Text;
                                    tbOffSetsMachZ.Text = tbMachZ.Text;
                                    break;
                                }

                            case "WPos":
                                {
                                    // We get WPos but no MPos depending on $10
                                    var workPos = Strings.Split(portion[1], ",");
                                    if (!tbWorkX.ContainsFocus)
                                    {
                                        tbWorkX.Text = TruncRound(Convert.ToDecimal(workPos[0])).ToString();
                                    }

                                    if (!tbWorkY.ContainsFocus)
                                    {
                                        tbWorkY.Text = TruncRound(Convert.ToDecimal(workPos[1])).ToString();
                                    }

                                    if (!tbWorkZ.ContainsFocus)
                                    {
                                        tbWorkZ.Text = TruncRound(Convert.ToDecimal(workPos[2])).ToString();
                                    }

                                    tbMachX.Text = TruncRound(Convert.ToDecimal(workPos[0]) + position.WcoX).ToString();
                                    tbMachY.Text = TruncRound(Convert.ToDecimal(workPos[1]) + position.WcoY).ToString();
                                    tbMachZ.Text = TruncRound(Convert.ToDecimal(workPos[2]) + position.WcoZ).ToString();
                                    break;
                                }
                        }
                    }
                }
            }
        }

        /// <summary>
    /// Round per Settings
    /// </summary>
    /// <returns></returns>
        private decimal TruncRound(decimal value)
        {
            if (tbTruncationDigits.Text == "0")
            {
                return value;
            }
            else
            {
                if (Information.IsNumeric(tbTruncationDigits.Text))
                {
                    return Math.Round(Convert.ToDecimal(value), Convert.ToInt16(tbTruncationDigits.Text));
                }

                return value;
            }
        }

        private void btnPosition_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            switch ((string)b.Tag ?? "")
            {
                case "HomeCycle":
                    {
                        // Send Home command string
                        gcode.sendGCodeLine("$H");
                        btnHome.BackColor = Color.Transparent;       // In case it was crimson for inital connect
                        tabCtlPosition.SelectedTab = tpWork;         // And show them the Work tab
                        break;
                    }

                case "Spcl Posn1":
                    {
                        gcode.sendGCodeLine(tbSettingsSpclPosition1.Text);
                        break;
                    }

                case "Spcl Posn2":
                    {
                        gcode.sendGCodeLine(tbSettingsSpclPosition2.Text);
                        break;
                    }

                case "ZeroXYZ":
                    {
                        gcode.sendGCodeLine(tbSettingsZeroXYZCmd.Text);
                        break;
                    }
            }
        }

        private void btnWorkXYZ0_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch ((string)btn.Tag ?? "")
            {
                case "X":
                    {
                        gcode.sendGCodeLine(My.MySettingsProperty.Settings.WorkX0Cmd);
                        break;
                    }

                case "Y":
                    {
                        gcode.sendGCodeLine(My.MySettingsProperty.Settings.WorkY0Cmd);
                        break;
                    }

                case "Z":
                    {
                        gcode.sendGCodeLine(My.MySettingsProperty.Settings.WorkZ0Cmd);
                        break;
                    }
            }
        }
        /// <summary>
    /// Support for entering Work Pos directly, clear text on focus
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
        private void tbWork_Click(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = "";
        }
    }
}