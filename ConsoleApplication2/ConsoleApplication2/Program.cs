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
                xbee.kt = 1;
                mySerialPort.Open();

                //Console.WriteLine("Press any key to continue...");
                Console.WriteLine();
                while (xbee.kt == 1)
                {
                    Console.WriteLine("ban muon chon des nao  2 or 3: ");
                    string diachi;

                    diachi = Console.ReadLine();

                    if (diachi == "3")
                    {
                        xbee.kt = 0;
                        xbee.add = "00 03";
                    }
                    if (diachi == "2")
                    {
                        xbee.kt = 0;
                        xbee.add = "00 02";
                    }

                    else Console.WriteLine(" dia chi ban nhap sai xin moi nhap lai");
                }
                string datasend0;
                Console.WriteLine("nhan 1 de dieu khien den, 2 de lay nhiet do:");
                datasend0 = Console.ReadLine();

                /// dieu khien tin hieu den------------------------------------------------------
                /// -----------------------------------------------------------------------------

                if (datasend0 == "1")
                {
                    string datasend1;
                    Console.WriteLine("nhan phim 1 de tat den, 2 de mo den");
                    datasend1 = Console.ReadLine();

                    // truyen lenh cho dia node 2-------------------------------------------------------------------------------
                    //------------------------------------------------------------------------------------------
                    if (xbee.add == "00 02")
                    {
                        if (datasend1 == "1")
                        {
                            string code = "7E 00 07 01 01 00 02 00 31 31 99";

                            byte[] codehex = xbee.ConvertHexToDecimal(code);

                            mySerialPort.Write(codehex, 0, xbee.data.Length);
                        }
                        if (datasend1 == "2")
                        {

                            string code = "7E 00 07 01 01 00 02 00 31 32 98";

                            byte[] codehex = xbee.ConvertHexToDecimal(code);

                            mySerialPort.Write(codehex, 0, xbee.data.Length);

                        }
                    }

                    //truyen lenh cho node 3-----------------------------------------------
                    //_______________________________________________________
                    if (xbee.add == "00 03")
                    {
                        if (datasend1 == "1")
                        {
                            string code = "7E 00 07 01 01 00 03 00 31 31 98";

                            byte[] codehex = xbee.ConvertHexToDecimal(code);

                            mySerialPort.Write(codehex, 0, xbee.data.Length);
                        }
                        if (datasend1 == "2")
                        {

                            string code = "7E 00 07 01 01 00 02 00 31 32 97";

                            byte[] codehex = xbee.ConvertHexToDecimal(code);

                            mySerialPort.Write(codehex, 0, xbee.data.Length);

                        }

                    }
                }


                // lay gia tri nhiet do-------------------------------
                if (datasend0 == "2")
                {
                    Console.WriteLine("Nhiet do tai " + xbee.diachinhietdo + xbee.data[9]);
                }




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
