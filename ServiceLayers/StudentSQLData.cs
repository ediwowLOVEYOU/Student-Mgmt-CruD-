using Microsoft.Data.SqlClient;
using ModelLayers;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayers
{
    public class StudentSQLData : Interface_StudentManageDataService
    {
        private string connectionString = "Data Source=Loyalty\\SQLEXPRESS;Initial Catalog=StudentMgmtDB; Integrated Security = True; TrustServerCertificate=True;";
        private SqlConnection sqlConnection;

        public StudentSQLData()
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public void Adding(Student_Data student)
        {
            var sql = "INSERT INTO SQL_Tables_Students VALUES (@StudentID, @StudentName, @StudentAge)";
            SqlCommand Commando = new SqlCommand(sql, sqlConnection);
            Commando.Parameters.AddWithValue("@StudentID", student.StudentID);
            Commando.Parameters.AddWithValue("@StudentName", student.StudentName);
            Commando.Parameters.AddWithValue("@StudentAge", student.StudentAge);
            sqlConnection.Open();
            Commando.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public List<Student_Data> GetAllStudents()
        {
            var sql = "SELECT StudentID, StudentName, StudentAge FROM SQL_Tables_Students";
            SqlCommand Commando = new SqlCommand(sql, sqlConnection);
            sqlConnection.Open();
            SqlDataReader reader = Commando.ExecuteReader();
            var SQL_Tables_Students = new List<Student_Data>();
            while (reader.Read())
                {
                SQL_Tables_Students.Add(new Student_Data
                {
                    StudentID = (int)reader["StudentID"],
                    StudentName = reader["StudentName"].ToString(),
                    StudentAge = (int)reader["StudentAge"]
                });

            }
            sqlConnection.Close();
            return SQL_Tables_Students;
        }

        public void Delete(Student_Data student)
        {
            var sql = "DELETE FROM SQL_Tables_Students WHERE StudentID = @StudentID";
            SqlCommand Commando = new SqlCommand(sql, sqlConnection);
            Commando.Parameters.AddWithValue("@StudentID", student.StudentID);
            sqlConnection.Open();
            Commando.ExecuteNonQuery();
            sqlConnection.Close();

        }

        public void Update(Student_Data student)
        {
            var sql = "UPDATE SQL_Tables_Students SET StudentName=@StudentName, " +
                      "StudentAge=@StudentAge WHERE StudentID=@StudentID";
            SqlCommand Commando = new SqlCommand(sql, sqlConnection);
            Commando.Parameters.AddWithValue("@StudentName", student.StudentName);
            Commando.Parameters.AddWithValue("@StudentAge", student.StudentAge);
            Commando.Parameters.AddWithValue("@StudentID", student.StudentID);
            sqlConnection.Open();
            Commando.ExecuteNonQuery();
            sqlConnection.Close();
        }

    }
}