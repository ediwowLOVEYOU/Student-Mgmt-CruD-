using ModelLayer;
using System.Collections.Generic;
namespace ServiceLayer
{
     
    public class StudentManager
    {
        private List<Student_Data> ListOfStudent = new List<Student_Data>();

        public void Add(Student_Data student)
        {   
            ListOfStudent.Add(student);
        }

        public List<Student_Data> GetAllStudents()
        {
            return ListOfStudent;
        }
 
    }


}