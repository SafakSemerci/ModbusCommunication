namespace ModbusCommunication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button1 = new Button();
            txtIPAddress = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtPort = new TextBox();
            lblStatus = new Label();
            btnDisconnect = new Button();
            textBox1 = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            label3 = new Label();
            button2 = new Button();
            txtWrite = new TextBox();
            checkBox1 = new CheckBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            txtCounter = new TextBox();
            button3 = new Button();
            label4 = new Label();
            chkbxSM402 = new CheckBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(81, 66);
            button1.Name = "button1";
            button1.Size = new Size(111, 48);
            button1.TabIndex = 0;
            button1.Text = "Connect";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtIPAddress
            // 
            txtIPAddress.Location = new Point(81, 6);
            txtIPAddress.Name = "txtIPAddress";
            txtIPAddress.Size = new Size(258, 23);
            txtIPAddress.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 2;
            label1.Text = "IP Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 39);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 4;
            label2.Text = "Port";
            // 
            // txtPort
            // 
            txtPort.Location = new Point(81, 36);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(258, 23);
            txtPort.TabIndex = 3;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(361, 9);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(42, 15);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "Status:";
            // 
            // btnDisconnect
            // 
            btnDisconnect.Location = new Point(228, 65);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new Size(111, 48);
            btnDisconnect.TabIndex = 6;
            btnDisconnect.Text = "Disconnect";
            btnDisconnect.UseVisualStyleBackColor = true;
            btnDisconnect.Click += btnDisconnect_Click;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(334, 201);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(201, 23);
            textBox1.TabIndex = 8;
            // 
            // timer1
            // 
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(295, 204);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 9;
            label3.Text = "D100";
            // 
            // button2
            // 
            button2.Location = new Point(12, 154);
            button2.Name = "button2";
            button2.Size = new Size(99, 47);
            button2.TabIndex = 10;
            button2.Text = "D100 Write Value";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtWrite
            // 
            txtWrite.Location = new Point(12, 207);
            txtWrite.Name = "txtWrite";
            txtWrite.Size = new Size(99, 23);
            txtWrite.TabIndex = 11;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(277, 154);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(48, 19);
            checkBox1.TabIndex = 12;
            checkBox1.Text = "Y0.0";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(334, 230);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(201, 23);
            textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(334, 259);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(201, 23);
            textBox3.TabIndex = 14;
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(334, 288);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(201, 23);
            textBox4.TabIndex = 15;
            // 
            // textBox5
            // 
            textBox5.Enabled = false;
            textBox5.Location = new Point(334, 317);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(201, 23);
            textBox5.TabIndex = 16;
            // 
            // textBox6
            // 
            textBox6.Enabled = false;
            textBox6.Location = new Point(3, 292);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(201, 23);
            textBox6.TabIndex = 17;
            // 
            // txtCounter
            // 
            txtCounter.Location = new Point(137, 207);
            txtCounter.Name = "txtCounter";
            txtCounter.Size = new Size(99, 23);
            txtCounter.TabIndex = 18;
            // 
            // button3
            // 
            button3.Location = new Point(137, 154);
            button3.Name = "button3";
            button3.Size = new Size(99, 47);
            button3.TabIndex = 19;
            button3.Text = "Write C0 Counter";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 274);
            label4.Name = "label4";
            label4.Size = new Size(118, 15);
            label4.TabIndex = 20;
            label4.Text = "Actual Counter Value";
            // 
            // chkbxSM402
            // 
            chkbxSM402.AutoSize = true;
            chkbxSM402.Location = new Point(361, 154);
            chkbxSM402.Name = "chkbxSM402";
            chkbxSM402.Size = new Size(54, 19);
            chkbxSM402.TabIndex = 21;
            chkbxSM402.Text = "10ms";
            chkbxSM402.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(295, 233);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 22;
            label5.Text = "D101";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(295, 262);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 23;
            label6.Text = "D102";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(295, 291);
            label7.Name = "label7";
            label7.Size = new Size(33, 15);
            label7.TabIndex = 24;
            label7.Text = "D103";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(295, 320);
            label8.Name = "label8";
            label8.Size = new Size(33, 15);
            label8.TabIndex = 25;
            label8.Text = "D104";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(547, 365);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(chkbxSM402);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(txtCounter);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(checkBox1);
            Controls.Add(txtWrite);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(btnDisconnect);
            Controls.Add(lblStatus);
            Controls.Add(label2);
            Controls.Add(txtPort);
            Controls.Add(label1);
            Controls.Add(txtIPAddress);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Modbus TCP Client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtIPAddress;
        private Label label1;
        private Label label2;
        private TextBox txtPort;
        private Label lblStatus;
        private Button btnDisconnect;
        private TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private Label label3;
        private Button button2;
        private TextBox txtWrite;
        private CheckBox checkBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox txtCounter;
        private Button button3;
        private Label label4;
        private CheckBox chkbxSM402;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}
