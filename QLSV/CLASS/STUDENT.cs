using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace QLSV.OOP
{
    internal class STUDENT
    {
        MyDB mydb = new MyDB();

        public bool InsertStudent(int id, string fname, string lname, DateTime bdate,
            string gender, string phone, string address, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("INSERT INTO std (id, fname, lname, bdate, gender, phone, address, picture)" +
                " VALUES (@id,@fn, @ln, @bdt, @gdr, @phn, @adrs, @pic)", mydb.getConnection);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@fn", fname);
            command.Parameters.AddWithValue("@ln", lname);
            command.Parameters.AddWithValue("@bdt", bdate);
            command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
            command.Parameters.AddWithValue("@phn",phone);
            command.Parameters.AddWithValue("@adrs", address);
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

            mydb.openConnection();
            if(command.ExecuteNonQuery() == 1) 
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

        public DataTable getStudents(SqlCommand commmand)
        {
            commmand.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(commmand);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool updateStudent(int id, string fname, string lname, DateTime bdate,
            string gender, string phone, string address, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("UPDATE std SET fname = @fn, lname = @ln, bdate = @bdt, gender = @gdr" +
                ", phone = @phn, address  = @adrs, picture = @pic WHERE id = @ID", mydb.getConnection);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@fn", fname);
            command.Parameters.AddWithValue("@ln", lname);
            command.Parameters.AddWithValue("@bdt", bdate);
            command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
            command.Parameters.AddWithValue("@phn", phone);
            command.Parameters.AddWithValue("@adrs", address);
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

            mydb.openConnection();
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
        public bool deleteStudent(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM std WHERE id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            mydb.openConnection();
            if(command.ExecuteNonQuery() == 1)
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
