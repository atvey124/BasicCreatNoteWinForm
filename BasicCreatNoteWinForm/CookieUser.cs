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
        private static List<int> _userEnjoy   = new List<int>();
        private static List<int> _userUnenjoy = new List<int>();

        public string GetUserPassword() => _userPassword;

        public string GetUserLogin() => _userLogin;

        public List<int> GetUserEnjoy()
        {
            return _userEnjoy;
        }

        public void AddUserEnjoy(int id_note)
        {
            _userEnjoy.Add(id_note);
        }

        public void DeleteUserEnjoy(int id_note)
        {
            _userEnjoy.RemoveAll(id => id == id_note);
        }

        public List<int> GetUserUnenjoy()
        {
            return _userUnenjoy;
        }

        public void AddUserUnenjoy(int id_note)
        {
            _userUnenjoy.Add(id_note);
        }

        public void DeleteUserUnenjoy(int id_note)
        {
            _userUnenjoy.RemoveAll(id => id == id_note);
        }

        public void SetUserPassword(string userPassword)
        {
            _userPassword = userPassword;
        }

        public void SetUserLogin(string userLogin)
        {
            _userLogin = userLogin;
        }

    }
}
