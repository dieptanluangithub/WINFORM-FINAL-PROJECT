
namespace _WINFORM_QUẢN_LÝ_THƯ_VIỆN
{
    partial class SachForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SachForm));
            this.TextBox_IDsach = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_sname = new System.Windows.Forms.TextBox();
            this.combo_tacgia = new System.Windows.Forms.ComboBox();
            this.combo_nxb = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_edit = new System.Windows.Forms.Button();
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_print = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.combo_theloai = new System.Windows.Forms.ComboBox();
            this.comboBox_phanloai = new System.Windows.Forms.ComboBox();
            this.tb_tong = new System.Windows.Forms.TextBox();
            this.tb_con = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bt_delete = new System.Windows.Forms.Button();
            this.radioButton_theloai = new System.Windows.Forms.RadioButton();
            this.radioButton_nxb = new System.Windows.Forms.RadioButton();
            this.radioButton_tg = new System.Windows.Forms.RadioButton();
            this.DGV_sach = new System.Windows.Forms.DataGridView();
            this.dlg = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_sach)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBox_IDsach
            // 
            this.TextBox_IDsach.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_IDsach.Location = new System.Drawing.Point(101, 23);
            this.TextBox_IDsach.Margin = new System.Windows.Forms.Padding(2);
            this.TextBox_IDsach.Name = "TextBox_IDsach";
            this.TextBox_IDsach.Size = new System.Drawing.Size(241, 29);
            this.TextBox_IDsach.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(12, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 18;
            this.label4.Text = "Thể loại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(823, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tổng số:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tên sách:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Mã sách:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(823, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 21);
            this.label5.TabIndex = 23;
            this.label5.Text = "Tên NXB:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(381, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 21);
            this.label6.TabIndex = 24;
            this.label6.Text = "Năm xuất bản:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(381, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 21);
            this.label7.TabIndex = 25;
            this.label7.Text = "Tên tác giả:";
            // 
            // textBox_sname
            // 
            this.textBox_sname.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_sname.Location = new System.Drawing.Point(101, 68);
            this.textBox_sname.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_sname.Name = "textBox_sname";
            this.textBox_sname.Size = new System.Drawing.Size(241, 29);
            this.textBox_sname.TabIndex = 26;
            // 
            // combo_tacgia
            // 
            this.combo_tacgia.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_tacgia.FormattingEnabled = true;
            this.combo_tacgia.Location = new System.Drawing.Point(528, 60);
            this.combo_tacgia.Margin = new System.Windows.Forms.Padding(2);
            this.combo_tacgia.Name = "combo_tacgia";
            this.combo_tacgia.Size = new System.Drawing.Size(241, 29);
            this.combo_tacgia.TabIndex = 28;
            // 
            // combo_nxb
            // 
            this.combo_nxb.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_nxb.FormattingEnabled = true;
            this.combo_nxb.Location = new System.Drawing.Point(932, 57);
            this.combo_nxb.Margin = new System.Windows.Forms.Padding(2);
            this.combo_nxb.Name = "combo_nxb";
            this.combo_nxb.Size = new System.Drawing.Size(241, 29);
            this.combo_nxb.TabIndex = 29;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(528, 102);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(241, 29);
            this.dateTimePicker1.TabIndex = 59;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Ivory;
            this.label11.Font = new System.Drawing.Font("SVN-Genica Pro", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(385, 2);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(848, 49);
            this.label11.TabIndex = 60;
            this.label11.Text = "QUẢN LÝ DANH MỤC SÁCH";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_add
            // 
            this.bt_add.BackColor = System.Drawing.Color.IndianRed;
            this.bt_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_add.Font = new System.Drawing.Font("UTM Akashi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_add.ForeColor = System.Drawing.Color.Transparent;
            this.bt_add.Location = new System.Drawing.Point(102, 155);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(90, 30);
            this.bt_add.TabIndex = 87;
            this.bt_add.Text = "LƯU";
            this.bt_add.UseVisualStyleBackColor = false;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.BackColor = System.Drawing.Color.DarkOrchid;
            this.bt_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_xoa.Font = new System.Drawing.Font("UTM Akashi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa.ForeColor = System.Drawing.Color.Transparent;
            this.bt_xoa.Location = new System.Drawing.Point(7, 155);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(90, 30);
            this.bt_xoa.TabIndex = 88;
            this.bt_xoa.Text = "THÊM";
            this.bt_xoa.UseVisualStyleBackColor = false;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_edit
            // 
            this.bt_edit.BackColor = System.Drawing.Color.DarkCyan;
            this.bt_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_edit.Font = new System.Drawing.Font("UTM Akashi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_edit.ForeColor = System.Drawing.Color.Transparent;
            this.bt_edit.Location = new System.Drawing.Point(198, 155);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.Size = new System.Drawing.Size(90, 30);
            this.bt_edit.TabIndex = 89;
            this.bt_edit.Text = "CHỈNH SỬA";
            this.bt_edit.UseVisualStyleBackColor = false;
            this.bt_edit.Click += new System.EventHandler(this.bt_edit_Click);
            // 
            // bt_save
            // 
            this.bt_save.BackColor = System.Drawing.Color.Red;
            this.bt_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_save.Font = new System.Drawing.Font("UTM Akashi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_save.ForeColor = System.Drawing.Color.Transparent;
            this.bt_save.Location = new System.Drawing.Point(683, 479);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(106, 35);
            this.bt_save.TabIndex = 91;
            this.bt_save.Text = "SAVE FILE";
            this.bt_save.UseVisualStyleBackColor = false;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // bt_print
            // 
            this.bt_print.BackColor = System.Drawing.Color.DarkOrange;
            this.bt_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_print.Font = new System.Drawing.Font("UTM Akashi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_print.ForeColor = System.Drawing.Color.Transparent;
            this.bt_print.Location = new System.Drawing.Point(459, 479);
            this.bt_print.Name = "bt_print";
            this.bt_print.Size = new System.Drawing.Size(106, 35);
            this.bt_print.TabIndex = 90;
            this.bt_print.Text = "PRINT";
            this.bt_print.UseVisualStyleBackColor = false;
            this.bt_print.Click += new System.EventHandler(this.bt_print_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.OrangeRed;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("UTM Akashi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Transparent;
            this.button5.Location = new System.Drawing.Point(571, 479);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 35);
            this.button5.TabIndex = 95;
            this.button5.Text = "RESET";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // combo_theloai
            // 
            this.combo_theloai.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_theloai.FormattingEnabled = true;
            this.combo_theloai.Location = new System.Drawing.Point(101, 118);
            this.combo_theloai.Name = "combo_theloai";
            this.combo_theloai.Size = new System.Drawing.Size(241, 29);
            this.combo_theloai.TabIndex = 96;
            // 
            // comboBox_phanloai
            // 
            this.comboBox_phanloai.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_phanloai.FormattingEnabled = true;
            this.comboBox_phanloai.Location = new System.Drawing.Point(528, 149);
            this.comboBox_phanloai.Name = "comboBox_phanloai";
            this.comboBox_phanloai.Size = new System.Drawing.Size(302, 29);
            this.comboBox_phanloai.TabIndex = 97;
            this.comboBox_phanloai.SelectionChangeCommitted += new System.EventHandler(this.comboBox_phanloai_SelectionChangeCommitted);
            // 
            // tb_tong
            // 
            this.tb_tong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tong.Location = new System.Drawing.Point(932, 102);
            this.tb_tong.Margin = new System.Windows.Forms.Padding(2);
            this.tb_tong.Name = "tb_tong";
            this.tb_tong.Size = new System.Drawing.Size(57, 29);
            this.tb_tong.TabIndex = 98;
            // 
            // tb_con
            // 
            this.tb_con.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_con.Location = new System.Drawing.Point(1116, 102);
            this.tb_con.Margin = new System.Windows.Forms.Padding(2);
            this.tb_con.Name = "tb_con";
            this.tb_con.Size = new System.Drawing.Size(57, 29);
            this.tb_con.TabIndex = 99;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(1024, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 21);
            this.label8.TabIndex = 100;
            this.label8.Text = "Còn lại:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(423, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 22);
            this.label9.TabIndex = 101;
            this.label9.Text = "Phân loại:";
            // 
            // bt_delete
            // 
            this.bt_delete.BackColor = System.Drawing.Color.DarkCyan;
            this.bt_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_delete.Font = new System.Drawing.Font("UTM Akashi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_delete.ForeColor = System.Drawing.Color.Transparent;
            this.bt_delete.Location = new System.Drawing.Point(294, 155);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(90, 30);
            this.bt_delete.TabIndex = 103;
            this.bt_delete.Text = "XÓA";
            this.bt_delete.UseVisualStyleBackColor = false;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // radioButton_theloai
            // 
            this.radioButton_theloai.AutoSize = true;
            this.radioButton_theloai.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_theloai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_theloai.ForeColor = System.Drawing.Color.Maroon;
            this.radioButton_theloai.Location = new System.Drawing.Point(864, 151);
            this.radioButton_theloai.Name = "radioButton_theloai";
            this.radioButton_theloai.Size = new System.Drawing.Size(102, 23);
            this.radioButton_theloai.TabIndex = 104;
            this.radioButton_theloai.TabStop = true;
            this.radioButton_theloai.Text = "THỂ LOẠI";
            this.radioButton_theloai.UseVisualStyleBackColor = false;
            // 
            // radioButton_nxb
            // 
            this.radioButton_nxb.AutoSize = true;
            this.radioButton_nxb.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_nxb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_nxb.ForeColor = System.Drawing.Color.Maroon;
            this.radioButton_nxb.Location = new System.Drawing.Point(977, 151);
            this.radioButton_nxb.Name = "radioButton_nxb";
            this.radioButton_nxb.Size = new System.Drawing.Size(97, 23);
            this.radioButton_nxb.TabIndex = 105;
            this.radioButton_nxb.TabStop = true;
            this.radioButton_nxb.Text = "TÊN NXB";
            this.radioButton_nxb.UseVisualStyleBackColor = false;
            this.radioButton_nxb.CheckedChanged += new System.EventHandler(this.radioButton_nxb_CheckedChanged);
            // 
            // radioButton_tg
            // 
            this.radioButton_tg.AutoSize = true;
            this.radioButton_tg.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_tg.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_tg.ForeColor = System.Drawing.Color.Maroon;
            this.radioButton_tg.Location = new System.Drawing.Point(1085, 151);
            this.radioButton_tg.Name = "radioButton_tg";
            this.radioButton_tg.Size = new System.Drawing.Size(128, 23);
            this.radioButton_tg.TabIndex = 106;
            this.radioButton_tg.TabStop = true;
            this.radioButton_tg.Text = "TÊN TÁC GIẢ";
            this.radioButton_tg.UseVisualStyleBackColor = false;
            this.radioButton_tg.CheckedChanged += new System.EventHandler(this.radioButton_tg_CheckedChanged);
            // 
            // DGV_sach
            // 
            this.DGV_sach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_sach.Location = new System.Drawing.Point(7, 203);
            this.DGV_sach.Name = "DGV_sach";
            this.DGV_sach.RowHeadersVisible = false;
            this.DGV_sach.Size = new System.Drawing.Size(1238, 251);
            this.DGV_sach.TabIndex = 107;
            this.DGV_sach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_sach_CellClick_1);
            // 
            // dlg
            // 
            this.dlg.UseEXDialog = true;
            // 
            // SachForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.BackgroundImage = global::_WINFORM_QUẢN_LÝ_THƯ_VIỆN.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1245, 517);
            this.Controls.Add(this.DGV_sach);
            this.Controls.Add(this.radioButton_tg);
            this.Controls.Add(this.radioButton_nxb);
            this.Controls.Add(this.radioButton_theloai);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_con);
            this.Controls.Add(this.tb_tong);
            this.Controls.Add(this.comboBox_phanloai);
            this.Controls.Add(this.combo_theloai);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.bt_print);
            this.Controls.Add(this.bt_edit);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.combo_nxb);
            this.Controls.Add(this.combo_tacgia);
            this.Controls.Add(this.textBox_sname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TextBox_IDsach);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SachForm";
            this.Text = "SachForm";
            this.Load += new System.EventHandler(this.SachForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_sach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TextBox_IDsach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_sname;
        private System.Windows.Forms.ComboBox combo_tacgia;
        private System.Windows.Forms.ComboBox combo_nxb;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_edit;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Button bt_print;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox combo_theloai;
        private System.Windows.Forms.ComboBox comboBox_phanloai;
        private System.Windows.Forms.TextBox tb_tong;
        private System.Windows.Forms.TextBox tb_con;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.RadioButton radioButton_theloai;
        private System.Windows.Forms.RadioButton radioButton_nxb;
        private System.Windows.Forms.RadioButton radioButton_tg;
        private System.Windows.Forms.DataGridView DGV_sach;
        private System.Windows.Forms.PrintDialog dlg;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}