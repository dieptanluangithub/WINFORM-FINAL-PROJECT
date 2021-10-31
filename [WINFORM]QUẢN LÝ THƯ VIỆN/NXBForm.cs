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
using System.Data.SqlClient;
using System.Drawing.Imaging;

namespace _WINFORM_QUẢN_LÝ_THƯ_VIỆN
{
    public partial class NXBForm : Form
    {
        NXB nxb = new NXB();
        public NXBForm()
        {
            InitializeComponent();
        }
        bool verif()
        {
            if ((Textbox_ID.Text.Trim() == "")
                || (Textbox_name.Text.Trim() == "")
                || (Textbox_que.Text.Trim() == "")
                || (Textbox_email.Text.Trim()=="")
                || (Textbox_sdt.Text.Trim()== ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void bt_add_Click(object sender, EventArgs e)
        {
            bt_them.Enabled = true;
            bt_delete.Enabled = true;
            bt_edit.Enabled = true;
            bt_search.Enabled = true;
            int cID = Convert.ToInt32(Textbox_ID.Text);
            string name = Textbox_name.Text;
            string que = Textbox_que.Text;
            string phone = Textbox_sdt.Text;
            string email = Textbox_email.Text;
            if (verif())
            {
                if (!nxb.Checknxb(Convert.ToInt32(Textbox_ID.Text)))
                {
                    if (nxb.insertnxb(cID, name, que,phone, email))
                    {
                        MessageBox.Show("Thêm thành công", "Thêm NXB", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công", "Thêm NXB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("This ID Already Exists, Try Another One", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Add NXB", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void NXBForm_Load(object sender, EventArgs e)
        {
            DGV_NXB.DefaultCellStyle.Font = new Font("Times New Roman", 10);
            // TODO: This line of code loads data into the 'qLTVDataSet4.nxb' table. You can move, or remove it, as needed.
            this.nxbTableAdapter.Fill(this.qLTVDataSet4.nxb);
            // TODO: This line of code loads data into the 'qLTVDataSet1.nxb' table. You can move, or remove it, as needed.
            SqlCommand command = new SqlCommand("SELECT * FROM nxb");
            fillgrid(command);
        }
        public void fillgrid(SqlCommand command)
        {
            DGV_NXB.ReadOnly = true;
            DGV_NXB.RowTemplate.Height = 30;
            DGV_NXB.DataSource = nxb.getnxb(command);
            DGV_NXB.AllowUserToAddRows = false;

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM nxb");
            fillgrid(command);
        }

        private void DGV_NXB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Textbox_ID.Text = DGV_NXB.CurrentRow.Cells[0].Value.ToString();
            Textbox_name.Text = DGV_NXB.CurrentRow.Cells[1].Value.ToString();
            Textbox_que.Text = DGV_NXB.CurrentRow.Cells[2].Value.ToString();
            Textbox_sdt.Text = DGV_NXB.CurrentRow.Cells[3].Value.ToString();
            Textbox_email.Text = DGV_NXB.CurrentRow.Cells[4].Value.ToString();
            
        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            int cID = Convert.ToInt32(Textbox_ID.Text);
            string name = Textbox_name.Text;
            string que = Textbox_que.Text;
            string phone = Textbox_sdt.Text;
            string email = Textbox_email.Text;
            if (verif())
            {
                if (nxb.updatenxb(cID, name, que, phone, email))
                {
                    MessageBox.Show("Chỉnh sửa thành công", "Chỉnh sửa NXB", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Chỉnh sửa không thành công", "Chỉnh sửa NXB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("This ID Already Exists, Try Another One", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
            
        

        private void bt_search_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM nxb WHERE CONCAT(nxb_id,nxb_name,address,phone,email) LIKE'%" + Textbox_Search.Text + "%'");
            fillgrid(command);
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int idtacgia = Convert.ToInt32(Textbox_ID.Text);
                if ((MessageBox.Show("Bạn chắc chắn xóa NXB", "Xóa NXB", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (nxb.detelenxb(idtacgia))
                    {
                        MessageBox.Show("Đã xóa NXB", "Xóa NXB", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Textbox_ID.Text = "";
                        Textbox_name.Text = "";
                        Textbox_que.Text = "";
                        Textbox_email.Text = "";
                        Textbox_sdt.Text = "";
                        Textbox_Search.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Tác giả không thể xóa", "Xóa NXB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch
            {
                MessageBox.Show("Please Enter A Valid ID", "Xóa NXB", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM nxb");
            fillgrid(command);
            bt_them.Enabled = false;
            bt_delete.Enabled = false;
            bt_edit.Enabled = false;
            bt_search.Enabled = false;

            int count = DGV_NXB.Rows.Count;
            int m = count + 1;
            Textbox_ID.Text = ("" + m);
            Textbox_ID.Enabled = false;
            Textbox_name.Text = "";
            Textbox_que.Text = "";
            Textbox_sdt.Text = "";
            Textbox_email.Text = "";
            Textbox_Search.Text = "";
            Textbox_Search.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM nxb");
            fillgrid(command);
            Textbox_Search.Text = "";
            bt_them.Enabled = true;
            bt_delete.Enabled = true;
            bt_edit.Enabled = true;
            bt_search.Enabled = true;
            Textbox_ID.Text = "";
            Textbox_ID.Enabled = true;
            Textbox_name.Text = "";
            Textbox_que.Text = "";
            Textbox_sdt.Text = "";
            Textbox_email.Text = "";
            Textbox_Search.Text = "";
        }
    }
}
