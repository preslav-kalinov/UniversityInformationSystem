using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    class Program
    {
        public delegate void ErrorProcessing(string errorMsg);

        public static void RaiseErrorMsg(string message)
        {
            Console.WriteLine("!!!" + message + "!!!");
        }
        static void Main(string[] args)
        {
            ErrorProcessing errorProcessing = new ErrorProcessing(RaiseErrorMsg);
            Console.WriteLine("Enter username: ");
            string username = Console.ReadLine();

            Console.WriteLine("Enter password: ");
            string password = Console.ReadLine();

            LoginValidation loginValidation = new LoginValidation(username, password, RaiseErrorMsg);

            User newUser = null;
            bool registered = loginValidation.ValidateUserInput(ref newUser);

            if (registered)
            {
                int userRole = (int)LoginValidation.currentUserRole;
                switch (userRole)
                {
                    case 1:
                        Console.WriteLine("Admin user");
                        printCredentials(newUser);
                        Console.WriteLine(LoginValidation.currentUserRole);
                        AdminRights();
                        break;
                    case 2:
                        Console.WriteLine("Inspector user");
                        printCredentials(newUser);
                        Console.WriteLine(LoginValidation.currentUserRole);
                        break;
                    case 3:
                        Console.WriteLine("Professor user");
                        printCredentials(newUser);
                        Console.WriteLine(LoginValidation.currentUserRole);
                        break;
                    case 4:
                        Console.WriteLine("Student user");
                        printCredentials(newUser);
                        Console.WriteLine(LoginValidation.currentUserRole);
                        break;
                }              
            }
            Console.WriteLine(LoginValidation.currentUserRole);
        }

        public static void printCredentials(User newUser)
        {
            Console.WriteLine("Username: " + newUser.username);
            Console.WriteLine("Password: " + newUser.password);
            Console.WriteLine("Faculty number: " + newUser.facNum);
            Console.WriteLine("Role: " + newUser.role);
        }

        public static void AdminRights()
        {
            StringBuilder sb = new StringBuilder();
            int command = int.MinValue;
            while (command != 0)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("0: Exit.");
                Console.WriteLine("1: Change user role.");
                Console.WriteLine("2: Change user activity.");
                Console.WriteLine("3: List of all users.");
                Console.WriteLine("4: List of all logs.");
                Console.WriteLine("5: List of all current logs.");               
                Console.WriteLine("6: Get the number of all log.");
                Console.WriteLine("7: Get the oldest log.");
                Console.WriteLine("8: Get certificate.");

                command = int.Parse(Console.ReadLine());

                Console.WriteLine("");

                switch (command)
                {
                    case 0:
                        break;
                    case 1:
                        Console.WriteLine("Enter username and new role");
                        string username = Console.ReadLine();
                        int role = int.Parse(Console.ReadLine());
                        UserData.AssignUserRole(username, (UserRoles)role);
                        Console.WriteLine("");
                        break;
                    case 2:
                        Console.WriteLine("Enter username and new date");
                        username = Console.ReadLine();
                        DateTime date = DateTime.Parse(Console.ReadLine());
                        UserData.SetUserActiveTo(username, date);
                        Console.WriteLine("");
                        break;
                    case 3:
                        UserData.listOfAllUsers();
                        Console.WriteLine("");
                        break;
                    case 4:
                        Logger.LogVisualization();
                        IEnumerable<string> allLogLines =
                            Logger.GetLogVisualization();
                        foreach(string line in allLogLines)
                        {
                            Console.WriteLine(line);
                        }
                        Console.WriteLine("");
                        break;
                    case 5:
                        Console.WriteLine("Enter filter for the log if you wish: ");
                        string logFilter = Console.ReadLine();
                        IEnumerable<string> currentActs = 
                            Logger.GetCurrentLogVisualization(logFilter);
                        foreach (string line in currentActs)
                        {
                            sb.Append(line);
                        }
                        Console.WriteLine(sb.ToString());
                        Console.WriteLine("");
                        break;
                    case 6:
                        Logger.LogCounter();
                        Console.WriteLine("");
                        break;
                    case 7:
                        Logger.showOldestLog();
                        Console.WriteLine("");
                        break;
                    case 8:
                        UserData.CreateCertificate();
                        Console.WriteLine("");
                        break;
                    default:
                        Console.WriteLine("Wrong choice");
                        Console.WriteLine("");
                        break;
                }
            }
        }
    }
}