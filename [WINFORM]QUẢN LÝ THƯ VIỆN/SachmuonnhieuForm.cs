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
using System.Windows.Forms.DataVisualization.Charting;

namespace _WINFORM_QUẢN_LÝ_THƯ_VIỆN
{
    public partial class SachmuonnhieuForm : Form
    {
        MY_DB mydb = new MY_DB();
        public SachmuonnhieuForm()
        {
            InitializeComponent();
        }

        private void SachmuonnhieuForm_Load(object sender, EventArgs e)
        {
            DGV_TKSMN.DataSource = getGroups("Select smn.smn_id as N'MÃ SÁCH', sach.name as N'TÊN SÁCH',tacgia.tacgia_name as N'TÊN TÁC GIẢ', nxb.nxb_name as N'TÊN NHÀ XUẤT BẢN', smn.smn_sl as N'TỔNG SỐ LƯỢT MƯỢN'" +
                " FROM smn INNER JOIN sach ON smn.smn_id = sach.id INNER JOIN nxb ON sach.nxb_id = nxb.nxb_id INNER JOIN tacgia ON sach.tacgia_id = tacgia.tacgia_id" +
                " WHERE smn.smn_sl >= 1" +
                " GROUP BY smn.smn_id, sach.name, tacgia.tacgia_name, nxb.nxb_name, smn.smn_sl  ORDER BY smn.smn_sl desc");
            setformPeople();

            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-MKS1NQ8\SQLEXPRESS;Initial Catalog=QLTHUVIEN;Integrated Security=True");
            SqlDataAdapter ad = new SqlDataAdapter("Select sach.name, smn.smn_sl" +
                " FROM smn INNER JOIN sach ON smn.smn_id = sach.id " +
                " WHERE smn.smn_sl >= 1 " +
                " GROUP BY smn.smn_id, sach.name, smn.smn_sl  ORDER BY smn.smn_sl desc; ", con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            chart1.DataSource = dt;
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Tên sách";
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Số lượt mượn";
            chart1.Series["Sách"].XValueMember = "name";
            chart1.Series["Sách"].YValueMembers = "smn_sl";



        }
        

        private void setformPeople()
        {
            DGV_TKSMN.EnableHeadersVisualStyles = false;
            DGV_TKSMN.ColumnHeadersDefaultCellStyle.BackColor = Color.OrangeRed;
            DGV_TKSMN.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DGV_TKSMN.DefaultCellStyle.ForeColor = Color.Black;
            DGV_TKSMN.ColumnHeadersDefaultCellStyle.Font = new Font("iCielBC Cubano Normal", 14);
            DGV_TKSMN.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_TKSMN.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_TKSMN.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_TKSMN.DefaultCellStyle.Font = new Font("Times New Roman", 14);
            DGV_TKSMN.RowTemplate.Height = 40;
            DGV_TKSMN.AllowUserToAddRows = false;
            DGV_TKSMN.Columns[0].Width = 150;
            DGV_TKSMN.Columns[1].Width = 250;
            DGV_TKSMN.Columns[2].Width = 200;
            DGV_TKSMN.Columns[3].Width = 200;
            DGV_TKSMN.Columns[4].Width = 250;
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

        

        private void bt_tron_Click(object sender, EventArgs e)
        {
            
        }
    }
}
