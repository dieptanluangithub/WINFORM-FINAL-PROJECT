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
    public partial class TacgiaForm : Form
    {
        TACGIA tacgia = new TACGIA();
        MY_DB mydb = new MY_DB();
        public TacgiaForm()
        {
            InitializeComponent();
        }
        bool verif()
        {
            if ((Textbox_ID.Text.Trim() == "")
                || (Textbox_name.Text.Trim() == "")
                || (Textbox_que.Text.Trim() == ""))
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
            bt_delete.Enabled = true;
            bt_edit.Enabled = true;
            bt_search.Enabled = true;
            bt_them.Enabled = true;
            int cID = Convert.ToInt32(Textbox_ID.Text);
            string name = Textbox_name.Text;
            string que = Textbox_que.Text;
            DateTime BDate = dateTimePicker1.Value.Date;
            if (verif())
            {
                if (!tacgia.CheckTacgia(Convert.ToInt32(Textbox_ID.Text)))
                {
                    if (tacgia.inserttacgia(cID, name, BDate, que))
                    {
                        MessageBox.Show("Thêm thành công", "Thêm tác giả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công", "Thêm tác giả", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("This ID Already Exists, Try Another One", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Thêm tác giả", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }


        }
        
        private void TacgiaForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTVDataSet3.tacgia' table. You can move, or remove it, as needed.
            this.tacgiaTableAdapter.Fill(this.qLTVDataSet3.tacgia);

            DGV_tacgia.DefaultCellStyle.Font = new Font("Times New Roman", 10);
            SqlCommand command = new SqlCommand("SELECT * FROM tacgia ORDER BY tacgia_id ASC");
            fillgrid(command);

            DGV_tacgia.Sort(DGV_tacgia.Columns[0], ListSortDirection.Ascending);


        }
        public void fillgrid(SqlCommand command)
        {
            DGV_tacgia.ReadOnly = true;
            DGV_tacgia.RowTemplate.Height = 30;
            DGV_tacgia.DataSource = tacgia.getTacgia(command);
            DGV_tacgia.AllowUserToAddRows = false;

        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM tacgia");
            fillgrid(command);
        }

        private void DGV_tacgia_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Textbox_ID.Text = DGV_tacgia.CurrentRow.Cells[0].Value.ToString();
            Textbox_name.Text = DGV_tacgia.CurrentRow.Cells[1].Value.ToString();
            Textbox_que.Text = DGV_tacgia.CurrentRow.Cells[2].Value.ToString();
            DateTime date = (DateTime)DGV_tacgia.CurrentRow.Cells[3].Value;
            dateTimePicker1.Value = date;
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM tacgia WHERE CONCAT(tacgia_id,tacgia_name,address,Bdate) LIKE'%" + Textbox_Search.Text+ "%'");
            fillgrid(command);
        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            int cID = Convert.ToInt32(Textbox_ID.Text);
            string name = Textbox_name.Text;
            string que = Textbox_que.Text;
            DateTime BDate = dateTimePicker1.Value.Date;
            if (verif())
            {
                if (tacgia.updateTacgia(cID, name, BDate, que))
                {
                    MessageBox.Show("Chỉnh sửa thành công", "Chỉnh sửa tác giả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Chỉnh sửa không thành công", "Chỉnh sửa tác giả", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields, Try Another One", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        
           
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int idtacgia = Convert.ToInt32(Textbox_ID.Text);
                if ((MessageBox.Show("Bạn chắc chắn xóa tác giả", "Xóa tác giả", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (tacgia.deteleTacgia(idtacgia))
                    {
                        MessageBox.Show("Đã xóa tác giả", "Xóa tác giả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Textbox_ID.Text = "";
                        Textbox_name.Text = "";
                        Textbox_que.Text = "";
                        Textbox_Search.Text = "";
                        dateTimePicker1.Value = DateTime.Now;
                    }
                    else
                    {
                        MessageBox.Show("Tác giả không thể xóa", "Xóa tác giả", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch
            {
                MessageBox.Show("Please Enter A Valid ID", "Xóa tác giả", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM tacgia");
            fillgrid(command);
            int count = DGV_tacgia.Rows.Count;
            int m = count +1;
            Textbox_ID.Text = ("" + m);
            Textbox_ID.Enabled = false;
            Textbox_name.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            Textbox_que.Text = "";
            Textbox_Search.Text = "";
            bt_delete.Enabled = false;
            bt_edit.Enabled = false;
            bt_search.Enabled = false;
            bt_them.Enabled = false;
        }

        private void DGV_tacgia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Textbox_ID.Text = DGV_tacgia.CurrentRow.Cells[0].Value.ToString();
            Textbox_name.Text = DGV_tacgia.CurrentRow.Cells[1].Value.ToString();
            Textbox_que.Text = DGV_tacgia.CurrentRow.Cells[2].Value.ToString();
            DateTime date = (DateTime)DGV_tacgia.CurrentRow.Cells[3].Value;
            dateTimePicker1.Value = date;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Textbox_ID.Text = "";
            Textbox_ID.Enabled = true;
            Textbox_name.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            Textbox_que.Text = "";
            Textbox_Search.Text = "";
            bt_delete.Enabled = true;
            bt_edit.Enabled = true;
            bt_search.Enabled = true;
            bt_them.Enabled = true;
        }
    }
}
