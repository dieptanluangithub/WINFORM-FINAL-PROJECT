
namespace _WINFORM_QUẢN_LÝ_THƯ_VIỆN
{
    partial class NhanvienForm
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
            this.DGV_nhanvien = new System.Windows.Forms.DataGridView();
            this.Combo_cv = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Textbox_Email = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Textbox_Address = new System.Windows.Forms.TextBox();
            this.Radiobt_Female = new System.Windows.Forms.RadioButton();
            this.Radiobt_Male = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Textbox_Phone = new System.Windows.Forms.TextBox();
            this.Textbox_Lname = new System.Windows.Forms.TextBox();
            this.Textbox_Fname = new System.Windows.Forms.TextBox();
            this.Textbox_ID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bt_uploadImage = new System.Windows.Forms.Button();
            this.bt_savefile = new System.Windows.Forms.Button();
            this.bt_in = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_luu = new System.Windows.Forms.Button();
            this.PictureboxStudentImage = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox_phanloai = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_nhanvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureboxStudentImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = System.Drawing.Color.OrangeRed;
            label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            label1.Font = new System.Drawing.Font("SVN-Genica Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label1.Location = new System.Drawing.Point(-6, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(1250, 44);
            label1.TabIndex = 111;
            label1.Text = "QUẢN LÝ NHÂN VIÊN THƯ VIỆN";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DGV_nhanvien
            // 
            this.DGV_nhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_nhanvien.Location = new System.Drawing.Point(2, 274);
            this.DGV_nhanvien.Name = "DGV_nhanvien";
            this.DGV_nhanvien.RowHeadersVisible = false;
            this.DGV_nhanvien.Size = new System.Drawing.Size(1241, 216);
            this.DGV_nhanvien.TabIndex = 0;
            this.DGV_nhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_nhanvien_CellClick);
            // 
            // Combo_cv
            // 
            this.Combo_cv.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Combo_cv.FormattingEnabled = true;
            this.Combo_cv.Location = new System.Drawing.Point(504, 174);
            this.Combo_cv.Name = "Combo_cv";
            this.Combo_cv.Size = new System.Drawing.Size(196, 25);
            this.Combo_cv.TabIndex = 108;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label11.Location = new System.Drawing.Point(409, 177);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 19);
            this.label11.TabIndex = 107;
            this.label11.Text = "Công việc:";
            // 
            // Textbox_Email
            // 
            this.Textbox_Email.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_Email.Location = new System.Drawing.Point(504, 137);
            this.Textbox_Email.Name = "Textbox_Email";
            this.Textbox_Email.Size = new System.Drawing.Size(196, 25);
            this.Textbox_Email.TabIndex = 106;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label10.Location = new System.Drawing.Point(409, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 19);
            this.label10.TabIndex = 105;
            this.label10.Text = "Email:";
            // 
            // Textbox_Address
            // 
            this.Textbox_Address.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_Address.Location = new System.Drawing.Point(849, 62);
            this.Textbox_Address.Multiline = true;
            this.Textbox_Address.Name = "Textbox_Address";
            this.Textbox_Address.Size = new System.Drawing.Size(196, 65);
            this.Textbox_Address.TabIndex = 104;
            // 
            // Radiobt_Female
            // 
            this.Radiobt_Female.AutoSize = true;
            this.Radiobt_Female.BackColor = System.Drawing.Color.Transparent;
            this.Radiobt_Female.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Radiobt_Female.Location = new System.Drawing.Point(598, 66);
            this.Radiobt_Female.Name = "Radiobt_Female";
            this.Radiobt_Female.Size = new System.Drawing.Size(74, 21);
            this.Radiobt_Female.TabIndex = 103;
            this.Radiobt_Female.TabStop = true;
            this.Radiobt_Female.Text = "Female";
            this.Radiobt_Female.UseVisualStyleBackColor = false;
            // 
            // Radiobt_Male
            // 
            this.Radiobt_Male.AutoSize = true;
            this.Radiobt_Male.BackColor = System.Drawing.Color.Transparent;
            this.Radiobt_Male.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Radiobt_Male.Location = new System.Drawing.Point(507, 66);
            this.Radiobt_Male.Name = "Radiobt_Male";
            this.Radiobt_Male.Size = new System.Drawing.Size(60, 21);
            this.Radiobt_Male.TabIndex = 102;
            this.Radiobt_Male.TabStop = true;
            this.Radiobt_Male.Text = "Male";
            this.Radiobt_Male.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(141, 174);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(196, 25);
            this.dateTimePicker1.TabIndex = 101;
            // 
            // Textbox_Phone
            // 
            this.Textbox_Phone.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_Phone.Location = new System.Drawing.Point(504, 101);
            this.Textbox_Phone.Name = "Textbox_Phone";
            this.Textbox_Phone.Size = new System.Drawing.Size(196, 25);
            this.Textbox_Phone.TabIndex = 100;
            // 
            // Textbox_Lname
            // 
            this.Textbox_Lname.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_Lname.Location = new System.Drawing.Point(141, 138);
            this.Textbox_Lname.Name = "Textbox_Lname";
            this.Textbox_Lname.Size = new System.Drawing.Size(196, 25);
            this.Textbox_Lname.TabIndex = 99;
            // 
            // Textbox_Fname
            // 
            this.Textbox_Fname.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_Fname.Location = new System.Drawing.Point(141, 100);
            this.Textbox_Fname.Name = "Textbox_Fname";
            this.Textbox_Fname.Size = new System.Drawing.Size(196, 25);
            this.Textbox_Fname.TabIndex = 98;
            // 
            // Textbox_ID
            // 
            this.Textbox_ID.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_ID.Location = new System.Drawing.Point(141, 63);
            this.Textbox_ID.Name = "Textbox_ID";
            this.Textbox_ID.Size = new System.Drawing.Size(196, 25);
            this.Textbox_ID.TabIndex = 97;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(754, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 19);
            this.label7.TabIndex = 96;
            this.label7.Text = "Địa chỉ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(409, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 19);
            this.label6.TabIndex = 95;
            this.label6.Text = "SĐT:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(409, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 19);
            this.label5.TabIndex = 94;
            this.label5.Text = "Giới tính:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(46, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 93;
            this.label4.Text = "Ngày sinh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(46, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 19);
            this.label3.TabIndex = 92;
            this.label3.Text = "Tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(46, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 19);
            this.label2.TabIndex = 91;
            this.label2.Text = "Họ:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label9.Location = new System.Drawing.Point(46, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 19);
            this.label9.TabIndex = 90;
            this.label9.Text = "ID:";
            // 
            // bt_uploadImage
            // 
            this.bt_uploadImage.Location = new System.Drawing.Point(1080, 200);
            this.bt_uploadImage.Name = "bt_uploadImage";
            this.bt_uploadImage.Size = new System.Drawing.Size(98, 23);
            this.bt_uploadImage.TabIndex = 110;
            this.bt_uploadImage.Text = "Upload Image";
            this.bt_uploadImage.UseVisualStyleBackColor = true;
            this.bt_uploadImage.Click += new System.EventHandler(this.bt_uploadImage_Click);
            // 
            // bt_savefile
            // 
            this.bt_savefile.BackColor = System.Drawing.Color.Brown;
            this.bt_savefile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_savefile.Font = new System.Drawing.Font("UTM Akashi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_savefile.ForeColor = System.Drawing.Color.Transparent;
            this.bt_savefile.Location = new System.Drawing.Point(724, 229);
            this.bt_savefile.Name = "bt_savefile";
            this.bt_savefile.Size = new System.Drawing.Size(77, 36);
            this.bt_savefile.TabIndex = 116;
            this.bt_savefile.Text = "LƯU FILE";
            this.bt_savefile.UseVisualStyleBackColor = false;
            // 
            // bt_in
            // 
            this.bt_in.BackColor = System.Drawing.Color.Brown;
            this.bt_in.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_in.Font = new System.Drawing.Font("UTM Akashi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_in.ForeColor = System.Drawing.Color.Transparent;
            this.bt_in.Location = new System.Drawing.Point(607, 229);
            this.bt_in.Name = "bt_in";
            this.bt_in.Size = new System.Drawing.Size(69, 36);
            this.bt_in.TabIndex = 115;
            this.bt_in.Text = "IN";
            this.bt_in.UseVisualStyleBackColor = false;
            // 
            // bt_xoa
            // 
            this.bt_xoa.BackColor = System.Drawing.Color.Brown;
            this.bt_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_xoa.Font = new System.Drawing.Font("UTM Akashi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa.ForeColor = System.Drawing.Color.Transparent;
            this.bt_xoa.Location = new System.Drawing.Point(490, 229);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(69, 36);
            this.bt_xoa.TabIndex = 114;
            this.bt_xoa.Text = "XÓA";
            this.bt_xoa.UseVisualStyleBackColor = false;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.BackColor = System.Drawing.Color.Brown;
            this.bt_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_sua.Font = new System.Drawing.Font("UTM Akashi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sua.ForeColor = System.Drawing.Color.Transparent;
            this.bt_sua.Location = new System.Drawing.Point(248, 229);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(69, 36);
            this.bt_sua.TabIndex = 113;
            this.bt_sua.Text = "SỬA";
            this.bt_sua.UseVisualStyleBackColor = false;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_them
            // 
            this.bt_them.BackColor = System.Drawing.Color.Firebrick;
            this.bt_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_them.Font = new System.Drawing.Font("UTM Akashi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_them.ForeColor = System.Drawing.Color.Transparent;
            this.bt_them.Location = new System.Drawing.Point(14, 229);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(69, 36);
            this.bt_them.TabIndex = 112;
            this.bt_them.Text = "THÊM";
            this.bt_them.UseVisualStyleBackColor = false;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // bt_luu
            // 
            this.bt_luu.BackColor = System.Drawing.Color.Firebrick;
            this.bt_luu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_luu.Font = new System.Drawing.Font("UTM Akashi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_luu.ForeColor = System.Drawing.Color.Transparent;
            this.bt_luu.Location = new System.Drawing.Point(131, 229);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(69, 36);
            this.bt_luu.TabIndex = 117;
            this.bt_luu.Text = "LƯU";
            this.bt_luu.UseVisualStyleBackColor = false;
            this.bt_luu.Click += new System.EventHandler(this.bt_luu_Click);
            // 
            // PictureboxStudentImage
            // 
            this.PictureboxStudentImage.BackColor = System.Drawing.Color.AliceBlue;
            this.PictureboxStudentImage.Location = new System.Drawing.Point(1080, 62);
            this.PictureboxStudentImage.Name = "PictureboxStudentImage";
            this.PictureboxStudentImage.Size = new System.Drawing.Size(98, 129);
            this.PictureboxStudentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureboxStudentImage.TabIndex = 109;
            this.PictureboxStudentImage.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Brown;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("UTM Akashi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(365, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 36);
            this.button1.TabIndex = 118;
            this.button1.Text = "QUAY LẠI";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // comboBox_phanloai
            // 
            this.comboBox_phanloai.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_phanloai.FormattingEnabled = true;
            this.comboBox_phanloai.Location = new System.Drawing.Point(1021, 240);
            this.comboBox_phanloai.Name = "comboBox_phanloai";
            this.comboBox_phanloai.Size = new System.Drawing.Size(196, 25);
            this.comboBox_phanloai.TabIndex = 120;
            this.comboBox_phanloai.SelectionChangeCommitted += new System.EventHandler(this.comboBox_phanloai_SelectionChangeCommitted);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(881, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 19);
            this.label8.TabIndex = 119;
            this.label8.Text = "Tìm theo công việc";
            // 
            // NhanvienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 514);
            this.Controls.Add(this.comboBox_phanloai);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_luu);
            this.Controls.Add(this.bt_savefile);
            this.Controls.Add(this.bt_in);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(label1);
            this.Controls.Add(this.bt_uploadImage);
            this.Controls.Add(this.PictureboxStudentImage);
            this.Controls.Add(this.Combo_cv);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Textbox_Email);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Textbox_Address);
            this.Controls.Add(this.Radiobt_Female);
            this.Controls.Add(this.Radiobt_Male);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Textbox_Phone);
            this.Controls.Add(this.Textbox_Lname);
            this.Controls.Add(this.Textbox_Fname);
            this.Controls.Add(this.Textbox_ID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DGV_nhanvien);
            this.Name = "NhanvienForm";
            this.Text = "NhanvienForm";
            this.Load += new System.EventHandler(this.NhanvienForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_nhanvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureboxStudentImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_nhanvien;
        private System.Windows.Forms.ComboBox Combo_cv;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox Textbox_Email;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox Textbox_Address;
        public System.Windows.Forms.RadioButton Radiobt_Female;
        public System.Windows.Forms.RadioButton Radiobt_Male;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.TextBox Textbox_Phone;
        public System.Windows.Forms.TextBox Textbox_Lname;
        public System.Windows.Forms.TextBox Textbox_Fname;
        public System.Windows.Forms.TextBox Textbox_ID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bt_uploadImage;
        public System.Windows.Forms.PictureBox PictureboxStudentImage;
        private System.Windows.Forms.Button bt_savefile;
        private System.Windows.Forms.Button bt_in;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_luu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox_phanloai;
        private System.Windows.Forms.Label label8;
    }
}