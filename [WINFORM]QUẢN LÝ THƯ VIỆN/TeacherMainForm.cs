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
using System.IO;

namespace _WINFORM_QUẢN_LÝ_THƯ_VIỆN
{
    public partial class TeacherMainForm : Form
    {
        MUON muon = new MUON();
        SACH sach = new SACH();
        USER user = new USER();
        MuonForm muonf = new MuonForm();
        TEACHER tea = new TEACHER();
        MY_DB mydb = new MY_DB();
        public TeacherMainForm()
        {
            InitializeComponent();
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
        private void tcCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            DONVI dv = new DONVI();

            Combo_Donvi.DataSource = dv.getDonvi();
            Combo_Donvi.DisplayMember = "donvi_name";
            Combo_Donvi.ValueMember = "Id";
            Combo_Donvi.SelectedItem = null;




            // click to tab TaiKhoan
            if (tcCustomer.SelectedIndex == 1)
            {
                // load info to textboxes
                STUDENT std = new STUDENT();

                SqlCommand command = new SqlCommand("SELECT * FROM teacher WHERE teacher.id = @usn", mydb.GetConnection);


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
                Combo_Donvi.SelectedValue = meo.ItemArray[5].ToString();
                byte[] pic;
                pic = (byte[])meo.ItemArray[9];
                MemoryStream picture = new MemoryStream(pic);
                PictureboxStudentImage.Image = Image.FromStream(picture);
                //
                Textbox_reUsername.Text = meo.ItemArray[0].ToString();

            }
            if (tcCustomer.SelectedIndex == 2)
            {
                STUDENT std = new STUDENT();
                
                SqlCommand command = new SqlCommand("SELECT * FROM teacher WHERE teacher.id = @usn", mydb.GetConnection);
                command.Parameters.Add("@usn", SqlDbType.Int).Value = Program.username;
                DataTable dt = std.getContact(command);
                DataRow meo = dt.Rows[0];

                Tb_teaid.Text = meo.ItemArray[0].ToString();
                Tb_teaid.Enabled = false;

                DGV_chomuon.DataSource = getchomuonsachtheotg();
                Setform();

            }    
        }

        private void TeacherMainForm_Load(object sender, EventArgs e)
        {
            STUDENT std = new STUDENT();

            SqlCommand command = new SqlCommand("SELECT * FROM teacher WHERE teacher.id = @usn", mydb.GetConnection);


            command.Parameters.Add("@usn", SqlDbType.Int).Value = Program.username;
            DataTable dt = std.getContact(command);
            DataRow meo = dt.Rows[0];
            Label_infor.Text = ("Xin chào: " + meo.ItemArray[2].ToString());

            Textbox_docgiaID.Text = meo.ItemArray[0].ToString();
            Textbox_docgiaID.Enabled = false;
            DGV_sachmuon.DefaultCellStyle.Font = new Font("Times New Roman", 12);
            DGV_sachmuon.DataSource = getMuonTeacher();
            setformMuon();

            DGV_tracuusach.DefaultCellStyle.Font = new Font("Times New Roman", 12);
            DGV_tracuusach.DataSource = muon.gettracuu();
            setform();



            radioButton_theloai.Checked = true;
            if (radioButton_theloai.Checked)
            {
                comboBox_phanloai.DataSource = sach.gettheloai();
                comboBox_phanloai.DisplayMember = "theloai";
                comboBox_phanloai.ValueMember = "id";
                comboBox_phanloai.SelectedItem = null;
            }
        }
        public DataTable getMuonTeacher()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.GetConnection;
            command.CommandText = ("SELECT MUON.docgia_id, MUON.sach_id, sach.name, theloai.theloai, nxb.nxb_name, " +
               " MUON.NgayMuon, MUON.NgayTra FROM MUON INNER JOIN teacher on MUON.docgia_id = teacher.id INNER JOIN sach on MUON.sach_id = sach.id INNER JOIN theloai on sach.theloai = theloai.id INNER JOIN nxb on sach.nxb_id = nxb.nxb_id WHERE MUON.docgia_id =" + Textbox_docgiaID.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        private void setformMuon()
        {
            DGV_sachmuon.RowTemplate.Height = 30;
            DGV_sachmuon.AllowUserToAddRows = false;
            DGV_sachmuon.Columns[0].HeaderText = "ID";
            DGV_sachmuon.Columns[0].Width = 100;
            DGV_sachmuon.Columns[1].HeaderText = "ID SÁCH";
            DGV_sachmuon.Columns[1].Width = 100;
            DGV_sachmuon.Columns[2].HeaderText = "TÊN SÁCH";
            DGV_sachmuon.Columns[2].Width = 200;


            DGV_sachmuon.Columns[3].HeaderText = "THỂ LOẠI";
            DGV_sachmuon.Columns[3].Width = 100;


            DGV_sachmuon.Columns[4].HeaderText = "NXB";
            DGV_sachmuon.Columns[4].Width = 160;

            DGV_sachmuon.Columns[5].HeaderText = "NGÀY MƯỢN";
            DGV_sachmuon.Columns[5].Width = 160;
            DGV_sachmuon.Columns[6].HeaderText = "NGÀY TRẢ";
            DGV_sachmuon.Columns[6].Width = 160;

        }
        private void setform()
        {
            DGV_tracuusach.RowTemplate.Height = 30;
            DGV_tracuusach.AllowUserToAddRows = false;
            DGV_tracuusach.Columns[0].HeaderText = "MÃ SÁCH";
            DGV_tracuusach.Columns[0].Width = 50;

            DGV_tracuusach.Columns[1].HeaderText = "TÊN SÁCH";
            DGV_tracuusach.Columns[1].Width = 210;


            DGV_tracuusach.Columns[2].HeaderText = "THỂ LOẠI";
            DGV_tracuusach.Columns[2].Width = 100;


            DGV_tracuusach.Columns[3].HeaderText = "TÁC GIẢ";
            DGV_tracuusach.Columns[3].Width = 160;

            DGV_tracuusach.Columns[4].HeaderText = "NHÀ XUẤT BẢN";
            DGV_tracuusach.Columns[4].Width = 160;

        }
        private void comboBox_phanloai_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            if (radioButton_theloai.Checked)
            {
                DGV_tracuusach.DataSource = getPhanloaiSachtl();
                setform();
            }
            if (radioButton_nxb.Checked)
            {
                DGV_tracuusach.DataSource = getPhanloaiSachnxb();
                setform();
            }
            else if (radioButton_tg.Checked)
            {
                DGV_tracuusach.DataSource = getPhanloaiSachtg();
                setform();
            }
        }
        public DataTable getPhanloaiSachtl()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.GetConnection;
            command.CommandText = ("SELECT sach.id, sach.name, theloai.theloai,tacgia.tacgia_name,nxb.nxb_name FROM sach INNER JOIN theloai on sach.theloai = theloai.id INNER JOIN tacgia on sach.tacgia_id = tacgia.tacgia_id INNER JOIN nxb on sach.nxb_id = nxb.nxb_id WHERE theloai.id =" + comboBox_phanloai.SelectedValue);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getPhanloaiSachnxb()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.GetConnection;
            command.CommandText = ("SELECT sach.id, sach.name, theloai.theloai,tacgia.tacgia_name,nxb.nxb_name FROM sach INNER JOIN theloai on sach.theloai = theloai.id INNER JOIN tacgia on sach.tacgia_id = tacgia.tacgia_id INNER JOIN nxb on sach.nxb_id = nxb.nxb_id WHERE nxb.nxb_id =" + comboBox_phanloai.SelectedValue);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getPhanloaiSachtg()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.GetConnection;
            command.CommandText = ("SELECT sach.id, sach.name, theloai.theloai,tacgia.tacgia_name,nxb.nxb_name FROM sach INNER JOIN theloai on sach.theloai = theloai.id INNER JOIN tacgia on sach.tacgia_id = tacgia.tacgia_id INNER JOIN nxb on sach.nxb_id = nxb.nxb_id WHERE tacgia.tacgia_id =" + comboBox_phanloai.SelectedValue);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        private void radioButton_theloai_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_phanloai.DataSource = sach.gettheloai();
            comboBox_phanloai.DisplayMember = "theloai";
            comboBox_phanloai.ValueMember = "id";
            comboBox_phanloai.SelectedItem = null;
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DGV_tracuusach.DefaultCellStyle.Font = new Font("Times New Roman", 12);
            DGV_tracuusach.DataSource = muon.gettracuu();
            comboBox_phanloai.SelectedItem = null;
            setform();
        }

        private void DGV_tracuusach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Textbox_sID.Text = DGV_tracuusach.CurrentRow.Cells[0].Value.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DGV_sachmuon.DefaultCellStyle.Font = new Font("Times New Roman", 12);
            DGV_sachmuon.DataSource = getMuonTeacher();
            setformMuon();
        }
        public bool updateSachconlai()
        {
            SqlCommand command = new SqlCommand("UPDATE sach SET con = con - 1 where sach.id = " + Textbox_sID.Text, mydb.GetConnection);
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool updateTrasach()
        {
            SqlCommand command = new SqlCommand("UPDATE sach SET con = con + 1 where sach.id = " + IdmaSach1.Text, mydb.GetConnection);
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        private void DGV_sachmuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Textbox_tensach.Text = DGV_sachmuon.CurrentRow.Cells[2].Value.ToString();
            IdmaSach1.Text = DGV_sachmuon.CurrentRow.Cells[1].Value.ToString();
            IDdocgia1.Text = DGV_sachmuon.CurrentRow.Cells[0].Value.ToString();
        }
        bool verif()
        {
            if ((Textbox_docgiaID.Text.Trim() == "")
                || (Textbox_sID.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void bt_muonsach_Click(object sender, EventArgs e)
        {
            int docgia = Convert.ToInt32(Textbox_docgiaID.Text);
            int sachid = Convert.ToInt32(Textbox_sID.Text);
            //DateTime muon = date_muon.Value.Date;
            //DateTime tra = date_tra.Value.Date;

            DateTime ngaymuon = Convert.ToDateTime(date_muon.Value);
            DateTime ngaytra = Convert.ToDateTime(date_tra.Value);
            TimeSpan Time = ngaytra - ngaymuon;
            int TongSoNgay = Time.Days;



            if (TongSoNgay <= 0)
            {
                MessageBox.Show("Ngày trả phải lớn hơn ngày mượn", "Thời gian mượn - trả", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verif())
            {
                if (muon.CheckTeacher(Convert.ToInt32(Textbox_docgiaID.Text)))
                {
                    if (!muon.Checkmuon(Convert.ToInt32(Textbox_docgiaID.Text), Convert.ToInt32(Textbox_sID.Text)))
                    {
                        if (muon.Checksachconhayhet(Convert.ToInt32(Textbox_sID.Text)))
                        {
                            if (muon.MuonSach(docgia, sachid, ngaymuon, ngaytra))
                            {
                                MessageBox.Show("Học sinh mượn sách thành công", "Mượn sách", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                updateSachconlai();
                                updateSachmuonnhieu();
                                DGV_sachmuon.DefaultCellStyle.Font = new Font("Times New Roman", 12);
                                DGV_sachmuon.DataSource = getMuonTeacher();
                                setformMuon();

                            }
                            else
                            {
                                MessageBox.Show("Học sinh mượn sách không thành công", "Mượn sách", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Thư viện đã hết sách này. Mong bạn thông cảm", "Mượn sách", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Học sinh đã mượn sách này rồi", "Mượn sách", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Mã học sinh không đúng với hệ thống", "Mượn sách", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("Empty Fields", "Mượn sách", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
        public bool updateSachmuonnhieu()
        {
            SqlCommand command = new SqlCommand("UPDATE smn SET smn_sl = smn_sl + 1 where smn.smn_id = " + Textbox_sID.Text, mydb.GetConnection);
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        private void bt_trasach_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(IDdocgia1.Text);
            int sid = Convert.ToInt32(IdmaSach1.Text);
            if ((MessageBox.Show("Bạn muốn trả sách?", "Trả sách", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                //TrasachForm tra = new TrasachForm();
                //tra.ShowDialog();
                if (muon.gettra(ID, sid))
                {
                    MessageBox.Show("Trả sách thành công", "Trả sách", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    updateTrasach();
                    IdmaSach1.Text = "";
                    IDdocgia1.Text = "";
                    Textbox_tensach.Text = "";
                    DGV_sachmuon.DefaultCellStyle.Font = new Font("Times New Roman", 12);
                    DGV_sachmuon.DataSource = getMuonTeacher();
                    setformMuon();
                }
                else
                {
                    MessageBox.Show("Trả sách không thành công", "Trả sách", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
        public DataTable getchomuonsachtheotg()
        {

            SqlCommand command = new SqlCommand();
            command.Connection = mydb.GetConnection;
            command.CommandText = ("SELECT CHOMUON.schomuon, CHOMUON.name_cm, CHOMUON.theloai, CHOMUON.tacgia, CHOMUON.nxb, CHOMUON.yxb, (fname + lname) AS hoten,CHOMUON.date_cm, CHOMUON.sl_cm FROM CHOMUON INNER JOIN teacher on CHOMUON.ngcho_id = teacher.id WHERE CHOMUON.ngcho_id = " + Tb_teaid.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
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
            TextBox_IDsach.Text = ("" + m);
            TextBox_IDsach.Enabled = false;
            bt_them.Enabled  = false;
            tb_nxb.Text = tb_sl.Text = tb_tacgia.Text = textBox_sname.Text = tb_theloai.Text = tb_theloai.Text = "";
            data_cm.Value = date_xb.Value = DateTime.Now;
        }

        private void logout_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Bạn muốn đăng xuất", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                this.Visible = false;
                Close();
                this.Visible = true;
            }
        }

        private void dmk_Click(object sender, EventArgs e)
        {
            string username = Textbox_reUsername.Text;
            string password = txtPassword1.Text;
            string newpass = Textbox_newpass.Text;
            string cfim = Textbox_confirmnew.Text;
            string quyen = "Teacher";

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

        private void bt_reset_Click(object sender, EventArgs e)
        {
            bt_them.Enabled = true;
            tb_nxb.Text = tb_sl.Text = tb_tacgia.Text = textBox_sname.Text = tb_theloai.Text = tb_theloai.Text = "";
            data_cm.Value = date_xb.Value = DateTime.Now;
            TextBox_IDsach.Text = "";
            TextBox_IDsach.Enabled = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DGV_sachmuon.DefaultCellStyle.Font = new Font("Times New Roman", 12);
            DGV_chomuon.DataSource = getchomuonsachtheotg();
            Setform();
        }
        CHOMUON cm = new CHOMUON();
        private void bt_add_Click(object sender, EventArgs e)
        {
            bt_them.Enabled = true;
            int muon_id = Convert.ToInt32(Tb_teaid.Text);
            string sma = TextBox_IDsach.Text;
            string sname = textBox_sname.Text;
            string tl = tb_theloai.Text;
            string nxb = tb_nxb.Text;
            int sl = Convert.ToInt32(tb_sl.Text);
            string tg = tb_tacgia.Text;
            DateTime dcm = data_cm.Value.Date;
            DateTime dxb = date_xb.Value.Date;
            if (verif1())
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
        bool verif1()
        {
            if ((Tb_teaid.Text.Trim() == "")
                || (TextBox_IDsach.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
