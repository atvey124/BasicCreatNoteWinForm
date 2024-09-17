using System.Text.RegularExpressions;

namespace BasicCreatNoteWinForm
{
    class NoteValidation : IValidations
    {
        public bool Validation(string textToCheckValid)
        {
            string inputText = textToCheckValid;

            if (string.IsNullOrEmpty(inputText))
            {
                EventManagment.SetMessageBox(new Action(() =>
                                             MessageBox.Show("Note field is empty")));
                return false;
            }


            Regex hasUpperChar = new Regex(@"[A-Z]+");
            Regex hasMiniMaxChar = new Regex(@".{20,500}");
            Regex hasLowerChar = new Regex(@"[a-z]+");


            if (!hasUpperChar.IsMatch(inputText))
            {
                EventManagment.SetMessageBox(new Action(() =>
                                             MessageBox.Show("The note must contain upper char")));
                return false;
            }

            else if (!hasMiniMaxChar.IsMatch(inputText))
            {
                EventManagment.SetMessageBox(new Action(() =>
                                             MessageBox.Show("The note must be longer than 20 and shorter than 500 characters")));
                return false;
            }

            else if (!hasLowerChar.IsMatch(inputText))
            {
                EventManagment.SetMessageBox(new Action(() =>
                                             MessageBox.Show("The note must contain lower char")));
                return false;
            }

            return true;
        }
    }
}

