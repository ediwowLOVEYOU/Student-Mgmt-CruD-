using DataLayers;
using ModelLayers;
using System.Linq;

namespace PUPSIS_AppServiceLayers
{
    public class StudentManagerBS
    {
        private StudentJsonData data = new StudentJsonData();
        public bool Adding(Student_Data student)
        {
            var exists = data.GetAllStudents()
                .FirstOrDefault(s => s.StudenID == student.StudenID);

                 if (exists != null)
                return false;
            data.Adding(student);
            return true;
        }
        public bool Update(int id, int age, string newName, int newAge)
        {
            var student = data.GetAllStudents()
                .FirstOrDefault(s => s.StudenID == id && s.StudentAge == age);
                    
              if (student == null)
                return false;

            student.StudentName = newName;
             student.StudentAge = newAge;
            return true;
        }
        public bool HasStudents()
        {

            return data.GetAllStudents().Any();
        }
        public List<Student_Data> GetAllStudents()
        {
            return data.GetAllStudents();
        }

        public bool Delete(int id)
        {
            var student = data.GetAllStudents()
                .FirstOrDefault(s => s.StudenID == id);

            if (student == null)
                  return false;

            data.Delete(student);
            return true;
        }
    }
}