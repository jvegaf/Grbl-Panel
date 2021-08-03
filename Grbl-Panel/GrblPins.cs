using System;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GrblPanel
{
    public partial class GrblGui
    {

        // Module to display Pin: and Lim: messages
        public class GrblPins
        {
            private GrblGui _gui;
            private bool _limits;      // have we seen a Lim: message?
            private bool _pins;        // have we seen Pin: message?

            public GrblPins(ref GrblGui gui)
            {
                // do setup stuff
                _gui = gui;
                _gui.grblPort.addRcvDelegate(_gui.showGrblPins);
            }
            /// <summary>
        /// Make the Pin Status panel visible or not
        /// </summary>
        /// <param name="action">True or False</param>
        /// <returns></returns>
            private bool enablePinStatus(bool action)
            {
                _gui.gbPinStatus.Visible = action;
                if (action == false)
                {
                    _gui.grblPort.deleteRcvDelegate(_gui.showGrblPins);
                }

                return true;
            }
            /// <summary>
        /// Tidy shutdown of PinStatus
        /// </summary>
            public void shutdown()
            {
                enablePinStatus(false);
            }

            public bool LimitsSeen
            {
                get
                {
                    return _limits;
                }

                set
                {
                    _limits = value;
                    _gui.gbPinStatus.Visible = value;
                    if (value == true)
                    {
                        {
                            var withBlock = _gui;
                            withBlock.cbLimitX.Visible = true;
                            withBlock.cbLimitY.Visible = true;
                            withBlock.cbLimitZ.Visible = true;
                        }
                    }
                }
            }

            public bool PinsSeen
            {
                get
                {
                    return _pins;
                }

                set
                {
                    _pins = value;
                    _gui.gbPinStatus.Visible = value;
                    if (value == true)
                    {
                        {
                            var withBlock = _gui;
                            withBlock.cbLimitX.Visible = true;
                            withBlock.cbLimitY.Visible = true;
                            withBlock.cbLimitZ.Visible = true;
                            withBlock.cbProbePin.Visible = true;
                            withBlock.cbResetAbort.Visible = true;
                            withBlock.cbFeedHold.Visible = true;
                            withBlock.cbStartResume.Visible = true;
                        }
                    }
                }
            }
        }
        /// <summary>
    /// Display Pin states, adapt to what Grbl is sending us (Pin: or Lim:)
    /// </summary>
    /// <param name="data">Grbl's status message</param>
        public void showGrblPins(string data)
        {
            int pos;
            if ((data ?? "") == Constants.vbCrLf)
                return;

            // We are on Grbl 0.9
            if (GrblVersion == 0 & data.Contains("Lim:"))
            {
                // We need to show Limit pins
                if (!pins.LimitsSeen)
                {
                    pins.LimitsSeen = true;
                }

                pos = Strings.InStr(data, "Lim:");
                cbLimitZ.Checked = Conversions.ToString(data[pos + 3]) == "1";
                cbLimitY.Checked = Conversions.ToString(data[pos + 4]) == "1";
                cbLimitX.Checked = Conversions.ToString(data[pos + 5]) == "1";
            }

            // Are we on Grbl 1.0 or later?
            if (GrblVersion == 1 & Conversions.ToString(data[0]) == "<")
            {
                if (data.Contains("Pn:"))
                {
                    // Show other pins
                    string pinlist;
                    if (!pins.PinsSeen)
                    {
                        pins.PinsSeen = true;
                    }

                    data = data.Remove(data.Length - 3, 3);
                    var statusMessage = Strings.Split(data, "|");
                    foreach (string item in statusMessage)
                    {
                        var portion = Strings.Split(item, ":");
                        switch (portion[0] ?? "")
                        {
                            case "Pn":
                                {
                                    pinlist = portion[1];
                                    cbProbePin.Checked = Conversions.ToBoolean(Strings.InStr(pinlist, "P"));
                                    cbDoorOpen.Checked = Conversions.ToBoolean(Strings.InStr(pinlist, "D"));
                                    cbFeedHold.Checked = Conversions.ToBoolean(Strings.InStr(pinlist, "H"));
                                    cbResetAbort.Checked = Conversions.ToBoolean(Strings.InStr(pinlist, "R"));
                                    cbStartResume.Checked = Conversions.ToBoolean(Strings.InStr(pinlist, "S"));
                                    cbLimitX.Checked = Conversions.ToBoolean(Strings.InStr(pinlist, "X"));
                                    cbLimitY.Checked = Conversions.ToBoolean(Strings.InStr(pinlist, "Y"));
                                    cbLimitZ.Checked = Conversions.ToBoolean(Strings.InStr(pinlist, "Z"));
                                    break;
                                }
                        }
                    }
                    // We don't clear, use the provided button. 
                    // This makes the pin occurance latch
                }
            }
        }

        private void btnStatusClearPins_Click(object sender, EventArgs e)
        {
            // Clear pins if set
            cbProbePin.Checked = false;
            cbDoorOpen.Checked = false;
            cbFeedHold.Checked = false;
            cbResetAbort.Checked = false;
            cbStartResume.Checked = false;
            cbLimitX.Checked = false;
            cbLimitY.Checked = false;
            cbLimitZ.Checked = false;
        }
    }
}