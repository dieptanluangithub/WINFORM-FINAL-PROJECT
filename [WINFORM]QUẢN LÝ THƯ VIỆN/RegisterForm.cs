using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _WINFORM_QUẢN_LÝ_THƯ_VIỆN
{
    public partial class RegisterForm : Form
    {
        
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_register_Click(object sender, EventArgs e)
        {
            USER user = new USER();
            string username = Textbox_reUsername.Text;
            string password = txtPassword1.Text;
            string repass = txtRepassword.Text;
            string quyen = "Student";
            if (radioButton_Teacher.Checked)
            {
                quyen = "Teacher";
            }
            if (password != repass)
            {
                MessageBox.Show("Your password and confirmation password do not match", "Add Account", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (user.CheckIDUser(Textbox_reUsername.Text))
            {
                MessageBox.Show("User ID Already Exist", "Add Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
            else if (verif())
            {
                if (user.insertAccount(username, password, quyen))
                {
                    MessageBox.Show("Add New account Successfully", "Add Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if(radioButton_Student.Checked)
                    {
                        AddStudentForm add = new AddStudentForm();
                        add.ShowDialog();
                    }
                    else if (radioButton_Teacher.Checked)
                    {
                        AddTeacherForm tea = new AddTeacherForm();
                        tea.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Chưa có gì luôn", "Add Account", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                }
                else
                {
                    MessageBox.Show("Error", "Add Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Add Account", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            bool verif()
            { 
                if ((Textbox_reUsername.Text.Trim() == "")
                    || (txtPassword1.Text.Trim() == "")
                    || (txtRepassword.Text.Trim() == ""))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void resetColor()
        {
            Textbox_reUsername.ForeColor = Color.White;
            txtPassword1.ForeColor = Color.White;
            txtRepassword.ForeColor = Color.White;

            pb1.BackgroundImage = Properties.Resources.user_50px;
            pb2.BackgroundImage = Properties.Resources.unlock_50px;
            pb3.BackgroundImage = Properties.Resources.key_c_50px;

            panID.BackColor = Panpass.BackColor = Panrepass.BackColor = Color.White;
        }

        private void Textbox_reUsername_Click(object sender, EventArgs e)
        {
            resetColor();
            Textbox_reUsername.ForeColor = Color.FromArgb(255, 193, 7);
            l1.ForeColor = Color.FromArgb(255, 193, 7);
            pb1.BackgroundImage = Properties.Resources.user_c_2_50px;
            panID.BackColor = Color.FromArgb(255, 193, 7);
            pb3.BackgroundImage = Properties.Resources.key_2_50px;
            Panpass.BackColor = Color.White;
            Panrepass.BackColor = Color.White;
            
        }

        private void txtPassword1_Click(object sender, EventArgs e)
        {
            resetColor();
            txtPassword1.ForeColor = Color.FromArgb(255, 193, 7);
            l2.ForeColor = Color.FromArgb(255, 193, 7);
            pb2.BackgroundImage = Properties.Resources.unlock_c_50px;
            Panpass.BackColor = Color.FromArgb(255, 193, 7);
            pb3.BackgroundImage = Properties.Resources.key_2_50px;
            panID.BackColor = Color.White;
            Panrepass.BackColor = Color.White;
            txtPassword1.PasswordChar = '✽';
        }

        private void txtRepassword_Click(object sender, EventArgs e)
        {
            resetColor();
            txtRepassword.ForeColor = Color.FromArgb(255, 193, 7);
            l3.ForeColor = Color.FromArgb(255, 193, 7);
            pb3.BackgroundImage = Properties.Resources.key_c_50px;
            Panrepass.BackColor = Color.FromArgb(255, 193, 7);
            panID.BackColor = Color.White;
            Panpass.BackColor = Color.White;
            txtRepassword.PasswordChar = '✽';
        }

        private void l4_MouseLeave(object sender, EventArgs e)
        {
            l4.ForeColor = Color.FromArgb(255, 193, 7);
        }

        private void l4_MouseMove(object sender, MouseEventArgs e)
        {
            l4.ForeColor = Color.White;
        }

        private void Textbox_reUsername_Leave(object sender, EventArgs e)
        {
            l1.ForeColor = Color.White;
        }

        private void txtPassword1_Leave(object sender, EventArgs e)
        {
            l2.ForeColor = Color.White;
        }

        private void txtRepassword_Leave(object sender, EventArgs e)
        {
            l3.ForeColor = Color.White;
        }

        
    }
}
