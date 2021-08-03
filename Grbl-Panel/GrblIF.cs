using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Ports;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using GrblPanel.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GrblPanel
{

    // 
    // Useful serialport tips, #3 is important!!!!
    // http://blogs.msdn.com/b/bclteam/archive/2006/10/10/top-5-serialport-tips-_5b00_kim-hamilton_5d00_.aspx
    // 
    public class GrblIF
    {
        public enum ConnectionType
        {
            IP,
            Serial,
            None
        }

        // A class to handle serial port list/open/close/read/write

        private string[] _commports;           // the comm ports available
        private SerialPort _port; // 
        private string _commport = "COM1";      // desired comm port
        private int _baudrate = 115200;       // active baudrate
        private bool _connected = false;
        private TcpClient _client = new TcpClient();
        private IPAddress _remoteHost;           // desired remote host
        private int _portNum = 0;            // remote port number
        private ConnectionType _type;
        private StringBuilder line;

        private delegate void _dataReceived();

        // The inbound queue supports delegates to call when a line of data arrives
        public delegate void grblDataReceived(string data);

        private List<grblDataReceived> _recvDelegates;   // who should get called when a line arrives

        public GrblIF()
        {
            _port = new SerialPort();
            _port.ReceivedBytesThreshold = 2;            // wait for this # of bytes to raise event
            _recvDelegates = new List<grblDataReceived>();
            serialDataEvent += raiseAppSerialDataEvent;
            line = new StringBuilder();
        }

        /// <summary>
    /// Starts the connection to grbl, via IP or Serial (COM). Expects to have the needed properties set beforehand.
    /// </summary>
    /// <param name="typeIn">Specifies if we're connecting via IP or Serial. None as safety/exception case</param>
    /// <returns>Returns True if the connection succeeded, false otherwise.</returns>
        public bool Connect(ConnectionType typeIn)
        {
            _type = typeIn;
            switch (_type)
            {
                case ConnectionType.IP:
                    {
                        if (_client.Connected)
                        {
                            return false;
                        }

                        try
                        {
                            _client = new TcpClient();
                            _client.Connect(_remoteHost, _portNum);
                            _dataReceived d = _client_DataReceived;
                            d.BeginInvoke(null, null);
                        }
                        catch (Exception ex)
                        {
                            return false;
                        }

                        _connected = true;
                        return true;
                    }

                case ConnectionType.Serial:
                    {
                        if (_port.IsOpen)
                        {
                            return false;
                        }

                        _port.PortName = _commport;
                        _port.BaudRate = _baudrate;
                        _port.ReadTimeout = 5000;
                        try
                        {
                            _port.Open();
                        }
                        catch (IOException ex)
                        {
                            return false;
                        }
                        catch (UnauthorizedAccessException ex)
                        {
                            return false;
                        }
                        // Reset the board
                        _port.DtrEnable = true;
                        _port.DtrEnable = false;
                        _connected = true;
                        _client_ComReadData();   // Start reading
                        return true;
                    }

                default:
                    {
                        return false; // This should never happen, just in case.
                    }
            }
        }

        /// <summary>
    /// Closes the connection.
    /// </summary>
        public void Disconnect()
        {
            switch (_type)
            {
                case ConnectionType.IP:
                    {
                        _client.Close();
                        break;
                    }

                case ConnectionType.Serial:
                    {
                        // disconnect from Grbl
                        try
                        {
                            if (_port.IsOpen)
                            {
                                _port.BaseStream.Close();
                                // _port.Close()     ' There is a known problem that hangs the program if you are using Invoke in the ReceiveData event (I now use BeforeInvoke)
                                // See http://social.msdn.microsoft.com/Forums/en-US/ce8ce1a3-64ed-4f26-b9ad-e2ff1d3be0a5/serial-port-hangs-whilst-closing?forum=Vsexpressvcs
                            }
                        }
                        catch
                        {
                            // This happens for sure if user disconnects the USB cable
                            MessageBox.Show(Resources.GrblIF_Disconnect_ErrorOnCloseOfGrblPort);
                        }

                        break;
                    }
            }

            _connected = false;
            _type = ConnectionType.None;
        }

        public string[] rescan()
        {
            // scan for com ports again
            return SerialPort.GetPortNames();
        }
        #region Properties

        /// <summary>
    /// Lists the available COM ports on the system.
    /// </summary>
    /// <returns>String Array of COM ports</returns>
        public string[] comports
        {
            get
            {
                // get list of available com ports
                _commports = SerialPort.GetPortNames();
                return _commports;
            }
        }

        /// <summary>
    /// COM port to use if connected via COM
    /// </summary>
    /// <value>The COM port to use</value>
    /// <returns>The selected COM port</returns>
        public string comport
        {
            get
            {
                return _commport;
            }

            set
            {
                _commport = value;
            }
        }

        /// <summary>
    /// Baudrate to use if connected via COM
    /// </summary>
    /// <value>The baudrate, as an integer. 9600 (0.8c) and 115200 (0.9g) are common values.</value>
    /// <returns>The configured baudrate</returns>
        public int baudrate
        {
            get
            {
                return _baudrate;
            }

            set
            {
                _baudrate = value;
            }
        }

        /// <summary>
    /// IP Address to use if connected via IP
    /// </summary>
    /// <value>The IP Address to connect to</value>
    /// <returns>The IP Address currently configured</returns>
        public IPAddress ipaddress
        {
            get
            {
                return _remoteHost;
            }

            set
            {
                _remoteHost = value;
            }
        }

        /// <summary>
    /// Port Number to use if connected via IP
    /// </summary>
    /// <value>Port number to use, as an integer between 1 and 65,535. WiFly defaults to 2000</value>
    /// <returns></returns>
    /// <remarks></remarks>
        public int portnum
        {
            get
            {
                return _portNum;
            }

            set
            {
                if (value > 65535 | value < 0)
                {
                    // port number passed in is outside of valid bounds, default to 2000.
                    _portNum = 2000;
                }
                else
                {
                    _portNum = value;
                }
            }
        }

        /// <summary>
    /// Are we connected to grbl?
    /// </summary>
        public bool Connected
        {
            // Are we connected to Grbl?
            get
            {
                return _connected;
            }
        }
        #endregion

        // **** Receive Queue Management
        // calls delegates (callbacks) to consumers of the data
        // collects received data line and pushes to queue
        // pops from queue after last delegate returns

        public bool addRcvDelegate(grblDataReceived param)
        {
            // Add a delegate (callback) to the received Data list
            _recvDelegates.Add(param);
            return true;
        }

        public bool deleteRcvDelegate(grblDataReceived param)
        {
            // Add a delegate (callback) to the received Data list
            _recvDelegates.Remove(param);
            return true;
        }

        private void _client_DataReceived() // sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles _stream.DataReceived
        {
            // THIS RUNS IN ITS OWN THREAD!!!!! with no direct access to UI elements
            // By using ReadLine here, we should block this thread until the rest of a line is available, set ReceivedBytesThreshold low (2)
            // All registered delegates are called, any new receive events get queued up 'in the system'

            string data;
            var _stream = _client.GetStream();
            var _reader = new StreamReader(_stream);
            while (_connected)
            {
                try
                {
                    data = _reader.ReadLine();
                    if (data.Length != 0)
                    {

                        // Dim lines As String() = data.Split({10, 13}, StringSplitOptions.RemoveEmptyEntries)
                        // If lines.Length > 0 Then
                        // For Each line In lines
                        foreach (var callback in _recvDelegates)
                            callback.Invoke(data);
                        // Next
                        // End If
                    }
                }
                catch (Exception ex)
                {
                    // various exceptions occur when closing app
                    // all due to race conditions because we process receive events on 
                    // different thread from gui.
                    // This Catch handles data=Nothing from passing to rest of code at exit
                    // Disconnect()
                    // Return
                }
            }
        }

        private byte[] readBuffer = new byte[257];

        private async void _client_ComReadData()
        {
            try
            {
                int _actualLength = await _port.BaseStream.ReadAsync(readBuffer, 0, 200);
                var _received = new byte[_actualLength + 1];
                Buffer.BlockCopy(readBuffer, 0, _received, 0, _actualLength);
                // Console.WriteLine("_client_ComReadData: Finished async read, bytes {0}", _actualLength)
                // raiseAppSerialDataEvent(System.Text.ASCIIEncoding.ASCII.GetString(_received))
                serialDataEvent?.Invoke(Encoding.ASCII.GetString(_received));
                _client_ComReadData(); // reprime the read
            }
            catch (InvalidOperationException e)
            {
            }
            catch (UnauthorizedAccessException e)
            {
            }
            catch (IOException e)
            {
                Debug.WriteLine("_client_ComReadData: error on reading from port " + e.Message);
            }
            catch (TimeoutException e)
            {
                Debug.WriteLine("_client_ComReadData: Timeout exception {0}", e.Message);
            }
        }

        public event serialDataEventEventHandler serialDataEvent;

        public delegate void serialDataEventEventHandler(string data);

        /// <summary>
    /// Handles the application serial data event.
    /// </summary>
    /// <remarks>
    /// Processes the received data into lines
    /// For each line, calls the registered delegates
    /// </remarks>
    /// <param name="data">The (possibly partial) data.</param>
        private void raiseAppSerialDataEvent(string data)
        {
          
            
            foreach (char ch in data)
            {
                if (Conversions.ToString(ch) != Constants.vbNullChar) // ignore the Null at end of received data
                {
                    if (Conversions.ToString(ch) == Constants.vbLf)
                    {
                        line.Append(ch);
                        // Send for processing
                        // Console.WriteLine("raiseAppSerialDataEvent: {0} ", line)
                        foreach (var callback in _recvDelegates)
                            // Console.WriteLine("recvDelegates: calling " + callback.Method.Name)
                            callback.Invoke(line.ToString());
                        // Get ready for next portion
                        line.Clear();
                    }
                    else
                    {
                        line.Append(ch);
                    }
                }
            }
        }
        /// <summary>
    /// Sends a byte of data to grbl
    /// </summary>
    /// <param name="data">The data to send to grbl</param>
    /// <returns>True if send was successful, false otherwise</returns>
        public bool sendData(string data)
        {
            switch (_type)
            {
                case ConnectionType.IP:
                    {
                        // We depend on the caller to not over send the 127 byte limit TODO HOW DO I PREVENT THIS???

                        if (_connected & _client.Connected)
                        {
                            // Write data to Grbl
                            // Simple is send data, wait for ok before sending next block
                            // Aggressive is determing how full the Grbl buffer is and sending as much as possible.
                            // This requires tracking ok's, see Grbl Wiki
                            // For now we just write
                            if (data.Length == 1)     // no CRLF at end, it should be an immediate command such as ! or ~ or ?
                            {
                                // _port.Write(data)
                                var c = Encoding.GetEncoding(1252).GetBytes(data);
                                try
                                {
                                    _client.GetStream().Write(c, 0, c.Length);
                                }
                                catch
                                {
                                    _connected = false;
                                    // _port.Close()
                                    MessageBox.Show(Resources.GrblIF_sendData_FatalErrorOnWriteToGrbl);
                                }
                            }

                            // Console.WriteLine("GrblIF::sendData Sent: " + data + " to Grbl")
                            else
                            {
                                // Note that this encoding allows only 7 bit Ascii characters!
                                var c = Encoding.ASCII.GetBytes(data + Constants.vbLf);
                                try
                                {
                                    _client.GetStream().Write(c, 0, c.Length);
                                }
                                catch
                                {
                                    _connected = false;
                                    // _port.Close()
                                    MessageBox.Show(Resources.GrblIF_sendData_FatalErrorOnWriteToGrbl);
                                }
                                // Console.WriteLine("GrblIF::sendData Sent: " + data + " to Grbl")
                            }

                            return true;
                        }
                        else
                        {
                            return false;
                        }

                        break;
                    }

                case ConnectionType.Serial:
                    {
                        // We depend on the caller to not over send the 127 byte limit TODO HOW DO I PREVENT THIS???

                        if (_connected & _port.IsOpen)
                        {
                            // Write data to Grbl
                            // Simple is send data, wait for ok before sending next block
                            // Aggressive is determing how full the Grbl buffer is and sending as much as possible.
                            // This requires tracking ok's, see Grbl Wiki
                            // For now we just write
                            if (data.Length == 1)     // no CRLF at end, it should be an immediate command such as ! or ~ or ?
                            {
                                var c = Encoding.GetEncoding(1252).GetBytes(data);
                                try
                                {
                                    _port.BaseStream.Write(c, 0, c.Length);
                                }
                                catch (Exception e)
                                {
                                    _connected = false;
                                    // _port.Close()
                                    MessageBox.Show(Resources.GrblIF_sendData_FatalErrorOnWriteToGrbl + ", " + e.Message);
                                }
                            }

                            // Console.WriteLine("GrblIF:char:sendData Sent: " + data + " to Grbl")
                            else
                            {
                                // Note that this encoding allows only 7 bit Ascii characters!
                                var c = Encoding.ASCII.GetBytes(data + Constants.vbLf);
                                try
                                {
                                    _port.BaseStream.Write(c, 0, c.Length);
                                }
                                catch (Exception e)
                                {
                                    _connected = false;
                                    // _port.Close()
                                    MessageBox.Show(Resources.GrblIF_sendData_FatalErrorOnWriteToGrbl + ", " + e.Message);
                                }
                                // Console.WriteLine(String.Format("Sent as byte: {0:X} {1:X}", c(0), c(1)))
                                // Console.WriteLine("GrblIF:line:sendData Sent: " + data + " to Grbl")
                            }

                            return true;
                        }
                        else
                        {
                            return false;
                        }

                        break;
                    }

                default:
                    {
                        return false; // This should not happen if connected, just in case.
                    }
            }
        }
    }
}