namespace VLCplayer
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axVLCPlugin21 = new AxAXVLC.AxVLCPlugin2();
            this.btn_Play = new System.Windows.Forms.Button();
            this.btn_Pause = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.txt_File = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Load = new System.Windows.Forms.Button();
            this.cbx_List = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin21)).BeginInit();
            this.SuspendLayout();
            // 
            // axVLCPlugin21
            // 
            this.axVLCPlugin21.Enabled = true;
            this.axVLCPlugin21.Location = new System.Drawing.Point(12, 40);
            this.axVLCPlugin21.Name = "axVLCPlugin21";
            this.axVLCPlugin21.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVLCPlugin21.OcxState")));
            this.axVLCPlugin21.Size = new System.Drawing.Size(567, 296);
            this.axVLCPlugin21.TabIndex = 0;
            // 
            // btn_Play
            // 
            this.btn_Play.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Play.Location = new System.Drawing.Point(12, 344);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(80, 40);
            this.btn_Play.TabIndex = 1;
            this.btn_Play.Text = "播放";
            this.btn_Play.UseVisualStyleBackColor = true;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            // 
            // btn_Pause
            // 
            this.btn_Pause.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Pause.Location = new System.Drawing.Point(98, 344);
            this.btn_Pause.Name = "btn_Pause";
            this.btn_Pause.Size = new System.Drawing.Size(80, 40);
            this.btn_Pause.TabIndex = 2;
            this.btn_Pause.Text = "暫停";
            this.btn_Pause.UseVisualStyleBackColor = true;
            this.btn_Pause.Click += new System.EventHandler(this.btn_Pause_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Stop.Location = new System.Drawing.Point(184, 344);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(80, 40);
            this.btn_Stop.TabIndex = 3;
            this.btn_Stop.Text = "停止";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // txt_File
            // 
            this.txt_File.Location = new System.Drawing.Point(115, 12);
            this.txt_File.Name = "txt_File";
            this.txt_File.Size = new System.Drawing.Size(464, 22);
            this.txt_File.TabIndex = 7;
            this.txt_File.TextChanged += new System.EventHandler(this.txt_File_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(7, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "串流來源：";
            // 
            // btn_Load
            // 
            this.btn_Load.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_Load.Location = new System.Drawing.Point(270, 344);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(180, 40);
            this.btn_Load.TabIndex = 10;
            this.btn_Load.Text = "載入伺服器表單";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // cbx_List
            // 
            this.cbx_List.FormattingEnabled = true;
            this.cbx_List.ItemHeight = 12;
            this.cbx_List.Location = new System.Drawing.Point(454, 363);
            this.cbx_List.Name = "cbx_List";
            this.cbx_List.Size = new System.Drawing.Size(125, 20);
            this.cbx_List.TabIndex = 11;
            this.cbx_List.SelectedIndexChanged += new System.EventHandler(this.cbx_List_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(452, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "伺服器名稱：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 395);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_List);
            this.Controls.Add(this.txt_File);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Load);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.btn_Pause);
            this.Controls.Add(this.btn_Play);
            this.Controls.Add(this.axVLCPlugin21);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxAXVLC.AxVLCPlugin2 axVLCPlugin21;
        private System.Windows.Forms.Button btn_Play;
        private System.Windows.Forms.Button btn_Pause;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.TextBox txt_File;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.ComboBox cbx_List;
        private System.Windows.Forms.Label label1;

    }
}

