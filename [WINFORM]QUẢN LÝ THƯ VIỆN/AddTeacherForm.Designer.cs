
namespace _WINFORM_QUẢN_LÝ_THƯ_VIỆN
{
    partial class AddTeacherForm
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
            this.bt_add = new System.Windows.Forms.Button();
            this.Combo_Donvi = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Textbox_Email = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.bt_uploadImage = new System.Windows.Forms.Button();
            this.Textbox_Address = new System.Windows.Forms.TextBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
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
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_add
            // 
            this.bt_add.BackColor = System.Drawing.Color.OrangeRed;
            this.bt_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_add.Font = new System.Drawing.Font("UTM Colossalis", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_add.ForeColor = System.Drawing.Color.White;
            this.bt_add.Location = new System.Drawing.Point(328, 398);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(223, 41);
            this.bt_add.TabIndex = 114;
            this.bt_add.Text = "ADD INFORMATION";
            this.bt_add.UseVisualStyleBackColor = false;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // Combo_Donvi
            // 
            this.Combo_Donvi.FormattingEnabled = true;
            this.Combo_Donvi.Location = new System.Drawing.Point(178, 130);
            this.Combo_Donvi.Name = "Combo_Donvi";
            this.Combo_Donvi.Size = new System.Drawing.Size(196, 21);
            this.Combo_Donvi.TabIndex = 113;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(50, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 22);
            this.label11.TabIndex = 112;
            this.label11.Text = "Đơn vị:";
            // 
            // Textbox_Email
            // 
            this.Textbox_Email.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_Email.Location = new System.Drawing.Point(177, 358);
            this.Textbox_Email.Name = "Textbox_Email";
            this.Textbox_Email.Size = new System.Drawing.Size(196, 21);
            this.Textbox_Email.TabIndex = 111;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(50, 358);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 22);
            this.label10.TabIndex = 110;
            this.label10.Text = "Email:";
            // 
            // bt_uploadImage
            // 
            this.bt_uploadImage.Location = new System.Drawing.Point(642, 358);
            this.bt_uploadImage.Name = "bt_uploadImage";
            this.bt_uploadImage.Size = new System.Drawing.Size(110, 23);
            this.bt_uploadImage.TabIndex = 109;
            this.bt_uploadImage.Text = "Upload Image";
            this.bt_uploadImage.UseVisualStyleBackColor = true;
            this.bt_uploadImage.Click += new System.EventHandler(this.bt_uploadImage_Click);
            // 
            // Textbox_Address
            // 
            this.Textbox_Address.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_Address.Location = new System.Drawing.Point(590, 93);
            this.Textbox_Address.Multiline = true;
            this.Textbox_Address.Name = "Textbox_Address";
            this.Textbox_Address.Size = new System.Drawing.Size(196, 98);
            this.Textbox_Address.TabIndex = 108;
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(642, 221);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(110, 129);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb1.TabIndex = 107;
            this.pb1.TabStop = false;
            // 
            // Radiobt_Female
            // 
            this.Radiobt_Female.AutoSize = true;
            this.Radiobt_Female.BackColor = System.Drawing.Color.Transparent;
            this.Radiobt_Female.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Radiobt_Female.ForeColor = System.Drawing.Color.Khaki;
            this.Radiobt_Female.Location = new System.Drawing.Point(268, 287);
            this.Radiobt_Female.Name = "Radiobt_Female";
            this.Radiobt_Female.Size = new System.Drawing.Size(74, 21);
            this.Radiobt_Female.TabIndex = 106;
            this.Radiobt_Female.TabStop = true;
            this.Radiobt_Female.Text = "Female";
            this.Radiobt_Female.UseVisualStyleBackColor = false;
            // 
            // Radiobt_Male
            // 
            this.Radiobt_Male.AutoSize = true;
            this.Radiobt_Male.BackColor = System.Drawing.Color.Transparent;
            this.Radiobt_Male.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Radiobt_Male.ForeColor = System.Drawing.Color.Khaki;
            this.Radiobt_Male.Location = new System.Drawing.Point(177, 287);
            this.Radiobt_Male.Name = "Radiobt_Male";
            this.Radiobt_Male.Size = new System.Drawing.Size(60, 21);
            this.Radiobt_Male.TabIndex = 105;
            this.Radiobt_Male.TabStop = true;
            this.Radiobt_Male.Text = "Male";
            this.Radiobt_Male.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(178, 246);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(196, 21);
            this.dateTimePicker1.TabIndex = 104;
            // 
            // Textbox_Phone
            // 
            this.Textbox_Phone.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_Phone.Location = new System.Drawing.Point(178, 320);
            this.Textbox_Phone.Name = "Textbox_Phone";
            this.Textbox_Phone.Size = new System.Drawing.Size(196, 21);
            this.Textbox_Phone.TabIndex = 103;
            // 
            // Textbox_Lname
            // 
            this.Textbox_Lname.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_Lname.Location = new System.Drawing.Point(178, 208);
            this.Textbox_Lname.Name = "Textbox_Lname";
            this.Textbox_Lname.Size = new System.Drawing.Size(196, 21);
            this.Textbox_Lname.TabIndex = 102;
            // 
            // Textbox_Fname
            // 
            this.Textbox_Fname.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_Fname.Location = new System.Drawing.Point(178, 170);
            this.Textbox_Fname.Name = "Textbox_Fname";
            this.Textbox_Fname.Size = new System.Drawing.Size(196, 21);
            this.Textbox_Fname.TabIndex = 101;
            // 
            // Textbox_ID
            // 
            this.Textbox_ID.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_ID.Location = new System.Drawing.Point(178, 94);
            this.Textbox_ID.Name = "Textbox_ID";
            this.Textbox_ID.Size = new System.Drawing.Size(196, 21);
            this.Textbox_ID.TabIndex = 100;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(496, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 22);
            this.label8.TabIndex = 99;
            this.label8.Text = "Picture:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(496, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 22);
            this.label7.TabIndex = 98;
            this.label7.Text = "Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(50, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 22);
            this.label6.TabIndex = 97;
            this.label6.Text = "Phone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(50, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 22);
            this.label5.TabIndex = 96;
            this.label5.Text = "Gender:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(50, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 22);
            this.label4.TabIndex = 95;
            this.label4.Text = "BirthDate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(50, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 22);
            this.label3.TabIndex = 94;
            this.label3.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(50, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 22);
            this.label2.TabIndex = 93;
            this.label2.Text = "First Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(50, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 22);
            this.label9.TabIndex = 92;
            this.label9.Text = "Teacher ID:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Maroon;
            this.pictureBox4.BackgroundImage = global::_WINFORM_QUẢN_LÝ_THƯ_VIỆN.Properties.Resources.delete_208px;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(849, -1);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.TabIndex = 115;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // AddTeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_WINFORM_QUẢN_LÝ_THƯ_VIỆN.Properties.Resources.ADD_TC_4x;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(878, 445);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.Combo_Donvi);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Textbox_Email);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.bt_uploadImage);
            this.Controls.Add(this.Textbox_Address);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.Radiobt_Female);
            this.Controls.Add(this.Radiobt_Male);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Textbox_Phone);
            this.Controls.Add(this.Textbox_Lname);
            this.Controls.Add(this.Textbox_Fname);
            this.Controls.Add(this.Textbox_ID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddTeacherForm";
            this.Text = "AddTeacherForm";
            this.Load += new System.EventHandler(this.AddTeacherForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.ComboBox Combo_Donvi;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox Textbox_Email;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button bt_uploadImage;
        public System.Windows.Forms.TextBox Textbox_Address;
        public System.Windows.Forms.PictureBox pb1;
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
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}