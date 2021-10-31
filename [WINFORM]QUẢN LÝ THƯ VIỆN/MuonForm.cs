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
    public partial class MuonForm : Form
    {
        public MuonForm()
        {
            InitializeComponent();
        }
        MUON muon = new MUON();
        SACH sach = new SACH();
        MY_DB mydb = new MY_DB();
        private void MuonForm_Load(object sender, EventArgs e)
        {
            DGV_muon.AllowUserToAddRows = false;
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
            radioButton_std.Checked = true;
            if (radioButton_std.Checked)
            {
                DGV_muon.DataSource = muon.getMuonSTD();
                setformMuon();
            }    
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

        private void DGV_tracuusach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Textbox_sID.Text = DGV_tracuusach.CurrentRow.Cells[0].Value.ToString();

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

        private void radioButton_nxb_CheckedChanged_1(object sender, EventArgs e)
        {
            comboBox_phanloai.DataSource = sach.getnxb();
            comboBox_phanloai.DisplayMember = "nxb_name";
            comboBox_phanloai.ValueMember = "nxb_id";
            comboBox_phanloai.SelectedItem = null;
        }

        private void radioButton_tg_CheckedChanged_1(object sender, EventArgs e)
        {
            comboBox_phanloai.DataSource = sach.gettacgia();
            comboBox_phanloai.DisplayMember = "tacgia_name";
            comboBox_phanloai.ValueMember = "tacgia_id";
            comboBox_phanloai.SelectedItem = null;
        }

        private void radioButton_theloai_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_phanloai.DataSource = sach.gettheloai();
            comboBox_phanloai.DisplayMember = "theloai";
            comboBox_phanloai.ValueMember = "id";
            comboBox_phanloai.SelectedItem = null;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DGV_tracuusach.DefaultCellStyle.Font = new Font("Times New Roman", 12);
            DGV_tracuusach.DataSource = muon.gettracuu();
            comboBox_phanloai.SelectedItem = null;
            setform();
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
                if (radioButton_std.Checked == true)
                {
                    if (muon.CheckDocgia(Convert.ToInt32(Textbox_docgiaID.Text)))
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
                                    DGV_muon.DataSource = muon.getMuonSTD();
                                    setformMuon();
                                    DGV_muon.AllowUserToAddRows = false;
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


                else if (radioButton_tea.Checked == true)
                {
                    if (muon.CheckTeacher(Convert.ToInt32(Textbox_docgiaID.Text)))
                    {
                        if (!muon.Checkmuon(Convert.ToInt32(Textbox_docgiaID.Text), Convert.ToInt32(Textbox_sID.Text)))
                        {
                            if (muon.Checksachconhayhet(Convert.ToInt32(Textbox_sID.Text)))
                            {
                                if (muon.MuonSach(docgia, sachid, ngaymuon, ngaytra))
                                {

                                    MessageBox.Show("Giảng viên mượn sách thành công", "Mượn sách", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    updateSachconlai();
                                    updateSachmuonnhieu();
                                    DGV_muon.DataSource = muon.getMuonTeacher();
                                    setformMuon();
                                    DGV_muon.AllowUserToAddRows = false;
                                }
                                else
                                {
                                    MessageBox.Show("Giảng viên mượn sách không thành công", "Mượn sách", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Thư viện đã hết sách này. Mong bạn thông cảm", "Mượn sách", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }       
                        }
                        else
                        {
                            MessageBox.Show("Giảng viên đã mượn sách này rồi", "Mượn sách", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã giảng viên không đúng với hệ thống", "Mượn sách", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    
                }    
               
            }
            else
            {
                MessageBox.Show("Empty Fields", "Mượn sách", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

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
        public bool updateTrasach()
        {
            SqlCommand command = new SqlCommand("UPDATE sach SET con = con + 1 where sach.id = " + Textbox_sID.Text, mydb.GetConnection);
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
        private void DGV_muon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Textbox_docgiaID.Text = DGV_muon.CurrentRow.Cells[0].Value.ToString();
            Textbox_sID.Text = DGV_muon.CurrentRow.Cells[3].Value.ToString();
            DateTime date1 = (DateTime)DGV_muon.CurrentRow.Cells[7].Value;
            date_muon.Value = date1;
            DateTime date = (DateTime)DGV_muon.CurrentRow.Cells[8].Value;
            date_tra.Value = date;
            setformMuon();
        }

        private void bt_trasach_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = Convert.ToInt32(Textbox_docgiaID.Text);
                int sid = Convert.ToInt32(Textbox_sID.Text);
                if ((MessageBox.Show("Bạn muốn trả sách?", "Trả sách", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    //TrasachForm tra = new TrasachForm();
                    //tra.ShowDialog();
                    if (muon.gettra(ID, sid))
                    {
                        MessageBox.Show("Trả sách thành công", "Trả sách", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        updateTrasach();
                        Textbox_docgiaID.Text = "";
                        Textbox_sID.Text = "";
                        date_muon.Value = DateTime.Now;
                        date_tra.Value = DateTime.Now;
                        if (radioButton_std.Checked)
                        {
                            DGV_muon.DataSource = muon.getMuonSTD();
                            setformMuon();
                            DGV_muon.AllowUserToAddRows = false;
                        }
                        else if (radioButton_tea.Checked)
                        {
                            DGV_muon.DataSource = muon.getMuonTeacher();
                            setformMuon();
                            DGV_muon.AllowUserToAddRows = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Trả sách không thành công", "Trả sách", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch
            {
                MessageBox.Show("Please Enter A Valid ID", "Trả sách", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public int tinhngaytra()
        {
            DateTime ngaytra = Convert.ToDateTime((DateTime)DGV_muon.CurrentRow.Cells[8].Value);
            DateTime homnay = Convert.ToDateTime(DateTime.Now);
            TimeSpan Time = ngaytra - homnay;
            int TongSoNgay = Time.Days;
            return TongSoNgay;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (radioButton_std.Checked)
            {
                DGV_muon.DataSource = muon.getMuonSTD();
                setformMuon();
                DGV_muon.AllowUserToAddRows = false;
            }    
            else if (radioButton_tea.Checked)
            {
                DGV_muon.DataSource = muon.getMuonTeacher();
                setformMuon();
                DGV_muon.AllowUserToAddRows = false;
            }    
        }

        private void radioButton_std_CheckedChanged(object sender, EventArgs e)
        {
            DGV_muon.DataSource = muon.getMuonSTD();
            Textbox_docgiaID.Text = "";
            Textbox_sID.Text = "";
            date_muon.Value = DateTime.Now;
            date_tra.Value = DateTime.Now;
            setformMuon();
        }

        private void radioButton_tea_CheckedChanged(object sender, EventArgs e)
        {
            DGV_muon.DataSource = muon.getMuonTeacher();
            Textbox_docgiaID.Text = "";
            Textbox_sID.Text = "";
            date_muon.Value = DateTime.Now;
            date_tra.Value = DateTime.Now;
            setformMuon();
        }
        private void setformMuon()
        {
            DGV_muon.RowTemplate.Height = 30;
            DGV_muon.AllowUserToAddRows = false;
            DGV_muon.Columns[0].HeaderText = "ID";
            DGV_muon.Columns[0].Width = 80;
            DGV_muon.Columns[3].HeaderText = "ID SÁCH";
            DGV_muon.Columns[3].Width = 50;
            DGV_muon.Columns[1].HeaderText = "HỌ";
            DGV_muon.Columns[1].Width = 100;


            DGV_muon.Columns[2].HeaderText = "TÊN";
            DGV_muon.Columns[2].Width = 100;

            DGV_muon.Columns[4].HeaderText = "TÊN SÁCH";
            DGV_muon.Columns[4].Width = 200;


            DGV_muon.Columns[5].HeaderText = "THỂ LOẠI";
            DGV_muon.Columns[5].Width = 100;


            DGV_muon.Columns[6].HeaderText = "NXB";
            DGV_muon.Columns[6].Width = 140;

            DGV_muon.Columns[7].HeaderText = "NGÀY MƯỢN";
            DGV_muon.Columns[7].Width = 100;
            DGV_muon.Columns[8].HeaderText = "NGÀY TRẢ";
            DGV_muon.Columns[8].Width = 100;

        }
    }
}
