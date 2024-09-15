using System.Text.RegularExpressions;

namespace BasicCreatNoteWinForm
{
    static class SearchValidation
    {
        static public bool SearchValidationMain(string text)
        {        
            string searchText = text;

            if(int.TryParse(searchText,out int value))
            {
                CheckInfo checkInfo = new CheckInfo();

                int MinValueNote = checkInfo.GetMinNumberNote();
                int MaxValueNote = checkInfo.GetMaxNumberNote();

                if (value >= MinValueNote && value <= MaxValueNote)
                    return true; 
                else
                {
                    EventManagment.SetMessageBox(new Action(() =>
                                                 MessageBox.Show("Number note didn't exist")));
                }
            }
            else
            {
                EventManagment.SetMessageBox(new Action(() =>
                                             MessageBox.Show("Number note didn't contain any letter or symbols")));
            }

            return false;
        }
    }
}
