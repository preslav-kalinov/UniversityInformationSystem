using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    public class LoginValidation
    {
        private string _username { get; }
        private string _password;

        public static string username { get; }
        

        public delegate void ActionOnError(string errorMsg);

        private ActionOnError _raiseError;
        public LoginValidation(string _username, string _password, ActionOnError _raiseError)
        {
            this._username = _username;
            this._password = _password;
            this._raiseError = _raiseError;
        } 

        static public UserRoles currentUserRole { get; private set; }
        public Boolean ValidateUserInput(ref User user)
        {
            int role = 0;
            Boolean emptyUsername;
            int usernameLength = _username.Length;
            emptyUsername = _username.Equals(String.Empty);

            if (emptyUsername == true)
            {
                currentUserRole = (UserRoles)role;
                _raiseError("No username entered.");
                return false;
            }

            if (usernameLength < 5 )
            {
                currentUserRole = (UserRoles)role;
                _raiseError("Username must be at least 5 symbols.");
                return false;
            }

            Boolean emptyPassword;
            int passwordLength = _password.Length;
            emptyPassword = _password.Equals(String.Empty);

            if (emptyPassword == true)
            {
                currentUserRole = (UserRoles)role;
                _raiseError("No password entered.");
                return false;
            }

            if (passwordLength < 5)
            {
                currentUserRole = (UserRoles)role;
                _raiseError("Password must be at least 5 symbols.");
                return false;
            }          

            user = UserData.IsUserPassCorrect(_username, _password);

            if (user == null)
            {
                _raiseError("No such user found!");
                return false;
            }           
            
            currentUserRole = (UserRoles)user.role;
            Logger.LogActivity("Login successful.");
            return true;
        }
    }
}