
namespace _WINFORM_QUẢN_LÝ_THƯ_VIỆN
{
    partial class BookStackerForm
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
            this.tcCustomer = new System.Windows.Forms.TabControl();
            this.tpBookBorrow = new System.Windows.Forms.TabPage();
            this.tpAccount = new System.Windows.Forms.TabPage();
            this.pn_Student = new System.Windows.Forms.Panel();
            this.Combo_congviec = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Textbox_Email = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Textbox_Address = new System.Windows.Forms.TextBox();
            this.PictureboxStudentImage = new System.Windows.Forms.PictureBox();
            this.Radiobt_Female = new System.Windows.Forms.RadioButton();
            this.Radiobt_Male = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Textbox_Phone = new System.Windows.Forms.TextBox();
            this.Textbox_Lname = new System.Windows.Forms.TextBox();
            this.Textbox_Fname = new System.Windows.Forms.TextBox();
            this.Textbox_ID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.Panrepass = new System.Windows.Forms.Panel();
            this.Textbox_confirmnew = new System.Windows.Forms.TextBox();
            this.panID = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.l3 = new System.Windows.Forms.Label();
            this.Textbox_newpass = new System.Windows.Forms.TextBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.l2 = new System.Windows.Forms.Label();
            this.l1 = new System.Windows.Forms.Label();
            this.Panpass = new System.Windows.Forms.Panel();
            this.txtPassword1 = new System.Windows.Forms.TextBox();
            this.Textbox_reUsername = new System.Windows.Forms.TextBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.label19 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tcCustomer.SuspendLayout();
            this.tpAccount.SuspendLayout();
            this.pn_Student.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureboxStudentImage)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tcCustomer
            // 
            this.tcCustomer.Controls.Add(this.tpBookBorrow);
            this.tcCustomer.Controls.Add(this.tpAccount);
            this.tcCustomer.Location = new System.Drawing.Point(-3, -1);
            this.tcCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.tcCustomer.Name = "tcCustomer";
            this.tcCustomer.SelectedIndex = 0;
            this.tcCustomer.Size = new System.Drawing.Size(1220, 455);
            this.tcCustomer.TabIndex = 52;
            this.tcCustomer.SelectedIndexChanged += new System.EventHandler(this.tcCustomer_SelectedIndexChanged);
            // 
            // tpBookBorrow
            // 
            this.tpBookBorrow.Location = new System.Drawing.Point(4, 22);
            this.tpBookBorrow.Margin = new System.Windows.Forms.Padding(4);
            this.tpBookBorrow.Name = "tpBookBorrow";
            this.tpBookBorrow.Padding = new System.Windows.Forms.Padding(4);
            this.tpBookBorrow.Size = new System.Drawing.Size(1212, 429);
            this.tpBookBorrow.TabIndex = 1;
            this.tpBookBorrow.Text = "Lịch phân công";
            this.tpBookBorrow.UseVisualStyleBackColor = true;
            // 
            // tpAccount
            // 
            this.tpAccount.BackColor = System.Drawing.Color.Transparent;
            this.tpAccount.Controls.Add(this.panel2);
            this.tpAccount.Controls.Add(this.pn_Student);
            this.tpAccount.Location = new System.Drawing.Point(4, 22);
            this.tpAccount.Margin = new System.Windows.Forms.Padding(4);
            this.tpAccount.Name = "tpAccount";
            this.tpAccount.Padding = new System.Windows.Forms.Padding(4);
            this.tpAccount.Size = new System.Drawing.Size(1212, 429);
            this.tpAccount.TabIndex = 5;
            this.tpAccount.Text = "Tài khoản";
            // 
            // pn_Student
            // 
            this.pn_Student.BackColor = System.Drawing.Color.White;
            this.pn_Student.Controls.Add(this.Combo_congviec);
            this.pn_Student.Controls.Add(this.label11);
            this.pn_Student.Controls.Add(this.Textbox_Email);
            this.pn_Student.Controls.Add(this.label10);
            this.pn_Student.Controls.Add(this.Textbox_Address);
            this.pn_Student.Controls.Add(this.PictureboxStudentImage);
            this.pn_Student.Controls.Add(this.Radiobt_Female);
            this.pn_Student.Controls.Add(this.Radiobt_Male);
            this.pn_Student.Controls.Add(this.dateTimePicker1);
            this.pn_Student.Controls.Add(this.Textbox_Phone);
            this.pn_Student.Controls.Add(this.Textbox_Lname);
            this.pn_Student.Controls.Add(this.Textbox_Fname);
            this.pn_Student.Controls.Add(this.Textbox_ID);
            this.pn_Student.Controls.Add(this.label8);
            this.pn_Student.Controls.Add(this.label7);
            this.pn_Student.Controls.Add(this.label6);
            this.pn_Student.Controls.Add(this.label5);
            this.pn_Student.Controls.Add(this.label4);
            this.pn_Student.Controls.Add(this.label3);
            this.pn_Student.Controls.Add(this.label2);
            this.pn_Student.Controls.Add(this.label9);
            this.pn_Student.Controls.Add(this.label1);
            this.pn_Student.Location = new System.Drawing.Point(1, -1);
            this.pn_Student.Name = "pn_Student";
            this.pn_Student.Size = new System.Drawing.Size(717, 431);
            this.pn_Student.TabIndex = 0;
            // 
            // Combo_congviec
            // 
            this.Combo_congviec.FormattingEnabled = true;
            this.Combo_congviec.Location = new System.Drawing.Point(165, 348);
            this.Combo_congviec.Name = "Combo_congviec";
            this.Combo_congviec.Size = new System.Drawing.Size(196, 21);
            this.Combo_congviec.TabIndex = 67;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label11.Location = new System.Drawing.Point(51, 348);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 19);
            this.label11.TabIndex = 66;
            this.label11.Text = "Công việc:";
            // 
            // Textbox_Email
            // 
            this.Textbox_Email.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_Email.Location = new System.Drawing.Point(165, 311);
            this.Textbox_Email.Name = "Textbox_Email";
            this.Textbox_Email.Size = new System.Drawing.Size(196, 21);
            this.Textbox_Email.TabIndex = 65;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label10.Location = new System.Drawing.Point(51, 311);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 19);
            this.label10.TabIndex = 64;
            this.label10.Text = "Email:";
            // 
            // Textbox_Address
            // 
            this.Textbox_Address.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_Address.Location = new System.Drawing.Point(492, 75);
            this.Textbox_Address.Multiline = true;
            this.Textbox_Address.Name = "Textbox_Address";
            this.Textbox_Address.Size = new System.Drawing.Size(196, 98);
            this.Textbox_Address.TabIndex = 59;
            // 
            // PictureboxStudentImage
            // 
            this.PictureboxStudentImage.Location = new System.Drawing.Point(544, 203);
            this.PictureboxStudentImage.Name = "PictureboxStudentImage";
            this.PictureboxStudentImage.Size = new System.Drawing.Size(110, 129);
            this.PictureboxStudentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureboxStudentImage.TabIndex = 58;
            this.PictureboxStudentImage.TabStop = false;
            // 
            // Radiobt_Female
            // 
            this.Radiobt_Female.AutoSize = true;
            this.Radiobt_Female.BackColor = System.Drawing.Color.Transparent;
            this.Radiobt_Female.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Radiobt_Female.Location = new System.Drawing.Point(256, 234);
            this.Radiobt_Female.Name = "Radiobt_Female";
            this.Radiobt_Female.Size = new System.Drawing.Size(74, 21);
            this.Radiobt_Female.TabIndex = 57;
            this.Radiobt_Female.TabStop = true;
            this.Radiobt_Female.Text = "Female";
            this.Radiobt_Female.UseVisualStyleBackColor = false;
            // 
            // Radiobt_Male
            // 
            this.Radiobt_Male.AutoSize = true;
            this.Radiobt_Male.BackColor = System.Drawing.Color.Transparent;
            this.Radiobt_Male.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Radiobt_Male.Location = new System.Drawing.Point(165, 234);
            this.Radiobt_Male.Name = "Radiobt_Male";
            this.Radiobt_Male.Size = new System.Drawing.Size(60, 21);
            this.Radiobt_Male.TabIndex = 56;
            this.Radiobt_Male.TabStop = true;
            this.Radiobt_Male.Text = "Male";
            this.Radiobt_Male.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(165, 193);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(196, 21);
            this.dateTimePicker1.TabIndex = 55;
            // 
            // Textbox_Phone
            // 
            this.Textbox_Phone.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_Phone.Location = new System.Drawing.Point(165, 275);
            this.Textbox_Phone.Name = "Textbox_Phone";
            this.Textbox_Phone.Size = new System.Drawing.Size(196, 21);
            this.Textbox_Phone.TabIndex = 54;
            // 
            // Textbox_Lname
            // 
            this.Textbox_Lname.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_Lname.Location = new System.Drawing.Point(165, 157);
            this.Textbox_Lname.Name = "Textbox_Lname";
            this.Textbox_Lname.Size = new System.Drawing.Size(196, 21);
            this.Textbox_Lname.TabIndex = 53;
            // 
            // Textbox_Fname
            // 
            this.Textbox_Fname.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_Fname.Location = new System.Drawing.Point(165, 119);
            this.Textbox_Fname.Name = "Textbox_Fname";
            this.Textbox_Fname.Size = new System.Drawing.Size(196, 21);
            this.Textbox_Fname.TabIndex = 52;
            // 
            // Textbox_ID
            // 
            this.Textbox_ID.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_ID.Location = new System.Drawing.Point(165, 82);
            this.Textbox_ID.Name = "Textbox_ID";
            this.Textbox_ID.Size = new System.Drawing.Size(196, 21);
            this.Textbox_ID.TabIndex = 51;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(390, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 19);
            this.label8.TabIndex = 50;
            this.label8.Text = "Picture:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(390, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 19);
            this.label7.TabIndex = 49;
            this.label7.Text = "Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(51, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 19);
            this.label6.TabIndex = 48;
            this.label6.Text = "Phone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(51, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 19);
            this.label5.TabIndex = 47;
            this.label5.Text = "Gender:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(51, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 46;
            this.label4.Text = "BirthDate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(51, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 45;
            this.label3.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(51, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 44;
            this.label2.Text = "First Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label9.Location = new System.Drawing.Point(51, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 19);
            this.label9.TabIndex = 43;
            this.label9.Text = "ID:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Firebrick;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(0, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(716, 40);
            this.label1.TabIndex = 42;
            this.label1.Text = "THÔNG TIN CÁ NHÂN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.Panrepass);
            this.panel2.Controls.Add(this.Textbox_confirmnew);
            this.panel2.Controls.Add(this.panID);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.l3);
            this.panel2.Controls.Add(this.Textbox_newpass);
            this.panel2.Controls.Add(this.pb3);
            this.panel2.Controls.Add(this.l2);
            this.panel2.Controls.Add(this.l1);
            this.panel2.Controls.Add(this.Panpass);
            this.panel2.Controls.Add(this.txtPassword1);
            this.panel2.Controls.Add(this.Textbox_reUsername);
            this.panel2.Controls.Add(this.pb2);
            this.panel2.Controls.Add(this.pb1);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Location = new System.Drawing.Point(718, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(597, 496);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Orange;
            this.panel3.Location = new System.Drawing.Point(87, 325);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(320, 2);
            this.panel3.TabIndex = 61;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("UTM Facebook K&T", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(162, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 35);
            this.button1.TabIndex = 119;
            this.button1.Text = "ĐỔI MẬT KHẨU";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(148, 267);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(161, 18);
            this.label20.TabIndex = 64;
            this.label20.Text = "Confirm new password";
            // 
            // Panrepass
            // 
            this.Panrepass.BackColor = System.Drawing.Color.Orange;
            this.Panrepass.Location = new System.Drawing.Point(86, 263);
            this.Panrepass.Name = "Panrepass";
            this.Panrepass.Size = new System.Drawing.Size(320, 2);
            this.Panrepass.TabIndex = 54;
            // 
            // Textbox_confirmnew
            // 
            this.Textbox_confirmnew.BackColor = System.Drawing.Color.DarkCyan;
            this.Textbox_confirmnew.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Textbox_confirmnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_confirmnew.ForeColor = System.Drawing.Color.Orange;
            this.Textbox_confirmnew.Location = new System.Drawing.Point(151, 288);
            this.Textbox_confirmnew.Multiline = true;
            this.Textbox_confirmnew.Name = "Textbox_confirmnew";
            this.Textbox_confirmnew.PasswordChar = '*';
            this.Textbox_confirmnew.Size = new System.Drawing.Size(255, 29);
            this.Textbox_confirmnew.TabIndex = 63;
            // 
            // panID
            // 
            this.panID.BackColor = System.Drawing.Color.Orange;
            this.panID.Location = new System.Drawing.Point(85, 137);
            this.panID.Name = "panID";
            this.panID.Size = new System.Drawing.Size(320, 2);
            this.panID.TabIndex = 55;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::_WINFORM_QUẢN_LÝ_THƯ_VIỆN.Properties.Resources.password_128px;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(87, 273);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(47, 46);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 62;
            this.pictureBox4.TabStop = false;
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.l3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l3.ForeColor = System.Drawing.Color.White;
            this.l3.Location = new System.Drawing.Point(147, 205);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(107, 18);
            this.l3.TabIndex = 60;
            this.l3.Text = "New password";
            // 
            // Textbox_newpass
            // 
            this.Textbox_newpass.BackColor = System.Drawing.Color.DarkCyan;
            this.Textbox_newpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Textbox_newpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_newpass.ForeColor = System.Drawing.Color.Orange;
            this.Textbox_newpass.Location = new System.Drawing.Point(150, 226);
            this.Textbox_newpass.Multiline = true;
            this.Textbox_newpass.Name = "Textbox_newpass";
            this.Textbox_newpass.PasswordChar = '*';
            this.Textbox_newpass.Size = new System.Drawing.Size(255, 29);
            this.Textbox_newpass.TabIndex = 59;
            // 
            // pb3
            // 
            this.pb3.BackColor = System.Drawing.Color.Transparent;
            this.pb3.BackgroundImage = global::_WINFORM_QUẢN_LÝ_THƯ_VIỆN.Properties.Resources.key_2_50px;
            this.pb3.Location = new System.Drawing.Point(86, 211);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(47, 46);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb3.TabIndex = 58;
            this.pb3.TabStop = false;
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.l2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l2.ForeColor = System.Drawing.Color.White;
            this.l2.Location = new System.Drawing.Point(147, 144);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(75, 18);
            this.l2.TabIndex = 57;
            this.l2.Text = "Password";
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.l1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l1.ForeColor = System.Drawing.Color.White;
            this.l1.Location = new System.Drawing.Point(147, 79);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(58, 18);
            this.l1.TabIndex = 56;
            this.l1.Text = "User ID";
            // 
            // Panpass
            // 
            this.Panpass.BackColor = System.Drawing.Color.Orange;
            this.Panpass.Location = new System.Drawing.Point(85, 200);
            this.Panpass.Name = "Panpass";
            this.Panpass.Size = new System.Drawing.Size(320, 2);
            this.Panpass.TabIndex = 53;
            // 
            // txtPassword1
            // 
            this.txtPassword1.BackColor = System.Drawing.Color.DarkCyan;
            this.txtPassword1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword1.ForeColor = System.Drawing.Color.Orange;
            this.txtPassword1.Location = new System.Drawing.Point(150, 165);
            this.txtPassword1.Multiline = true;
            this.txtPassword1.Name = "txtPassword1";
            this.txtPassword1.PasswordChar = '*';
            this.txtPassword1.Size = new System.Drawing.Size(255, 29);
            this.txtPassword1.TabIndex = 52;
            // 
            // Textbox_reUsername
            // 
            this.Textbox_reUsername.BackColor = System.Drawing.Color.DarkCyan;
            this.Textbox_reUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Textbox_reUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_reUsername.ForeColor = System.Drawing.Color.Orange;
            this.Textbox_reUsername.Location = new System.Drawing.Point(150, 100);
            this.Textbox_reUsername.Multiline = true;
            this.Textbox_reUsername.Name = "Textbox_reUsername";
            this.Textbox_reUsername.Size = new System.Drawing.Size(255, 31);
            this.Textbox_reUsername.TabIndex = 51;
            // 
            // pb2
            // 
            this.pb2.BackColor = System.Drawing.Color.Transparent;
            this.pb2.BackgroundImage = global::_WINFORM_QUẢN_LÝ_THƯ_VIỆN.Properties.Resources.unlock_50px;
            this.pb2.Location = new System.Drawing.Point(86, 150);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(47, 46);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb2.TabIndex = 50;
            this.pb2.TabStop = false;
            // 
            // pb1
            // 
            this.pb1.BackColor = System.Drawing.Color.Transparent;
            this.pb1.BackgroundImage = global::_WINFORM_QUẢN_LÝ_THƯ_VIỆN.Properties.Resources.user_50px;
            this.pb1.Location = new System.Drawing.Point(88, 85);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(47, 46);
            this.pb1.TabIndex = 49;
            this.pb1.TabStop = false;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.White;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.DarkRed;
            this.label19.Location = new System.Drawing.Point(0, 19);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(498, 40);
            this.label19.TabIndex = 43;
            this.label19.Text = "ĐỔI MẬT KHẨU";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::_WINFORM_QUẢN_LÝ_THƯ_VIỆN.Properties.Resources.export_200px;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(444, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 46);
            this.pictureBox1.TabIndex = 126;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BookStackerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 453);
            this.Controls.Add(this.tcCustomer);
            this.Name = "BookStackerForm";
            this.Text = "BookStackerForm";
            this.Load += new System.EventHandler(this.BookStackerForm_Load);
            this.tcCustomer.ResumeLayout(false);
            this.tpAccount.ResumeLayout(false);
            this.pn_Student.ResumeLayout(false);
            this.pn_Student.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureboxStudentImage)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcCustomer;
        private System.Windows.Forms.TabPage tpBookBorrow;
        private System.Windows.Forms.TabPage tpAccount;
        private System.Windows.Forms.Panel pn_Student;
        private System.Windows.Forms.ComboBox Combo_congviec;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox Textbox_Email;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox Textbox_Address;
        public System.Windows.Forms.PictureBox PictureboxStudentImage;
        public System.Windows.Forms.RadioButton Radiobt_Female;
        public System.Windows.Forms.RadioButton Radiobt_Male;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.TextBox Textbox_Phone;
        public System.Windows.Forms.TextBox Textbox_Lname;
        public System.Windows.Forms.TextBox Textbox_Fname;
        public System.Windows.Forms.TextBox Textbox_ID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel Panrepass;
        private System.Windows.Forms.TextBox Textbox_confirmnew;
        private System.Windows.Forms.Panel panID;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.TextBox Textbox_newpass;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Panel Panpass;
        private System.Windows.Forms.TextBox txtPassword1;
        private System.Windows.Forms.TextBox Textbox_reUsername;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}