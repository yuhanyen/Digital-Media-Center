using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VLCplayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_Pause.Enabled = false;
            btn_Stop.Enabled = false;
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            if (txt_File.Text != "")
            {
                //在播放時可操作之按鈕
                btn_Pause.Enabled = true;
                btn_Stop.Enabled = true;
                //在播放時不可操作之按鈕
                btn_Play.Enabled = false;

                axVLCPlugin21.playlist.add("http://"+txt_File.Text);
                axVLCPlugin21.playlist.play();
                axVLCPlugin21.playlist.playItem(0);
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
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
