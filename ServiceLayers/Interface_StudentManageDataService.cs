using ModelLayers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayers
{
    public interface Interface_StudentManageDataService
    {
        void Adding(Student_Data student);
        void Delete(Student_Data student);
        void Update(Student_Data student);
        List<Student_Data> GetAllStudents();
    }
}
