using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GrblPanel
{
    public partial class GrblGui
    {
        /// <summary>
    /// Class to handle overrides related functionality
    /// </summary>
        public enum overrideChars
        {
            CMD_SAFETY_DOOR = 132,       // 0x84
            CMD_JOG_CANCEL = 133,        // 0x85
            CMD_DEBUG_REPORT = 133,      // 0x86 ' Only When DEBUG enabled, sends debug report In '{}' braces. 
            CMD_FEED_OVR_RESET = 144,    // 0x90         ' Restores feed override value To 100%.
            CMD_FEED_OVR_COARSE_PLUS = 145, // 0x91
            CMD_FEED_OVR_COARSE_MINUS = 146, // 0x92
            CMD_FEED_OVR_FINE_PLUS = 147, // 0x93
            CMD_FEED_OVR_FINE_MINUS = 148, // 0x94
            CMD_RAPID_OVR_FULL = 149, // 0x95       'Restores rapid override value To 100%.
            CMD_RAPID_OVR_MEDIUM = 150, // 0x96
            CMD_RAPID_OVR_LOW = 151, // 0x97
                                     // CMD_RAPID_OVR_EXTRA_LOW 0x98 ' *Not SUPPORTED*
            CMD_SPINDLE_OVR_RESET = 153,     // 0x99      ' Restores spindle override value To 100%.
            CMD_SPINDLE_OVR_COARSE_PLUS = 154, // 0x9A
            CMD_SPINDLE_OVR_COARSE_MINUS = 155, // 0x9B
            CMD_SPINDLE_OVR_FINE_PLUS = 156, // 0x9C
            CMD_SPINDLE_OVR_FINE_MINUS = 157, // 0x9D
            CMD_SPINDLE_OVR_STOP = 158,  // 0x9E aka Toogle Spindle Stop
            CMD_TOGGLE_FLOOD = 160,      // 0xA0
            CMD_TOGGLE_MIST = 161       // 0xA1
        }

        public class GrblOverrides
        {
            private GrblGui _gui;

            public GrblOverrides(ref GrblGui gui)
            {
                _gui = gui;

                // We wait to enable Overrides panel until we know if Grbl supports it (V1.0 and later)
                _gui.settings.GrblSettingsRetrievedEvent += GrblSettingsRetrieved;

                // For Connected events
                My.MyProject.Forms.GrblGui.Connected += GrblConnected;
            }

            private void GrblSettingsRetrieved()  // Handles the named event
            {
                // Settings from Grbl are now available to query
                if (_gui.settings.IsOverrideCapable)
                {
                    // Enable the Overrides section
                    _gui.gbOverrides.Visible = true;
                }
            }

            private void GrblConnected(string msg)
            {
                if (msg == "Connected")
                {
                    _gui.grblPort.addRcvDelegate(_gui.showOverrides);
                }
                else
                {
                    _gui.grblPort.deleteRcvDelegate(_gui.showOverrides);
                }
            }
        }

        public void showOverrides(string data)
        {

            // Process Override values, Grbl 1.x only
            if (data.Contains("Ov:") | data.Contains("A:"))
            {
                data = data.Remove(data.Length - 3, 3);
                var statusMessage = Strings.Split(data, "|");
                foreach (string item in statusMessage)
                {
                    var portion = Strings.Split(item, ":");
                    switch (portion[0] ?? "")
                    {
                        case "Ov":
                            {
                                var ovr = Strings.Split(portion[1], ",");
                                tbFeedOvr.Text = ovr[0] + "%";
                                if (ovr[0] == "100")
                                {
                                    tbFeedOvr.BackColor = Color.White;
                                }
                                else
                                {
                                    tbFeedOvr.BackColor = Color.Coral;
                                }

                                tbRapidOvr.Text = ovr[1] + "%";
                                if (ovr[1] == "100")
                                {
                                    tbRapidOvr.BackColor = Color.White;
                                }
                                else
                                {
                                    tbRapidOvr.BackColor = Color.Coral;
                                }

                                tbSpindleOvr.Text = ovr[2] + "%";
                                if (ovr[2] == "100")
                                {
                                    tbSpindleOvr.BackColor = Color.White;
                                }
                                else
                                {
                                    tbSpindleOvr.BackColor = Color.Coral;
                                }

                                if (!data.Contains("A"))
                                {
                                    btnSpindleOverride.BackColor = Color.Transparent;
                                    btnFloodOverride.BackColor = Color.Transparent;
                                    btnMistOverride.BackColor = Color.Transparent;
                                }

                                break;
                            }

                        case "A":
                            {
                                if (portion[1].Contains("S"))
                                {
                                    btnSpindleOverride.BackColor = Color.Coral;
                                }
                                else
                                {
                                    btnSpindleOverride.BackColor = Color.Transparent;
                                }

                                if (portion[1].Contains("F"))
                                {
                                    btnFloodOverride.BackColor = Color.Coral;
                                }
                                else
                                {
                                    btnFloodOverride.BackColor = Color.Transparent;
                                }

                                if (portion[1].Contains("M"))
                                {
                                    btnMistOverride.BackColor = Color.Coral;
                                }
                                else
                                {
                                    btnMistOverride.BackColor = Color.Transparent;
                                }

                                break;
                            }
                    }
                }
            }
        }
        /// <summary>
    /// Handles the Click event of the btnFeedOverride controls.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnFeedOverride_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch ((string)btn.Tag ?? "")
            {
                case "plus":
                    {
                        if (cbFeedCoarse.Checked)
                        {
                            grblPort.sendData(Conversions.ToString('\u0091'));
                        }
                        else
                        {
                            grblPort.sendData(Conversions.ToString('\u0093'));
                        }

                        break;
                    }

                case "minus":
                    {
                        if (cbFeedCoarse.Checked)
                        {
                            grblPort.sendData(Conversions.ToString('\u0092'));
                        }
                        else
                        {
                            grblPort.sendData(Conversions.ToString('\u0094'));
                        }

                        break;
                    }
            }
        }

        private void btnRapidOverride_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch ((string)btn.Tag ?? "")
            {
                case "50":
                    {
                        grblPort.sendData(Conversions.ToString('\u0096'));
                        break;
                    }

                case "25":
                    {
                        grblPort.sendData(Conversions.ToString('\u0097'));
                        break;
                    }
            }
        }

        private void btnSpindleOverride_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch ((string)btn.Tag ?? "")
            {
                case "plus":
                    {
                        if (cbSpindleCoarse.Checked)
                        {
                            grblPort.sendData(Conversions.ToString('\u009a'));
                        }
                        else
                        {
                            grblPort.sendData(Conversions.ToString('\u009c'));
                        }

                        break;
                    }

                case "minus":
                    {
                        if (cbSpindleCoarse.Checked)
                        {
                            grblPort.sendData(Conversions.ToString('\u009b'));
                        }
                        else
                        {
                            grblPort.sendData(Conversions.ToString('\u009d'));
                        }

                        break;
                    }
            }
        }

        private void btnFeedOverrideReset_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch ((string)btn.Tag ?? "")
            {
                case "Rapid":
                    {
                        grblPort.sendData(Conversions.ToString('\u0095'));
                        break;
                    }

                case "Feed":
                    {
                        grblPort.sendData(Conversions.ToString('\u0090'));
                        break;
                    }

                case "Spindle":
                    {
                        grblPort.sendData(Conversions.ToString('\u0099'));
                        break;
                    }
            }
        }
        /// <summary>
    /// Handle toggle of some overrides, constrained by present state
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
        private void btnToggleOverride_Click(object sender, EventArgs e)
        {
            // Spindle toggle only in Hold
            // Coolant and Mist in Idle,Run or Hold
            Button btn = (Button)sender;
            switch ((string)btn.Tag ?? "")
            {
                case "SpindleOverride":
                    {
                        grblPort.sendData(Conversions.ToString('\u009e'));
                        break;
                    }

                case "FloodOverride":
                    {
                        grblPort.sendData(Conversions.ToString(' '));
                        break;
                    }

                case "MistOverride":
                    {
                        grblPort.sendData(Conversions.ToString('¡'));
                        break;
                    }
            }
            // btn colour changes based on A:SFM response handled in showOverrides()
        }
    }
}