using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        SerialPort port;
        public Form1()
        {
            InitializeComponent();
            InitializePort("COM3");
        }

        private void InitializePort(string portName)
        {
            if (port == null);
            {
                port = new SerialPort(portName, 9600);
                port.Open();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PortWrite("1");

        }

        private void PortWrite(string v)
        {
            if (port != null && port.IsOpen)
            {
                port.Write(v);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (port != null && port.IsOpen)
            {
                port.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PortWrite("0");
        }
    }
}
