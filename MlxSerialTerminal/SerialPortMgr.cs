using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace MlxSerialTerminal
{
    internal class SerialPortMgr
    //https://docs.microsoft.com/en-us/dotnet/api/system.io.ports.serialport?view=dotnet-plat-ext-6.0
    {
        static SerialPort _serialPort = null;
        public SerialPortMgr()
        {
            _serialPort = new SerialPort();
            _serialPort.PortName = "COM1";
            // Set the read/write timeouts
            _serialPort.ReadTimeout = -1;
            _serialPort.WriteTimeout = -1;
            _serialPort.DataBits = 8;
            _serialPort.Parity = Parity.None;
            _serialPort.StopBits = StopBits.One;
            _serialPort.Handshake = Handshake.None;

            _serialPort.BaudRate = 115200;

        }
        public void Open()
        {
            _serialPort.Open();
        }

        public void Close()
        {
            _serialPort.Close();
        }

        public void SetPortName(string sPortName)
        {
            _serialPort.PortName = sPortName;
        }
        public string GetPortName()
        {
            return _serialPort.PortName;
        }


        public int Byte2Read()
        {
            return _serialPort.BytesToRead;
        }

        public string ReadExisting()
        {
            return _serialPort.ReadExisting();
        }

        public bool IsOpen()
        { return _serialPort.IsOpen; }

        public void Write(string sLine)
        {
            _serialPort.Write(sLine);
        }
    }
}
