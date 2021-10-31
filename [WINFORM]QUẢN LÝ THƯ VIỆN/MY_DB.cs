using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace _WINFORM_QUẢN_LÝ_THƯ_VIỆN
{
    class MY_DB
    {
        SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-MKS1NQ8\SQLEXPRESS;Initial Catalog=QLTHUVIEN;Integrated Security=True");

        public SqlConnection GetConnection
        {
            get { return con; }
        }

        public void openConnection()
        {
            if ((con.State == ConnectionState.Closed))
            {
                con.Open();
            }
        }

        public void closeConnection()
        {
            if ((con.State == ConnectionState.Open))
            { con.Close(); }
        }

    }
}
