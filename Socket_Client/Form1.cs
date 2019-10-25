using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
                    byte[] buffer = new byte[1024 * 1024 * 2];
                    int r = socketSend.Receive(buffer);
                    if (r == 0)
                    {
                        break;
                    }
                    else
                    {
                        string str = Encoding.UTF8.GetString(buffer, 0, r);
                        ShowMsg(socketSend.RemoteEndPoint.ToString() + ":" + str);
                    }

                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //跨线程访问
            Control.CheckForIllegalCrossThreadCalls = false;
        }
    }
}
