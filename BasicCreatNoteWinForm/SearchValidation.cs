using System.Text.RegularExpressions;

namespace BasicCreatNoteWinForm
{
    class SearchValidation : IValidations
    {
        public bool Validation(string textToCheckValid)
        {
            string searchText = textToCheckValid;

            if (int.TryParse(searchText, out int value))
            {
                NoteManagment noteManagment = new NoteManagment();

                int MinValueNote = noteManagment.GetMinNumberNote();
                int MaxValueNote = noteManagment.GetMaxNumberNote();

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
