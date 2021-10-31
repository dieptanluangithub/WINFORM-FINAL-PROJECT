
namespace _WINFORM_QUẢN_LÝ_THƯ_VIỆN
{
    partial class LoginForm
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
            this.radioButton_Student = new System.Windows.Forms.RadioButton();
            this.radioButton_Teacher = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.PassVisible = new System.Windows.Forms.PictureBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.Textbox_Username = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Passinvisible = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.bt_login = new System.Windows.Forms.Button();
            this.bt_register = new System.Windows.Forms.Button();
            this.radio_bookStaker = new System.Windows.Forms.RadioButton();
            this.radioButton_staff = new System.Windows.Forms.RadioButton();
            this.radioButton_Manager = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassVisible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Passinvisible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton_Student
            // 
            this.radioButton_Student.AutoSize = true;
            this.radioButton_Student.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_Student.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Student.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton_Student.Location = new System.Drawing.Point(312, 272);
            this.radioButton_Student.Name = "radioButton_Student";
            this.radioButton_Student.Size = new System.Drawing.Size(78, 23);
            this.radioButton_Student.TabIndex = 14;
            this.radioButton_Student.TabStop = true;
            this.radioButton_Student.Text = "Student";
            this.radioButton_Student.UseVisualStyleBackColor = false;
            // 
            // radioButton_Teacher
            // 
            this.radioButton_Teacher.AutoSize = true;
            this.radioButton_Teacher.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_Teacher.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Teacher.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton_Teacher.Location = new System.Drawing.Point(394, 272);
            this.radioButton_Teacher.Name = "radioButton_Teacher";
            this.radioButton_Teacher.Size = new System.Drawing.Size(81, 23);
            this.radioButton_Teacher.TabIndex = 15;
            this.radioButton_Teacher.TabStop = true;
            this.radioButton_Teacher.Text = "Teacher";
            this.radioButton_Teacher.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::_WINFORM_QUẢN_LÝ_THƯ_VIỆN.Properties.Resources.user_50px;
            this.pictureBox2.Location = new System.Drawing.Point(377, 140);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 46);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::_WINFORM_QUẢN_LÝ_THƯ_VIỆN.Properties.Resources.unlock_50px;
            this.pictureBox3.Location = new System.Drawing.Point(375, 205);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(47, 46);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // PassVisible
            // 
            this.PassVisible.BackColor = System.Drawing.Color.Transparent;
            this.PassVisible.BackgroundImage = global::_WINFORM_QUẢN_LÝ_THƯ_VIỆN.Properties.Resources.icons8_invisible_30px_2;
            this.PassVisible.Location = new System.Drawing.Point(700, 219);
            this.PassVisible.Name = "PassVisible";
            this.PassVisible.Size = new System.Drawing.Size(30, 30);
            this.PassVisible.TabIndex = 23;
            this.PassVisible.TabStop = false;
            this.PassVisible.Click += new System.EventHandler(this.PassVisible_Click);
            this.PassVisible.MouseLeave += new System.EventHandler(this.PassVisible_MouseLeave);
            this.PassVisible.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PassVisible_MouseMove);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.DimGray;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Silver;
            this.txtPassword.Location = new System.Drawing.Point(439, 220);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(255, 29);
            this.txtPassword.TabIndex = 25;
            this.txtPassword.Text = "Password";
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // Textbox_Username
            // 
            this.Textbox_Username.BackColor = System.Drawing.Color.DimGray;
            this.Textbox_Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Textbox_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_Username.ForeColor = System.Drawing.Color.DarkGray;
            this.Textbox_Username.Location = new System.Drawing.Point(439, 155);
            this.Textbox_Username.Multiline = true;
            this.Textbox_Username.Name = "Textbox_Username";
            this.Textbox_Username.Size = new System.Drawing.Size(255, 31);
            this.Textbox_Username.TabIndex = 24;
            this.Textbox_Username.Text = "Library ID";
            this.Textbox_Username.Click += new System.EventHandler(this.Textbox_Username_Click);
            this.Textbox_Username.Enter += new System.EventHandler(this.Textbox_Username_Enter);
            this.Textbox_Username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Textbox_Username_KeyPress);
            this.Textbox_Username.Leave += new System.EventHandler(this.Textbox_Username_Leave);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(371, 192);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 2);
            this.panel1.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(371, 255);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 2);
            this.panel2.TabIndex = 27;
            // 
            // Passinvisible
            // 
            this.Passinvisible.BackColor = System.Drawing.Color.Transparent;
            this.Passinvisible.BackgroundImage = global::_WINFORM_QUẢN_LÝ_THƯ_VIỆN.Properties.Resources.icons8_eye_30px_11;
            this.Passinvisible.Location = new System.Drawing.Point(700, 219);
            this.Passinvisible.Name = "Passinvisible";
            this.Passinvisible.Size = new System.Drawing.Size(30, 30);
            this.Passinvisible.TabIndex = 28;
            this.Passinvisible.TabStop = false;
            this.Passinvisible.Click += new System.EventHandler(this.Passinvisible_Click);
            this.Passinvisible.MouseLeave += new System.EventHandler(this.Passinvisible_MouseLeave);
            this.Passinvisible.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Passinvisible_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Maroon;
            this.pictureBox1.BackgroundImage = global::_WINFORM_QUẢN_LÝ_THƯ_VIỆN.Properties.Resources.delete_208px;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(812, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(389, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 18);
            this.label1.TabIndex = 30;
            this.label1.Text = "If you don’t have an account, you can create with";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::_WINFORM_QUẢN_LÝ_THƯ_VIỆN.Properties.Resources.male_user_96px;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(485, 24);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(147, 115);
            this.pictureBox4.TabIndex = 31;
            this.pictureBox4.TabStop = false;
            // 
            // bt_login
            // 
            this.bt_login.BackColor = System.Drawing.Color.Tomato;
            this.bt_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_login.Font = new System.Drawing.Font("UTM Akashi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_login.ForeColor = System.Drawing.Color.Transparent;
            this.bt_login.Location = new System.Drawing.Point(498, 312);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(120, 41);
            this.bt_login.TabIndex = 54;
            this.bt_login.Text = "LOG IN";
            this.bt_login.UseVisualStyleBackColor = false;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click_1);
            // 
            // bt_register
            // 
            this.bt_register.BackColor = System.Drawing.Color.Tomato;
            this.bt_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_register.Font = new System.Drawing.Font("UTM Akashi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_register.ForeColor = System.Drawing.Color.Transparent;
            this.bt_register.Location = new System.Drawing.Point(498, 405);
            this.bt_register.Name = "bt_register";
            this.bt_register.Size = new System.Drawing.Size(120, 41);
            this.bt_register.TabIndex = 55;
            this.bt_register.Text = "REGISTER";
            this.bt_register.UseVisualStyleBackColor = false;
            this.bt_register.Click += new System.EventHandler(this.bt_register_Click);
            // 
            // radio_bookStaker
            // 
            this.radio_bookStaker.AutoSize = true;
            this.radio_bookStaker.BackColor = System.Drawing.Color.Transparent;
            this.radio_bookStaker.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_bookStaker.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radio_bookStaker.Location = new System.Drawing.Point(687, 272);
            this.radio_bookStaker.Name = "radio_bookStaker";
            this.radio_bookStaker.Size = new System.Drawing.Size(117, 23);
            this.radio_bookStaker.TabIndex = 79;
            this.radio_bookStaker.TabStop = true;
            this.radio_bookStaker.Text = "Book stacker";
            this.radio_bookStaker.UseVisualStyleBackColor = false;
            // 
            // radioButton_staff
            // 
            this.radioButton_staff.AutoSize = true;
            this.radioButton_staff.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_staff.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_staff.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton_staff.Location = new System.Drawing.Point(572, 272);
            this.radioButton_staff.Name = "radioButton_staff";
            this.radioButton_staff.Size = new System.Drawing.Size(111, 23);
            this.radioButton_staff.TabIndex = 78;
            this.radioButton_staff.TabStop = true;
            this.radioButton_staff.Text = "Library staff";
            this.radioButton_staff.UseVisualStyleBackColor = false;
            // 
            // radioButton_Manager
            // 
            this.radioButton_Manager.AutoSize = true;
            this.radioButton_Manager.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_Manager.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Manager.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton_Manager.Location = new System.Drawing.Point(479, 272);
            this.radioButton_Manager.Name = "radioButton_Manager";
            this.radioButton_Manager.Size = new System.Drawing.Size(89, 23);
            this.radioButton_Manager.TabIndex = 77;
            this.radioButton_Manager.TabStop = true;
            this.radioButton_Manager.Text = "Manager";
            this.radioButton_Manager.UseVisualStyleBackColor = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_WINFORM_QUẢN_LÝ_THƯ_VIỆN.Properties.Resources._1235_4x;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(841, 471);
            this.Controls.Add(this.radio_bookStaker);
            this.Controls.Add(this.radioButton_staff);
            this.Controls.Add(this.radioButton_Manager);
            this.Controls.Add(this.bt_register);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Passinvisible);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.Textbox_Username);
            this.Controls.Add(this.PassVisible);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.radioButton_Teacher);
            this.Controls.Add(this.radioButton_Student);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassVisible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Passinvisible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radioButton_Student;
        private System.Windows.Forms.RadioButton radioButton_Teacher;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox PassVisible;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox Textbox_Username;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox Passinvisible;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.Button bt_register;
        private System.Windows.Forms.RadioButton radio_bookStaker;
        private System.Windows.Forms.RadioButton radioButton_staff;
        private System.Windows.Forms.RadioButton radioButton_Manager;
    }
}

