
namespace _WINFORM_QUẢN_LÝ_THƯ_VIỆN
{
    partial class RegisterForm
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
            this.Panpass = new System.Windows.Forms.Panel();
            this.txtPassword1 = new System.Windows.Forms.TextBox();
            this.Textbox_reUsername = new System.Windows.Forms.TextBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.radioButton_Teacher = new System.Windows.Forms.RadioButton();
            this.radioButton_Student = new System.Windows.Forms.RadioButton();
            this.l1 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtRepassword = new System.Windows.Forms.TextBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.panID = new System.Windows.Forms.Panel();
            this.Panrepass = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.bt_add = new System.Windows.Forms.Button();
            this.l4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // Panpass
            // 
            this.Panpass.Location = new System.Drawing.Point(20, 221);
            this.Panpass.Name = "Panpass";
            this.Panpass.Size = new System.Drawing.Size(320, 2);
            this.Panpass.TabIndex = 41;
            // 
            // txtPassword1
            // 
            this.txtPassword1.BackColor = System.Drawing.Color.DarkCyan;
            this.txtPassword1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword1.ForeColor = System.Drawing.Color.Silver;
            this.txtPassword1.Location = new System.Drawing.Point(85, 186);
            this.txtPassword1.Multiline = true;
            this.txtPassword1.Name = "txtPassword1";
            this.txtPassword1.Size = new System.Drawing.Size(255, 29);
            this.txtPassword1.TabIndex = 39;
            this.txtPassword1.Click += new System.EventHandler(this.txtPassword1_Click);
            this.txtPassword1.Leave += new System.EventHandler(this.txtPassword1_Leave);
            // 
            // Textbox_reUsername
            // 
            this.Textbox_reUsername.BackColor = System.Drawing.Color.DarkCyan;
            this.Textbox_reUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Textbox_reUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_reUsername.ForeColor = System.Drawing.Color.DarkGray;
            this.Textbox_reUsername.Location = new System.Drawing.Point(85, 121);
            this.Textbox_reUsername.Multiline = true;
            this.Textbox_reUsername.Name = "Textbox_reUsername";
            this.Textbox_reUsername.Size = new System.Drawing.Size(255, 31);
            this.Textbox_reUsername.TabIndex = 38;
            this.Textbox_reUsername.Click += new System.EventHandler(this.Textbox_reUsername_Click);
            this.Textbox_reUsername.Leave += new System.EventHandler(this.Textbox_reUsername_Leave);
            // 
            // pb2
            // 
            this.pb2.BackColor = System.Drawing.Color.Transparent;
            this.pb2.BackgroundImage = global::_WINFORM_QUẢN_LÝ_THƯ_VIỆN.Properties.Resources.unlock_50px;
            this.pb2.Location = new System.Drawing.Point(21, 171);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(47, 46);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb2.TabIndex = 36;
            this.pb2.TabStop = false;
            // 
            // pb1
            // 
            this.pb1.BackColor = System.Drawing.Color.Transparent;
            this.pb1.BackgroundImage = global::_WINFORM_QUẢN_LÝ_THƯ_VIỆN.Properties.Resources.user_50px;
            this.pb1.Location = new System.Drawing.Point(23, 106);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(47, 46);
            this.pb1.TabIndex = 35;
            this.pb1.TabStop = false;
            // 
            // radioButton_Teacher
            // 
            this.radioButton_Teacher.AutoSize = true;
            this.radioButton_Teacher.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_Teacher.Font = new System.Drawing.Font("UTM Bitsumishi Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Teacher.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton_Teacher.Location = new System.Drawing.Point(219, 296);
            this.radioButton_Teacher.Name = "radioButton_Teacher";
            this.radioButton_Teacher.Size = new System.Drawing.Size(119, 28);
            this.radioButton_Teacher.TabIndex = 33;
            this.radioButton_Teacher.TabStop = true;
            this.radioButton_Teacher.Text = "Teacher";
            this.radioButton_Teacher.UseVisualStyleBackColor = false;
            // 
            // radioButton_Student
            // 
            this.radioButton_Student.AutoSize = true;
            this.radioButton_Student.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_Student.Font = new System.Drawing.Font("UTM Bitsumishi Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Student.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton_Student.Location = new System.Drawing.Point(31, 296);
            this.radioButton_Student.Name = "radioButton_Student";
            this.radioButton_Student.Size = new System.Drawing.Size(116, 28);
            this.radioButton_Student.TabIndex = 32;
            this.radioButton_Student.TabStop = true;
            this.radioButton_Student.Text = "Student";
            this.radioButton_Student.UseVisualStyleBackColor = false;
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.l1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l1.ForeColor = System.Drawing.Color.White;
            this.l1.Location = new System.Drawing.Point(82, 100);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(58, 18);
            this.l1.TabIndex = 43;
            this.l1.Text = "User ID";
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.l2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l2.ForeColor = System.Drawing.Color.White;
            this.l2.Location = new System.Drawing.Point(82, 165);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(75, 18);
            this.l2.TabIndex = 44;
            this.l2.Text = "Password";
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.l3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l3.ForeColor = System.Drawing.Color.White;
            this.l3.Location = new System.Drawing.Point(82, 226);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(124, 18);
            this.l3.TabIndex = 48;
            this.l3.Text = "Repeat password";
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(-8, 320);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(0, 0);
            this.panel3.TabIndex = 47;
            // 
            // txtRepassword
            // 
            this.txtRepassword.BackColor = System.Drawing.Color.DarkCyan;
            this.txtRepassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRepassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepassword.ForeColor = System.Drawing.Color.Silver;
            this.txtRepassword.Location = new System.Drawing.Point(85, 247);
            this.txtRepassword.Multiline = true;
            this.txtRepassword.Name = "txtRepassword";
            this.txtRepassword.Size = new System.Drawing.Size(255, 29);
            this.txtRepassword.TabIndex = 46;
            this.txtRepassword.Click += new System.EventHandler(this.txtRepassword_Click);
            this.txtRepassword.Leave += new System.EventHandler(this.txtRepassword_Leave);
            // 
            // pb3
            // 
            this.pb3.BackColor = System.Drawing.Color.Transparent;
            this.pb3.BackgroundImage = global::_WINFORM_QUẢN_LÝ_THƯ_VIỆN.Properties.Resources.key_2_50px;
            this.pb3.Location = new System.Drawing.Point(21, 232);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(47, 46);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb3.TabIndex = 45;
            this.pb3.TabStop = false;
            // 
            // panID
            // 
            this.panID.Location = new System.Drawing.Point(20, 158);
            this.panID.Name = "panID";
            this.panID.Size = new System.Drawing.Size(320, 2);
            this.panID.TabIndex = 42;
            // 
            // Panrepass
            // 
            this.Panrepass.Location = new System.Drawing.Point(21, 284);
            this.Panrepass.Name = "Panrepass";
            this.Panrepass.Size = new System.Drawing.Size(320, 2);
            this.Panrepass.TabIndex = 42;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Maroon;
            this.pictureBox4.BackgroundImage = global::_WINFORM_QUẢN_LÝ_THƯ_VIỆN.Properties.Resources.delete_208px;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(344, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.TabIndex = 49;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // bt_add
            // 
            this.bt_add.BackColor = System.Drawing.Color.Tomato;
            this.bt_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_add.Font = new System.Drawing.Font("UTM Akashi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_add.ForeColor = System.Drawing.Color.Transparent;
            this.bt_add.Location = new System.Drawing.Point(124, 333);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(120, 41);
            this.bt_add.TabIndex = 56;
            this.bt_add.Text = "REGISTER";
            this.bt_add.UseVisualStyleBackColor = false;
            this.bt_add.Click += new System.EventHandler(this.bt_register_Click);
            // 
            // l4
            // 
            this.l4.AutoSize = true;
            this.l4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.l4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l4.ForeColor = System.Drawing.Color.White;
            this.l4.Location = new System.Drawing.Point(3, 419);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(175, 16);
            this.l4.TabIndex = 57;
            this.l4.Text = "<< Have an account? Log in ";
            this.l4.Click += new System.EventHandler(this.label4_Click);
            this.l4.MouseLeave += new System.EventHandler(this.l4_MouseLeave);
            this.l4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.l4_MouseMove);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_WINFORM_QUẢN_LÝ_THƯ_VIỆN.Properties.Resources.REGISTER_4x;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(374, 450);
            this.Controls.Add(this.l4);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.Panrepass);
            this.Controls.Add(this.panID);
            this.Controls.Add(this.l3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtRepassword);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.Panpass);
            this.Controls.Add(this.txtPassword1);
            this.Controls.Add(this.Textbox_reUsername);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.radioButton_Teacher);
            this.Controls.Add(this.radioButton_Student);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel Panpass;
        private System.Windows.Forms.TextBox txtPassword1;
        private System.Windows.Forms.TextBox Textbox_reUsername;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.RadioButton radioButton_Teacher;
        private System.Windows.Forms.RadioButton radioButton_Student;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtRepassword;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.Panel panID;
        private System.Windows.Forms.Panel Panrepass;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Label l4;
    }
}