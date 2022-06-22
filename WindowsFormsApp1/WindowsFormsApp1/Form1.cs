using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyModbus;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        ModbusClient modbusClient;
        public Form1()
        {
            InitializeComponent();
        }

        private void tb_ModBus_Server_IP_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_Connect_Click(object sender, EventArgs e)
        {

            try
            {
                modbusClient = new ModbusClient(tb_ModBus_Server_IP.Text, 502);    //Ip-Address and Port of Modbus-TCP-Server
                modbusClient.Connect();
                lb_status.Text = "Connected!";

            }
            catch (Exception ex)
            {
                lb_status.Text = ex.ToString();
                throw;
            }



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bt_Disconnect_Click(object sender, EventArgs e)
        {
            modbusClient?.Disconnect();
            lb_status.Text = "Disconnected!";

        }

    }  
}
