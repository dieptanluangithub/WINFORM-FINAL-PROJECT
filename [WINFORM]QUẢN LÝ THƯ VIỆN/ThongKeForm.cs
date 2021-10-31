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

namespace _WINFORM_QUẢN_LÝ_THƯ_VIỆN
{
    public partial class ThongKeForm : Form
    {
        MY_DB mydb = new MY_DB();
        public ThongKeForm()
        {
            InitializeComponent();
        }

        private void ThongKeForm_Load(object sender, EventArgs e)
        {
            comboBox_FilterGroup.DataSource = getFilter("People");
            comboBox_FilterGroup.DisplayMember = "phanloai_name";
            comboBox_FilterGroup.ValueMember = "phanloai_id";

            comboBox_FilterBook.DataSource = getFilter("Book");
            comboBox_FilterBook.DisplayMember = "phanloai_name";
            comboBox_FilterBook.ValueMember = "phanloai_id";

            reloadPeopleDataGridView();
            reloadBookDataGridView();

            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-MKS1NQ8\SQLEXPRESS;Initial Catalog=QLTHUVIEN;Integrated Security=True");
            SqlDataAdapter ad = new SqlDataAdapter("SELECT donvi.donvi_name, COUNT(std.id) as meo FROM std INNER JOIN donvi ON std.donvi = donvi.Id GROUP BY std.donvi, donvi.donvi_name", con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            chart1.DataSource = dt;
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Tên đơn vị";
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Số lượng học sinh";
            chart1.Series["Người"].XValueMember = "donvi_name";
            chart1.Series["Người"].YValueMembers = "meo";

            SqlConnection con1 = new SqlConnection(@"Data Source = DESKTOP-MKS1NQ8\SQLEXPRESS;Initial Catalog=QLTHUVIEN;Integrated Security=True");
            SqlDataAdapter ad1 = new SqlDataAdapter("SELECT tacgia.tacgia_name, SUM(sach.sl) as meo " +
                "FROM sach INNER JOIN tacgia ON sach.tacgia_id = tacgia.tacgia_id " +
                "GROUP BY tacgia.tacgia_name; ", con1);
            DataTable dt1 = new DataTable();
            ad1.Fill(dt1);
            chart2.DataSource = dt1;
            chart2.ChartAreas["ChartArea1"].AxisX.Title = "Tên tác giả";
            chart2.ChartAreas["ChartArea1"].AxisY.Title = "Số lượng sách";
            chart2.Series["Sách"].XValueMember = "tacgia_name";
            chart2.Series["Sách"].YValueMembers = "meo";


        }
        DataTable getFilter(string doituongphanloai)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM phanloai WHERE phanloai_ob = @plo", mydb.GetConnection);
            command.Parameters.Add("@plo", SqlDbType.NVarChar).Value = doituongphanloai;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        void reloadPeopleDataGridView()
        {
            DGV_TKNguoi.ReadOnly = true;

            if (comboBox_FilterGroup.Text.ToString() == "Sinh viên")
            {
                label_AllUser.Text = "Tổng số sinh viên của hệ thống: " + exeCountByUserAuthority1();
                DGV_TKNguoi.DataSource = getGroups("SELECT std.donvi as N'STT', donvi.donvi_name as N'ĐƠN VỊ', COUNT(std.id) as N'SỐ LƯỢNG HIỆN TẠI' FROM std INNER JOIN donvi ON std.donvi = donvi.Id GROUP BY std.donvi, donvi.donvi_name ORDER BY std.donvi ASC");
                setformPeople();
                SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-MKS1NQ8\SQLEXPRESS;Initial Catalog=QLTHUVIEN;Integrated Security=True");
                SqlDataAdapter ad = new SqlDataAdapter("SELECT donvi.donvi_name, COUNT(std.id) as meo FROM std INNER JOIN donvi ON std.donvi = donvi.Id GROUP BY std.donvi, donvi.donvi_name", con);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                chart1.DataSource = dt;
                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Tên đơn vị";
                chart1.ChartAreas["ChartArea1"].AxisY.Title = "Số lượng học sinh";
                chart1.Series["Người"].XValueMember = "donvi_name";
                chart1.Series["Người"].YValueMembers = "meo";
            }
            else if (comboBox_FilterGroup.Text.ToString() == "Sinh viên đang mượn")
            {
                int count = DGV_TKNguoi.Rows.Count;
                label_AllUser.Text = "Tổng số sinh viên đang mượn sách: " + count;
                DGV_TKNguoi.DataSource = getGroups("Select docgia_id as N'MSSV', (std.fname+' '+std.lname) as N'HỌ VÀ TÊN',count(docgia_id) as N'SỐ LƯỢNG SÁCH ĐÃ MƯỢN' " +
                    " from MUON INNER JOIN std on MUON.docgia_id = std.id GROUP BY docgia_id, std.fname, std.lname ORDER BY count(docgia_id) desc");
                setformPeople();
                SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-MKS1NQ8\SQLEXPRESS;Initial Catalog=QLTHUVIEN;Integrated Security=True");
                SqlDataAdapter ad = new SqlDataAdapter("Select (std.fname+' '+std.lname) as meo,count(docgia_id) as gau" +
                    " from MUON INNER JOIN std on MUON.docgia_id = std.id" +
                    " GROUP BY std.fname, std.lname ORDER BY count(docgia_id) desc", con);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                chart1.DataSource = dt;
                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Tên sinh viên";
                chart1.ChartAreas["ChartArea1"].AxisY.Title = "Tổng số lượng sách";
                chart1.Series["Người"].XValueMember = "meo";
                chart1.Series["Người"].YValueMembers = "gau";

            }
            else if (comboBox_FilterGroup.Text.ToString() == "Giáo viên cho thư viện mượn")
            {
                int count = DGV_TKNguoi.Rows.Count;
                label_AllUser.Text = "Tổng số giáo viên cho thư viện mượn: " + count;
                DGV_TKNguoi.DataSource = getGroups("Select CHOMUON.ngcho_id as N'MSGV', (teacher.fname+' '+teacher.lname) as N'HỌ VÀ TÊN',  sum(CHOMUON.sl_cm) as N'TỔNG SỐ SÁCH CHO MƯỢN'" +
                    " from teacher INNER JOIN CHOMUON on CHOMUON.ngcho_id = teacher.id" +
                    " GROUP BY ngcho_id, teacher.fname, teacher.lname ORDER BY sum(CHOMUON.sl_cm) desc");
                setformPeople();
                SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-MKS1NQ8\SQLEXPRESS;Initial Catalog=QLTHUVIEN;Integrated Security=True");
                SqlDataAdapter ad = new SqlDataAdapter("Select (teacher.fname+' '+teacher.lname) as meo,  sum(CHOMUON.sl_cm) as gau" +
                    " from teacher INNER JOIN CHOMUON on CHOMUON.ngcho_id = teacher.id" +
                    " GROUP BY teacher.fname, teacher.lname ORDER BY sum(CHOMUON.sl_cm) desc; ", con);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                chart1.DataSource = dt;
                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Tên giáo viên";
                chart1.ChartAreas["ChartArea1"].AxisY.Title = "Tổng số lượng sách";
                chart1.Series["Người"].XValueMember = "meo";
                chart1.Series["Người"].YValueMembers = "gau";
            }
            else if (comboBox_FilterGroup.Text.ToString() == "Giáo viên đang mượn")
            {
                int count = DGV_TKNguoi.Rows.Count;
                label_AllUser.Text = "Tổng số giáo viên đang mượn sách: " + count;
                DGV_TKNguoi.DataSource = getGroups("Select docgia_id as N'MSGV', (teacher.fname+' '+teacher.lname) as N'HỌ VÀ TÊN',count(docgia_id) as N'SỐ LƯỢNG SÁCH ĐÃ MƯỢN' " +
                    " from MUON INNER JOIN teacher on MUON.docgia_id = teacher.id GROUP BY docgia_id, teacher.fname, teacher.lname ORDER BY count(docgia_id) desc");
                setformPeople();
                SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-MKS1NQ8\SQLEXPRESS;Initial Catalog=QLTHUVIEN;Integrated Security=True");
                SqlDataAdapter ad = new SqlDataAdapter("Select (teacher.fname+' '+teacher.lname) as meo,count(docgia_id) as gau " +
                    " from MUON INNER JOIN teacher on MUON.docgia_id = teacher.id " +
                    " GROUP BY teacher.fname, teacher.lname ORDER BY count(docgia_id) desc; ", con);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                chart1.DataSource = dt;
                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Tên giáo viên";
                chart1.ChartAreas["ChartArea1"].AxisY.Title = "Tổng số lượng sách";
                chart1.Series["Người"].XValueMember = "meo";
                chart1.Series["Người"].YValueMembers = "gau";
            }

            else if (comboBox_FilterGroup.Text.ToString() == "Giáo viên")
            {
                label_AllUser.Text = "Tổng số giáo viên của hệ thống: " + exeCountByUserAuthority2();
                DGV_TKNguoi.DataSource = getGroups("SELECT teacher.donvi as N'STT', donvi.donvi_name as N'ĐƠN VỊ', COUNT(teacher.id)  as N'SỐ LƯỢNG HIỆN TẠI' FROM teacher INNER JOIN donvi ON teacher.donvi = donvi.Id GROUP BY teacher.donvi, donvi.donvi_name ORDER BY teacher.donvi ASC");
                setformPeople();
                SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-MKS1NQ8\SQLEXPRESS;Initial Catalog=QLTHUVIEN;Integrated Security=True");
                SqlDataAdapter ad = new SqlDataAdapter("SELECT donvi.donvi_name, COUNT(teacher.id) as meo FROM teacher INNER JOIN donvi ON teacher.donvi = donvi.Id GROUP BY teacher.donvi, donvi.donvi_name", con);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                chart1.DataSource = dt;
                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Tên đơn vị";
                chart1.ChartAreas["ChartArea1"].AxisY.Title = "Số lượng giáo viên";
                chart1.Series["Người"].XValueMember = "donvi_name";
                chart1.Series["Người"].YValueMembers = "meo";
            }
            else if (comboBox_FilterGroup.Text.ToString() == "Nhân viên thư viện")
            {
                label_AllUser.Text = "Tổng số nhân viên của hệ thống: " + exeCountAllLibrarian();
                DGV_TKNguoi.DataSource = getGroups("SELECT nhanvien.cv_id as N'STT', congviec.congviec_name N'CÔNG VIỆC', COUNT(id_nv) as N'SỐ LƯỢNG HIỆN TẠI' FROM nhanvien INNER JOIN congviec ON nhanvien.cv_id = congviec.congviec_id GROUP BY cv_id,congviec.congviec_name ORDER BY nhanvien.cv_id ASC");
                setformPeople();
                SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-MKS1NQ8\SQLEXPRESS;Initial Catalog=QLTHUVIEN;Integrated Security=True");
                SqlDataAdapter ad = new SqlDataAdapter("SELECT congviec.congviec_name, COUNT(id_nv) as meo FROM nhanvien INNER JOIN congviec ON nhanvien.cv_id = congviec.congviec_id GROUP BY cv_id,congviec.congviec_name", con);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                chart1.DataSource = dt;
                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Công việc";
                chart1.ChartAreas["ChartArea1"].AxisY.Title = "Số lượng nhân viên";
                chart1.Series["Người"].XValueMember = "congviec_name";
                chart1.Series["Người"].YValueMembers = "meo";

            }
            DGV_TKNguoi.AllowUserToAddRows = false;
        }
        string exeCountUser(string query) // dem so luong nguoi su dung
        {
            SqlCommand command = new SqlCommand(query, mydb.GetConnection);
            mydb.openConnection();
            string count = command.ExecuteScalar().ToString();
            mydb.closeConnection();
            return count;
        }
        public string exeCountByUserAuthority1() // dem so luong nguoi su dung dua theo chuc vu
        {
            string query = "SELECT COUNT(*) FROM std ";
            return exeCountUser(query);
        }
        public string exeCountByUserAuthority2() // dem so luong nguoi su dung dua theo chuc vu
        {
            string query = "SELECT COUNT(*) FROM teacher";
            return exeCountUser(query);
        }
        public string exeCountAllUser() // dem so luong tat ca nguoi su dung
        {
            string query = "SELECT COUNT(*) FROM teacher";
            return exeCountUser(query);
        }
        public DataTable getGroups(string query, int userid = 0) //xac dinh group cua mot user
        {
            SqlCommand command = new SqlCommand(query, mydb.GetConnection);
            if (userid != 0)
            {
                command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
            }

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }
        string exeCountLibrarian(string query) // dem so luong nhan vien
        {
            SqlCommand command = new SqlCommand(query, mydb.GetConnection);
            mydb.openConnection();
            string count = command.ExecuteScalar().ToString();
            mydb.closeConnection();
            return count;
        }
        public string exeCountByWork(string congviec) // dem so luong nhan vien theo cong viec
        {
            string query = "SELECT COUNT(*) FROM nhanvien INNER JOIN congviec ON cv_id = congviec_id WHERE congviec_name = " + congviec;
            return exeCountLibrarian(query);
        }
        public string exeCountAllLibrarian() // dem so luong tat ca nguoi su dung
        {
            string query = "SELECT COUNT(*) FROM nhanvien";
            return exeCountLibrarian(query);
        }

        private void comboBox_FilterGroup_TextChanged(object sender, EventArgs e)
        {
            reloadPeopleDataGridView();
        }
        private void setformPeople()
        {
            DGV_TKNguoi.EnableHeadersVisualStyles = false;
            DGV_TKNguoi.ColumnHeadersDefaultCellStyle.BackColor = Color.OrangeRed;
            DGV_TKNguoi.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DGV_TKNguoi.DefaultCellStyle.ForeColor = Color.Black;
            DGV_TKNguoi.ColumnHeadersDefaultCellStyle.Font = new Font("iCielBC Cubano Normal", 14);
            DGV_TKNguoi.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_TKNguoi.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_TKNguoi.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_TKNguoi.DefaultCellStyle.Font = new Font("Times New Roman", 14);
            DGV_TKNguoi.RowTemplate.Height = 30;
            DGV_TKNguoi.AllowUserToAddRows = false;
            DGV_TKNguoi.Columns[0].Width = 100;
            DGV_TKNguoi.Columns[1].Width = 230;
            DGV_TKNguoi.Columns[2].Width = 300;
            //DGV_TKNguoi.Columns[3].Width = 300;
        }
        private void setformSach()
        {
            dataGridView_StatisticBook.EnableHeadersVisualStyles = false;
            dataGridView_StatisticBook.ColumnHeadersDefaultCellStyle.BackColor = Color.OrangeRed;
            dataGridView_StatisticBook.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView_StatisticBook.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView_StatisticBook.ColumnHeadersDefaultCellStyle.Font = new Font("iCielBC Cubano Normal", 14);
            dataGridView_StatisticBook.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_StatisticBook.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_StatisticBook.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_StatisticBook.DefaultCellStyle.Font = new Font("Times New Roman", 14);
            dataGridView_StatisticBook.RowTemplate.Height = 30;
            dataGridView_StatisticBook.AllowUserToAddRows = false;
            dataGridView_StatisticBook.Columns[0].Width = 100;
            dataGridView_StatisticBook.Columns[1].Width = 230;
            dataGridView_StatisticBook.Columns[2].Width = 300;
            //DGV_TKNguoi.Columns[3].Width = 300;
        }


        void reloadBookDataGridView()
        {
            label_AllBook.Text = "Tổng số sách của thư viện: " + exeCountAllBook();

            dataGridView_StatisticBook.ReadOnly = true;

            if (comboBox_FilterBook.Text.ToString() == "Tác giả")
            {
                dataGridView_StatisticBook.DataSource = getBooks("SELECT sach.tacgia_id as N'MSTG', tacgia.tacgia_name as N'TÊN TÁC GIẢ', SUM(sach.sl) as N'SỐ LƯỢNG SÁCH'" +
                    "FROM sach INNER JOIN tacgia ON sach.tacgia_id = tacgia.tacgia_id " +
                    "GROUP BY sach.tacgia_id, tacgia.tacgia_name");
                setformSach();
                SqlConnection con1 = new SqlConnection(@"Data Source = DESKTOP-MKS1NQ8\SQLEXPRESS;Initial Catalog=QLTHUVIEN;Integrated Security=True");
                SqlDataAdapter ad1 = new SqlDataAdapter("SELECT tacgia.tacgia_name, SUM(sach.sl) as meo " +
                    "FROM sach INNER JOIN tacgia ON sach.tacgia_id = tacgia.tacgia_id " +
                    "GROUP BY tacgia.tacgia_name; ", con1);
                DataTable dt1 = new DataTable();
                ad1.Fill(dt1);
                chart2.DataSource = dt1;
                chart2.ChartAreas["ChartArea1"].AxisX.Title = "Tên tác giả";
                chart2.ChartAreas["ChartArea1"].AxisY.Title = "Số lượng sách";
                chart2.Series["Sách"].XValueMember = "tacgia_name";
                chart2.Series["Sách"].YValueMembers = "meo";
            }
            else if (comboBox_FilterBook.Text.ToString() == "Nhà xuất bản")
            {
                dataGridView_StatisticBook.DataSource = getBooks("SELECT sach.nxb_id as N'MSNXB', nxb.nxb_name as N'TÊN NHÀ XUẤT BẢN', SUM(sach.sl) as N'SỐ LƯỢNG SÁCH'" +
                    "FROM sach INNER JOIN nxb ON sach.nxb_id = nxb.nxb_id " +
                    "GROUP BY sach.nxb_id, nxb.nxb_name");
                setformSach();
                SqlConnection con1 = new SqlConnection(@"Data Source = DESKTOP-MKS1NQ8\SQLEXPRESS;Initial Catalog=QLTHUVIEN;Integrated Security=True");
                SqlDataAdapter ad1 = new SqlDataAdapter("SELECT nxb.nxb_name, SUM(sach.sl) as meo " +
                    " FROM sach INNER JOIN nxb ON sach.nxb_id = nxb.nxb_id " +
                    " GROUP BY nxb.nxb_name", con1);
                DataTable dt1 = new DataTable();
                ad1.Fill(dt1);
                chart2.DataSource = dt1;
                chart2.ChartAreas["ChartArea1"].AxisX.Title = "Tên nhà xuất bản";
                chart2.ChartAreas["ChartArea1"].AxisY.Title = "Số lượng sách";
                chart2.Series["Sách"].XValueMember = "nxb_name";
                chart2.Series["Sách"].YValueMembers = "meo";
            }
            else
            {
                dataGridView_StatisticBook.DataSource = getBooks("SELECT sach.theloai N'MSTL', theloai.theloai as N'TÊN THỂ LOẠI', SUM(sach.sl) as N'SỐ LƯỢNG SÁCH'" +
                    "FROM sach INNER JOIN theloai ON sach.theloai = theloai.id " +
                    "GROUP BY sach.theloai, theloai.theloai");
                setformSach();
                SqlConnection con1 = new SqlConnection(@"Data Source = DESKTOP-MKS1NQ8\SQLEXPRESS;Initial Catalog=QLTHUVIEN;Integrated Security=True");
                SqlDataAdapter ad1 = new SqlDataAdapter("SELECT theloai.theloai, SUM(sach.sl) as meo " +
                    " FROM sach INNER JOIN theloai ON sach.theloai = theloai.id " +
                    " GROUP BY sach.theloai, theloai.theloai", con1);
                DataTable dt1 = new DataTable();
                ad1.Fill(dt1);
                chart2.DataSource = dt1;
                chart2.ChartAreas["ChartArea1"].AxisX.Title = "Tên nhà xuất bản";
                chart2.ChartAreas["ChartArea1"].AxisY.Title = "Số lượng sách";
                chart2.Series["Sách"].XValueMember = "theloai";
                chart2.Series["Sách"].YValueMembers = "meo";
            }
            dataGridView_StatisticBook.AllowUserToAddRows = false;
        }
        private void comboBox_FilterBook_TextChanged(object sender, EventArgs e)
        {
            reloadBookDataGridView();
        }
        string exeCountBook(string query) //dem so luong sach
        {
            SqlCommand command = new SqlCommand(query, mydb.GetConnection);
            mydb.openConnection();
            string count = command.ExecuteScalar().ToString();
            mydb.closeConnection();
            return count;
        }
        public string exeCountAllBook() // dem so luong tat ca sach
        {
            string query = "SELECT SUM(sl) FROM sach";
            return exeCountBook(query);
        }
        public DataTable getBooks(string query) // lay danh sach cac quyen sach trong thu vien
        {
            SqlCommand command = new SqlCommand(query, mydb.GetConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }
    }
}

