namespace server_application
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
            this.button1_listen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1_port = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button1_listen
            // 
            this.button1_listen.Location = new System.Drawing.Point(330, 25);
            this.button1_listen.Name = "button1_listen";
            this.button1_listen.Size = new System.Drawing.Size(135, 59);
            this.button1_listen.TabIndex = 0;
            this.button1_listen.Text = "Listen";
            this.button1_listen.UseVisualStyleBackColor = true;
            this.button1_listen.Click += new System.EventHandler(this.button1_listen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port";
            // 
            // textBox1_port
            // 
            this.textBox1_port.Location = new System.Drawing.Point(94, 47);
            this.textBox1_port.Name = "textBox1_port";
            this.textBox1_port.Size = new System.Drawing.Size(209, 22);
            this.textBox1_port.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(40, 141);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(424, 229);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 415);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox1_port);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1_listen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_listen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1_port;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

