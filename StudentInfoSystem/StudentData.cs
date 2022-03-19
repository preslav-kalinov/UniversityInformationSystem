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
            Student student = new Student();
            student.name = "Ivan";
            student.surname = "Todorov";
            student.lastName = "Georgiev";
            student.specialty = "Software Engeneering";
            student.educationLevel = "Bachelor";
            student.status = "Assured";
            student.facNumber = "501219025";
            student.course = 3;
            student.stream = 9;
            student.group = 36;

            return student;
        }

        public List<Student> GetTestStudents()
        {
            return TestStudents;
        }
    }
}
