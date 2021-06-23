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
            //按鈕初始狀態
            label1.Enabled = false;
            label2.Enabled = false;
            txt_IPAddress.Enabled = false;
            txt_IPPort.Enabled = false;
            btn_Pause.Enabled = false;
            btn_Stop.Enabled = false;
            //播放清單清空
            axVLCPlugin21.playlist.clear();
        }

        private void chk_Stream_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Stream.Checked)
            {
                label1.Enabled = true;
                label2.Enabled = true;
                txt_IPAddress.Enabled = true;
                txt_IPPort.Enabled = true;
                btn_Play.Text = "開始串流";
                btn_Pause.Text = "暫停串流";
                btn_Stop.Text = "停止串流";
            }
            else
            {
                label1.Enabled = false;
                label2.Enabled = false;
                txt_IPAddress.Enabled = false;
                txt_IPPort.Enabled = false;
                btn_Play.Text = "播放";
                btn_Pause.Text = "暫停";
                btn_Stop.Text = "停止";
            }
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            if (txt_File.Text != "")
            {
                //在播放(開始串流)時可操作之按鈕
                btn_Pause.Enabled = true;
                btn_Stop.Enabled = true;
                //在播放(開始串流)時不可操作之按鈕
                btn_Play.Enabled = false;
                chk_Stream.Enabled = false;
                txt_IPAddress.Enabled = false;
                txt_IPPort.Enabled = false;
                txt_File.Enabled = false;

                if (btn_Play.Text == "播放")
                {
                    axVLCPlugin21.playlist.add("http://"+txt_File.Text, null, null);
                }
                else if (btn_Play.Text == "開始串流")
                {
                    axVLCPlugin21.playlist.add("http://" + txt_File.Text, null,
                    ":sout=#transcode{vcodec=mp4v,vb=1024,scale=1,acodec=mpga,ab=192,channels=2}:duplicate{dst=display,dst=std{access=http,mux=ts,dst=" + txt_IPAddress.Text + ":" + txt_IPPort.Text + "}}");
                }
                axVLCPlugin21.playlist.play();
                axVLCPlugin21.playlist.playItem(0);
            }
            else
            {
                MessageBox.Show("路徑錯誤");
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

            //在停止(停止串流)時可操作之按鈕
            btn_Play.Enabled = true;
            //btn_Browse.Enabled = true;
            chk_Stream.Enabled = true;
            txt_IPAddress.Enabled = true;
            txt_IPPort.Enabled = true;
            txt_File.Enabled = true;
            //在停止(停止串流)時不可操作之按鈕
            btn_Pause.Enabled = false;
            btn_Stop.Enabled = false;          

            axVLCPlugin21.playlist.stop();
            axVLCPlugin21.playlist.clear();
        }
    }
}
