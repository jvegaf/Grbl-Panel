// Imported from
// http://www.codeproject.com/Articles/5289/A-Simple-Auto-Repeat-Button-on-VB-NET
// Thank you Daniel
// 

using System;
using System.Windows.Forms;

namespace RepeatButton
{
    public class RepeatButton : Button
    {
        public RepeatButton()
        {
            base.MouseDown += RepeatButton_MouseDown;
            base.MouseUp += RepeatButton_MouseUp;
            myTimer.Tick += OnTimer;
            myTimer.Enabled = false;
        }

        public Timer myTimer = new Timer();

        public int Interval
        {
            get
            {
                return myTimer.Interval;
            }

            set
            {
                myTimer.Interval = value;
            }
        }

        private void OnTimer(object sender, EventArgs e)
        {
            // fire off a click on each timer tick
            OnClick(EventArgs.Empty);
        }

        private void RepeatButton_MouseDown(object sender, MouseEventArgs e)
        {
            // turn on the timer 
            myTimer.Enabled = true;
        }

        private void RepeatButton_MouseUp(object sender, MouseEventArgs e)
        {
            // turn off the timer 
            myTimer.Enabled = false;
        }
    }
}