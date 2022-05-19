using System;

namespace UserLogin
{
    public class Student
    {
        public String name { get; set; }
        public String surname { get; set; }
        public String lastName { get; set; }
        public String faculty { get; set; }
        public String specialty { get; set; }
        public String educationLevel { get; set; }
        public String status { get; set; }
        public String facNumber { get; set; }
        public int course { get; set; }
        public int stream { get; set; }
        public int group { get; set; }
        public String username { get; set; }
        public String password { get; set; }
        public int StudentId { get; set; }

        public Student(String name, String surname,
            String lastName, String faculty, String specialty, String educationLevel,
            String status, String facNumber, int course, int stream, int group)
        {
            this.name = name;
            this.surname = surname;
            this.lastName = lastName;
            this.faculty = faculty;
            this.specialty = specialty;
            this.educationLevel = educationLevel;
            this.status = status;
            this.facNumber = facNumber;
            this.course = course;
            this.stream = stream;
            this.group = group;
        }

    }
}