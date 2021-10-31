using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace _WINFORM_QUẢN_LÝ_THƯ_VIỆN
{
    public class NXB
    {
        MY_DB mydb = new MY_DB();

        public bool insertnxb(int ID, string Name, string Diachi, string Phone, string Email)
        {
            SqlCommand command = new SqlCommand("INSERT INTO dbo.nxb (nxb_id, nxb_name, address, phone, email)" +
                " VALUES (@id, @name,@adrs, @phn, @em)", mydb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = ID;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = Name;
            command.Parameters.Add("@adrs", SqlDbType.NVarChar).Value = Diachi;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = Phone;
            command.Parameters.Add("@em", SqlDbType.VarChar).Value = Email;


            mydb.openConnection();
            try
            {
                if (command.ExecuteNonQuery() == 1)
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
            catch (SqlException)
            {
                return false;
            }

        }
        public bool Checknxb(int id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM nxb WHERE nxb_id = @id", mydb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
                return false;
        }
        public DataTable getnxb(SqlCommand command)
        {
            command.Connection = mydb.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool updatenxb(int ID, string Name, string Diachi, string Phone, string Email)
        {
            SqlCommand command = new SqlCommand("UPDATE nxb SET nxb_name=@name, address=@adrs, phone=@phn, email=@em WHERE nxb_id=@ID", mydb.GetConnection);
            command.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = Name;
            command.Parameters.Add("@adrs", SqlDbType.NVarChar).Value = Diachi;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = Phone;
            command.Parameters.Add("@em", SqlDbType.VarChar).Value = Email;
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
        public bool detelenxb(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM nxb WHERE nxb_id = @id", mydb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
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
    }
}
