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
    public class STUDENT
    {
        MY_DB mydb = new MY_DB();
        public bool insertStd(int ID, string FName, string LName, DateTime BDate, string Gender,int Donvi, string Address, string Phone, string email, MemoryStream Picture)
        {
            SqlCommand command = new SqlCommand("INSERT INTO dbo.std (id, fname,lname, bdate, gender, donvi, address, phone, email, pic)" +
                " VALUES (@id, @fn, @ln, @bdt, @gdr,@dv, @adrs, @phn, @email, @pic)", mydb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = ID;
            command.Parameters.Add("@fn", SqlDbType.NVarChar).Value = FName;
            command.Parameters.Add("@ln", SqlDbType.NVarChar).Value = LName;
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = BDate;
            command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = Gender;
            command.Parameters.Add("@dv", SqlDbType.Int).Value = Donvi;
            command.Parameters.Add("@adrs", SqlDbType.NVarChar).Value = Address;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = Phone;
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = Picture.ToArray();
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
        public bool CheckStudent(int id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM std WHERE id = @id", mydb.GetConnection);
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
        public DataTable getContact(SqlCommand command)
        {
            command.Connection = mydb.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool updateStudent(int ID, string FName, string LName, DateTime BDate, string Gender, int Donvi, string Address, string Phone, string email, MemoryStream Picture)
        {
            SqlCommand command = new SqlCommand("UPDATE std SET id=@id, fname=@fn,lname=@ln, bdate=@bdt, gender=@gdr, donvi=@dv, address=@adrs, phone=@phn, email=@email, pic=@pic WHERE id=@id", mydb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = ID;
            command.Parameters.Add("@fn", SqlDbType.NVarChar).Value = FName;
            command.Parameters.Add("@ln", SqlDbType.NVarChar).Value = LName;
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = BDate;
            command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = Gender;
            command.Parameters.Add("@dv", SqlDbType.Int).Value = Donvi;
            command.Parameters.Add("@adrs", SqlDbType.NVarChar).Value = Address;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = Phone;
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = Picture.ToArray();
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
        public bool deteleStudent(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM std WHERE id = @id", mydb.GetConnection);
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
