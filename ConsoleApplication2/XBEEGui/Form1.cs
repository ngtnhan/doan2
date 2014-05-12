using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XBEEController;

namespace XBEEGui
{
    public partial class Form1 : Form
    {
        private const string ON_LIGHT = "Turn on Light";
        private const string OFF_LIGHT = "Turn off Light";
        private const string CONTROL_SENSOR = "Control Sensor";


        private XBEE xbee;
        private SerialPort mySerialPort;

        public Form1()
        {
            InitializeComponent();

            xbee = new XBEE();

            mySerialPort = new SerialPort("COM2");

            mySerialPort.BaudRate = 9600;
            mySerialPort.Parity = Parity.None;
            mySerialPort.StopBits = StopBits.One;
            mySerialPort.DataBits = 8;
            mySerialPort.Handshake = Handshake.None;

            mySerialPort.DataReceived += new SerialDataReceivedEventHandler(xbee.DataReceivedHandler);
            mySerialPort.Open();
        }

        private void buttonControl_Click(object sender, EventArgs e)
        {
            //reset textbox
            this.textBoxOutput.Text = string.Empty;

            //
            int address = (int) this.numericUpDownAddress.Value;
            string function = (string) this.comboBoxControl.SelectedItem;

            if (string.IsNullOrEmpty(function))
            {
                this.textBoxOutput.Text = "Please select a function to do!";
                return;
            }


            if (function == CONTROL_SENSOR)
            {
               this.textBoxOutput.Text = "Nhiet do tai " + xbee.diachinhietdo + xbee.data[9];
               return;
            }

            //light control
            string code = string.Empty;
            

            if (address == 2)
            {
                if (function == ON_LIGHT)
                {
                    code = "7E 00 07 01 01 00 02 00 31 32 98";
                }
                else if (function == OFF_LIGHT)
                {
                    code = "7E 00 07 01 01 00 02 00 31 31 99";
                }
            }
            else if (address == 3)
            {
                if (function == ON_LIGHT)
                {
                    code = "7E 00 07 01 01 00 03 00 31 31 98";

                    
                }
                else if (function == OFF_LIGHT)
                {
                    code = "7E 00 07 01 01 00 02 00 31 32 97";
                }
            }

            byte[] codehex = xbee.ConvertHexToDecimal(code);
            mySerialPort.Write(codehex, 0, xbee.data.Length);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.textBoxOutput.Text = "Closing port...";
            this.mySerialPort.Close();
        }

       
    }
}
