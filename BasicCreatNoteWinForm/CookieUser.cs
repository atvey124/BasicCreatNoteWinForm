using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCreatNoteWinForm
{
    class CookieUser
    {
        private static string _userPassword;
        private static string _userLogin;


        public  string GetUserPassword() => _userPassword;


        public  string GetUserLogin() => _userLogin;


        public  void SetUserPassword(string userPassword)
        {
            _userPassword = userPassword;
        }


        public void SetUserLogin(string userLogin)
        {
            _userLogin = userLogin;
        }

    }
}
