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

namespace PonteH
{
    public partial class Form1 : Form
    {
        SerialPort myport = new SerialPort();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(string name in SerialPort.GetPortNames())
            {
                portName.Items.Add(name);
            }
            baudeRate.Items.Add("9600");
        }

        private void connect_Click(object sender, EventArgs e)
        {
            try
            {
                if(baudeRate.Text != "") myport.BaudRate = Convert.ToInt32(baudeRate.Text); else MessageBox.Show("Selezionare un BaudRate grazie", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if(portName.Text != "") myport.PortName = portName.Text; else MessageBox.Show("Selezionare una Porta grazie", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                myport.Parity = Parity.None;
                if (!myport.IsOpen && portName.Text != "" && baudeRate.Text != "") { myport.Open(); logList.Items.Add("Connesso @" + portName.Text); }
                if(portName.Text != "" && baudeRate.Text != "") connect.Enabled = false;
            }
            catch(Exception er)
            {
                MessageBox.Show(er.ToString(),"Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            btnDown.Enabled = true;
            btnUp.Enabled = false;
            btnUp.BackColor = Color.Red;
            btnDown.BackColor = Color.Green;
            string value = "0$";
            myport.Write(value);
            logList.Items.Add(myport.ReadExisting());
            logList.SelectedIndex = logList.Items.Count - 1;
            myport.DiscardInBuffer();
            myport.DiscardOutBuffer();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            btnUp.Enabled = true;
            btnDown.Enabled = false;
            btnUp.BackColor = Color.Green;
            btnDown.BackColor = Color.Red;
            string value = "1$";
            myport.Write(value);
            logList.Items.Add(myport.ReadExisting());
            logList.SelectedIndex = logList.Items.Count - 1;
            myport.DiscardInBuffer();
            myport.DiscardOutBuffer();
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            myport.Write("2$");
        }
    }
}
