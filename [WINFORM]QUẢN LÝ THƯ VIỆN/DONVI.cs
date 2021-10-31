using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace _WINFORM_QUẢN_LÝ_THƯ_VIỆN
{
    public class DONVI
    {
        MY_DB mydb = new MY_DB();
        public DataTable getDonvi()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM donvi ", mydb.GetConnection);
            command.Connection = mydb.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }
    }
}
