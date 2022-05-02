using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    public class StudentData
    {
        public static List<Student> TestStudents
        { 
            get
            {
                AddStudentInList();
                return _testStudent;
            } 
            set { }         
        }

        private static List<Student> _testStudent = new List<Student>();

        static private void AddStudentInList()
        {
            if (!_testStudent.Any())
            {
                _testStudent.Add(AddStudent());
            }
        }

        private static Student AddStudent()
        {
            Student student = new Student("Ivan", "Todorov", "Georgiev", "FCST", "Software Engeneering",
               "Bachelor", "Assured", "501219025", 3, 9, 36);
            student.username = "iv4o00";
            student.password = "Abcd1234";

            return student;
        }

        public List<Student> GetTestStudents()
        {
            return TestStudents;
        }
    }
}
