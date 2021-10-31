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
    public class CHOMUON
    {
        MY_DB mydb = new MY_DB();
        public bool insertChoMuonSach(int ID, string sID, string name, string tl, string tg, string nxb, DateTime yxb, DateTime dcm, int sl)
        {
            SqlCommand command = new SqlCommand("INSERT INTO dbo.CHOMUON (ngcho_id, schomuon, name_cm, theloai,tacgia,nxb, yxb, date_cm, sl_cm)" +
                " VALUES (@mid, @sid, @name, @tl, @tg, @nxb, @yxb, @dcm, @sl)", mydb.GetConnection);
            command.Parameters.Add("@mid", SqlDbType.Int).Value = ID;
            command.Parameters.Add("@sid", SqlDbType.NVarChar).Value = sID;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@tl", SqlDbType.NVarChar).Value = tl;
            command.Parameters.Add("@tg", SqlDbType.NVarChar).Value = tg;
            command.Parameters.Add("@nxb", SqlDbType.NVarChar).Value = nxb;
            command.Parameters.Add("@yxb", SqlDbType.DateTime).Value = yxb;
            command.Parameters.Add("@dcm", SqlDbType.DateTime).Value = dcm;
            command.Parameters.Add("@sl", SqlDbType.Int).Value = sl;
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
        public bool CheckGiangvien(int id)
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
        public DataTable getchomuonsach()
        {
            
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.GetConnection;
            command.CommandText = ("SELECT CHOMUON.schomuon, CHOMUON.name_cm, CHOMUON.theloai, CHOMUON.tacgia, CHOMUON.nxb, CHOMUON.yxb, (fname +' '+ lname) AS hoten,CHOMUON.date_cm, CHOMUON.sl_cm FROM CHOMUON INNER JOIN teacher on CHOMUON.ngcho_id = teacher.id ORDER BY CHOMUON.schomuon ASC");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        
    }
}
