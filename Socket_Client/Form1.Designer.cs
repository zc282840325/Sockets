namespace Socket_Client
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
            this.txt_msg = new System.Windows.Forms.TextBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.txt_IP = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.txt_send = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_msg
            // 
            this.txt_msg.Location = new System.Drawing.Point(74, 110);
            this.txt_msg.Multiline = true;
            this.txt_msg.Name = "txt_msg";
            this.txt_msg.Size = new System.Drawing.Size(563, 108);
            this.txt_msg.TabIndex = 9;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(391, 58);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 7;
            this.btn_start.Text = "连接";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.Btn_start_Click);
            // 
            // txt_port
            // 
            this.txt_port.Location = new System.Drawing.Point(230, 60);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(64, 21);
            this.txt_port.TabIndex = 6;
            this.txt_port.Text = "5000";
            // 
            // txt_IP
            // 
            this.txt_IP.Location = new System.Drawing.Point(74, 60);
            this.txt_IP.Name = "txt_IP";
            this.txt_IP.Size = new System.Drawing.Size(125, 21);
            this.txt_IP.TabIndex = 5;
            this.txt_IP.Text = "172.18.108.209";
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(562, 389);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 10;
            this.btn_send.Text = "发送信息";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.Btn_send_Click);
            // 
            // txt_send
            // 
            this.txt_send.Location = new System.Drawing.Point(20, 20);
            this.txt_send.Multiline = true;
            this.txt_send.Name = "txt_send";
            this.txt_send.Size = new System.Drawing.Size(563, 108);
            this.txt_send.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_send);
            this.groupBox1.Location = new System.Drawing.Point(48, 239);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(589, 144);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "消息输入框";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.txt_msg);
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

        private System.Windows.Forms.TextBox txt_msg;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.TextBox txt_IP;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.TextBox txt_send;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

