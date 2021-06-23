using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;

namespace VLCplayer
{
    public partial class Form1 : Form
    {
        public System.Windows.Forms.Timer ChkTimer = new System.Windows.Forms.Timer();
        public List<string> ServerList = new List<string>();

        public Form1()
        {
            InitializeComponent();

            ChkTimer.Enabled = true;
            ChkTimer.Interval = 3000; // one hour

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_Pause.Enabled = false;
            btn_Stop.Enabled = false;
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            func_PlayBack();
        }

        private void func_PlayBack()
        {
            if (txt_File.Text != "")
            {
                //在播放時可操作之按鈕
                btn_Pause.Enabled = true;
                btn_Stop.Enabled = true;
                //在播放時不可操作之按鈕
                btn_Play.Enabled = false;

                if (axVLCPlugin21.playlist.isPlaying)
                {
                    axVLCPlugin21.playlist.stop();
                    axVLCPlugin21.playlist.clear();
                }

                axVLCPlugin21.playlist.add("http://"+txt_File.Text);
                axVLCPlugin21.playlist.play();
                axVLCPlugin21.playlist.playItem(0);

                ChkTimer.Tick += new EventHandler(ChkTimer_Tick);
                ChkTimer.Start();

            }
            else
            {
                MessageBox.Show("無輸入串流來源");
            }
        }

        private void btn_Pause_Click(object sender, EventArgs e)
        {
            btn_Play.Enabled = true;
            btn_Pause.Enabled = false;
            btn_Stop.Enabled = true;
            axVLCPlugin21.playlist.togglePause();
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {

            //在停止時可操作之按鈕
            btn_Play.Enabled = true;
            txt_File.Enabled = true;

            //在停止時不可操作之按鈕
            btn_Pause.Enabled = false;
            btn_Stop.Enabled = false;          

            axVLCPlugin21.playlist.stop();
            axVLCPlugin21.playlist.clear();

            ChkTimer.Tick -= new EventHandler(ChkTimer_Tick);
            ChkTimer.Stop();
        }

        private void ChkTimer_Tick(object sender, EventArgs e)
        {
            func_chkParentNode();
        }

        private void func_chkParentNode()
        {

            string line = txt_File.Text;			// 讀取文字到 line 變數
            string ipaddress = line.Substring(0, line.LastIndexOf(":"));
            string portaddress = line.Substring(line.LastIndexOf(":") + 1, line.Length - line.LastIndexOf(":") - 1);
            int port = Convert.ToInt32(portaddress);
            TcpClient tcpClient = new TcpClient();
            try
            {
                tcpClient.Connect(ipaddress, port);
            }
            catch (Exception)
            {
                // Need to connect to new parent node
                txt_File.Text = ServerList[1];
                func_PlayBack();
            }
            tcpClient.Close();
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "文字檔 (*.txt)|*.txt";



            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                {
                    try
                    {
                        while (!sr.EndOfStream)                   // 每次讀取一行，直到檔尾
                        {
                            string line = sr.ReadLine();			// 讀取文字到 line 變數
                            ServerList.Add(line);
                        }
                        sr.Close();						                    // 關閉串流
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("載入檔案錯誤");
                    }
                }
            }
            txt_File.Text = ServerList[0];
            func_PlayBack();
        }
    }
}
