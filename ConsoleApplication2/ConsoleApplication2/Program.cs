using System;
using System.IO.Ports;
using System.Threading;


namespace XBEEController
{

    class chuongtrinh
    {  
        private static void Main()
        {

            XBEE xbee = new XBEE();

            SerialPort mySerialPort = new SerialPort("COM2");

            mySerialPort.BaudRate = 9600;
            mySerialPort.Parity = Parity.None;
            mySerialPort.StopBits = StopBits.One;
            mySerialPort.DataBits = 8;
            mySerialPort.Handshake = Handshake.None;

            mySerialPort.DataReceived += new SerialDataReceivedEventHandler(xbee.DataReceivedHandler);

            //int b = 0;

            while (true)
            {
                
                mySerialPort.Open();

                





                mySerialPort.Close();
            }
        }
    }
}
