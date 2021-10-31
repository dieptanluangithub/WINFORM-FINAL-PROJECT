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
    public class NHANVIEN
    {
        MY_DB mydb = new MY_DB();
        public bool insertnhanvien(int ID, string FName, string LName, DateTime BDate, string Gender, int Congviec, string Address, string Phone, string email, MemoryStream Picture)
        {
            SqlCommand command = new SqlCommand("INSERT INTO dbo.nhanvien (id_nv, fn_nv,ln_nv, bdate_nv, gender_nv, cv_id, address_nv, phone_nv, email_nv, pic_nv)" +
                " VALUES (@id, @fn, @ln, @bdt, @gdr,@dv, @adrs, @phn, @email, @pic)", mydb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = ID;
            command.Parameters.Add("@fn", SqlDbType.NVarChar).Value = FName;
            command.Parameters.Add("@ln", SqlDbType.NVarChar).Value = LName;
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = BDate;
            command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = Gender;
            command.Parameters.Add("@dv", SqlDbType.Int).Value = Congviec;
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
        public bool updateNHANVIEN(int ID, string FName, string LName, DateTime BDate, string Gender, int Congviec, string Address, string Phone, string email, MemoryStream Picture)
        {
            SqlCommand command = new SqlCommand("UPDATE nhanvien SET id_nv=@id, fn_nv=@fn,ln_nv=@ln, bdate_nv=@bdt, gender_nv=@gdr, cv_id=@dv, address_nv=@adrs, phone_nv=@phn, email_nv=@email, pic_nv=@pic WHERE id_nv=@id", mydb.GetConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = ID;
            command.Parameters.Add("@fn", SqlDbType.NVarChar).Value = FName;
            command.Parameters.Add("@ln", SqlDbType.NVarChar).Value = LName;
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = BDate;
            command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = Gender;
            command.Parameters.Add("@dv", SqlDbType.Int).Value = Congviec;
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
        public bool deteleNhanvien(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM nhanvien WHERE id_nv=@id", mydb.GetConnection);
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
        public bool CheckNhanvien(int id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM nhanvien WHERE id_nv = @id", mydb.GetConnection);
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
        public DataTable getCongviec()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM congviec ", mydb.GetConnection);
            command.Connection = mydb.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }
        public DataTable getNhanvien(SqlCommand command)
        {
            command.Connection = mydb.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
