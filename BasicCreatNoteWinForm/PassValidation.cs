using System.Text.RegularExpressions;

namespace BasicCreatNoteWinForm
{
    static class PassValidation
    {
        static public bool ValidationRegister(string password,string passwordRepeat)
        {
            string inputPassword       = password;
            string inputRepeatPassword = passwordRepeat;

            if (string.IsNullOrEmpty(inputPassword))
            {
                EventManagment.SetMessageBox(new Action(() => 
                                             MessageBox.Show("Password field is empty")));
                return false;
            }

            else if(!inputPassword.Equals(inputRepeatPassword))
            {
                EventManagment.SetMessageBox(new Action(() =>
                                             MessageBox.Show("Password don't match")));
                return false;
            }


            Regex hasNumber      = new Regex(@"[0-9]+");
            Regex hasUpperChar   = new Regex(@"[A-Z]+");
            Regex hasMiniMaxChar = new Regex(@".{6,12}");
            Regex hasLowerChar   = new Regex(@"[a-z]+");
            Regex hasSymbols     = new Regex(@"[!@#$%^&*]");


            if (!hasNumber.IsMatch(inputPassword))
            {
                EventManagment.SetMessageBox(new Action(() =>
                                             MessageBox.Show("The password must contain numbers")));
                return false;
            }

            else if(!hasUpperChar.IsMatch(inputPassword))
            {
                EventManagment.SetMessageBox(new Action(() =>
                                             MessageBox.Show("The password must contain upper char")));
                return false;
            }

            else if (!hasMiniMaxChar.IsMatch(inputPassword))
            {
                EventManagment.SetMessageBox(new Action(() =>
                                             MessageBox.Show("The password must be longer than 6 and shorter than 12 characters")));
                return false;
            }

            else if (!hasLowerChar.IsMatch(inputPassword))
            {
                EventManagment.SetMessageBox(new Action(() =>
                                             MessageBox.Show("The password must contain lower char")));
                return false;
            }

            else if(!hasSymbols.IsMatch(inputPassword))
            {
                EventManagment.SetMessageBox(new Action(() =>
                                             MessageBox.Show("The password must contain the following characters:!@#$%^&*")));
                return false;
            }
            return true;     
        }

        static public bool ValidationLogin(string password)
        {
            string inputPassword = password;

            if (string.IsNullOrEmpty(inputPassword))
            {
                EventManagment.SetMessageBox(new Action(() =>
                                             MessageBox.Show("Password field is empty")));
                return false;
            }

            Regex hasNumber      = new Regex(@"[0-9]+");
            Regex hasUpperChar   = new Regex(@"[A-Z]+");
            Regex hasMiniMaxChar = new Regex(@".{6,12}");
            Regex hasLowerChar   = new Regex(@"[a-z]+");
            Regex hasSymbols     = new Regex(@"[!@#$%^&*]");


            if (!hasNumber.IsMatch(inputPassword))
            {
                EventManagment.SetMessageBox(new Action(() =>
                                             MessageBox.Show("The password must contain numbers")));
                return false;
            }

            else if (!hasUpperChar.IsMatch(inputPassword))
            {
                EventManagment.SetMessageBox(new Action(() =>
                                             MessageBox.Show("The password must contain upper char")));
                return false;
            }

            else if (!hasMiniMaxChar.IsMatch(inputPassword))
            {
                EventManagment.SetMessageBox(new Action(() =>
                                             MessageBox.Show("The password must be longer than 6 and shorter than 12 characters")));
                return false;
            }

            else if (!hasLowerChar.IsMatch(inputPassword))
            {
                EventManagment.SetMessageBox(new Action(() =>
                                             MessageBox.Show("The password must contain lower char")));
                return false;
            }

            else if (!hasSymbols.IsMatch(inputPassword))
            {
                EventManagment.SetMessageBox(new Action(() =>
                                             MessageBox.Show("The password must contain the following characters:!@#$%^&*")));
                return false;
            }
            return true;
        }
    }
}
