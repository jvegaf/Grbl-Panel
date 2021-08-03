using System;
using Microsoft.VisualBasic;

namespace GrblPanel
{
    public partial class GrblGui
    {
        /// <summary>
    /// A Class to handle Grbl VER and OPT messages
    /// </summary>

        public class GrblInfo
        {
            private GrblGui _gui;

            public GrblInfo(ref GrblGui gui)
            {
                // Get ref to parent object
                _gui = gui;
                // For Connected events
                My.MyProject.Forms.GrblGui.Connected += GrblConnected;
            }
            /// <summary>
        /// Activate Info object to request/process VER/OPT messages
        /// </summary>
        /// <param name="msg"></param>
            private void GrblConnected(string msg)     // Handles GrblGui.Connected Event
            {
                if (msg == "Connected")
                {
                    _gui.grblPort.addRcvDelegate(_gui.processVerOptMessages);
                    // We are connected to Grbl so populate the State
                    gcode.sendGCodeLine("$I");
                    once = true;
                }
            }

            private bool _single;

            public bool once
            {
                get
                {
                    return _single;
                }

                set
                {
                    _single = value;
                }
            }

            private short _QueueSize;

            public short QueueSize
            {
                get
                {
                    return _QueueSize;
                }

                set
                {
                    _QueueSize = value;
                }
            }

            private short _BufferSize;

            public short BufferSize
            {
                get
                {
                    return _BufferSize;
                }

                set
                {
                    _BufferSize = value;
                }
            }
        }

        /// <summary>
    /// Handle incoming VER and OPT message from $I request
    /// </summary>
    /// <param name="data"></param>
        public void processVerOptMessages(string data)
        {
            if (info.once == true)
            {
                if (data.StartsWith("[VER:"))
                {
                    string str = data.Remove(data.Length - 3);
                    tbGrblVersion.Text = str.Remove(0, 5);
                }

                if (data.StartsWith("[OPT"))
                {
                    string str = data.Remove(data.Length - 3);
                    tbGrblOptions.Text = str.Remove(0, 5);
                    string[] values;
                    values = Strings.Split(tbGrblOptions.Text, ",");
                    info.BufferSize = Convert.ToInt16(values[2]);
                    info.QueueSize = Convert.ToInt16(values[1]);
                    info.once = false;
                }
            }
        }
    }
}