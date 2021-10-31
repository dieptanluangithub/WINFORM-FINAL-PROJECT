using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace _WINFORM_QUẢN_LÝ_THƯ_VIỆN
{
    public partial class BookStackerForm : Form
    {
        public BookStackerForm()
        {
            InitializeComponent();
        }
        MY_DB mydb = new MY_DB();
        NHANVIEN nv = new NHANVIEN();
        private void BookStackerForm_Load(object sender, EventArgs e)
        {
            

            SqlCommand command = new SqlCommand("SELECT * FROM nhanvien WHERE nhanvien.id_nv = @usn", mydb.GetConnection);
            command.Parameters.Add("@usn", SqlDbType.Int).Value = Program.username;
            DataTable dt = getContact(command);
            DataRow meo = dt.Rows[0];

            Combo_congviec.DataSource = nv.getCongviec();
            Combo_congviec.DisplayMember = "congviec_name";
            Combo_congviec.ValueMember = "congviec_id";
            Combo_congviec.SelectedItem = null;
        }
        public DataTable getContact(SqlCommand command)
        {
            command.Connection = mydb.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        private void tcCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            Combo_congviec.DataSource = nv.getCongviec();
            Combo_congviec.DisplayMember = "congviec_name";
            Combo_congviec.ValueMember = "congviec_id";
            Combo_congviec.SelectedItem = null;
            if (tcCustomer.SelectedIndex == 1)
            {
                // load info to textboxes
                STUDENT std = new STUDENT();

                SqlCommand command = new SqlCommand("SELECT * FROM nhanvien WHERE nhanvien.id_nv = @usn", mydb.GetConnection);


                command.Parameters.Add("@usn", SqlDbType.Int).Value = Program.username;
                DataTable dt = std.getContact(command);
                DataRow meo = dt.Rows[0];
                Textbox_ID.Enabled = false;
                Textbox_ID.Text = meo.ItemArray[0].ToString();
                Textbox_Fname.Text = meo.ItemArray[1].ToString();
                Textbox_Lname.Text = meo.ItemArray[2].ToString();
                DateTime date = Convert.ToDateTime(meo.ItemArray[3].ToString());
                dateTimePicker1.Value = date;

                string sex = meo.ItemArray[4].ToString().Trim();
                if (sex == "Female")
                {
                    Radiobt_Female.Checked = true;
                }

                if (sex == "Male")
                {
                    Radiobt_Male.Checked = true;
                }
                Textbox_Address.Text = meo.ItemArray[6].ToString();
                Textbox_Phone.Text = meo.ItemArray[7].ToString();
                Textbox_Email.Text = meo.ItemArray[8].ToString();
                Combo_congviec.SelectedValue = meo.ItemArray[5].ToString();
                byte[] pic;
                pic = (byte[])meo.ItemArray[9];
                MemoryStream picture = new MemoryStream(pic);
                PictureboxStudentImage.Image = Image.FromStream(picture);
                Textbox_reUsername.Text = meo.ItemArray[0].ToString();

            }
        }

        private void bt_update_Click(object sender, EventArgs e)
        {

        }
        USER user = new USER();
        private void button1_Click(object sender, EventArgs e)
        {
            string username = Textbox_reUsername.Text;
            string password = txtPassword1.Text;
            string newpass = Textbox_newpass.Text;
            string cfim = Textbox_confirmnew.Text;
            string quyen = "Book stacker";

            if (user.CheckIDUserThemmoi(Textbox_reUsername.Text, txtPassword1.Text))
            {
                if (newpass != cfim)
                {
                    MessageBox.Show("Nhắc lại mật khẩu không trùng khớp", "Đổi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    if (newpass != password)
                    {
                        if (verif())
                        {
                            if (user.updateAccount(username, newpass, quyen))
                            {
                                MessageBox.Show("Đổi mật khẩu thành công", "Đổi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Đổi mật khẩu thất bại", "Đổi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Empty Fields", "Đổi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu mới phải khác mật khẩu cũ", "Đổi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else
            {
                MessageBox.Show("Mật khẩu cũ không đúng", "Đổi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




            bool verif()
            {
                if ((Textbox_reUsername.Text.Trim() == "")
                    || (txtPassword1.Text.Trim() == "")
                    || (Textbox_confirmnew.Text.Trim() == "")
                    || (Textbox_newpass.Text.Trim() == ""))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Bạn muốn đăng xuất", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                this.Visible = false;
                Close();
                this.Visible = true;
            }
        }
    }
}
