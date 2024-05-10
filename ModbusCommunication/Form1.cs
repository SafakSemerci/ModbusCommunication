using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using EasyModbus;

namespace ModbusCommunication
{
    public partial class Form1 : Form
    {
        //Create Modbus Client Configuration
        ModbusClient modbusClient;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Parameters Check
            try
            {
                // Create Modbus Client
                modbusClient = new ModbusClient();
                // Set IP Address PLC
                modbusClient.IPAddress = txtIPAddress.Text;
                // Set Port Number PLC
                //  modbusClient.Port = Convert.ToInt32(txtPort.Text);
            }

            // Check Any Error Situation
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Communication Try Catch
            try
            {
                // Modbus is connecting.
                modbusClient.Connect();


                // Check the connection
                if (modbusClient.Connected)
                {
                    lblStatus.Text = "Status: Connected";

                    // Start Timer Cyclic
                    timer1.Enabled = true;
                }
            }
            // Error Handling
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatus.Text = "Status: Not Connected";
            }

        }

        /* Disconnect from master */
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            modbusClient.Disconnect();
            if (modbusClient.Connected == false)
            {
                lblStatus.Text = "Status: Disconnected.";
            }
        }

        // Read Cyclicly
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (modbusClient.Connected == true)
            {
                TextBox[] textArray = { textBox1, textBox2, textBox3, textBox4, textBox5 };

                // int[] data = modbusClient.ReadHoldingRegisters(100, 5); // Read from D100 to D105

                int[] data = modbusClient.ReadHoldingRegisters(12288, 2);

                 for (int i = 0; i < data.Length; i++)
                 {
                 textArray[i].Text = data[i].ToString();
                  }


                //  bool[] Status = modbusClient.ReadDiscreteInputs(40960, 7); // Read SM Functions Starting from SM400 to SM407

                //chkbxSM402.Checked = Status[0]; // Read SM407 Clock Pulse

                // modbusClient.WriteSingleCoil(40960, checkBox1.Checked); // Write Output 0 (Y0);

                //int[] counter = modbusClient.ReadHoldingRegisters(61440, 1); // Read Counter (C0)

                // textBox6.Text = counter[0].ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)

        {
            // Write D100 Register
            int[] test = modbusClient.ReadHoldingRegisters(0, 7);
                txtWrite.Text = test[0].ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Write Counter Value (C0)
            modbusClient.WriteSingleRegister(0, Convert.ToInt32(txtCounter.Text));
        }

      
    }
}
