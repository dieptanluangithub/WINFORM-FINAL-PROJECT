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
    public class SACH
    {
        MY_DB mydb = new MY_DB();
        public DataTable gettheloai()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM theloai", mydb.GetConnection);
            command.Connection = mydb.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }
        public DataTable gettacgia()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM tacgia", mydb.GetConnection);
            command.Connection = mydb.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }
        public DataTable getnxb()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM nxb", mydb.GetConnection);
            command.Connection = mydb.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool insertSach(int ID, string name, int theloai, int tacgia, int nxb, DateTime yxb, int sluong, int conlai)
        {
            SqlCommand command = new SqlCommand("INSERT INTO dbo.sach (id, name, theloai, tacgia_id, nxb_id, yxb, sl, con)" +
                " VALUES (@id, @name, @tl, @tg, @nxb,@yxb, @sluong, @conl)", mydb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = ID;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@tl", SqlDbType.Int).Value = theloai;
            command.Parameters.Add("@tg", SqlDbType.Int).Value = tacgia;
            command.Parameters.Add("@nxb", SqlDbType.Int).Value = nxb;
            command.Parameters.Add("@yxb", SqlDbType.DateTime).Value = yxb;
            command.Parameters.Add("@sluong", SqlDbType.Int).Value = sluong;
            command.Parameters.Add("@conl", SqlDbType.Int).Value = conlai;
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
        public bool CheckSach(int id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM sach WHERE id = @id", mydb.GetConnection);
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
        public DataTable getSach(SqlCommand command)
        {
            command.Connection = mydb.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getDSSach()
        {
            //INNER JOIN course on score.course_id = course.Id
            //score.student_id, hocsinh.Fname, hocsinh.Lname, score.course_id, course.label, score.
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.GetConnection;
            command.CommandText = ("SELECT sach.id, sach.name, sach.theloai,theloai.theloai, sach.tacgia_id, tacgia.tacgia_name, sach.nxb_id , nxb.nxb_name, sach.yxb, sach.sl, sach.con FROM sach INNER JOIN theloai on sach.theloai = theloai.id INNER JOIN tacgia on sach.tacgia_id = tacgia.tacgia_id INNER JOIN nxb on sach.nxb_id = nxb.nxb_id ORDER BY sach.id ASC");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool updateSach(int ID, string name, int theloai, int tacgia, int nxb, DateTime yxb, int sluong, int conlai)
        {
            SqlCommand command = new SqlCommand("UPDATE dbo.sach SET id=@id, name=@name, theloai=@tl, tacgia_id=@tg, nxb_id=@nxb, yxb=@yxb, sl=@sluong, con=@conl WHERE id=@id", mydb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = ID;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@tl", SqlDbType.Int).Value = theloai;
            command.Parameters.Add("@tg", SqlDbType.Int).Value = tacgia;
            command.Parameters.Add("@nxb", SqlDbType.Int).Value = nxb;
            command.Parameters.Add("@yxb", SqlDbType.DateTime).Value = yxb;
            command.Parameters.Add("@sluong", SqlDbType.Int).Value = sluong;
            command.Parameters.Add("@conl", SqlDbType.Int).Value = conlai;
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
        public bool deteleSach(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM sach WHERE id = @id", mydb.GetConnection);
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
