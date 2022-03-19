using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    public class User
    {
        public String username { get; set; }
        public String password { get; set; }
        public String facNum { get; set; }
        public int role { get; set; }

        public DateTime Created;

    }
}