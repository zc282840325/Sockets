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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Btn_start_Click(object sender, EventArgs e)
        {
            try
            {
                Socket socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPAddress ip = IPAddress.Any;
                //创建端口号对象
                IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(txt_port.Text));
                //监听
                socketWatch.Bind(point);
                ShowMsg("监听成功！");
                socketWatch.Listen(10);

                Thread t1 = new Thread(new ParameterizedThreadStart(Listen));
                t1.Start(socketWatch);
            }
            catch (Exception)
            {
            }
        }

        //存储连接的客户端的IP和Socket
        Dictionary<string, Socket> dicSocket = new Dictionary<string, Socket>();
        Socket socketSend;
        void Listen(object o)
        {
            Socket socketWatch = o as Socket;
            while (true)
            {
                socketSend = socketWatch.Accept();
                dicSocket.Add(socketSend.RemoteEndPoint.ToString(), socketSend);

                //将远程的服务器的ip和S
                comboBox1.Items.Add(socketSend.RemoteEndPoint.ToString());
                //192.168.11.78
                ShowMsg(socketSend.RemoteEndPoint.ToString() + ":连接成功");
                //开启线程不断接受信息
                Thread t2 = new Thread(new ParameterizedThreadStart(Recive));
                t2.Start(socketSend);
              
            }
          
        }
       

        private void ShowMsg(string v)
        {
            txt_msg.AppendText(v+"\r\n");
        }
        /// <summary>
        /// 轮询接受信息
        /// </summary>
        /// <param name="o"></param>
        void Recive(Object o)
        {
          
            Socket socketSend = o as Socket;
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
        /// <summary>
        /// 服务器给客户端发送消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_send_Click(object sender, EventArgs e)
        {
            string str = txt_send.Text.Trim();
            byte[] buffer = Encoding.UTF8.GetBytes(str);
            string ip = comboBox1.SelectedItem.ToString(); ;
            dicSocket[ip].Send(buffer);
        }
    }
}
