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
    public class TEACHER
    {
        MY_DB mydb = new MY_DB();

        public bool insertteacher(int ID, string FName, string LName, DateTime BDate, string Gender, int Donvi, string Address, string Phone, string email, MemoryStream Picture)
        {
            SqlCommand command = new SqlCommand("INSERT INTO dbo.teacher (id, fname, lname, bdate, gender, donvi, address, phone, email, pic)" +
                " VALUES (@id, @fn, @ln, @bdt, @gdr,@dv, @adrs, @phn, @email, @pic)", mydb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = ID;
            command.Parameters.Add("@fn", SqlDbType.NVarChar).Value = FName;
            command.Parameters.Add("@ln", SqlDbType.NVarChar).Value = LName;
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = BDate;
            command.Parameters.Add("@gdr", SqlDbType.NVarChar).Value = Gender;
            command.Parameters.Add("@dv", SqlDbType.Int).Value = Donvi;
            command.Parameters.Add("@adrs", SqlDbType.NVarChar).Value = Address;
            command.Parameters.Add("@phn", SqlDbType.NVarChar).Value = Phone;
            command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
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
        public bool CheckTeacher(int id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM teacher WHERE id = @id", mydb.GetConnection);
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
        public bool deteleTeacher(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM teacher WHERE id = @id", mydb.GetConnection);
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
