using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Socket_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Socket socketSend;
        private void Btn_start_Click(object sender, EventArgs e)
        {
            //创建负责通讯的Socket
             socketSend = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress ip = IPAddress.Parse(txt_IP.Text);
            IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(txt_port.Text));
            //获得要连接的远程服务器应用程序的IP地址和端口号
            socketSend.Connect(point);
            ShowMsg("连接成功！");
            //开启线程不断接受信息
            Thread t2 = new Thread(Recive);
            t2.Start();
        }

        private void ShowMsg(string v)
        {
            txt_msg.AppendText(v + "\r\n");
        }

        private void Btn_send_Click(object sender, EventArgs e)
        {
            string str = txt_send.Text.Trim();
            byte[] buffer = Encoding.UTF8.GetBytes(str);
      


            socketSend.Send(buffer);
        }
        /// <summary>
        /// 轮询接受信息
        /// </summary>
        /// <param name="o"></param>
        void Recive()
        {
            while (true)
            {
                try
                {
                    byte[] buffer = new byte[1024 * 1024 * 3];
                    int r = socketSend.Receive(buffer);
                    int n = buffer[0];
                    if (r == 0)
                    {
                        break;
                    }
                    //发送文字消息
                    if (n == 0)
                    {
                        //实际接收到的有效字节数
                        string str = Encoding.UTF8.GetString(buffer, 1, r-1);
                        ShowMsg(socketSend.RemoteEndPoint.ToString() + ":" + str);
                        
                    }
                    else if (n == 1)
                    {
                        SaveFileDialog sfd = new SaveFileDialog();
                        sfd.InitialDirectory = @"C:\Users\Administrator\Desktop";
                        sfd.Title = "请选择要保存的文件";
                        sfd.Filter = "所有文件|*.*";
                        sfd.ShowDialog(this);
                        string path = sfd.FileName;
                        using (FileStream fs=new FileStream(path,FileMode.OpenOrCreate,FileAccess.Write))
                        {
                            fs.Write(buffer,1,r);
                        }
                    }
                    else if(n==2)
                    {
                        ZD();
                    }
                   

                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        /// <summary>
        /// 震动
        /// </summary>
        void ZD()
        {
            for (int i = 0; i < 500; i++)
            {
                this.Location = new Point(200,200);
                this.Location = new Point(280, 280);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //跨线程访问
            Control.CheckForIllegalCrossThreadCalls = false;
        }
    }
}
