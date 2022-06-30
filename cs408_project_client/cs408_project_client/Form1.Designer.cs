namespace cs408_project_client
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1_connect = new System.Windows.Forms.Button();
            this.button2_disconnect = new System.Windows.Forms.Button();
            this.textBox1_username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1_send = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1_IP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2_port = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1_connect
            // 
            this.button1_connect.Location = new System.Drawing.Point(365, 12);
            this.button1_connect.Name = "button1_connect";
            this.button1_connect.Size = new System.Drawing.Size(131, 53);
            this.button1_connect.TabIndex = 0;
            this.button1_connect.Text = "Connect";
            this.button1_connect.UseVisualStyleBackColor = true;
            this.button1_connect.Click += new System.EventHandler(this.button1_connect_Click);
            // 
            // button2_disconnect
            // 
            this.button2_disconnect.Location = new System.Drawing.Point(365, 73);
            this.button2_disconnect.Name = "button2_disconnect";
            this.button2_disconnect.Size = new System.Drawing.Size(131, 53);
            this.button2_disconnect.TabIndex = 1;
            this.button2_disconnect.Text = "Disconnect";
            this.button2_disconnect.UseVisualStyleBackColor = true;
            this.button2_disconnect.Click += new System.EventHandler(this.button2_disconnect_Click);
            // 
            // textBox1_username
            // 
            this.textBox1_username.Location = new System.Drawing.Point(144, 168);
            this.textBox1_username.Name = "textBox1_username";
            this.textBox1_username.Size = new System.Drawing.Size(156, 22);
            this.textBox1_username.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "username";
            // 
            // button1_send
            // 
            this.button1_send.Location = new System.Drawing.Point(365, 161);
            this.button1_send.Name = "button1_send";
            this.button1_send.Size = new System.Drawing.Size(106, 37);
            this.button1_send.TabIndex = 4;
            this.button1_send.Text = "Send";
            this.button1_send.UseVisualStyleBackColor = true;
            this.button1_send.Click += new System.EventHandler(this.button1_send_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 217);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(484, 205);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // textBox1_IP
            // 
            this.textBox1_IP.Location = new System.Drawing.Point(144, 27);
            this.textBox1_IP.Name = "textBox1_IP";
            this.textBox1_IP.Size = new System.Drawing.Size(156, 22);
            this.textBox1_IP.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "IP";
            // 
            // textBox2_port
            // 
            this.textBox2_port.Location = new System.Drawing.Point(144, 73);
            this.textBox2_port.Name = "textBox2_port";
            this.textBox2_port.Size = new System.Drawing.Size(156, 22);
            this.textBox2_port.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "port";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 434);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2_port);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1_IP);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1_send);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1_username);
            this.Controls.Add(this.button2_disconnect);
            this.Controls.Add(this.button1_connect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_connect;
        private System.Windows.Forms.Button button2_disconnect;
        private System.Windows.Forms.TextBox textBox1_username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1_send;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1_IP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2_port;
        private System.Windows.Forms.Label label3;
    }
}

