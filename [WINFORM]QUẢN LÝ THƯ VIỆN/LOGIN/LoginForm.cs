using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _WINFORM_QUẢN_LÝ_THƯ_VIỆN
{
    public partial class LoginForm : Form
    {
        MY_DB mydb = new MY_DB();
        public LoginForm()
        {
            InitializeComponent();
        }
        private void bt_login_Click_1(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();

            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable table = new DataTable();
            string quyen = "Student";
            if (radioButton_Teacher.Checked)
            {
                quyen = "Teacher";
            }
            else if (radioButton_Manager.Checked)
            {
                quyen = "Manager";
            }
            else if (radioButton_staff.Checked)
            {
                quyen = "Library staff";
            }
            else if (radio_bookStaker.Checked)
            {
                quyen = "Book stacker";
            }    

            SqlCommand command = new SqlCommand("SELECT * FROM dbo.ACCOUNT WHERE username = @User AND password = @Pass AND quyen = @Quyen", db.GetConnection);
            command.Parameters.Add("@User", SqlDbType.VarChar).Value = Textbox_Username.Text;
            command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = txtPassword.Text;
            command.Parameters.Add("@Quyen", SqlDbType.VarChar).Value = quyen;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if ((table.Rows.Count > 0))
            {
                Program.username = Textbox_Username.Text;
                if ( radioButton_Student.Checked)
                {
                    StudentMainForm std = new StudentMainForm();
                    this.Visible = false;
                    std.ShowDialog();
                    this.Visible = true;
                    
                }
                else if (radioButton_Teacher.Checked)
                {
                    TeacherMainForm teaf = new TeacherMainForm();
                    this.Visible = false;
                    teaf.ShowDialog();
                    this.Visible = true;

                }
                else if (radioButton_Manager.Checked)
                {
                    LibrarianMainForm lib = new LibrarianMainForm();
                    
                    this.Visible = false;
                    lib.ShowDialog();
                    this.Visible = true;

                }
                else if (radio_bookStaker.Checked)
                {
                    BookStackerForm boo = new BookStackerForm();
                    this.Visible = false;
                    boo.ShowDialog();
                    this.Visible = true;
                }    

                //MessageBox.Show("Ok, next time will be go to Main Menu of App", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // this.DialogResult = DialogResult.OK;
                
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        
        private void Textbox_Username_Enter(object sender, EventArgs e)
        {
            if (Textbox_Username.Text == "Library ID")
            {
                Textbox_Username.Text = "";
                Textbox_Username.ForeColor = Color.Black;
            }
        }

        private void Textbox_Username_Leave(object sender, EventArgs e)
        {
            if (Textbox_Username.Text == "")
            {
                Textbox_Username.Text = "Library ID";
                Textbox_Username.ForeColor = Color.Silver;
            }
        }

        private void Textbox_Username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(ConsoleKey.Enter))
            {
                bt_login_Click_1(sender, e);
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(ConsoleKey.Enter))
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
               
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
                
                txtPassword.ForeColor = Color.Silver;
            }
            
        }
        private void resetColor()
        {
            Textbox_Username.ForeColor = Color.White;
            txtPassword.ForeColor = Color.White;
            pictureBox2.BackgroundImage = Properties.Resources.user_50px;
            pictureBox3.BackgroundImage = Properties.Resources.unlock_50px;
            panel1.BackColor = panel2.BackColor = Color.White;
        }

        private void Textbox_Username_Click(object sender, EventArgs e)
        {
            resetColor();
            Textbox_Username.ForeColor = Color.FromArgb(255, 193, 7);

            pictureBox2.BackgroundImage = Properties.Resources.user_c_2_50px;
            panel1.BackColor = Color.FromArgb(255, 193, 7);
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            resetColor();
            txtPassword.ForeColor = Color.FromArgb(255, 193, 7);
            pictureBox3.BackgroundImage = Properties.Resources.unlock_c_50px;
            panel2.BackColor = Color.FromArgb(255, 193, 7);
            if (PassVisible.Visible == true && Passinvisible.Visible == true)
            {
                txtPassword.PasswordChar = '✽';
                PassVisible.Visible = false;
            }
        }

        private void PassVisible_Click(object sender, EventArgs e)
        {
            if (PassVisible.Visible == true)
            {
                PassVisible.Visible = false;
                Passinvisible.Visible = true;
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                PassVisible.Visible = true;
                Passinvisible.Visible = false;
                txtPassword.PasswordChar = '✽';
            }
        }

        private void Passinvisible_Click(object sender, EventArgs e)
        {
            if (Passinvisible.Visible == false)
            {
                PassVisible.Visible = false;
                Passinvisible.Visible = true;
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                PassVisible.Visible = true;
                Passinvisible.Visible = false;
                txtPassword.PasswordChar = '✽';
            }
        }

        private void Passinvisible_MouseLeave(object sender, EventArgs e)
        {
            PictureBox bt = (PictureBox)sender;
            bt.BackgroundImage = Properties.Resources.icons8_eye_30px_1;
        }

        private void Passinvisible_MouseMove(object sender, MouseEventArgs e)
        {
            PictureBox bt = (PictureBox)sender;
            bt.BackgroundImage = Properties.Resources.icons8_eye_30px;
        }

        private void PassVisible_MouseLeave(object sender, EventArgs e)
        {
            PictureBox bt = (PictureBox)sender;
            bt.BackgroundImage = Properties.Resources.icons8_invisible_30px_2;
        }

        private void PassVisible_MouseMove(object sender, MouseEventArgs e)
        {
            PictureBox bt = (PictureBox)sender;
            bt.BackgroundImage = Properties.Resources.icons8_invisible_30px_1;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_register_Click(object sender, EventArgs e)
        {
            RegisterForm reg = new RegisterForm();
            reg.ShowDialog();
            
        }
    }
}
