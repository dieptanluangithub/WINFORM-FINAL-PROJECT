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
using System.Drawing.Printing;
using Word = Microsoft.Office.Interop.Word;

namespace _WINFORM_QUẢN_LÝ_THƯ_VIỆN
{
    public partial class DocgiaForm : Form
    {
        MY_DB mydb = new MY_DB();
        Bitmap bmp;
        public DocgiaForm()
        {
            InitializeComponent();
        }
        STUDENT std = new STUDENT();
        SACH sach = new SACH();
        TEACHER tea = new TEACHER();
        private void DocgiaForm_Load(object sender, EventArgs e)
        {
            DONVI dv = new DONVI();
            Combo_Donvi.DataSource = dv.getDonvi();
            Combo_Donvi.DisplayMember = "donvi_name";
            Combo_Donvi.ValueMember = "Id";
            Combo_Donvi.SelectedItem = null;

            comboBox_phanloai.DataSource = dv.getDonvi();
            comboBox_phanloai.DisplayMember = "donvi_name";
            comboBox_phanloai.ValueMember = "Id";
            comboBox_phanloai.SelectedItem = null;
            radioButton_std.Checked = true;

            if (radioButton_std.Checked)
            {
                DGV_Docgia.DefaultCellStyle.Font = new Font("Times New Roman", 12);
                SqlCommand command = new SqlCommand("SELECT std.id, std.fname, std.lname, std.bdate, std.gender," +
                    " std.donvi, donvi.donvi_name, std.address, std.phone, std.email, std.pic FROM std INNER JOIN donvi on std.donvi = donvi.Id");
                fillgrid(command);
            }


        }
        public void fillgrid(SqlCommand command)
        {
            DGV_Docgia.ReadOnly = true;
            DGV_Docgia.DataSource = std.getContact(command);
            DGV_Docgia.RowTemplate.Height = 50;

            DGV_Docgia.AllowUserToAddRows = false;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)DGV_Docgia.Columns[10];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            DGV_Docgia.AllowUserToAddRows = false;


            DGV_Docgia.Columns[0].HeaderText = "ID";
            DGV_Docgia.Columns[0].Width = 100;
            DGV_Docgia.Columns[1].HeaderText = "HỌ";
            DGV_Docgia.Columns[1].Width = 120;

            DGV_Docgia.Columns[2].HeaderText = "TÊN";
            DGV_Docgia.Columns[2].Width = 120;

            DGV_Docgia.Columns[3].HeaderText = "NGÀY SINH";
            DGV_Docgia.Columns[3].Width = 100;

            DGV_Docgia.Columns[4].HeaderText = "GIỚI TÍNH";
            DGV_Docgia.Columns[4].Width = 90;
            DGV_Docgia.Columns[5].HeaderText = "ID ĐV";
            DGV_Docgia.Columns[5].Width = 80;
            DGV_Docgia.Columns[6].HeaderText = "ĐƠN VỊ";
            DGV_Docgia.Columns[6].Width = 80;

            DGV_Docgia.Columns[7].HeaderText = "ĐỊA CHỈ";
            DGV_Docgia.Columns[7].Width = 150;
            DGV_Docgia.Columns[8].HeaderText = "SĐT";
            DGV_Docgia.Columns[8].Width = 120;
            DGV_Docgia.Columns[9].HeaderText = "EMAIL";
            DGV_Docgia.Columns[9].Width = 200;
            DGV_Docgia.Columns[10].HeaderText = "ẢNH";
            DGV_Docgia.Columns[10].Width = 50;
        }



        private void bt_them_Click(object sender, EventArgs e)
        {
            RegisterForm re = new RegisterForm();
            re.ShowDialog();
        }
        bool verif()
        {
            if ((Textbox_Fname.Text.Trim() == "")
                || (Textbox_Lname.Text.Trim() == "")
                || (Textbox_Phone.Text.Trim() == "")
                || (Textbox_Address.Text.Trim() == "")
                || (Textbox_Email.Text.Trim() == "")
                || (Textbox_ID.Text.Trim() == "")
                || (PictureboxStudentImage.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void bt_sua_Click(object sender, EventArgs e)
        {
            int cID = Convert.ToInt32(Textbox_ID.Text);
            string fname = Textbox_Fname.Text;
            string lname = Textbox_Lname.Text;
            DateTime BDate = dateTimePicker1.Value.Date;
            string Gender = "Male";
            if (Radiobt_Female.Checked)
            {
                Gender = "Female";
            }
            int donvi = Convert.ToInt32(Combo_Donvi.SelectedValue);
            string address = Textbox_Address.Text;
            string phone = Textbox_Phone.Text;

            string email = Textbox_Email.Text;
            MemoryStream pic = new MemoryStream();
            int born_year = dateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;
            PictureboxStudentImage.Image.Save(pic, PictureboxStudentImage.Image.RawFormat);
            if ((((this_year - born_year) < 15) || ((this_year - born_year) > 80)))
            {
                MessageBox.Show("The Student Age Must Be Between 15 and 30 year", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verif())
            {
                if (std.updateStudent(cID, fname, lname, BDate, Gender, donvi, address, phone, email, pic))
                {
                    MessageBox.Show("Chỉnh sửa thông tin thành công", "Chỉnh sửa thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Chỉnh sửa thông tin thất bại", "Chỉnh sửa thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Chỉnh sửa thông tin", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (radioButton_std.Checked)
            {
                xoathongtin();
                DGV_Docgia.DefaultCellStyle.Font = new Font("Times New Roman", 12);
                SqlCommand command = new SqlCommand("SELECT std.id, std.fname, std.lname, std.bdate, std.gender," +
                    " std.donvi, donvi.donvi_name, std.address, std.phone, std.email, std.pic FROM std INNER JOIN donvi on std.donvi = donvi.Id");
                fillgrid(command);
            }
            else
            {
                xoathongtin();
                DGV_Docgia.DefaultCellStyle.Font = new Font("Times New Roman", 12);
                SqlCommand command = new SqlCommand("SELECT teacher.id, teacher.fname, teacher.lname, teacher.bdate, teacher.gender," +
                    " teacher.donvi, donvi.donvi_name, teacher.address, teacher.phone, teacher.email, teacher.pic FROM teacher INNER JOIN donvi on teacher.donvi = donvi.Id");
                fillgrid(command);
            }

        }

        private void radioButton_std_CheckedChanged(object sender, EventArgs e)
        {
            xoathongtin();
            DGV_Docgia.DefaultCellStyle.Font = new Font("Times New Roman", 12);
            SqlCommand command = new SqlCommand("SELECT std.id, std.fname, std.lname, std.bdate, std.gender," +
                " std.donvi, donvi.donvi_name, std.address, std.phone, std.email, std.pic FROM std INNER JOIN donvi on std.donvi = donvi.Id");
            fillgrid(command);
        }

        private void radioButton_tea_CheckedChanged(object sender, EventArgs e)
        {
            xoathongtin();
            DGV_Docgia.DefaultCellStyle.Font = new Font("Times New Roman", 12);
            SqlCommand command = new SqlCommand("SELECT teacher.id, teacher.fname, teacher.lname, teacher.bdate, teacher.gender," +
                " teacher.donvi, donvi.donvi_name, teacher.address, teacher.phone, teacher.email, teacher.pic FROM teacher INNER JOIN donvi on teacher.donvi = donvi.Id");
            fillgrid(command);
        }
        private void xoathongtin()
        {
            Combo_Donvi.Text = "";
            Textbox_Fname.Text = "";
            Textbox_Lname.Text = "";
            Textbox_Phone.Text = "";
            Textbox_Address.Text = "";
            Textbox_Email.Text = "";
            Textbox_ID.Text = "";
            PictureboxStudentImage.Image = null;
            dateTimePicker1.Value = DateTime.Now;
            comboBox_phanloai.Text = "";
        }


        private void comboBox_phanloai_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (radioButton_std.Checked)
            {

                DGV_Docgia.DataSource = getPhanloaitheoDVstd();
                chinhform();
            }
            if (radioButton_tea.Checked)
            {

                DGV_Docgia.DataSource = getPhanloaitheoDV();
                chinhform();
            }

        }

        private void DGV_Docgia_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Textbox_ID.Enabled = false;
            Textbox_ID.Text = DGV_Docgia.CurrentRow.Cells[0].Value.ToString();
            Textbox_Fname.Text = DGV_Docgia.CurrentRow.Cells[1].Value.ToString();
            Textbox_Lname.Text = DGV_Docgia.CurrentRow.Cells[2].Value.ToString();
            DateTime date = (DateTime)DGV_Docgia.CurrentRow.Cells[3].Value;
            dateTimePicker1.Value = date;
            string sex = DGV_Docgia.CurrentRow.Cells[4].Value.ToString().Trim();
            if (sex == "Female")
            {
                Radiobt_Female.Checked = true;
            }

            if (sex == "Male")
            {
                Radiobt_Male.Checked = true;
            }
            Textbox_Phone.Text = DGV_Docgia.CurrentRow.Cells[8].Value.ToString();
            Textbox_Email.Text = DGV_Docgia.CurrentRow.Cells[9].Value.ToString();
            Textbox_Address.Text = DGV_Docgia.CurrentRow.Cells[7].Value.ToString();
            Combo_Donvi.SelectedValue = DGV_Docgia.CurrentRow.Cells[5].Value;

            byte[] pic;
            pic = (byte[])DGV_Docgia.CurrentRow.Cells[10].Value;
            MemoryStream picture = new MemoryStream(pic);
            PictureboxStudentImage.Image = Image.FromStream(picture);
        }
        public DataTable getPhanloaitheoDV()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.GetConnection;
            command.CommandText = ("SELECT teacher.id, teacher.fname, teacher.lname, teacher.bdate, teacher.gender," +
                " teacher.donvi, donvi.donvi_name, teacher.address, teacher.phone, teacher.email, teacher.pic FROM teacher INNER JOIN donvi on teacher.donvi = donvi.Id WHERE donvi.Id =" + comboBox_phanloai.SelectedValue);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getPhanloaitheoDVstd()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.GetConnection;
            command.CommandText = ("SELECT std.id, std.fname, std.lname, std.bdate, std.gender," +
                " std.donvi, donvi.donvi_name, std.address, std.phone, std.email, std.pic FROM std INNER JOIN donvi on std.donvi = donvi.Id WHERE donvi.Id =" + comboBox_phanloai.SelectedValue);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public void chinhform()
        {
            DGV_Docgia.RowTemplate.Height = 50;

            DGV_Docgia.AllowUserToAddRows = false;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)DGV_Docgia.Columns[10];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            DGV_Docgia.AllowUserToAddRows = false;


            DGV_Docgia.Columns[0].HeaderText = "ID";
            DGV_Docgia.Columns[0].Width = 100;
            DGV_Docgia.Columns[1].HeaderText = "HỌ";
            DGV_Docgia.Columns[1].Width = 120;

            DGV_Docgia.Columns[2].HeaderText = "TÊN";
            DGV_Docgia.Columns[2].Width = 120;

            DGV_Docgia.Columns[3].HeaderText = "NGÀY SINH";
            DGV_Docgia.Columns[3].Width = 100;

            DGV_Docgia.Columns[4].HeaderText = "GIỚI TÍNH";
            DGV_Docgia.Columns[4].Width = 90;
            DGV_Docgia.Columns[5].HeaderText = "ID ĐV";
            DGV_Docgia.Columns[5].Width = 80;
            DGV_Docgia.Columns[6].HeaderText = "ĐƠN VỊ";
            DGV_Docgia.Columns[6].Width = 80;

            DGV_Docgia.Columns[7].HeaderText = "ĐỊA CHỈ";
            DGV_Docgia.Columns[7].Width = 150;
            DGV_Docgia.Columns[8].HeaderText = "SĐT";
            DGV_Docgia.Columns[8].Width = 120;
            DGV_Docgia.Columns[9].HeaderText = "EMAIL";
            DGV_Docgia.Columns[9].Width = 200;
            DGV_Docgia.Columns[10].HeaderText = "ẢNH";
            DGV_Docgia.Columns[10].Width = 50;
        }

        private void bt_uploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png,*.gif)|*.jpg;*.png,*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                PictureboxStudentImage.Image = Image.FromFile(opf.FileName);
            }
        }

        private void bt_in_Click(object sender, EventArgs e)
        {

            //dlg.ShowDialog(); //Hiển thị hộp thoại PrintDialog

            //cau hinh trang
            int height = DGV_Docgia.Height;
            DGV_Docgia.Height = DGV_Docgia.RowCount * DGV_Docgia.RowTemplate.Height * 2;

            //Chuyen datagridview ve file Bitmap de doc hinh anh
            bmp = new Bitmap(DGV_Docgia.Width, DGV_Docgia.Height);
            DGV_Docgia.DrawToBitmap(bmp, new Rectangle(0, 0, DGV_Docgia.Width, DGV_Docgia.Height));
            DGV_Docgia.Height = height;

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
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void bt_savefile_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Word Document (*.docx)|*.docx";

            sfd.FileName = "DSDOCGIA.docx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Export_Data_To_Word(DGV_Docgia, sfd.FileName);
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
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 16;

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
                    headerRange.Text = "DANH SÁCH ĐỘC GIẢ CỦA THƯ VIỆN";
                    headerRange.Font.Size = 16;
                    headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }

                //save image
                for (r = 0; r < RowCount; r++)
                {
                    byte[] imgbyte = (byte[])DGV_Docgia.Rows[r].Cells[10].Value;
                    MemoryStream ms = new MemoryStream(imgbyte);
                    Image finalPic = (Image)(new Bitmap(Image.FromStream(ms), new Size(70, 70)));
                    Clipboard.SetDataObject(finalPic, true);
                    oDoc.Application.Selection.Tables[1].Cell(r + 2, 11).Range.Paste();
                    oDoc.Application.Selection.Tables[1].Cell(r + 2, 11).Range.InsertParagraph();
                }

                //save the file
                oDoc.SaveAs(filename);
            }
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            if (radioButton_std.Checked)
            {
                try
                {
                    int studentID = Convert.ToInt32(Textbox_ID.Text);
                    if ((MessageBox.Show("Bạn có chắc muốn xóa độc giả này?", "Xóa độc giả", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {
                        if (std.deteleStudent(studentID))
                        {
                            MessageBox.Show("Đã xóa độc giả", "Xóa độc giả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Combo_Donvi.Text = "";
                            Textbox_Fname.Text = "";
                            Textbox_Lname.Text = "";
                            Textbox_Phone.Text = "";
                            Textbox_Address.Text = "";
                            Textbox_Email.Text = "";
                            Textbox_ID.Text = "";
                            PictureboxStudentImage.Image = null;
                            dateTimePicker1.Value = DateTime.Now;
                            comboBox_phanloai.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Xóa độc giả không thành công", "Xóa độc giả", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                catch
                {
                    MessageBox.Show("Please Enter A Valid ID", "Xóa độc giả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                try
                {
                    int studentID = Convert.ToInt32(Textbox_ID.Text);
                    if ((MessageBox.Show("Bạn có chắc muốn xóa độc giả này?", "Xóa độc giả", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {
                        if (tea.deteleTeacher(studentID))
                        {
                            MessageBox.Show("Đã xóa độc giả", "Xóa độc giả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Combo_Donvi.Text = "";
                            Textbox_Fname.Text = "";
                            Textbox_Lname.Text = "";
                            Textbox_Phone.Text = "";
                            Textbox_Address.Text = "";
                            Textbox_Email.Text = "";
                            Textbox_ID.Text = "";
                            PictureboxStudentImage.Image = null;
                            dateTimePicker1.Value = DateTime.Now;
                            comboBox_phanloai.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Xóa độc giả không thành công", "Xóa độc giả", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                catch
                {
                    MessageBox.Show("Please Enter A Valid ID", "Xóa độc giả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }                
            
        }
    }
}
