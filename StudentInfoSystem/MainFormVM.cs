using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    class MainFormVM
    {
        private Student _student;
        public Student Student
        {
            get
            {
                return _student;
            }
            set
            {
                if (_student == null)
                {
                    _student = value;
                }
            }
        }
    }
}
