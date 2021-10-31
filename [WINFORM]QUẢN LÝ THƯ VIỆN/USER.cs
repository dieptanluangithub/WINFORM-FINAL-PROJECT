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
    public class USER
    {
        MY_DB mydb = new MY_DB();
        public bool insertAccount(string username, string password, string quyen)
        {
            SqlCommand command = new SqlCommand("INSERT INTO dbo.ACCOUNT (username, password, quyen)" +
                " VALUES (@User, @Pass, @Quyen)", mydb.GetConnection);
            command.Parameters.Add("@User", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = password;
            command.Parameters.Add("@Quyen", SqlDbType.VarChar).Value = quyen;
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
        public bool updateAccount(string username, string password, string quyen)
        {
            SqlCommand command = new SqlCommand("UPDATE dbo.ACCOUNT SET username = @User, password = @Pass, quyen= @Quyen WHERE username = @User", mydb.GetConnection);
            command.Parameters.Add("@User", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = password;
            command.Parameters.Add("@Quyen", SqlDbType.VarChar).Value = quyen;
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
        public bool deteleUser(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM dbo.ACCOUNT WHERE username = @User", mydb.GetConnection);
            command.Parameters.Add("@User", SqlDbType.Int).Value = id;
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
        public bool CheckIDUser(string uname)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM ACCOUNT WHERE username = @uname", mydb.GetConnection);
            command.Parameters.Add("@uname", SqlDbType.VarChar).Value = uname;

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
        public DataTable getContact(SqlCommand command)
        {
            command.Connection = mydb.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool CheckIDUserThemmoi(string uname, string passcu)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM ACCOUNT WHERE username = @uname AND password = @Pass", mydb.GetConnection);
            command.Parameters.Add("@uname", SqlDbType.VarChar).Value = uname;
            command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = passcu;
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
    }
}
