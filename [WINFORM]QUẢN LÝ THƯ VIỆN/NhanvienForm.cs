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

namespace _WINFORM_QUẢN_LÝ_THƯ_VIỆN
{
    public partial class NhanvienForm : Form
    {
        NHANVIEN nv = new NHANVIEN();
        MY_DB mydb = new MY_DB();
        public NhanvienForm()
        {
            InitializeComponent();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            bt_them.Enabled = false;
            bt_sua.Enabled = false;
            bt_savefile.Enabled = false;
            bt_xoa.Enabled = false;
            bt_in.Enabled = false;
            PictureboxStudentImage.Image = null;
            int count = DGV_nhanvien.Rows.Count;
            int n = count + 20210000;
            int m = n + 1;
            Textbox_ID.Text = ("" + m);
            Textbox_ID.Enabled = false;
            Textbox_Fname.Text = "";
            Textbox_Lname.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            Textbox_Address.Text = "";
            Textbox_Email.Text = "";
            Textbox_Phone.Text = "";
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
        private void bt_luu_Click(object sender, EventArgs e)
        {
            bt_them.Enabled = true;
            bt_sua.Enabled = true;
            bt_savefile.Enabled = true;
            bt_in.Enabled = true;
            bt_xoa.Enabled = true;
            Textbox_ID.Enabled = true;
            int cID = Convert.ToInt32(Textbox_ID.Text);
            string fname = Textbox_Fname.Text;
            string lname = Textbox_Lname.Text;
            DateTime BDate = dateTimePicker1.Value.Date;
            string Gender = "Male";
            if (Radiobt_Female.Checked)
            {
                Gender = "Female";
            }
            int donvi = Convert.ToInt32(Combo_cv.SelectedValue);
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
                if (!nv.CheckNhanvien(Convert.ToInt32(Textbox_ID.Text)))
                {
                    if (nv.insertnhanvien(cID, fname, lname, BDate, Gender, donvi, address, phone, email, pic))
                    {
                        MessageBox.Show("Thêm nhân viên thành công. Đăng ký tài khoản cho nhân viên mới nào!", "Thêm nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RegisterFormNV renv = new RegisterFormNV();
                        loadform();
                        this.Visible = false;
                        renv.ShowDialog();
                        this.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Error", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("This ID Already Exists, Try Another One", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("Empty Fields", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
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
        private void NhanvienForm_Load(object sender, EventArgs e)
        {
            Combo_cv.DataSource = nv.getCongviec();
            Combo_cv.DisplayMember = "congviec_name";
            Combo_cv.ValueMember = "congviec_id";
            Combo_cv.SelectedItem = null;

            comboBox_phanloai.DataSource = nv.getCongviec();
            comboBox_phanloai.DisplayMember = "congviec_name";
            comboBox_phanloai.ValueMember = "congviec_id";
            comboBox_phanloai.SelectedItem = null;

            DGV_nhanvien.DefaultCellStyle.Font = new Font("Times New Roman", 12);
            SqlCommand command = new SqlCommand("SELECT nhanvien.id_nv, nhanvien.fn_nv, nhanvien.ln_nv, nhanvien.bdate_nv, nhanvien.gender_nv," +
                "nhanvien.cv_id, congviec.congviec_name, nhanvien.address_nv, nhanvien.phone_nv, nhanvien.email_nv, nhanvien.pic_nv FROM nhanvien INNER JOIN congviec on nhanvien.cv_id = congviec.congviec_id");
            fillgrid(command);
        }
        public void loadform()
        {
            DGV_nhanvien.DefaultCellStyle.Font = new Font("Times New Roman", 12);
            SqlCommand command = new SqlCommand("SELECT nhanvien.id_nv, nhanvien.fn_nv, nhanvien.ln_nv, nhanvien.bdate_nv, nhanvien.gender_nv," +
                "nhanvien.cv_id, congviec.congviec_name, nhanvien.address_nv, nhanvien.phone_nv, nhanvien.email_nv, nhanvien.pic_nv FROM nhanvien INNER JOIN congviec on nhanvien.cv_id = congviec.congviec_id");
            fillgrid(command);
        }
        public void fillgrid(SqlCommand command)
        {
            DGV_nhanvien.ReadOnly = true;
            DGV_nhanvien.RowTemplate.Height = 40;
            DGV_nhanvien.DataSource = nv.getNhanvien(command);
            DGV_nhanvien.AllowUserToAddRows = false;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)DGV_nhanvien.Columns[10];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            DGV_nhanvien.AllowUserToAddRows = false;


            DGV_nhanvien.Columns[0].HeaderText = "ID";
            DGV_nhanvien.Columns[0].Width = 80;
            DGV_nhanvien.Columns[1].HeaderText = "HỌ";
            DGV_nhanvien.Columns[1].Width = 120;

            DGV_nhanvien.Columns[2].HeaderText = "TÊN";
            DGV_nhanvien.Columns[2].Width = 120;

            DGV_nhanvien.Columns[3].HeaderText = "NGÀY SINH";
            DGV_nhanvien.Columns[3].Width = 100;

            DGV_nhanvien.Columns[4].HeaderText = "GIỚI TÍNH";
            DGV_nhanvien.Columns[4].Width = 100;
            DGV_nhanvien.Columns[5].HeaderText = "ID CÔNG VIỆC";
            DGV_nhanvien.Columns[5].Width = 100;
            DGV_nhanvien.Columns[6].HeaderText = "CÔNG VIỆC";
            DGV_nhanvien.Columns[6].Width = 160;

            DGV_nhanvien.Columns[7].HeaderText = "ĐỊA CHỈ";
            DGV_nhanvien.Columns[7].Width = 120;
            DGV_nhanvien.Columns[8].HeaderText = "SĐT";
            DGV_nhanvien.Columns[8].Width = 98;
            DGV_nhanvien.Columns[9].HeaderText = "EMAIL";
            DGV_nhanvien.Columns[9].Width = 200;
            DGV_nhanvien.Columns[10].HeaderText = "ẢNH";
            DGV_nhanvien.Columns[10].Width = 40;
        }

        private void DGV_nhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Textbox_ID.Text = DGV_nhanvien.CurrentRow.Cells[0].Value.ToString();
            Textbox_Fname.Text = DGV_nhanvien.CurrentRow.Cells[1].Value.ToString();
            Textbox_Lname.Text = DGV_nhanvien.CurrentRow.Cells[2].Value.ToString();
            DateTime date = (DateTime)DGV_nhanvien.CurrentRow.Cells[3].Value;
            dateTimePicker1.Value = date;
            string sex = DGV_nhanvien.CurrentRow.Cells[4].Value.ToString().Trim();
            if (sex == "Female")
            {
                Radiobt_Female.Checked = true;
            }

            if (sex == "Male")
            {
                Radiobt_Male.Checked = true;
            }
            Textbox_Phone.Text = DGV_nhanvien.CurrentRow.Cells[8].Value.ToString();
            Textbox_Email.Text = DGV_nhanvien.CurrentRow.Cells[9].Value.ToString();
            Textbox_Address.Text = DGV_nhanvien.CurrentRow.Cells[7].Value.ToString();
            Combo_cv.SelectedValue = DGV_nhanvien.CurrentRow.Cells[5].Value;

            byte[] pic;
            pic = (byte[])DGV_nhanvien.CurrentRow.Cells[10].Value;
            MemoryStream picture = new MemoryStream(pic);
            PictureboxStudentImage.Image = Image.FromStream(picture);
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            Textbox_ID.Enabled = false;
            int cID = Convert.ToInt32(Textbox_ID.Text);
            string fname = Textbox_Fname.Text;
            string lname = Textbox_Lname.Text;
            DateTime BDate = dateTimePicker1.Value.Date;
            string Gender = "Male";
            if (Radiobt_Female.Checked)
            {
                Gender = "Female";
            }
            int donvi = Convert.ToInt32(Combo_cv.SelectedValue);
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
                if (nv.updateNHANVIEN(cID, fname, lname, BDate, Gender, donvi, address, phone, email, pic))
                {
                    loadform();
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
        USER user = new USER();
        private void bt_xoa_Click(object sender, EventArgs e)
        {

            int studentID = Convert.ToInt32(Textbox_ID.Text);
            if ((MessageBox.Show("Bạn có chắc muốn xóa nhân viên này?", "Xóa nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                if (nv.deteleNhanvien(studentID))
                {
                    MessageBox.Show("Đã xóa nhân viên", "Xóa nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Combo_cv.Text = "";
                    Textbox_Fname.Text = "";
                    Textbox_Lname.Text = "";
                    Textbox_Phone.Text = "";
                    Textbox_Address.Text = "";
                    Textbox_Email.Text = "";
                    Textbox_ID.Text = "";
                    PictureboxStudentImage.Image = null;
                    dateTimePicker1.Value = DateTime.Now;
                    loadform();
                }
                else
                {
                    MessageBox.Show("Xóa nhân viên không thành công", "Xóa nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Combo_cv.Text = "";
            Textbox_Fname.Text = "";
            Textbox_Lname.Text = "";
            Textbox_Phone.Text = "";
            Textbox_Address.Text = "";
            Textbox_Email.Text = "";
            Textbox_ID.Text = "";
            PictureboxStudentImage.Image = null;
            dateTimePicker1.Value = DateTime.Now;
            loadform();
            bt_them.Enabled = true;
            bt_sua.Enabled = true;
            bt_savefile.Enabled = true;
            bt_xoa.Enabled = true;
            bt_in.Enabled = true;
        }

        private void comboBox_phanloai_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DGV_nhanvien.DataSource = getPhanloaitheoCV();
            
        }
        public DataTable getPhanloaitheoCV()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.GetConnection;
            command.CommandText = ("SELECT nhanvien.id_nv, nhanvien.fn_nv, nhanvien.ln_nv, nhanvien.bdate_nv, nhanvien.gender_nv," +
                "nhanvien.cv_id, congviec.congviec_name, nhanvien.address_nv, nhanvien.phone_nv, nhanvien.email_nv, nhanvien.pic_nv FROM nhanvien INNER JOIN congviec on nhanvien.cv_id = congviec.congviec_id WHERE nhanvien.cv_id =" + comboBox_phanloai.SelectedValue);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}

        
    


        
