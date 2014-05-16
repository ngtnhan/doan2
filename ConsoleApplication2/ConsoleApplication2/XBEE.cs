using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XBEEController
{
    public class XBEE
    {
        public string trangthai2="";
        public string trangthai3="";
        public int ack = 0;
        public string diachinhietdo = "";
        public string xacnhan = "";
        public byte[] node2 = new byte[2];
        public byte[] node3 = new byte[2];
        public string add = "";
        public int kt = 1;
        public int a = 0;
        public byte[] data = new byte[12];
        public void Test()
        
            //public string xacnhan="";
        {
            SerialPort mySerialPort = new SerialPort("COM2");

            mySerialPort.BaudRate = 9600;
            mySerialPort.Parity = Parity.None;
            mySerialPort.StopBits = StopBits.One;
            mySerialPort.DataBits = 8;
            mySerialPort.Handshake = Handshake.None;

            mySerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

            //int b = 0;

            while (true)
            {
               
                kt = 1;
                mySerialPort.Open();

                //Console.WriteLine("Press any key to continue...");
                Console.WriteLine();
                while (kt == 1)
                {
                    Console.WriteLine("ban muon chon des nao  2 or 3: ");
                    string diachi;

                    diachi = Console.ReadLine();

                    if (diachi == "3")
                    {
                        kt = 0;
                        add = "00 03";
                    }
                    if (diachi == "2")
                    {
                        kt = 0;
                        add = "00 02";
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
                    if (add == "00 02")
                    {
                        if (datasend1 == "1")
                        {
                            string code = "7E 00 07 01 01 00 02 00 31 31 99";

                            byte[] codehex = ConvertHexToDecimal(code);

                            mySerialPort.Write(codehex, 0, data.Length);
                        }
                        if (datasend1 == "2")
                        {

                            string code = "7E 00 07 01 01 00 02 00 31 32 98";

                            byte[] codehex = ConvertHexToDecimal(code);

                            mySerialPort.Write(codehex, 0, data.Length);

                        }
                    }

                    //truyen lenh cho node 3-----------------------------------------------
                    //_______________________________________________________
                    if (add == "00 03")
                    {
                        if (datasend1 == "1")
                        {
                            string code = "7E 00 07 01 01 00 03 00 31 31 98";

                            byte[] codehex = ConvertHexToDecimal(code);

                            mySerialPort.Write(codehex, 0, data.Length);
                        }
                        if (datasend1 == "2")
                        {

                            string code = "7E 00 07 01 01 00 02 00 31 32 97";

                            byte[] codehex = ConvertHexToDecimal(code);

                            mySerialPort.Write(codehex, 0, data.Length);

                        }

                    }
                }


                // lay gia tri nhiet do-------------------------------
                if (datasend0 == "2")
                {
                    Console.WriteLine("Nhiet do tai " + diachinhietdo + data[9]);
                }




                ///-------------------------------------------------------------------------------------------------------------

                //Console.ReadKey();

                //if (chuongtrinh.data[0] == 0x7E)
                //{
                //    if (chuongtrinh.data[3] == 0x89)
                //    {
                //        if (chuongtrinh.data[5] == 0x00)
                //        {
                //           xacnhan="OK";
                //        }
                //        else 
                //            xacnhan="FAILURE";

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



        public void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;

            int indata = sp.ReadByte();
            char c = Convert.ToChar(indata);
            byte buffer = Convert.ToByte(c);

            if (buffer == 0x7E)
            {
                this.data[0] = buffer;
                this.a = 1;
                while (this.a < 4)
                {
                    indata = sp.ReadByte();
                    c = Convert.ToChar(indata);
                    buffer = Convert.ToByte(c);
                    this.data[this.a] = buffer;
                    this.a++;
                }

                //if (chuongtrinh.data[3] == 0x89)
                //{
                //    while (chuongtrinh.a < 7)
                //    {
                //        indata = sp.ReadByte();
                //        c = Convert.ToChar(indata);
                //        buffer = Convert.ToByte(c);
                //        chuongtrinh.data[chuongtrinh.a] = buffer;
                //        chuongtrinh.a++;

                //    }
                //    if (chuongtrinh.data[5] == 0x00)
                //    {
                //        Console.WriteLine("lenh da duoc truyen thanh cong");

                //    }
                //    else
                //        Console.WriteLine("Lenh truyen khong thanh cong");
                //}
                if (this.data[3] == 0x81)
                {
                    while (this.a < 12)
                    {
                        indata = sp.ReadByte();
                        c = Convert.ToChar(indata);
                        buffer = Convert.ToByte(c);
                        this.data[this.a] = buffer;
                        this.a++;
                    }
                    if (this.data[5] == 0x02)//node 2
                    {
                        this.node2[0] = this.data[9];
                        this.node2[1] = this.data[10];
                        if (this.data[10] == 0x32)
                        {
                            this.trangthai2 = "tiep diem da mo";
                        }
                        else this.trangthai2 = "tiep diem da dong";
                    }
                    if (this.data[5] == 0x03)
                    {
                        this.node3[0] = this.data[9];
                        this.node3[1] = this.data[10];
                        if (this.data[10] == 0x32)
                        {
                            this.trangthai2 = "tiep diem da mo";
                        }
                        else this.trangthai2 = "tiep diem da dong";
                    }

                }
                if (this.data[3] == 0x89)
                {
                    while (this.a < 7)
                    {
                        indata = sp.ReadByte();
                        c = Convert.ToChar(indata);
                        buffer = Convert.ToByte(c);
                        this.data[this.a] = buffer;
                        this.a++;
                    }

                    ack = 1;
                    if (this.data[5] == 0x00)
                    {
                        xacnhan = "OK";
                        
                    }
                    else
                        xacnhan = "FAILURE";
                    ack = 1;
                }
                


            }






            //Vi du cai doan code nay la de display cho option A



            //    Console.WriteLine(indata);
            //    char c = Convert.ToChar(indata);
            //    string d = c.ToString();
            //    Console.Write(c);


            //    string indatastr = indata.ToString();
            //    int indata = sp.ReadByte();
            //           Console.Write("Data Received:");
            //    Console.Write(d);
            //    Thread.Sleep(100);
            //}
            //else if (displayOption == DisplayOption.B)
            //{
            //neu option B thi viet code trong cai else nay




        }
        public byte[] ConvertHexToDecimal(string hexValues)
        {
            //string hexValues = "48 65 6C 6C 6F 20 57 6F 72 6C 64 21";
            string[] hexValuesSplit = hexValues.Split(' ');

            byte[] result = new byte[hexValuesSplit.Length];
            for (int i = 0; i < hexValuesSplit.Length; i++)
            {
                string hex = hexValuesSplit[i];
                // Convert the number expressed in base-16 to an integer. 
                result[i] = Convert.ToByte(hex, 16);
            }

            return result;
        }
        public string ConvertHexToHexString(Byte[] hex)
        {


            //string str = BitConverter.ToString(hex);
            //Console.WriteLine(str);

            string str = BitConverter.ToString(hex).Replace("-", " ");
            //Console.WriteLine(str);
            return str;

        }
    }
}
