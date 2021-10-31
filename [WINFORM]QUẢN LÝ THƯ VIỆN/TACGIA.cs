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
    public class TACGIA
    {
        MY_DB mydb = new MY_DB();

        public bool inserttacgia(int ID, string Name, DateTime BDate, string Quequan)
        {
            SqlCommand command = new SqlCommand("INSERT INTO dbo.tacgia (tacgia_id, tacgia_name, address, Bdate)" +
                " VALUES (@id, @name,@adrs, @bdt)", mydb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = ID;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = Name;
            command.Parameters.Add("@adrs", SqlDbType.NVarChar).Value = Quequan;
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = BDate;

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
        public bool CheckTacgia(int id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM tacgia WHERE tacgia_id = @id", mydb.GetConnection);
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
        public DataTable getTacgia(SqlCommand command)
        {
            command.Connection = mydb.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool updateTacgia(int ID, string Name, DateTime BDate, string Quequan)
        {
            SqlCommand command = new SqlCommand("UPDATE tacgia SET tacgia_name=@name, Bdate=@bdt, address=@que WHERE tacgia_id=@ID", mydb.GetConnection);
            command.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = Name;
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = BDate;
            command.Parameters.Add("@que", SqlDbType.NVarChar).Value = Quequan;
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
        public bool deteleTacgia(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM tacgia WHERE tacgia_id = @id", mydb.GetConnection);
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
