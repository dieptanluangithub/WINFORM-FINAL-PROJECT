
namespace _WINFORM_QUẢN_LÝ_THƯ_VIỆN
{
    partial class ChomuonForm
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
            System.Windows.Forms.Label label1;
            this.tb_theloai = new System.Windows.Forms.TextBox();
            this.tb_nxb = new System.Windows.Forms.TextBox();
            this.tb_tacgia = new System.Windows.Forms.TextBox();
            this.Tb_teaid = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.data_cm = new System.Windows.Forms.DateTimePicker();
            this.label23 = new System.Windows.Forms.Label();
            this.tb_sl = new System.Windows.Forms.TextBox();
            this.date_xb = new System.Windows.Forms.DateTimePicker();
            this.textBox_sname = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.TextBox_IDsach = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_reset = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_edit = new System.Windows.Forms.Button();
            this.bt_add = new System.Windows.Forms.Button();
            this.DGV_chomuon = new System.Windows.Forms.DataGridView();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_chomuon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = System.Drawing.Color.OrangeRed;
            label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            label1.Font = new System.Drawing.Font("SVN-Genica Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label1.Location = new System.Drawing.Point(0, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(1246, 44);
            label1.TabIndex = 91;
            label1.Text = "QUẢN LÝ DANH MỤC SÁCH GIẢNG VIÊN CHO MƯỢN";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_theloai
            // 
            this.tb_theloai.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_theloai.Location = new System.Drawing.Point(583, 61);
            this.tb_theloai.Margin = new System.Windows.Forms.Padding(2);
            this.tb_theloai.Name = "tb_theloai";
            this.tb_theloai.Size = new System.Drawing.Size(241, 29);
            this.tb_theloai.TabIndex = 161;
            // 
            // tb_nxb
            // 
            this.tb_nxb.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nxb.Location = new System.Drawing.Point(583, 139);
            this.tb_nxb.Margin = new System.Windows.Forms.Padding(2);
            this.tb_nxb.Name = "tb_nxb";
            this.tb_nxb.Size = new System.Drawing.Size(241, 29);
            this.tb_nxb.TabIndex = 160;
            // 
            // tb_tacgia
            // 
            this.tb_tacgia.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tacgia.Location = new System.Drawing.Point(583, 100);
            this.tb_tacgia.Margin = new System.Windows.Forms.Padding(2);
            this.tb_tacgia.Name = "tb_tacgia";
            this.tb_tacgia.Size = new System.Drawing.Size(241, 29);
            this.tb_tacgia.TabIndex = 159;
            // 
            // Tb_teaid
            // 
            this.Tb_teaid.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_teaid.Location = new System.Drawing.Point(219, 58);
            this.Tb_teaid.Margin = new System.Windows.Forms.Padding(2);
            this.Tb_teaid.Name = "Tb_teaid";
            this.Tb_teaid.Size = new System.Drawing.Size(241, 29);
            this.Tb_teaid.TabIndex = 158;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(4, 61);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(189, 22);
            this.label19.TabIndex = 157;
            this.label19.Text = "Giảng viên cho mượn:";
            // 
            // data_cm
            // 
            this.data_cm.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_cm.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_cm.Location = new System.Drawing.Point(991, 103);
            this.data_cm.Name = "data_cm";
            this.data_cm.Size = new System.Drawing.Size(241, 29);
            this.data_cm.TabIndex = 156;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(843, 106);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(144, 22);
            this.label23.TabIndex = 155;
            this.label23.Text = "Ngày cho mượn:";
            // 
            // tb_sl
            // 
            this.tb_sl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sl.Location = new System.Drawing.Point(991, 142);
            this.tb_sl.Margin = new System.Windows.Forms.Padding(2);
            this.tb_sl.Name = "tb_sl";
            this.tb_sl.Size = new System.Drawing.Size(57, 29);
            this.tb_sl.TabIndex = 154;
            // 
            // date_xb
            // 
            this.date_xb.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_xb.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_xb.Location = new System.Drawing.Point(991, 64);
            this.date_xb.Name = "date_xb";
            this.date_xb.Size = new System.Drawing.Size(241, 29);
            this.date_xb.TabIndex = 153;
            // 
            // textBox_sname
            // 
            this.textBox_sname.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_sname.Location = new System.Drawing.Point(101, 136);
            this.textBox_sname.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_sname.Name = "textBox_sname";
            this.textBox_sname.Size = new System.Drawing.Size(359, 29);
            this.textBox_sname.TabIndex = 152;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(470, 103);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(107, 22);
            this.label25.TabIndex = 151;
            this.label25.Text = "Tên tác giả:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(843, 67);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(129, 22);
            this.label26.TabIndex = 150;
            this.label26.Text = "Năm xuất bản:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(470, 142);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(92, 22);
            this.label27.TabIndex = 149;
            this.label27.Text = "Tên NXB:";
            // 
            // TextBox_IDsach
            // 
            this.TextBox_IDsach.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_IDsach.Location = new System.Drawing.Point(177, 97);
            this.TextBox_IDsach.Margin = new System.Windows.Forms.Padding(2);
            this.TextBox_IDsach.Name = "TextBox_IDsach";
            this.TextBox_IDsach.Size = new System.Drawing.Size(283, 29);
            this.TextBox_IDsach.TabIndex = 148;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.White;
            this.label29.Location = new System.Drawing.Point(470, 64);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(82, 22);
            this.label29.TabIndex = 147;
            this.label29.Text = "Thể loại:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.White;
            this.label30.Location = new System.Drawing.Point(843, 145);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(88, 22);
            this.label30.TabIndex = 146;
            this.label30.Text = "Số lượng:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.White;
            this.label31.Location = new System.Drawing.Point(4, 139);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(89, 22);
            this.label31.TabIndex = 145;
            this.label31.Text = "Tên sách:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.Transparent;
            this.label32.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.Color.White;
            this.label32.Location = new System.Drawing.Point(4, 100);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(171, 22);
            this.label32.TabIndex = 144;
            this.label32.Text = "Mã sách cho mượn:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::_WINFORM_QUẢN_LÝ_THƯ_VIỆN.Properties.Resources.counterclockwise_arrows_48px;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox4.Location = new System.Drawing.Point(906, 178);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(47, 46);
            this.pictureBox4.TabIndex = 143;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // bt_them
            // 
            this.bt_them.BackColor = System.Drawing.Color.OrangeRed;
            this.bt_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_them.Font = new System.Drawing.Font("UTM Akashi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_them.ForeColor = System.Drawing.Color.Transparent;
            this.bt_them.Location = new System.Drawing.Point(334, 189);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(106, 35);
            this.bt_them.TabIndex = 166;
            this.bt_them.Text = "THÊM";
            this.bt_them.UseVisualStyleBackColor = false;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // bt_reset
            // 
            this.bt_reset.BackColor = System.Drawing.Color.OrangeRed;
            this.bt_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_reset.Font = new System.Drawing.Font("UTM Akashi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_reset.ForeColor = System.Drawing.Color.Transparent;
            this.bt_reset.Location = new System.Drawing.Point(782, 189);
            this.bt_reset.Name = "bt_reset";
            this.bt_reset.Size = new System.Drawing.Size(106, 35);
            this.bt_reset.TabIndex = 165;
            this.bt_reset.Text = "RESET";
            this.bt_reset.UseVisualStyleBackColor = false;
            this.bt_reset.Click += new System.EventHandler(this.bt_reset_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.BackColor = System.Drawing.Color.OrangeRed;
            this.bt_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_delete.Font = new System.Drawing.Font("UTM Akashi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_delete.ForeColor = System.Drawing.Color.Transparent;
            this.bt_delete.Location = new System.Drawing.Point(670, 189);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(106, 35);
            this.bt_delete.TabIndex = 164;
            this.bt_delete.Text = "HOÀN TRẢ";
            this.bt_delete.UseVisualStyleBackColor = false;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_edit
            // 
            this.bt_edit.BackColor = System.Drawing.Color.OrangeRed;
            this.bt_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_edit.Font = new System.Drawing.Font("UTM Akashi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_edit.ForeColor = System.Drawing.Color.Transparent;
            this.bt_edit.Location = new System.Drawing.Point(558, 189);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.Size = new System.Drawing.Size(106, 35);
            this.bt_edit.TabIndex = 163;
            this.bt_edit.Text = "CHỈNH SỬA";
            this.bt_edit.UseVisualStyleBackColor = false;
            this.bt_edit.Click += new System.EventHandler(this.bt_edit_Click);
            // 
            // bt_add
            // 
            this.bt_add.BackColor = System.Drawing.Color.OrangeRed;
            this.bt_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_add.Font = new System.Drawing.Font("UTM Akashi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_add.ForeColor = System.Drawing.Color.Transparent;
            this.bt_add.Location = new System.Drawing.Point(446, 189);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(106, 35);
            this.bt_add.TabIndex = 162;
            this.bt_add.Text = "LƯU";
            this.bt_add.UseVisualStyleBackColor = false;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // DGV_chomuon
            // 
            this.DGV_chomuon.BackgroundColor = System.Drawing.Color.White;
            this.DGV_chomuon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_chomuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_chomuon.Location = new System.Drawing.Point(-3, 243);
            this.DGV_chomuon.Name = "DGV_chomuon";
            this.DGV_chomuon.RowHeadersVisible = false;
            this.DGV_chomuon.Size = new System.Drawing.Size(1249, 248);
            this.DGV_chomuon.TabIndex = 167;
            this.DGV_chomuon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_chomuon_CellClick);
            // 
            // ChomuonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1244, 489);
            this.Controls.Add(this.DGV_chomuon);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.bt_reset);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_edit);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.tb_theloai);
            this.Controls.Add(this.tb_nxb);
            this.Controls.Add(this.tb_tacgia);
            this.Controls.Add(this.Tb_teaid);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.data_cm);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.tb_sl);
            this.Controls.Add(this.date_xb);
            this.Controls.Add(this.textBox_sname);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.TextBox_IDsach);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(label1);
            this.Name = "ChomuonForm";
            this.Text = "ChomuonForm";
            this.Load += new System.EventHandler(this.ChomuonForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_chomuon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_theloai;
        private System.Windows.Forms.TextBox tb_nxb;
        private System.Windows.Forms.TextBox tb_tacgia;
        private System.Windows.Forms.TextBox Tb_teaid;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker data_cm;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox tb_sl;
        private System.Windows.Forms.DateTimePicker date_xb;
        private System.Windows.Forms.TextBox textBox_sname;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox TextBox_IDsach;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_reset;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_edit;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.DataGridView DGV_chomuon;
    }
}