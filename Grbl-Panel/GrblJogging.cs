﻿using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GrblPanel
{
    public partial class GrblGui
    {
        public class GrblJogging
        {
            private GrblGui _gui;

            public GrblJogging(ref GrblGui gui)
            {
                _gui = gui;
                _gui.settings.GrblSettingsRetrievedEvent += GrblSettingsRetrieved;
                // Do set up things

                {
                    var withBlock = My.MySettingsProperty.Settings;
                    _gui.tbSettingsFIImperial.Text = withBlock.JoggingFIImperial;
                    _gui.tbSettingsFRImperial.Text = withBlock.JoggingFRImperial;
                    _gui.tbSettingsFIMetric.Text = withBlock.JoggingFIMEtric;
                    _gui.tbSettingsFRMetric.Text = withBlock.JoggingFRMetric;
                    _gui.cbSettingsMetric.Checked = withBlock.JoggingUnitsMetric;
                    _gui.setDistanceMetric(_gui.cbSettingsMetric.Checked);
                    _gui.btnXPlus.Interval = (int)Math.Round(1000d / Conversions.ToDouble(withBlock.JoggingXRepeat));
                    _gui.btnXMinus.Interval = (int)Math.Round(1000d / Conversions.ToDouble(withBlock.JoggingXRepeat));
                    _gui.btnYPlus.Interval = (int)Math.Round(1000d / Conversions.ToDouble(withBlock.JoggingYRepeat));
                    _gui.btnYMinus.Interval = (int)Math.Round(1000d / Conversions.ToDouble(withBlock.JoggingYRepeat));
                    _gui.btnZPlus.Interval = (int)Math.Round(1000d / Conversions.ToDouble(withBlock.JoggingZRepeat));
                    _gui.btnZMinus.Interval = (int)Math.Round(1000d / Conversions.ToDouble(withBlock.JoggingZRepeat));

                    // Set the default feed rate and increment
                    foreach (RadioButton rb in _gui.gbDistance.Controls)
                    {
                        if (((string)rb.Tag ?? "") == (My.MySettingsProperty.Settings.JoggingFIDefault ?? ""))
                        {
                            rb.Checked = true;
                        }
                    }

                    foreach (RadioButton rb in _gui.gbFeedRate.Controls)
                    {
                        if (((string)rb.Tag ?? "") == (My.MySettingsProperty.Settings.JoggingFRDefault ?? ""))
                        {
                            rb.Checked = true;
                        }
                    }
                }
            }

            public bool enableJogging(bool action)
            {
                // Enable/disable jogging functions
                _gui.gbJogging.Enabled = action;
                return true;
            }

            public void shutdown()
            {
                // Close up shop
                enableJogging(false);
            }

            private void GrblSettingsRetrieved()  // Handles the named event
            {
                _gui.cbUnits.Checked = _gui.settings.IsGrblMetric;
            }
        }

        private void btnJogArray_Click(object sender, EventArgs e)
        {
            RepeatButton.RepeatButton btn = (RepeatButton.RepeatButton)sender;
            switch ((string)btn.Tag ?? "")
            {
                case "X+":
                    {
                        gcode.sendGCodeLine(createJogCommand("X"));
                        break;
                    }

                case "X-":
                    {
                        gcode.sendGCodeLine(createJogCommand("X-"));
                        break;
                    }

                case "Y+":
                    {
                        gcode.sendGCodeLine(createJogCommand("Y"));
                        break;
                    }

                case "Y-":
                    {
                        gcode.sendGCodeLine(createJogCommand("Y-"));
                        break;
                    }

                case "Z+":
                    {
                        gcode.sendGCodeLine(createJogCommand("Z"));
                        break;
                    }

                case "Z-":
                    {
                        gcode.sendGCodeLine(createJogCommand("Z-"));
                        break;
                    }
            }

            if (GrblVersion == 0)
            {
                gcode.sendGCodeLine("G90");
            }
        }

        private void cbSettingsMetric_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            cbUnits.Checked = cb.Checked;
        }

        public void setDistanceMetric(bool metric)
        {
            // set distance units as metric or imperial
            string[] info;
            if (metric)
            {
                info = Strings.Split(gbSettingsJogging.Controls["tbSettingsFIMetric"].Text, ",");
                if (info.Count() == 4)
                {
                    rbDistance1.Text = info[0];
                    rbDistance2.Text = info[1];
                    rbDistance3.Text = info[2];
                    rbDistance4.Text = info[3];
                }

                info = Strings.Split(tbSettingsFRMetric.Text, ",");
                if (info.Count() == 4)
                {
                    rbFeedRate1.Text = info[0];
                    rbFeedRate2.Text = info[1];
                    rbFeedRate3.Text = info[2];
                    rbFeedRate4.Text = info[3];
                }
            }
            else
            {
                info = Strings.Split(tbSettingsFIImperial.Text, ",");
                if (info.Count() == 4)
                {
                    rbDistance1.Text = info[0];
                    rbDistance2.Text = info[1];
                    rbDistance3.Text = info[2];
                    rbDistance4.Text = info[3];
                }

                info = Strings.Split(tbSettingsFRImperial.Text, ",");
                if (info.Count() == 4)
                {
                    rbFeedRate1.Text = info[0];
                    rbFeedRate2.Text = info[1];
                    rbFeedRate3.Text = info[2];
                    rbFeedRate4.Text = info[3];
                }
            }
        }
        /// <summary>
    /// Changes Distance and Feed Rate to new units
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void cbUnits_CheckedChanged(CheckBox sender, EventArgs e)
        {
            // Set reasonable values into the Distance and Feed Rate radio buttons

            setDistanceMetric(sender.Checked);
        }
        /// <summary>
    /// Creates a jog command string.
    /// </summary>
    /// <param name="axis">The axis.</param>
    /// <returns></returns>
        public string createJogCommand(string axis)
        {
            // Builds a jog command from various inputs
            // Jog in incremental mode, leave parser in absolute mode!
            if (GrblVersion == 0)
            {
                return "G91 " + whichUnits() + " G01 " + axis + whichDistance() + " F" + whichFeedRate();
            }

            if (GrblVersion == 1)
            {
                return "$J=G91" + whichUnits() + axis + whichDistance() + " F" + whichFeedRate();
            }

            return "";
        }
        /// <summary>
    /// Return value of current Distance Increment
    /// </summary>
    /// <returns>distance</returns>
        private string whichDistance()
        {
            // Return the value of cbDistance that is checked
            string distance;
            foreach (RadioButton rb in gbDistance.Controls)
            {
                if (rb.Checked)
                {
                    distance = rb.Text;
                    return distance;
                }
            }

            return "";
        }
        /// <summary>
    /// Return value of current feed rate.
    /// </summary>
    /// <returns>feed rate</returns>
        private string whichFeedRate()
        {
            // Return the value of cbDistance that is checked
            string rate;
            foreach (RadioButton rb in gbFeedRate.Controls)
            {
                if (rb.Checked)
                {
                    rate = rb.Text;
                    return rate;
                }
            }

            return "";
        }
        /// <summary>
    /// Returns Units gcode
    /// </summary>
    /// <returns>G20 or G21</returns>
        private string whichUnits()
        {
            if (cbUnits.Checked)
            {
                return "G21";
            }
            else
            {
                return "G20";
            }
        }
        /// <summary>
    /// Handles the CheckedChanged event of the rbDistancex control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void rbDistancex_CheckedChanged(object sender, EventArgs e)
        {
            // Remember the setting
            RadioButton rbtn = (RadioButton)sender;
            switch ((string)rbtn.Tag ?? "")
            {
                case "I1":
                case "I2":
                case "I3":
                case "I4":
                    {
                        My.MySettingsProperty.Settings.JoggingFIDefault = Conversions.ToString(rbtn.Tag);
                        break;
                    }

                case "F1":
                case "F2":
                case "F3":
                case "F4":
                    {
                        My.MySettingsProperty.Settings.JoggingFRDefault = Conversions.ToString(rbtn.Tag);
                        break;
                    }
            }
        }
        /// <summary>
    /// Changes the distance increment, up or down.
    /// </summary>
    /// <param name="up">if set to <c>true</c> [direction].</param>
        public void changeDistanceIncrement(bool up)
        {
            // We don't wrap, if we are at bottom of group and asked to go down again, we ignore request
            int index = 0;
            // find the one selected at present
            foreach (RadioButton rb in gbDistance.Controls)
            {
                if (rb.Checked)
                {
                    break;
                }

                index += 1;
            }

            if (up == false)
            {
                if (index < 3)
                {
                    // we check the next one down
                    RadioButton rb = (RadioButton)gbDistance.Controls[index + 1];
                    rb.Checked = true;
                }
            }
            else if (index > 0)
            {
                // we check the next one up
                RadioButton rb = (RadioButton)gbDistance.Controls[index - 1];
                rb.Checked = true;
            }
        }
        /// <summary>
    /// Changes the feed rate, up or down.
    /// </summary>
    /// <param name="up">if set to <c>true</c> [up].</param>
        public void changeFeedRate(bool up)
        {
            // We don't wrap, if we are at bottom of group and asked to go down again, we ignore request
            int index = 0;
            // find the one selected at present
            foreach (RadioButton rb in gbFeedRate.Controls)
            {
                if (rb.Checked)
                {
                    break;
                }

                index += 1;
            }

            if (up == false)
            {
                if (index < 3)
                {
                    // we check the next one down
                    RadioButton rb = (RadioButton)gbFeedRate.Controls[index + 1];
                    rb.Checked = true;
                }
            }
            else if (index > 0)
            {
                // we check the next one up
                RadioButton rb = (RadioButton)gbFeedRate.Controls[index - 1];
                rb.Checked = true;
            }
        }
    }
}