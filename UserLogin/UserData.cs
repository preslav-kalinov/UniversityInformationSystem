using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UserLogin
{
    static public class UserData
    {
        public static List<User> TestUsers
        {
            get {
                ResetTestUserData();
                return _testUsers;
            }
            set { }
        }
        private static List<User> _testUsers = new List<User>();

        static private void ResetTestUserData()
        {           
            if(!_testUsers.Any())
            {
                _testUsers.Add(AddAdminUser(1));
                _testUsers.Add(AddFirstStudentUser(4));
                _testUsers.Add(AddSecondStudentUser(4));              
            }
        }

        private static User AddAdminUser(int role)
        {
            User user = new User();
            user.username = "Preslav";
            user.password = "Abcd1234";
            user.facNum = "501219046";
            user.role = role;//UserRoles.ADMIN;
            user.Created = DateTime.MaxValue;
            return user;
        }

        private static User AddFirstStudentUser(int role)
        {
            User user1 = new User();
            user1.username = "Yordan";
            user1.password = "Abcd1234";
            user1.facNum = "501219042";
            user1.role = role;//UserRoles.STUDENT;
            user1.Created = DateTime.MaxValue;
            return user1;
        }

        private static User AddSecondStudentUser(int role)
        {
            User user2 = new User();
            user2.username = "Marin";
            user2.password = "Abcd1234";
            user2.facNum = "501219013";
            user2.role = role;//UserRoles.STUDENT;
            user2.Created = DateTime.MaxValue;
            return user2;
        }

        public static User IsUserPassCorrect(string username, string password)
        {
            User searchUsers = (from user in TestUsers
                                where username.Equals(user.username)
                                && password.Equals(user.password)
                                select user).First();
           if(searchUsers != null)
            {
                return searchUsers;
            }
            return null;
        }

        public static void SetUserActiveTo(string username, DateTime date)
        {
            foreach(User user in TestUsers)
            {
                if (username.Equals(user.username))
                {
                    Logger.LogActivity("Changing activity on " + username);
                    user.Created = date;
                    break;
                }
            }
        }

        public static void AssignUserRole(string username, UserRoles role)
        {
            foreach (User user in TestUsers)
            {
                if (username.Equals(user.username))
                {
                    Logger.LogActivity("Changing role on " + username);
                    user.role = (int)role;
                    break;
                }
            }
        }

        public static void listOfAllUsers()
        {
            foreach (User user in _testUsers)
            {
                Console.WriteLine(user.username);
            }
        }

        public static User getUser(string username)
        {
            foreach (User user in TestUsers)
            {
                if (username.Equals(user.username))
                {
                    return user;
                }
            }
            return null;
        }

        public static void CreateCertificate()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("+===================+");
            sb.AppendLine("|    CERTIFICATE    |");
            sb.AppendLine("+===================+");

            Console.WriteLine("Enter username of the student for certificate to be created: ");
            string userName = Console.ReadLine();

            Console.WriteLine("Enter studenent's specialty: ");
            string specialty = Console.ReadLine();

            Console.WriteLine("Enter last graduated student's course: ");
            string course = Console.ReadLine();

            User user = getUser(userName);

            if (user == null)
            {
                Console.WriteLine("No such user found!");
                return;
            }
            sb.AppendLine("Student N" +
                "9me: " + user.username);
            sb.AppendLine("Faculty number: " + user.facNum);
            sb.AppendLine("Student specialty: " + specialty);
            sb.AppendLine("Last graduated course: " + course);
            sb.AppendLine();

            while (true)
            {
                Console.WriteLine("Enter file name to save certificate: ");
                string fileName = Console.ReadLine();

                if (!fileName.Contains(".txt"))
                {
                    fileName += ".txt";
                }

                if(fileName != null)
                {
                    SaveCertifivate(sb.ToString(), fileName);
                    break;
                }

                Console.WriteLine("Invalid file!");
            }
        }

        private static void SaveCertifivate(string cartificate, string fileName)
        {
            if (!File.Exists(fileName))
            {
                FileStream fs = File.Create(fileName);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(cartificate);
                sw.Close();
                fs.Close();
                return;
            }

            Thread.Sleep(2000);
            File.AppendAllText(fileName, cartificate);
        }
    }
}
