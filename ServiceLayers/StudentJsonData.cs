using ModelLayers;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace DataLayers
{

        public class StudentJsonData : Interface_StudentManageDataService
    {
        private string filePath = "SQL_Tables_Students.json";

        public List<Student_Data> GetAllStudents()
            {
                if (!File.Exists(filePath))
                    return new List<Student_Data>();

                var json = File.ReadAllText(filePath);

                return JsonSerializer.Deserialize<List<Student_Data>>(json)
                   ?? new List<Student_Data>();
            }
            public void Adding(Student_Data student)
            {
                var SQL_Tables_Students = GetAllStudents();
                SQL_Tables_Students.Add(student);

                string json = JsonSerializer.Serialize(SQL_Tables_Students);
                File.WriteAllText(filePath, json);
            }
            public void Delete(Student_Data student)
            {
                var SQL_Tables_Students = GetAllStudents();
                SQL_Tables_Students.RemoveAll(b => b.StudentID == student.StudentID);

                string json = JsonSerializer.Serialize(SQL_Tables_Students);
                File.WriteAllText(filePath, json);
            }
            public void Update(Student_Data updatedStudent)
            {
                var SQL_Tables_Students = GetAllStudents();

                var student = SQL_Tables_Students.FirstOrDefault(a => a.StudentID == updatedStudent.StudentID);

                if (student != null)
                {
                    student.StudentName = updatedStudent.StudentName;
                    student.StudentAge = updatedStudent.StudentAge;
                }

                string json = JsonSerializer.Serialize(SQL_Tables_Students);
                File.WriteAllText(filePath, json);
            }
        }
    }