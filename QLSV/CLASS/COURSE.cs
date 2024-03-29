using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Emit;

namespace QLSV
{

    internal class COURSE
    {
        MyDB mydb = new MyDB();
        public bool insertCourse(int id, string courseName, int hoursNumber, string description)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Course(Id, label, period, description) VALUES (@id, @name, @hrs, @descr)", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = courseName;
            cmd.Parameters.Add("@hrs", SqlDbType.Int).Value = hoursNumber;
            cmd.Parameters.Add("@descr", SqlDbType.Text).Value = description;

            mydb.openConnection();

            if ((cmd.ExecuteNonQuery() == 1))
                return true;
            return false;
        }
        public bool updateCourse(int id, string courseName, int hoursNumber, string description)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Course SET label = @name, period = @hrs, description = @descr WHERE Id = @id", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = courseName;
            cmd.Parameters.Add("@hrs", SqlDbType.Int).Value = hoursNumber;
            cmd.Parameters.Add("@descr", SqlDbType.Text).Value = description;

            mydb.openConnection();

            if ((cmd.ExecuteNonQuery() == 1))
                return true;
            return false;
        }
        public bool deleteCourse(int id, string courseName, int hoursNumber, string description)
        {
            SqlCommand cmd = new SqlCommand("DELETE Course WHERE Id = @id", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

            mydb.openConnection();

            if ((cmd.ExecuteNonQuery() == 1))
                return true;
            return false;
        }
        public bool deleteCourse(int id)
        {
            SqlCommand command = new SqlCommand("Delete from course where Id = @id", mydb.getConnection);
            command.Parameters.AddWithValue("@id", id);
            mydb.openConnection();
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                return true;
            }
            else
            { 
                return false; 
            }
        }
        // tim course trung ten
        public bool checkCourseName(string courseName, int courseId = 0)
        {
            // id <> @cID de phan biet xem co ton tai khong, chi la parameter
            SqlCommand command = new SqlCommand("SELECT * FROM Course WHERE label=@name And Id <> @id", mydb.getConnection);
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = courseName; 
            command.Parameters.Add("@id", SqlDbType.Int).Value = courseId;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if ((table.Rows.Count > 0))
            {
                // neu phat hien co 1 dong ton tai trung ten
                return false;
            }
            else
            {
                return true;
            }
        }
        public DataTable getALLCourse()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Course", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        
    }
}
