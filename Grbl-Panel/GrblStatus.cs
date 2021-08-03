using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using GrblPanel.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GrblPanel
{
    public partial class GrblGui
    {
        public class GrblStatus
        {
            // A class to display status of Grbl onto the UI
            private GrblGui _gui;
            public timerInfo timerState;   // For sending a request every x times, e.g. for Parser state request

            public GrblStatus(ref GrblGui gui)
            {
                // do setup stuff
                _gui = gui;
                _gui.prgBarQ.Maximum = Convert.ToInt16(My.MySettingsProperty.Settings.QBuffMaxSize);
                _gui.prgbRxBuf.Maximum = Convert.ToInt16(My.MySettingsProperty.Settings.RBuffMaxSize);
                timerState = new timerInfo();
                timerState.count = 0;
            }

            public bool enableStatus(bool action)
            {
                _gui.gbStatus.Enabled = action;
                if (action == true)
                {
                    _gui.grblPort.addRcvDelegate(_gui.showGrblStatus);
                }
                else
                {
                    _gui.grblPort.deleteRcvDelegate(_gui.showGrblStatus);
                }

                return true;
            }

            public void shutdown()
            {
                // Close up shop
                _gui.statusPrompt(Resources.GrblGui_btnConnDisconnect_Click_End);
                enableStatus(false);
            }

            public class timerInfo
            {
                // An object to pass info to Timer event
                public int count;
            }
        }       // Class GrblStatus

        // Private __statusThread As New _statusThread()
        public void statusPrompt(string operation)
        {
            TimerCallback tcb = _statusThreadProc;
            object state = 0;
            // Start/stop status probe thread
            if ((operation ?? "") == (Resources.MsgFilter_PreFilterMessage_Start ?? ""))
            {
                _statusTimer = new System.Threading.Timer(tcb, status.timerState, 0, Convert.ToInt16(My.MySettingsProperty.Settings.StatusPollInterval));
            }

            if ((operation ?? "") == (Resources.GrblGui_btnConnDisconnect_Click_End ?? ""))
            {
                if (!Information.IsNothing(_statusTimer))     // if close before Connect to Grbl
                {
                    _statusTimer.Change(Timeout.Infinite, Timeout.Infinite);
                }
            }
        }

        public void changeStatusRate(int newrate)
        {
            // Change the status polling rate
            if (!Information.IsNothing(_statusTimer))
            {
                _statusTimer.Change(0, newrate);
            }
        }

        private System.Threading.Timer _statusTimer;

        public void _statusThreadProc(object stateInfo)
        {
            // Send a ? status request every 200ms

            // We can't poll for Parser status until Grbl stops requiring a vbLF at end of $ commands
            // This is because that results in an ok response, which messes up Gcode file send ack's!! :-(
            GrblStatus.timerInfo state = (GrblStatus.timerInfo)stateInfo;
            state.count += 1;
            if (state.count == 10)
            {
                state.count = 0;
                // TODO , Change Grbl command for $G grblPort.sendData("$G")     ' Ask for Parser status
            }

            if (Conversions.ToBoolean(cbStatusPollEnable.CheckState))
            {
                grblPort.sendData("?");
            }
        }

        // End Class
        private void btnUnlock_Click(object sender, EventArgs e)
        {
            // Send Unlock ($x) to Grbl
            grblPort.sendData("$x");
            tabCtlPosition.SelectedTab = tpWork;         // refocus to Work tab
            btnHome.BackColor = Color.Transparent;       // Use decided not to Home Cycle, so clear hint
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Send Reset command to Grbl
            gcode.ResetGcode(false);
            grblPort.sendData(Conversions.ToString('\u0018'));      // ctl-X
        }

        private void btnHold_Click(object sender, EventArgs e)
        {
            // Send Reset command to Grbl
            grblPort.sendData("!");
        }

        private void btnStartResume_Click(object sender, EventArgs e)
        {
            // Send Reset command to Grbl
            grblPort.sendData("~");
        }

        private GrblErrorsSingleton GrblErrors = GrblErrorsSingleton.GetInstance();

        static Dictionary<string, string> initial_errors() => GrblErrors.GetErrorsDct();

        private Dictionary<string, string> _errors;

        public void showGrblStatus(string data)
        {

            // TODO This needs tidying up, pre-process message to remove leading, trailing < [ , etc. so 
            // we have a clean code flow below, create a messageType variable?
            // Console.WriteLine("showGrblStatus: " + data)
            if (Conversions.ToString(data[0]) == Constants.vbLf | Conversions.ToString(data[0]) == Constants.vbCr)
            {
                return;                  // nothing to do
            }

            if (cbVerbose.Checked)
            {
                // Show data in the Status screen (from our own thread)
                lbResponses.Items.Add(data);
                if (lbResponses.Items.Count > 1)      // handle case where user doesn't have 
                {
                    lbResponses.TopIndex = lbResponses.Items.Count - 1;
                }
            }
            // filter out <> , ok, $G, $$ response messages
            else if (data.Length > 0 & !(Conversions.ToString(data.First()) == "<") & !(Conversions.ToString(data.First()) == "o") & !(Conversions.ToString(data.First()) == "$") & !(Conversions.ToString(data.First()) == "G") & !(Conversions.ToString(data.First()) == "[" & data.Contains("F")) & !data.StartsWith("error:"))
            {
                // Show data in the Status screen (from our own thread)
                lbResponses.Items.Add(data);
                lbResponses.TopIndex = lbResponses.Items.Count - 1;
            }

            if (lbResponses.Items.Count > 100)
            {
                // keep the list reasonably short
                lbResponses.Items.RemoveAt(0);
                lbResponses.TopIndex = lbResponses.Items.Count - 1;
            }

            if (data.StartsWith("Grbl"))
            {
                // set Grbl version, 0.x or 1.x
                GrblVersion = Conversions.ToInteger(data.Substring(5, 1));
                if (GrblVersion == 1)
                {
                    pins.PinsSeen = true;      // Show all pins
                }
                else
                {
                    pins.LimitsSeen = true;
                }      // Show limit pins only
                       // Set version into Settings page
                tbGrblVersion.Text = Strings.Split(data, "[")[0];

                // Something reset the Grbl device, likely a physical Reset
                // Stop what we are doing and clear out for restart
                state.GrblConnected("Connected");   // Reset State object
                gcode.ResetGcode(false);
            }

            // BG Modification to get errors in plain text. Looks like this is the same, independantly of Grbl version, which is why its here.
            int errorCode;
            if (data.StartsWith("error:"))
            {
                if (Information.IsNumeric(data["error:".Length + 1])) // If Grbl in GUI mode, then char follwing the : is number
                {
                    // We are in GUI mode so expand the message
                    errorCode = Convert.ToInt16(data.Substring(6, data.Length - 6 - 2));
                    data = data + " -> " + _errors[errorCode.ToString()];
                    lbResponses.Items.Add(data);
                    lbResponses.TopIndex = lbResponses.Items.Count - 1;
                }
            }

            // We switch processing based on Grbl version, 1.x is quite different

            if (GrblVersion == 0)
            {
                // Split out the Q and Buffer sizes
                // (Look for Buf:nn,RX:nnn)
                if (data.Contains("Buf:"))     // Pre Grbl 1.0
                {
                    // Lets display the values
                    data = data.Remove(data.Length - 3, 3);   // Remove the "> " at end
                    var positions = Strings.Split(data, ":");
                    try
                    {
                        var buffer = Strings.Split(positions[3], ",");
                        var rx = Strings.Split(positions[4], ",");
                        prgbRxBuf.Value = Conversions.ToInteger(rx[0]);
                        prgBarQ.Value = Conversions.ToInteger(buffer[0]);
                    }
                    catch
                    {
                        // do nothing, should have Status Report mask = 15
                    }
                }

                // Show status on the buttons
                // Extract status
                var status = Strings.Split(data, ",");
                // Set indicators
                if (!Information.IsNothing(status)) // And status(0).StartsWith("<") Then
                {
                    statusSetIndicators(status[0]);
                }

                // Set button states
                if (status[0] == "<Idle" | status[0] == "<Run")
                {
                    // Clear the button lights
                    btnUnlock.BackColor = Color.Transparent;
                    btnHold.BackColor = Color.Transparent;
                    btnReset.BackColor = Color.Transparent;
                    btnStartResume.BackColor = Color.Transparent;
                    btnStartResume.Text = Resources.MsgFilter_PreFilterMessage_Start;
                }

                if (data.StartsWith("<Queue") | data.StartsWith("<Hold"))   // This might become Hold later when fixed in Grbl
                {
                    btnStartResume.BackColor = Color.Crimson;
                    btnStartResume.Text = Resources.GrblGui_showGrblStatus_Resume;
                }

                if (status[0] == "<Alarm")
                {
                    btnUnlock.BackColor = Color.Crimson;
                }

                if (status[0] == "<Alarm" | status[0].StartsWith("ALARM"))
                {
                    statusSetIndicators(status[0].Substring(0, 6));       // Messy Status messages make for messy code :(
                }

                // Display the Parser state if that is the message type
                if (Conversions.ToString(data[0]) == "[" & data.Contains("F"))        // we have a Parser status message
                {
                    state.ProcessGCode(data);
                }
            } // Grbl 0.x proccessing Then

            if (GrblVersion == 1)
            {
                if (data.StartsWith("[MSG:"))
                {
                }

                if (data.StartsWith("[GC:"))
                {
                    // Parser State message
                    state.ProcessGCode(data);
                }

                if (data.StartsWith("<"))
                {
                    data = data.Remove(data.Length - 3, 3);
                    var statusMessage = Strings.Split(data, "|");
                    foreach (string item in statusMessage)
                    {
                        var portion = Strings.Split(item, ":");
                        // Pn, Ov, T are andled in their respective objects
                        switch (portion[0] ?? "")
                        {
                            case "<Idle":
                                {
                                    // Clear the button lights
                                    btnUnlock.BackColor = Color.Transparent;
                                    btnHold.BackColor = Color.Transparent;
                                    btnReset.BackColor = Color.Transparent;
                                    btnCheckMode.BackColor = Color.Transparent;
                                    btnStartResume.BackColor = Color.Transparent;
                                    btnStartResume.Text = Resources.MsgFilter_PreFilterMessage_Start;
                                    tbCurrentStatus.BackColor = Color.LightGreen;
                                    tbCurrentStatus.Text = Resources.GrblGui_showGrblStatus_IDLE;
                                    break;
                                }

                            case "<Run":
                                {
                                    btnUnlock.BackColor = Color.Transparent;
                                    btnHold.BackColor = Color.Transparent;
                                    btnReset.BackColor = Color.Transparent;
                                    btnStartResume.BackColor = Color.Transparent;
                                    btnStartResume.Text = Resources.MsgFilter_PreFilterMessage_Start;
                                    tbCurrentStatus.BackColor = Color.LightGreen;
                                    tbCurrentStatus.Text = Resources.GrblGui_showGrblStatus_RUN;
                                    break;
                                }

                            case "<Hold":
                                {
                                    btnStartResume.BackColor = Color.Crimson;
                                    btnStartResume.Text = Resources.GrblGui_showGrblStatus_Resume;
                                    tbCurrentStatus.BackColor = Color.LightGreen;
                                    tbCurrentStatus.Text = Resources.GrblGui_showGrblStatus_HOLD;
                                    break;
                                }

                            case "<Alarm":
                                {
                                    btnUnlock.BackColor = Color.Crimson;
                                    statusSetIndicators("<Alarm");       // Messy Status messages make for messy code :(
                                    break;
                                }

                            case "<Jog":
                                {
                                    tbCurrentStatus.BackColor = Color.LightGreen;
                                    tbCurrentStatus.Text = "JOG";
                                    break;
                                }

                            case "<Door":
                                {
                                    tbCurrentStatus.BackColor = Color.LightGreen;
                                    tbCurrentStatus.Text = "DOOR";
                                    break;
                                }

                            case "<Check":
                                {
                                    btnCheckMode.BackColor = Color.Crimson;
                                    tbCurrentStatus.BackColor = Color.LightGreen;
                                    tbCurrentStatus.Text = Resources.GrblGui_showGrblStatus_CHECK;
                                    break;
                                }

                            case "<Home":
                                {
                                    tbCurrentStatus.BackColor = Color.LightGreen;
                                    tbCurrentStatus.Text = "HOME";
                                    break;
                                }

                            case "Bf":
                                {
                                    var values = Strings.Split(portion[1], ",");
                                    try
                                    {
                                        prgBarQ.Value = (int)Math.Round(info.QueueSize - Conversions.ToDouble(values[0]));
                                        prgbRxBuf.Value = (int)Math.Round(info.BufferSize - Conversions.ToDouble(values[1]));
                                    }
                                    catch
                                    {
                                    }

                                    break;
                                }

                            case "F":
                                {
                                    break;
                                }

                            case "FS":
                                {
                                    break;
                                }
                                // TODO Figure out where to display Grbl's actual feedrate, if at all
                        }
                    }
                }
                // A bit messy but it doesn't really fit anywhere else
                if (data.StartsWith("ALARM"))
                {
                    statusSetIndicators(data.Substring(0, 6));
                }
            }

            // TODO Move to Settings handler
            if (Conversions.ToString(data[0]) == "$" & Information.IsNumeric(data[1]))
            {
                // we have a Grbl Settings response
                settings.FillSettings(data);
            }
        }

        private void statusSetIndicators(string status)
        {
            // Version 0.x only
            // Set status indicators depending on Grbl's status
            switch (status ?? "")
            {
                case "<Alarm":
                case "ALARM:":
                case "ALARM":
                    {
                        tbCurrentStatus.BackColor = Color.Red;
                        tbCurrentStatus.Text = "ALARM";
                        break;
                    }

                case "<Run":
                    {
                        tbCurrentStatus.BackColor = Color.LightGreen;
                        tbCurrentStatus.Text = Resources.GrblGui_showGrblStatus_RUN;
                        break;
                    }

                case "<Idle":
                    {
                        tbCurrentStatus.BackColor = Color.LightGreen;
                        tbCurrentStatus.Text = Resources.GrblGui_showGrblStatus_IDLE;
                        break;
                    }

                case "<Check":
                    {
                        tbCurrentStatus.BackColor = Color.YellowGreen;
                        tbCurrentStatus.Text = Resources.GrblGui_showGrblStatus_CHECK;
                        break;
                    }

                case "<Queue":
                    {
                        tbCurrentStatus.BackColor = Color.YellowGreen;
                        tbCurrentStatus.Text = "QUEUE";
                        break;
                    }
            }
        }
    }
}   // partial grblgui