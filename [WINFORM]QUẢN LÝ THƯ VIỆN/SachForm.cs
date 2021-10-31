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
using Word = Microsoft.Office.Interop.Word;
using System.Drawing.Printing;

namespace _WINFORM_QUẢN_LÝ_THƯ_VIỆN
{
    public partial class SachForm : Form
    {
        Bitmap bmp;
        public SachForm()
        {
            InitializeComponent();
        }
        SACH sach = new SACH();
        MY_DB mydb = new MY_DB();
        private void SachForm_Load(object sender, EventArgs e)
        {
            radioButton_theloai.Checked = true;
            DGV_sach.DefaultCellStyle.Font = new Font("Times New Roman", 12);
            DGV_sach.DataSource = sach.getDSSach();
            setform();

            combo_theloai.DataSource = sach.gettheloai();
            combo_theloai.DisplayMember = "theloai";
            combo_theloai.ValueMember = "id";
            combo_theloai.SelectedItem = null;

            combo_tacgia.DataSource = sach.gettacgia();
            combo_tacgia.DisplayMember = "tacgia_name";
            combo_tacgia.ValueMember = "tacgia_id";
            combo_tacgia.SelectedItem = null;

            combo_nxb.DataSource = sach.getnxb();
            combo_nxb.DisplayMember = "nxb_name";
            combo_nxb.ValueMember = "nxb_id";
            combo_nxb.SelectedItem = null;
            if (radioButton_theloai.Checked)
            {
                comboBox_phanloai.DataSource = sach.gettheloai();
                comboBox_phanloai.DisplayMember = "theloai";
                comboBox_phanloai.ValueMember = "id";
                comboBox_phanloai.SelectedItem = null;
            }




        }
        private void setform()
        {
            DGV_sach.RowTemplate.Height = 30;
            DGV_sach.AllowUserToAddRows = false;
            DGV_sach.Columns[0].HeaderText = "MÃ SÁCH";
            DGV_sach.Columns[0].Width = 60;

            DGV_sach.Columns[1].HeaderText = "TÊN SÁCH";
            DGV_sach.Columns[1].Width = 278;

            DGV_sach.Columns[2].HeaderText = "TL";
            DGV_sach.Columns[2].Width = 30;
            DGV_sach.Columns[3].HeaderText = "THỂ LOẠI";
            DGV_sach.Columns[3].Width = 150;

            DGV_sach.Columns[4].HeaderText = "TG";
            DGV_sach.Columns[4].Width = 30;
            DGV_sach.Columns[5].HeaderText = "TÁC GIẢ";
            DGV_sach.Columns[5].Width = 150;
            DGV_sach.Columns[6].HeaderText = "NXB";
            DGV_sach.Columns[6].Width = 35;
            DGV_sach.Columns[7].HeaderText = "NHÀ XUẤT BẢN";
            DGV_sach.Columns[7].Width = 170;
            DGV_sach.Columns[8].HeaderText = "NGÀY XUẤT BẢN";
            DGV_sach.Columns[8].Width = 120;
            DGV_sach.Columns[9].HeaderText = "TỔNG CỘNG";
            DGV_sach.Columns[9].Width = 98;
            DGV_sach.Columns[10].HeaderText = "CÒN LẠI";
            DGV_sach.Columns[10].Width = 95;
        }
        bool verif()
        {
            if ((textBox_sname.Text.Trim() == "")
                || (TextBox_IDsach.Text.Trim() == ""))
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
            //Textbox_Search.Enabled = true;
            comboBox_phanloai.Enabled = true;
            bt_xoa.Enabled = bt_edit.Enabled = bt_delete.Enabled = true;
            int cID = Convert.ToInt32(TextBox_IDsach.Text);
            string name = textBox_sname.Text;
            int theloaiID = Convert.ToInt32(combo_theloai.SelectedValue.ToString());
            int tacgiaID = Convert.ToInt32(combo_tacgia.SelectedValue.ToString());
            int nxbID = Convert.ToInt32(combo_nxb.SelectedValue.ToString());
            DateTime yxb = dateTimePicker1.Value.Date;
            int sl = Convert.ToInt32(tb_tong.Text);
            int con = Convert.ToInt32(tb_con.Text);
            if (verif())
            {
                if (!sach.CheckSach(Convert.ToInt32(TextBox_IDsach.Text)))
                {
                    if (sach.insertSach(cID, name, theloaiID, tacgiaID, nxbID, yxb, sl, con))
                    {
                        MessageBox.Show("Thêm thành công", "Thêm sách", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công", "Thêm sách", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("This ID Already Exists, Try Another One", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Thêm sách", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            DGV_sach.DataSource = sach.getDSSach();
            setform();
        }


       

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            DGV_sach.DataSource = sach.getDSSach();
            setform();
            
            int count = DGV_sach.Rows.Count;
            int m = 0;
            if (count == 0)
            {
                m = count + 1;
            }
            else
            {

                int sosanh = Convert.ToInt32(DGV_sach.Rows[count - 1].Cells[0].Value);
                m = sosanh + 1;
            }

            TextBox_IDsach.Text = ("" + m);
            TextBox_IDsach.Enabled = false;
            textBox_sname.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            combo_nxb.Text = "";
            combo_tacgia.Text = "";
            combo_theloai.Text = "";
            tb_con.Text = "";
            tb_tong.Text = "";
            //Textbox_Search.Enabled = false;
            comboBox_phanloai.Enabled = false;
            bt_xoa.Enabled = bt_edit.Enabled = bt_delete.Enabled = false;

        }

        private void comboBox_phanloai_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (radioButton_theloai.Checked)
            {
                DGV_sach.DataSource = getPhanloaiSachtl();
                setform();
            }
            if (radioButton_nxb.Checked)
            {
                DGV_sach.DataSource = getPhanloaiSachnxb();
                setform();
            }
            else if (radioButton_tg.Checked)
            {
                DGV_sach.DataSource = getPhanloaiSachtg();
                setform();
            }

        }
        public DataTable getPhanloaiSachtl()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.GetConnection;
            command.CommandText = ("SELECT sach.id, sach.name, sach.theloai,theloai.theloai, sach.tacgia_id, tacgia.tacgia_name, sach.nxb_id , nxb.nxb_name, sach.yxb, sach.sl, sach.con " +
                "FROM sach INNER JOIN theloai on sach.theloai = theloai.id INNER JOIN tacgia on sach.tacgia_id = tacgia.tacgia_id INNER JOIN nxb on sach.nxb_id = nxb.nxb_id WHERE theloai.id =" + comboBox_phanloai.SelectedValue);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getPhanloaiSachnxb()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.GetConnection;
            command.CommandText = ("SELECT sach.id, sach.name, sach.theloai,theloai.theloai, sach.tacgia_id, tacgia.tacgia_name, sach.nxb_id , nxb.nxb_name, sach.yxb, sach.sl, sach.con " +
                "FROM sach INNER JOIN theloai on sach.theloai = theloai.id INNER JOIN tacgia on sach.tacgia_id = tacgia.tacgia_id INNER JOIN nxb on sach.nxb_id = nxb.nxb_id WHERE nxb.nxb_id =" + comboBox_phanloai.SelectedValue);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getPhanloaiSachtg()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.GetConnection;
            command.CommandText = ("SELECT sach.id, sach.name, sach.theloai,theloai.theloai, sach.tacgia_id, tacgia.tacgia_name, sach.nxb_id , nxb.nxb_name, sach.yxb, sach.sl, sach.con " +
                "FROM sach INNER JOIN theloai on sach.theloai = theloai.id INNER JOIN tacgia on sach.tacgia_id = tacgia.tacgia_id INNER JOIN nxb on sach.nxb_id = nxb.nxb_id WHERE tacgia.tacgia_id =" + comboBox_phanloai.SelectedValue);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        private void radioButton_nxb_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_phanloai.DataSource = sach.getnxb();
            comboBox_phanloai.DisplayMember = "nxb_name";
            comboBox_phanloai.ValueMember = "nxb_id";
            comboBox_phanloai.SelectedItem = null;

        }

        private void radioButton_tg_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_phanloai.DataSource = sach.gettacgia();
            comboBox_phanloai.DisplayMember = "tacgia_name";
            comboBox_phanloai.ValueMember = "tacgia_id";
            comboBox_phanloai.SelectedItem = null;

        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            TextBox_IDsach.Enabled = false;
            int cID = Convert.ToInt32(TextBox_IDsach.Text);
            string name = textBox_sname.Text;
            int theloaiID = Convert.ToInt32(combo_theloai.SelectedValue.ToString());
            int tacgiaID = Convert.ToInt32(combo_tacgia.SelectedValue.ToString());
            int nxbID = Convert.ToInt32(combo_nxb.SelectedValue.ToString());
            DateTime yxb = dateTimePicker1.Value.Date;
            int sl = Convert.ToInt32(tb_tong.Text);
            int con = Convert.ToInt32(tb_con.Text);
            if ((MessageBox.Show("Bạn chắn chắn chỉnh sửa quyển sách này?", "Chỉnh sửa sách", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                if (verif())
                {
                    if (sach.updateSach(cID, name, theloaiID, tacgiaID, nxbID, yxb, sl, con))
                    {
                        MessageBox.Show("Chỉnh sửa thành công", "Chỉnh sửa sách", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Chỉnh sửa không thành công", "Chỉnh sửa sách", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Empty Fields", "Chỉnh sửa sách", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int sID = Convert.ToInt32(TextBox_IDsach.Text);
                if ((MessageBox.Show("Bạn chắn chắn xóa quyển sách này?", "Xóa sách", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (sach.deteleSach(sID))
                    {
                        MessageBox.Show("Sách này đã bị xóa", "Xóa sách", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TextBox_IDsach.Text = "";
                        textBox_sname.Text = "";
                        dateTimePicker1.Value = DateTime.Now;
                        combo_nxb.Text = "";
                        combo_tacgia.Text = "";
                        combo_theloai.Text = "";
                        tb_con.Text = "";
                        tb_tong.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Xóa sách không thành công", "Xóa sách", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch
            {
                MessageBox.Show("Please Enter A Valid ID", "Xóa sách", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DGV_sach_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            TextBox_IDsach.Text = DGV_sach.CurrentRow.Cells[0].Value.ToString();
            textBox_sname.Text = DGV_sach.CurrentRow.Cells[1].Value.ToString();
            DateTime date = (DateTime)DGV_sach.CurrentRow.Cells[8].Value;
            dateTimePicker1.Value = date;

            combo_theloai.SelectedValue = DGV_sach.CurrentRow.Cells[2].Value;
            combo_tacgia.SelectedValue = DGV_sach.CurrentRow.Cells[4].Value;
            combo_nxb.SelectedValue = DGV_sach.CurrentRow.Cells[6].Value;
            tb_tong.Text = DGV_sach.CurrentRow.Cells[9].Value.ToString();
            tb_con.Text = DGV_sach.CurrentRow.Cells[10].Value.ToString();
        }
        public void tinhsachconlai()
        {
            int count = Convert.ToInt32(DGV_sach.Rows[1].Cells[10].Value);
        }

        private void bt_print_Click(object sender, EventArgs e)
        {
            //dlg.ShowDialog(); //Hiển thị hộp thoại PrintDialog

            //cau hinh trang
            int height = DGV_sach.Height;
            DGV_sach.Height = DGV_sach.RowCount * DGV_sach.RowTemplate.Height * 2;

            //Chuyen datagridview ve file Bitmap de doc hinh anh
            bmp = new Bitmap(DGV_sach.Width, DGV_sach.Height);
            DGV_sach.DrawToBitmap(bmp, new Rectangle(0, 0, DGV_sach.Width, DGV_sach.Height));
            DGV_sach.Height = height;

            //chon ok thi in
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
            else
            {
                MessageBox.Show("Cancel printing!");
            }
        }
        public void Export_Data_To_Word(DataGridView DGV, string filename)
        {
            if (DGV.Rows.Count != 0)
            {
                int RowCount = DGV.Rows.Count;
                int ColumnCount = DGV.Columns.Count;
                Object[,] DataArray = new object[RowCount + 1, ColumnCount + 1];

                //add rows
                int r = 0;
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    for (r = 0; r <= RowCount - 1; r++)
                    {
                        DataArray[r, c] = DGV.Rows[r].Cells[c].Value;
                    }// end row loop
                }// end column loop

                Word.Document oDoc = new Word.Document();
                oDoc.Application.Visible = true;
                //page orintation
                oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;
                dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = "";
                for (r = 0; r <= RowCount - 1; r++)
                {
                    for (int c = 0; c <= ColumnCount - 1; c++)
                    {
                        oTemp = oTemp + DataArray[r, c] + "\t";
                    }
                }
                //table format
                oRange.Text = oTemp;

                object Separator = Word.WdTableFieldSeparator.wdSeparateByTabs;
                object ApplyBorders = true;
                object AutoFit = true;
                object AutoFitBehavior = Word.WdAutoFitBehavior.wdAutoFitContent;

                oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
                                      Type.Missing, Type.Missing, ref ApplyBorders,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);
                oRange.Select();

                oDoc.Application.Selection.Tables[1].Select();
                oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.InsertRowsAbove(1);
                oDoc.Application.Selection.Tables[1].Rows[1].Select();

                //header row style
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Times New Roman";
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 14;

                //add header row manually
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = DGV.Columns[c].HeaderText;
                }

                //table style
                oDoc.Application.Selection.Tables[1].set_Style("Grid Table 4 - Accent 5");
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                //header text
                foreach (Word.Section section in oDoc.Application.ActiveDocument.Sections)
                {
                    Word.Range headerRange = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Fields.Add(headerRange, Word.WdFieldType.wdFieldPage);
                    headerRange.Text = "THỐNG KÊ SÁCH CỦA TOÀN THƯ VIỆN";
                    headerRange.Font.Size = 16;
                    headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }

                //save the file
                oDoc.SaveAs(filename);
            }
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Word Document (*.docx)|*.docx";

            sfd.FileName = "THONGKESACH.docx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Export_Data_To_Word(DGV_sach, sfd.FileName);
            }
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
