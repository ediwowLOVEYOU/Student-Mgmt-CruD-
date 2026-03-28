using ModelLayers;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace DataLayers
{
    public class StudentJsonData
    {
        private string filePath = "students.json";

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
               var students = GetAllStudents();
                 students.Add(student);

              string json = JsonSerializer.Serialize(students);
             File.WriteAllText(filePath, json);
        }
        public void Delete(Student_Data student)
        {
              var students = GetAllStudents();
             students.RemoveAll(s => s.StudenID == student.StudenID);

                string json = JsonSerializer.Serialize(students);
             File.WriteAllText(filePath, json);
        }
        public void Update(Student_Data updatedStudent)
        {
              var students = GetAllStudents();

             var student = students.FirstOrDefault(s => s.StudenID == updatedStudent.StudenID);

              if (student != null)
              {
                  student.StudentName = updatedStudent.StudentName;
                student.StudentAge = updatedStudent.StudentAge;
              }

            string json = JsonSerializer.Serialize(students);
             File.WriteAllText(filePath, json);
        }
    }
}