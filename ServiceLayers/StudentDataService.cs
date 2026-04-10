using ModelLayers;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayers
{
    public class StudentDataService
    {
        Interface_StudentManageDataService _DataService; 
    
    public StudentDataService (Interface_StudentManageDataService DataService)
        {
            _DataService = DataService;
        }
        public void Adding(Student_Data student)
        {
            _DataService.Adding(student);
        }
        public void Delete(Student_Data student)
        {
            _DataService.Delete(student);
        }
        public List<Student_Data> GetAllStudents()
        {
            return _DataService.GetAllStudents();
        }
        public void Update(Student_Data student)
        {
            _DataService.Update(student);
        }
    
        
    
    }
}
