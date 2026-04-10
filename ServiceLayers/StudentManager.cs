using ModelLayers;
using System.Collections.Generic;
namespace DataLayers
{

    public class StudentData : Interface_StudentManageDataService
    {
        private List<Student_Data> ListOfStudent = new List<Student_Data>();

        public void Adding(Student_Data student)
        {
            ListOfStudent.Add(student);
        }

        public List<Student_Data> GetAllStudents()
        {
            return ListOfStudent;
        }
        public void Delete(Student_Data student)
        {
            ListOfStudent.Remove(student);
        }
        public void Update(Student_Data student)
        {
            var existing = ListOfStudent
                .FirstOrDefault(s => s.StudentID == student.StudentID);
            if (existing != null)
            {
                existing.StudentName = student.StudentName;
                existing.StudentAge = student.StudentAge;

            }


        }
    }
}