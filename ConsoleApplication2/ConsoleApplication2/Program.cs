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

                




                ///-------------------------------------------------------------------------------------------------------------

                //Console.ReadKey();

                //if (chuongtrinh.data[0] == 0x7E)
                //{
                //    if (chuongtrinh.data[3] == 0x89)
                //    {
                //        if (chuongtrinh.data[5] == 0x00)
                //        {
                //            Console.WriteLine("Lenh da goi di thanh cong");
                //        }
                //        else 
                //            Console.WriteLine("lenh goi di khong thanh cong");

                //    }
                //    if (chuongtrinh.data[3]==0x81)
                //    {
                //        //string datareceive;
                //        Console.Write(data[8] + data[9]);

                //    }
                //}
                mySerialPort.Close();
            }
        }
    }
}
