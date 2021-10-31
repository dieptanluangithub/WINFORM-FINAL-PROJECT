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
    public partial class ChomuonForm : Form
    {
        CHOMUON cm = new CHOMUON();
        public ChomuonForm()
        {
            InitializeComponent();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            int count = DGV_chomuon.Rows.Count;
            int m = 0;
            if (count == 0)
            {
                m = count + 1;
            }
            else
            {

                int sosanh = Convert.ToInt32(DGV_chomuon.Rows[count - 1].Cells[0].Value);
                m = sosanh + 1;
            }
            Tb_teaid.Text = "";
            TextBox_IDsach.Text = ("" + m);
            TextBox_IDsach.Enabled = false;
            bt_them.Enabled = bt_delete.Enabled = bt_edit.Enabled = false;
            tb_nxb.Text = tb_sl.Text = tb_tacgia.Text = textBox_sname.Text = tb_theloai.Text = tb_theloai.Text = "";
            data_cm.Value =date_xb.Value= DateTime.Now;
        }
        bool verif()
        {
            if ((tb_nxb.Text.Trim() == "")
                || (tb_sl.Text.Trim() == "")
                || (tb_tacgia.Text.Trim() == "")
                || (textBox_sname.Text.Trim() =="")
                || (tb_theloai.Text.Trim() == "")
                || (tb_theloai.Text.Trim() == ""))
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
            bt_them.Enabled = bt_delete.Enabled = bt_edit.Enabled = true;
            int muon_id = Convert.ToInt32(Tb_teaid.Text);
            string sma = TextBox_IDsach.Text;
            string sname= textBox_sname.Text;
            string tl = tb_theloai.Text;
            string nxb = tb_nxb.Text;
            int sl = Convert.ToInt32(tb_sl.Text);
            string tg = tb_tacgia.Text;
            DateTime dcm = data_cm.Value.Date;
            DateTime dxb = date_xb.Value.Date;
            if (verif())
            {
                if (cm.CheckGiangvien(Convert.ToInt32(Tb_teaid.Text)))
                {
                    if (cm.insertChoMuonSach(muon_id, sma, sname, tl, tg, nxb, dxb, dcm, sl))
                    {
                        MessageBox.Show("Thêm thành công", "Cho thư viện mượn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công", "Cho thư viện mượn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("This ID Already Exists, Try Another One", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Cho thư viện mượn", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void ChomuonForm_Load(object sender, EventArgs e)
        {
            DGV_chomuon.DataSource = cm.getchomuonsach();
            Setform();
        }
        private void Setform()
        {
            DGV_chomuon.DefaultCellStyle.Font = new Font("Times New Roman", 12);
            DGV_chomuon.RowTemplate.Height = 30;
            DGV_chomuon.AllowUserToAddRows = false;
            DGV_chomuon.Columns[0].HeaderText = "ID";
            DGV_chomuon.Columns[0].Width = 100;
            DGV_chomuon.Columns[1].HeaderText = "TÊN SÁCH";
            DGV_chomuon.Columns[1].Width = 230;
            DGV_chomuon.Columns[2].HeaderText = "THỂ LOẠI";
            DGV_chomuon.Columns[2].Width = 100;


            DGV_chomuon.Columns[3].HeaderText = "TÁC GIẢ";
            DGV_chomuon.Columns[3].Width = 140;


            DGV_chomuon.Columns[4].HeaderText = "NXB";
            DGV_chomuon.Columns[4].Width = 160;

            DGV_chomuon.Columns[5].HeaderText = "NĂM XUẤT BẢN";
            DGV_chomuon.Columns[5].Width = 130;
            DGV_chomuon.Columns[6].HeaderText = "GIẢNG VIÊN CHO MƯỢN";
            DGV_chomuon.Columns[6].Width = 160;


            DGV_chomuon.Columns[8].HeaderText = "SỐ LƯỢNG";
            DGV_chomuon.Columns[8].Width = 90;
            DGV_chomuon.Columns[7].HeaderText = "NGÀY CHO MƯỢN";
            DGV_chomuon.Columns[7].Width = 140;
            
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            bt_them.Enabled = bt_delete.Enabled = bt_edit.Enabled = true;
            DGV_chomuon.DataSource = cm.getchomuonsach();
            Tb_teaid.Text = "";
            Setform();
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {

        }

        private void bt_edit_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            bt_them.Enabled = bt_delete.Enabled = bt_edit.Enabled = true;
            Tb_teaid.Text = "";
        }

        private void DGV_chomuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Tb_teaid.Text = DGV_chomuon.CurrentRow.Cells[6].Value.ToString();
            TextBox_IDsach.Text = DGV_chomuon.CurrentRow.Cells[0].Value.ToString();
            TextBox_IDsach.Enabled = false;
            textBox_sname.Text = DGV_chomuon.CurrentRow.Cells[1].Value.ToString();

            tb_nxb.Text = DGV_chomuon.CurrentRow.Cells[4].Value.ToString();
            tb_theloai.Text = DGV_chomuon.CurrentRow.Cells[2].Value.ToString();
            tb_tacgia.Text = DGV_chomuon.CurrentRow.Cells[3].Value.ToString();

            
            tb_sl.Text = DGV_chomuon.CurrentRow.Cells[8].Value.ToString();


            DateTime date = (DateTime)DGV_chomuon.CurrentRow.Cells[7].Value;
            data_cm.Value = date;
            DateTime date1 = (DateTime)DGV_chomuon.CurrentRow.Cells[5].Value;
            date_xb.Value = date1;
        }
    }
}
