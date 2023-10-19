using System;
using System.Linq;

namespace BookStoreLIB
{
    public class UserData
    {
        public int UserID { set; get; }

        public string LoginName { set; get; }

        public string Password { set; get; }

        public Boolean accurate { set; get; }

        public Boolean LogIn(string loginName, string passWord)
        {
            var dbUser = new DALUserInfo();
            UserID = dbUser.UserCheck(loginName);
            if (UserID < 0)
                return false;

            if (!passReqs(passWord))
                return false;

            bool pass;
            pass = dbUser.LogIn(UserID, passWord);
            if (pass)
            {
                LoginName = loginName;
                Password = passWord;
                return true;
            }
            else
            {
                return false;
            }

        }
        public Boolean passReqs(string Password)
        {
            if (Password.Length > 5 && Password.Any(char.IsDigit) && Password.All(char.IsLetterOrDigit) && ((Password[0] >= 65 && Password[0] <= 90) || (Password[0] >= 97 && Password[0] <= 122)))
                return true;
            else
            {
                this.accurate = false;
                return false;
            }
        }
    }
}