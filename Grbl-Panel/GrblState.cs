using System;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GrblPanel
{
    public partial class GrblGui
    {
        public class GrblState
        {

            // A class to track and display Gcode state
            // e.g. to show active G90/91 or Work/Fixture offset

            // Gets fed each line of Gcode before it is sent to 
            // Gets fed the response to $G (Parser state)
            private GrblGui _gui;

            public GrblState(ref GrblGui gui)
            {
                // Get ref to parent object
                _gui = gui;
                // For Connected events
                My.MyProject.Forms.GrblGui.Connected += GrblConnected;
            }

            public void EnableState(bool yes)
            {
                if (yes)
                {
                    _gui.gbState.Enabled = true;
                }
                else
                {
                    _gui.gbState.Enabled = false;
                }
            }

            public void GrblConnected(string msg)     // Handles GrblGui.Connected Event
            {
                if (msg == "Connected")
                {

                    // We are connected to Grbl so populate the State
                    gcode.sendGCodeLine("$G");
                }
            }

            public void ProcessGCode(string line)
            {
                // parse the line for codes we are interested in
                // We get our data from:
                // - Outbound Gcode
                // - Response from Grbl to $G

                var ignore = new[] { '$', '!', '~', '?', '(' };
                var codes = new[] { 'M', 'T', 'S', 'G', 'F' };
                var allcodes = new[] { 'M', 'T', 'F', 'G', 'P', 'S', 'X', 'Y', 'Z', 'I', 'J', 'K', ' ', '[', ']', Conversions.ToChar(Constants.vbLf) };
                var spclcodes = new[] { 'T', 'S', 'F' };
                bool collect = false;          // collect code characters
                var gcodes = Array.Empty<string>();      // the gcodes found
                int gcodeIndex = 0;           // current entry being processed
                bool comment = false;
                if (line.Length == 0)     // Deal with blank lines
                {
                    return;
                }

                if (ignore.Contains(line[0]) | !allcodes.Contains(line[0]))
                {
                    return;                              // ignore lines with no gcode
                }

                foreach (char c in line)
                {
                    if (Conversions.ToString(c) == "(")
                    {
                        break;    // we are done parsing this line
                    }

                    if (allcodes.Contains(c))        // did we find a gcode block?
                    {
                        collect = false;                 // we reached end of what we were collecting
                        if (codes.Contains(c))       // is it one we care about?
                        {
                            collect = true;
                            Array.Resize(ref gcodes, gcodeIndex + 1 + 1);
                            gcodes[gcodeIndex] = Conversions.ToString(c);
                            gcodeIndex += 1;
                        }
                    }
                    else if (collect)                     // are we in a gcode block?
                    {
                        gcodes[gcodeIndex - 1] += Conversions.ToString(c);
                    }
                }
                // parsing done, lets see what we 
                // (settings are explicit to avoid showing an assumed value. If we don't know, then box is empty)
                // TODO Remove leading 0's from numbers
                foreach (var code in gcodes)
                {
                    if (Information.IsNothing(code))
                    {
                        break;
                    }

                    if (spclcodes.Contains(code[0]))
                    {
                        // Handle F, S and T
                        switch (code[0])
                        {
                            case 'T':
                                {
                                    _gui.tbStateTool.Text = code.Remove(0, 1);
                                    break;
                                }

                            case 'S':
                                {
                                    _gui.tbStateSpindleRPM.Text = code.Remove(0, 1);
                                    break;
                                }

                            case 'F':
                                {
                                    _gui.tbStateFeedRate.Text = code.Remove(0, 1);
                                    break;
                                }
                        }
                    }
                    else
                    {
                        switch (code ?? "")
                        {
                            case "G20":
                            case "G21":
                                {
                                    _gui.cbxStateUnits.SelectedItem = this.find(_gui.cbxStateUnits, code);
                                    break;
                                }

                            case "G54":
                            case "G55":
                            case "G56":
                            case "G57":
                            case "G58":
                            case "G59":
                                {
                                    _gui.cbxStateOffset.SelectedItem = this.find(_gui.cbxStateOffset, code);
                                    _gui.lblPositionCurrentOffset.Text = code; // find(_gui.cbxStateOffset, code)
                                    break;
                                }

                            case "G90":
                            case "G91":
                                {
                                    _gui.cbxStateDistance.SelectedItem = this.find(_gui.cbxStateDistance, code);
                                    break;
                                }

                            case "G93":
                            case "G94":
                                {
                                    _gui.cbxStateFeedMode.SelectedItem = this.find(_gui.cbxStateFeedMode, code);
                                    break;
                                }

                            case "G17":
                            case "G18":
                            case "G19":
                                {
                                    // Plane           
                                    _gui.cbxStatePlane.SelectedItem = this.find(_gui.cbxStatePlane, code);
                                    break;
                                }

                            case "M3":
                            case "M4":
                            case "M5":
                                {
                                    // Motor control
                                    _gui.cbxStateSpindle.SelectedItem = this.find(_gui.cbxStateSpindle, code);
                                    break;
                                }

                            case "M8":
                            case "M9":
                                {
                                    _gui.cbxStateCoolant.SelectedItem = this.find(_gui.cbxStateCoolant, code);
                                    break;
                                }
                        }
                    }

                    int x = 1;
                }
            }

            private object find(ComboBox bx, string code)
            {
                // I should overload ComboBox FindString but then we get a custom control :-(
                // so we do this instead
                foreach (object i in bx.Items)
                {
                    if (i.ToString().Contains(code))
                    {
                        return i;
                    }
                }

                return null;
            }
        }

        private void cbxState_SelectionChangeCommittted(object sender, EventArgs e)


        {
            // Send new setting to Grbl
            ComboBox cbx = (ComboBox)sender;
            string code = Conversions.ToString(cbx.SelectedItem);
            if (!string.IsNullOrEmpty(code))
            {
                code = code.Substring(code.Length - 3, 3);
                gcode.sendGCodeLine(code);
            }
        }
    }
}