using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _WINFORM_QUẢN_LÝ_THƯ_VIỆN
{
    public partial class RegisterFormNV : Form
    {
        public RegisterFormNV()
        {
            InitializeComponent();
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            USER user = new USER();
            string username = Textbox_reUsername1.Text;
            string password = txtPassword2.Text;
            string repass = txtRepassword1.Text;
            string quyen = "Manager";
            if (radioButton_Manager.Checked)
            {
                quyen = "Manager";
            }    
            if (radioButton_staff.Checked)
            {
                quyen = "Library staff";
            }
            if (radio_bookStaker.Checked)
            {
                quyen = "Book stacker";
            }    
            if (password != repass)
            {
                MessageBox.Show("Your password and confirmation password do not match", "Add Account", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (user.CheckIDUser(Textbox_reUsername1.Text))
            {
                MessageBox.Show("User ID Already Exist", "Tạo tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verif())
            {
                if (user.insertAccount(username, password, quyen))
                {
                    MessageBox.Show("Thêm tài khoản nhân viên thành công", "Tạo tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Error", "Tạo tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Tạo tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            bool verif()
            {
                if ((Textbox_reUsername1.Text.Trim() == "")
                    || (txtPassword2.Text.Trim() == "")
                    || (txtRepassword1.Text.Trim() == ""))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        private void resetColor()
        {
            Textbox_reUsername1.ForeColor = Color.White;
            txtPassword2.ForeColor = Color.White;
            txtRepassword1.ForeColor = Color.White;

            pb1.BackgroundImage = Properties.Resources.user_50px;
            pb2.BackgroundImage = Properties.Resources.unlock_50px;
            pb3.BackgroundImage = Properties.Resources.key_c_50px;

            panID.BackColor = Panpass.BackColor = Panrepass.BackColor = Color.White;
        }

        private void Textbox_reUsername1_Click(object sender, EventArgs e)
        {
            resetColor();
            Textbox_reUsername1.ForeColor = Color.FromArgb(255, 193, 7);
            l1.ForeColor = Color.FromArgb(255, 193, 7);
            pb1.BackgroundImage = Properties.Resources.user_c_2_50px;
            panID.BackColor = Color.FromArgb(255, 193, 7);
            pb3.BackgroundImage = Properties.Resources.key_2_50px;
            Panpass.BackColor = Color.White;
            Panrepass.BackColor = Color.White;
        }

        private void txtPassword2_Click(object sender, EventArgs e)
        {
            resetColor();
            txtPassword2.ForeColor = Color.FromArgb(255, 193, 7);
            l2.ForeColor = Color.FromArgb(255, 193, 7);
            pb2.BackgroundImage = Properties.Resources.unlock_c_50px;
            Panpass.BackColor = Color.FromArgb(255, 193, 7);
            pb3.BackgroundImage = Properties.Resources.key_2_50px;
            panID.BackColor = Color.White;
            Panrepass.BackColor = Color.White;
            txtPassword2.PasswordChar = '✽';
        }

        private void txtRepassword1_Click(object sender, EventArgs e)
        {
            resetColor();
            txtRepassword1.ForeColor = Color.FromArgb(255, 193, 7);
            l3.ForeColor = Color.FromArgb(255, 193, 7);
            pb3.BackgroundImage = Properties.Resources.key_c_50px;
            Panrepass.BackColor = Color.FromArgb(255, 193, 7);
            panID.BackColor = Color.White;
            Panpass.BackColor = Color.White;
            txtRepassword1.PasswordChar = '✽';
        }

        private void Textbox_reUsername1_Leave(object sender, EventArgs e)
        {
            l1.ForeColor = Color.White;
        }

        private void txtPassword2_Leave(object sender, EventArgs e)
        {
            l2.ForeColor = Color.White;
        }

        private void txtRepassword1_Leave(object sender, EventArgs e)
        {
            l3.ForeColor = Color.White;
        }
    }
}
