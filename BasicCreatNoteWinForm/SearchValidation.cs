using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BasicCreatNoteWinForm
{
    static class SearchValidation
    {
        static public bool SearchValidationMain(string text)
        {
             CheckInfo checkInfo = new CheckInfo();

            int MinValueNote  = checkInfo.GetMinNumberNote();
            int MaxValueNote  = checkInfo.GetMaxNumberNote();
            string searchText = text;


            Regex hasLetterLower = new Regex(@"[a-z]+");
            Regex hasLetterUpper = new Regex(@"[A-Z]+");
            Regex hasSymbols     = new Regex(@"[!@#$%^&*]");


            if (hasLetterLower.IsMatch(searchText)) 
            {
                EventManagment.SetMessageBox(new Action(() =>
                                             MessageBox.Show("Number note didn't contain lower letter")));
                return false;
            }

            else if (hasLetterUpper.IsMatch(searchText))
            {
                EventManagment.SetMessageBox(new Action(() =>
                                             MessageBox.Show("Number note didn't contain upper letter")));
                return false;
            }

            else if (hasSymbols.IsMatch(searchText))
            {
                EventManagment.SetMessageBox(new Action(() =>
                                             MessageBox.Show("Number note didn't contain symbols")));
                return false;
            }

            else if(int.Parse(searchText) < MinValueNote || int.Parse(searchText) > MaxValueNote)
            {
                EventManagment.SetMessageBox(new Action(() =>
                                             MessageBox.Show("Number note didn't exist")));
                return false;
            }

            return true;
        }
    }
}
