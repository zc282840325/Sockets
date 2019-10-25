namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_IP = new System.Windows.Forms.TextBox();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txt_msg = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_send = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_IP
            // 
            this.txt_IP.Location = new System.Drawing.Point(80, 32);
            this.txt_IP.Name = "txt_IP";
            this.txt_IP.Size = new System.Drawing.Size(125, 21);
            this.txt_IP.TabIndex = 0;
            this.txt_IP.Text = "172.18.108.209";
            // 
            // txt_port
            // 
            this.txt_port.Location = new System.Drawing.Point(236, 32);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(64, 21);
            this.txt_port.TabIndex = 1;
            this.txt_port.Text = "5000";
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(397, 30);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "开始监听";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.Btn_start_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(496, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(147, 20);
            this.comboBox1.TabIndex = 3;
            // 
            // txt_msg
            // 
            this.txt_msg.Location = new System.Drawing.Point(80, 82);
            this.txt_msg.Multiline = true;
            this.txt_msg.Name = "txt_msg";
            this.txt_msg.Size = new System.Drawing.Size(563, 146);
            this.txt_msg.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_send);
            this.groupBox1.Location = new System.Drawing.Point(80, 246);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 144);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "消息输入框";
            // 
            // txt_send
            // 
            this.txt_send.Location = new System.Drawing.Point(20, 20);
            this.txt_send.Multiline = true;
            this.txt_send.Name = "txt_send";
            this.txt_send.Size = new System.Drawing.Size(543, 108);
            this.txt_send.TabIndex = 11;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(558, 396);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(85, 30);
            this.btn_send.TabIndex = 13;
            this.btn_send.Text = "发送信息";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.Btn_send_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.txt_msg);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.txt_port);
            this.Controls.Add(this.txt_IP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_IP;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txt_msg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_send;
        private System.Windows.Forms.Button btn_send;
    }
}

