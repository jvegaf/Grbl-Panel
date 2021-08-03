using System;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace GrblPanel
{
    public partial class GrblGui
    {
        public class Elapsed
        {
            private Stopwatch _stopwatch;
            private System.Threading.Timer _timer;
            private TimeSpan _span;

            // Private _target As Object = Nothing

            public Elapsed(object target)
            {
                _stopwatch = new Stopwatch();
                _timer = new System.Threading.Timer(_timerCB, target, 0, 1000);
                // _target = target
            }

            public void BeginTimer()
            {
                _stopwatch.Reset();
                _stopwatch.Start();
            }

            public void StopTimer()
            {
                _stopwatch.Stop();
            }

            public void ResumeTimer()
            {
                _stopwatch.Start();
            }

            public void ResetTimer()
            {
                _stopwatch.Reset();
            }

            public delegate void MySub(object data);

            private void _timerCB(object state)
            {
                Control c = (Control)state;
                if (c.InvokeRequired)
                {
                    // we need to cross thread this callback
                    var ncb = new MySub(_timerCB);
                    c.Parent.BeginInvoke(ncb, new object[] { state });
                    return;
                }
                else if (!Information.IsNothing(state) & _stopwatch.IsRunning)
                {
                    _span = TimeSpan.FromMilliseconds(_stopwatch.ElapsedMilliseconds);
                    c.Text = _span.ToString(@"hh\:mm\:ss");
                }
            }

            public string ElapsedMillis
            {
                get
                {
                    return _stopwatch.ElapsedMilliseconds.ToString();
                }
            }
        }
    }
}