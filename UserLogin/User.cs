using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    public class User
    {
        public System.String username
        {
            get;
            set;
        }
        public System.String password
        {
            get;
            set;
        }
        public System.String facNum
        {
            get;
            set;
        }
        public System.Int32 role
        {
            get; set;
        }
        public System.DateTime Created
        {
            get;
            set;
        }
        public System.DateTime ActiveTo
        {
            get; set;
        }
        public System.Int32 UserId { get; set; }
    }
}