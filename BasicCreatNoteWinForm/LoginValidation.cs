using System.Text.RegularExpressions;

namespace BasicCreatNoteWinForm
{
    class LoginValidation : IValidations
    {
        public bool Validation(string textToCheckValid)
        {
            string inputLogin = textToCheckValid;

            if (string.IsNullOrEmpty(inputLogin))
            {
                EventManagment.SetMessageBox(new Action(() =>
                                             MessageBox.Show("Login field is empty")));
                return false;
            }


            Regex hasNumber = new Regex(@"[0-9]+");
            Regex hasUpperChar = new Regex(@"[A-Z]+");
            Regex hasMiniMaxChar = new Regex(@".{6,12}");
            Regex hasLowerChar = new Regex(@"[a-z]+");


            if (!hasNumber.IsMatch(inputLogin))
            {
                EventManagment.SetMessageBox(new Action(() =>
                                             MessageBox.Show("The login must contain numbers")));
                return false;
            }

            else if (!hasUpperChar.IsMatch(inputLogin))
            {
                EventManagment.SetMessageBox(new Action(() =>
                                             MessageBox.Show("The login must contain upper char")));
                return false;
            }

            else if (!hasMiniMaxChar.IsMatch(inputLogin))
            {
                EventManagment.SetMessageBox(new Action(() =>
                                             MessageBox.Show("The login must be longer than 6 and shorter than 12 characters")));
                return false;
            }

            else if (!hasLowerChar.IsMatch(inputLogin))
            {
                EventManagment.SetMessageBox(new Action(() =>
                                             MessageBox.Show("The login must contain lower char")));
                return false;
            }

            return true;
        }
    }
}
