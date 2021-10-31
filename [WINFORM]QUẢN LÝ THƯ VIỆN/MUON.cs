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
    public class MUON
    {
        SACH sach = new SACH();
        MY_DB mydb = new MY_DB();
        public DataTable gettracuu()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.GetConnection;
            command.CommandText = ("SELECT sach.id, sach.name, theloai.theloai,tacgia.tacgia_name,nxb.nxb_name FROM sach INNER JOIN theloai on sach.theloai = theloai.id INNER JOIN tacgia on sach.tacgia_id = tacgia.tacgia_id INNER JOIN nxb on sach.nxb_id = nxb.nxb_id ORDER BY sach.id ASC");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool MuonSach(int ID_user, int sID, DateTime Muon, DateTime Tra)
        {
            SqlCommand command = new SqlCommand("INSERT INTO dbo.MUON (docgia_id, sach_id, NgayMuon, NgayTra)" +
                " VALUES (@id, @sid, @muon, @tra)", mydb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = ID_user;
            command.Parameters.Add("@sid", SqlDbType.Int).Value = sID;
            command.Parameters.Add("@muon", SqlDbType.DateTime).Value = Muon;
            command.Parameters.Add("@tra", SqlDbType.DateTime).Value = Tra;
            
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
        public bool CheckDocgia(int id)
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
        public DataTable getMuonSTD()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.GetConnection;
            command.CommandText = ("SELECT MUON.docgia_id, std.fname, std.lname,MUON.sach_id, sach.name, theloai.theloai, nxb.nxb_name, " +
               " MUON.NgayMuon, MUON.NgayTra FROM MUON INNER JOIN std on MUON.docgia_id = std.id INNER JOIN sach on MUON.sach_id = sach.id INNER JOIN theloai on sach.theloai = theloai.id INNER JOIN nxb on sach.nxb_id = nxb.nxb_id");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getMuonTeacher()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.GetConnection;
            command.CommandText = ("SELECT MUON.docgia_id, teacher.fname, teacher.lname,MUON.sach_id, sach.name, theloai.theloai, nxb.nxb_name, " +
               " MUON.NgayMuon, MUON.NgayTra FROM MUON INNER JOIN teacher on MUON.docgia_id = teacher.id INNER JOIN sach on MUON.sach_id = sach.id INNER JOIN theloai on sach.theloai = theloai.id INNER JOIN nxb on sach.nxb_id = nxb.nxb_id");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool gettra(int id, int idsach)
        {
            SqlCommand command = new SqlCommand("DELETE FROM MUON WHERE docgia_id = @id AND sach_id = @sach", mydb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@sach", SqlDbType.Int).Value = idsach;
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
        public bool Checkmuon(int id, int ms)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM MUON WHERE docgia_id = @id AND MUON.sach_id = @sid", mydb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@sid", SqlDbType.Int).Value = ms;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }    
                

        }
        public bool Checksachconhayhet(int ms)
        {
            SqlCommand command = new SqlCommand("SELECT * from sach where con <> 0 AND id = @sid", mydb.GetConnection);
            command.Parameters.Add("@sid", SqlDbType.Int).Value = ms;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
