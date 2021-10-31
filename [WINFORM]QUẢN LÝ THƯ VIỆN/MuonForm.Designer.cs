
namespace _WINFORM_QUẢN_LÝ_THƯ_VIỆN
{
    partial class MuonForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label3;
            this.date_muon = new System.Windows.Forms.DateTimePicker();
            this.Textbox_docgiaID = new System.Windows.Forms.TextBox();
            this.Textbox_sID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.date_tra = new System.Windows.Forms.DateTimePicker();
            this.DGV_muon = new System.Windows.Forms.DataGridView();
            this.bt_muonsach = new System.Windows.Forms.Button();
            this.bt_trasach = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioButton_tea = new System.Windows.Forms.RadioButton();
            this.radioButton_std = new System.Windows.Forms.RadioButton();
            this.DGV_tracuusach = new System.Windows.Forms.DataGridView();
            this.comboBox_phanloai = new System.Windows.Forms.ComboBox();
            this.radioButton_theloai = new System.Windows.Forms.RadioButton();
            this.radioButton_nxb = new System.Windows.Forms.RadioButton();
            this.radioButton_tg = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_muon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_tracuusach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // date_muon
            // 
            this.date_muon.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_muon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_muon.Location = new System.Drawing.Point(151, 87);
            this.date_muon.Name = "date_muon";
            this.date_muon.Size = new System.Drawing.Size(196, 25);
            this.date_muon.TabIndex = 88;
            // 
            // Textbox_docgiaID
            // 
            this.Textbox_docgiaID.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_docgiaID.Location = new System.Drawing.Point(151, 50);
            this.Textbox_docgiaID.Name = "Textbox_docgiaID";
            this.Textbox_docgiaID.Size = new System.Drawing.Size(196, 25);
            this.Textbox_docgiaID.TabIndex = 86;
            // 
            // Textbox_sID
            // 
            this.Textbox_sID.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_sID.Location = new System.Drawing.Point(491, 50);
            this.Textbox_sID.Name = "Textbox_sID";
            this.Textbox_sID.Size = new System.Drawing.Size(196, 25);
            this.Textbox_sID.TabIndex = 85;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(45, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 19);
            this.label4.TabIndex = 84;
            this.label4.Text = "Ngày mượn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(49, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 82;
            this.label2.Text = "Mã độc giả:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label9.Location = new System.Drawing.Point(389, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 19);
            this.label9.TabIndex = 81;
            this.label9.Text = "Mã sách:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(385, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 89;
            this.label1.Text = "Ngày trả:";
            // 
            // date_tra
            // 
            this.date_tra.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_tra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_tra.Location = new System.Drawing.Point(491, 87);
            this.date_tra.Name = "date_tra";
            this.date_tra.Size = new System.Drawing.Size(196, 25);
            this.date_tra.TabIndex = 90;
            // 
            // DGV_muon
            // 
            this.DGV_muon.BackgroundColor = System.Drawing.Color.White;
            this.DGV_muon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_muon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_muon.Location = new System.Drawing.Point(0, 175);
            this.DGV_muon.Name = "DGV_muon";
            this.DGV_muon.RowHeadersVisible = false;
            this.DGV_muon.Size = new System.Drawing.Size(731, 275);
            this.DGV_muon.TabIndex = 91;
            this.DGV_muon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_muon_CellClick);
            // 
            // bt_muonsach
            // 
            this.bt_muonsach.BackColor = System.Drawing.Color.OrangeRed;
            this.bt_muonsach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_muonsach.Font = new System.Drawing.Font("UTM Facebook K&T", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_muonsach.ForeColor = System.Drawing.Color.Transparent;
            this.bt_muonsach.Location = new System.Drawing.Point(200, 125);
            this.bt_muonsach.Name = "bt_muonsach";
            this.bt_muonsach.Size = new System.Drawing.Size(137, 35);
            this.bt_muonsach.TabIndex = 104;
            this.bt_muonsach.Text = "MƯỢN SÁCH";
            this.bt_muonsach.UseVisualStyleBackColor = false;
            this.bt_muonsach.Click += new System.EventHandler(this.bt_muonsach_Click);
            // 
            // bt_trasach
            // 
            this.bt_trasach.BackColor = System.Drawing.Color.OrangeRed;
            this.bt_trasach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_trasach.Font = new System.Drawing.Font("UTM Facebook K&T", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_trasach.ForeColor = System.Drawing.Color.Transparent;
            this.bt_trasach.Location = new System.Drawing.Point(379, 125);
            this.bt_trasach.Name = "bt_trasach";
            this.bt_trasach.Size = new System.Drawing.Size(137, 35);
            this.bt_trasach.TabIndex = 111;
            this.bt_trasach.Text = "TRẢ SÁCH";
            this.bt_trasach.UseVisualStyleBackColor = false;
            this.bt_trasach.Click += new System.EventHandler(this.bt_trasach_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::_WINFORM_QUẢN_LÝ_THƯ_VIỆN.Properties.Resources.counterclockwise_arrows_48px;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(23, 125);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 46);
            this.pictureBox1.TabIndex = 112;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // radioButton_tea
            // 
            this.radioButton_tea.AutoSize = true;
            this.radioButton_tea.BackColor = System.Drawing.Color.DarkSlateGray;
            this.radioButton_tea.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_tea.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButton_tea.Location = new System.Drawing.Point(371, 10);
            this.radioButton_tea.Name = "radioButton_tea";
            this.radioButton_tea.Size = new System.Drawing.Size(103, 23);
            this.radioButton_tea.TabIndex = 115;
            this.radioButton_tea.TabStop = true;
            this.radioButton_tea.Text = "TEACHER";
            this.radioButton_tea.UseVisualStyleBackColor = false;
            this.radioButton_tea.CheckedChanged += new System.EventHandler(this.radioButton_tea_CheckedChanged);
            // 
            // radioButton_std
            // 
            this.radioButton_std.AutoSize = true;
            this.radioButton_std.BackColor = System.Drawing.Color.DarkSlateGray;
            this.radioButton_std.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_std.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButton_std.Location = new System.Drawing.Point(246, 10);
            this.radioButton_std.Name = "radioButton_std";
            this.radioButton_std.Size = new System.Drawing.Size(101, 23);
            this.radioButton_std.TabIndex = 114;
            this.radioButton_std.TabStop = true;
            this.radioButton_std.Text = "STUDENT";
            this.radioButton_std.UseVisualStyleBackColor = false;
            this.radioButton_std.CheckedChanged += new System.EventHandler(this.radioButton_std_CheckedChanged);
            // 
            // DGV_tracuusach
            // 
            this.DGV_tracuusach.BackgroundColor = System.Drawing.Color.White;
            this.DGV_tracuusach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_tracuusach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_tracuusach.Location = new System.Drawing.Point(730, 116);
            this.DGV_tracuusach.Name = "DGV_tracuusach";
            this.DGV_tracuusach.RowHeadersVisible = false;
            this.DGV_tracuusach.Size = new System.Drawing.Size(634, 334);
            this.DGV_tracuusach.TabIndex = 105;
            this.DGV_tracuusach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_tracuusach_CellClick);
            // 
            // comboBox_phanloai
            // 
            this.comboBox_phanloai.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_phanloai.FormattingEnabled = true;
            this.comboBox_phanloai.Location = new System.Drawing.Point(783, 80);
            this.comboBox_phanloai.Name = "comboBox_phanloai";
            this.comboBox_phanloai.Size = new System.Drawing.Size(288, 29);
            this.comboBox_phanloai.TabIndex = 106;
            this.comboBox_phanloai.SelectionChangeCommitted += new System.EventHandler(this.comboBox_phanloai_SelectionChangeCommitted);
            // 
            // radioButton_theloai
            // 
            this.radioButton_theloai.AutoSize = true;
            this.radioButton_theloai.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_theloai.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_theloai.ForeColor = System.Drawing.Color.Black;
            this.radioButton_theloai.Location = new System.Drawing.Point(3, 20);
            this.radioButton_theloai.Name = "radioButton_theloai";
            this.radioButton_theloai.Size = new System.Drawing.Size(83, 19);
            this.radioButton_theloai.TabIndex = 107;
            this.radioButton_theloai.TabStop = true;
            this.radioButton_theloai.Text = "THỂ LOẠI";
            this.radioButton_theloai.UseVisualStyleBackColor = false;
            this.radioButton_theloai.CheckedChanged += new System.EventHandler(this.radioButton_theloai_CheckedChanged);
            // 
            // radioButton_nxb
            // 
            this.radioButton_nxb.AutoSize = true;
            this.radioButton_nxb.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_nxb.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_nxb.ForeColor = System.Drawing.Color.Black;
            this.radioButton_nxb.Location = new System.Drawing.Point(97, 20);
            this.radioButton_nxb.Name = "radioButton_nxb";
            this.radioButton_nxb.Size = new System.Drawing.Size(79, 19);
            this.radioButton_nxb.TabIndex = 108;
            this.radioButton_nxb.TabStop = true;
            this.radioButton_nxb.Text = "TÊN NXB";
            this.radioButton_nxb.UseVisualStyleBackColor = false;
            this.radioButton_nxb.CheckedChanged += new System.EventHandler(this.radioButton_nxb_CheckedChanged_1);
            // 
            // radioButton_tg
            // 
            this.radioButton_tg.AutoSize = true;
            this.radioButton_tg.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_tg.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_tg.ForeColor = System.Drawing.Color.Black;
            this.radioButton_tg.Location = new System.Drawing.Point(187, 20);
            this.radioButton_tg.Name = "radioButton_tg";
            this.radioButton_tg.Size = new System.Drawing.Size(103, 19);
            this.radioButton_tg.TabIndex = 109;
            this.radioButton_tg.TabStop = true;
            this.radioButton_tg.Text = "TÊN TÁC GIẢ";
            this.radioButton_tg.UseVisualStyleBackColor = false;
            this.radioButton_tg.CheckedChanged += new System.EventHandler(this.radioButton_tg_CheckedChanged_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::_WINFORM_QUẢN_LÝ_THƯ_VIỆN.Properties.Resources.counterclockwise_arrows_48px;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(730, 67);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 46);
            this.pictureBox2.TabIndex = 110;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label3
            // 
            label3.BackColor = System.Drawing.Color.Maroon;
            label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            label3.Font = new System.Drawing.Font("SVN-Genica Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label3.Location = new System.Drawing.Point(730, 10);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(635, 44);
            label3.TabIndex = 113;
            label3.Text = "THÔNG TIN DANH MỤC SÁCH";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_tg);
            this.groupBox1.Controls.Add(this.radioButton_theloai);
            this.groupBox1.Controls.Add(this.radioButton_nxb);
            this.groupBox1.Location = new System.Drawing.Point(1076, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 48);
            this.groupBox1.TabIndex = 116;
            this.groupBox1.TabStop = false;
            // 
            // MuonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radioButton_tea);
            this.Controls.Add(this.radioButton_std);
            this.Controls.Add(label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bt_trasach);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.comboBox_phanloai);
            this.Controls.Add(this.DGV_tracuusach);
            this.Controls.Add(this.bt_muonsach);
            this.Controls.Add(this.DGV_muon);
            this.Controls.Add(this.date_tra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.date_muon);
            this.Controls.Add(this.Textbox_docgiaID);
            this.Controls.Add(this.Textbox_sID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Name = "MuonForm";
            this.Load += new System.EventHandler(this.MuonForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_muon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_tracuusach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DateTimePicker date_muon;
        public System.Windows.Forms.TextBox Textbox_docgiaID;
        public System.Windows.Forms.TextBox Textbox_sID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker date_tra;
        private System.Windows.Forms.DataGridView DGV_muon;
        private System.Windows.Forms.Button bt_muonsach;
        private System.Windows.Forms.Button bt_trasach;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioButton_tea;
        private System.Windows.Forms.RadioButton radioButton_std;
        private System.Windows.Forms.DataGridView DGV_tracuusach;
        private System.Windows.Forms.ComboBox comboBox_phanloai;
        private System.Windows.Forms.RadioButton radioButton_theloai;
        private System.Windows.Forms.RadioButton radioButton_nxb;
        private System.Windows.Forms.RadioButton radioButton_tg;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}