using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Start
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //网上找的函数
       public void SetAutoRun(string fileName, bool isAutoRun)
        {
            RegistryKey reg = null;
            try
            {
                if (!System.IO.File.Exists(fileName))
                    throw new Exception("该文件不存在!");
                String name = fileName.Substring(fileName.LastIndexOf(@"/") + 1);
                reg = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
                if (reg == null)
                    reg = Registry.LocalMachine.CreateSubKey(@"SOFTWARE/Microsoft/Windows/CurrentVersion/Run");
                if (isAutoRun)
                    reg.SetValue(name, fileName);
                else
                    reg.SetValue(name, false);
                lbl_autorunerr.Visible = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (reg != null)
                    reg.Close();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "|*.exe";
                if (ofd.ShowDialog() == DialogResult.OK)  //如果点击的是打开文件
                {
                    textBox1.Text = ofd.FileName;  //获取全路径文件名
                }
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SetAutoRun(textBox1.Text,true);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            SetAutoRun(textBox1.Text, false);
        }
    }
}
