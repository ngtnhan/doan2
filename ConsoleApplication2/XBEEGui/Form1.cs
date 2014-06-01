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
using System.Timers;

namespace XBEEGui
{
    public partial class Form1 : Form
    {
        private const string ON_LIGHT = "Turn on Light";
        private const string OFF_LIGHT = "Turn off Light";
        private const string CONTROL_SENSOR = "Control Sensor";

        private  System.Timers.Timer aTimer;
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

            //timer
            aTimer = new System.Timers.Timer(10000);
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.Interval = 1000;
            aTimer.Enabled = true;
            
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
                if (address== 2)
                {
                    this.textBoxOutput.Text = "Nhiet do tai node 2 la " + xbee.node2[0];
                }
                if (address ==3)
                {
                 this.textBoxOutput.Text = "Nhiet do tai node 3 la " + xbee.node3[0];   
                }
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
                    code = "7E 00 07 01 01 00 03 00 31 32 97";
                }
            }

            byte[] codehex = xbee.ConvertHexToDecimal(code);
            mySerialPort.Write(codehex, 0, codehex.Length);
            //while (xbee.ack == 0)
            //{
            //}

            //this.textBoxOutput.Text = xbee.xacnhan;
            //xbee.ack = 0;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.textBoxOutput.Text = "Closing port...";
            this.mySerialPort.Close();
        }

        private void textBoxOutput_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {

            this.textBoxRelay2.Invoke(new Action(delegate() { textBoxRelay2.Text = xbee.trangthai2; }));
            this.textBoxRelay3.Invoke(new Action(delegate() { textBoxRelay3.Text = xbee.trangthai3; }));
            this.textBoxTemp2.Invoke(new Action(delegate() { textBoxTemp2.Text = xbee.node2[0] +"C"; }));
            this.textBoxTemp3.Invoke(new Action(delegate() { textBoxTemp3.Text = xbee.node3[0] + "C"; }));
            if (xbee.ack == 1)
            {
                this.textBoxOutput.Invoke(new Action(delegate() { textBoxOutput.Text = xbee.xacnhan; }));
                xbee.ack = 0;
            }
            
        }

       
    }
}
