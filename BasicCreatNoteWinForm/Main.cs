using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCreatNoteWinForm
{
    public partial class Main : Form
    {
        private const int numberNoteDefaultValue = 1;
        private static int currentNote           = numberNoteDefaultValue;


        private readonly CookieUser cookieUser   = new CookieUser();
        private readonly CheckInfo checkInfo     = new CheckInfo();
        private readonly InsertInto insertNote   = new InsertInto();
        private readonly UpdateDB updateDataBase = new UpdateDB();


        public Main()
        {
            InitializeComponent();

            if (checkInfo.IsUserNote(currentNote))
                labelIsUserNote.Text = "Is yours note";
            else
                labelIsUserNote.Text = string.Empty;

            textBoxNote.Text       = checkInfo.CurrentNoteText(currentNote);
            labelUniqueNumber.Text = currentNote.ToString();
            labelDateTime.Text     = checkInfo.CurrentDateTimeNote(currentNote);
            labelGeolocation.Text  = checkInfo.CurrentGeolocationNote(currentNote);
            labelLoginUser.Text    = checkInfo.CurrentUserNote(currentNote);
            labelEnjoy.Text        = checkInfo.CurrentEnjoy(currentNote).ToString();
            labelUnenjoy.Text      = checkInfo.CurrentUnenjoy(currentNote).ToString();
        }

        private void textBoxNote_TextChanged(object sender, EventArgs e)
        {
            if (checkInfo.IsUserNote(currentNote))
                labelIsUserNote.Text = "Is yours note";
            else
                labelIsUserNote.Text = string.Empty;

            labelUniqueNumber.Text = currentNote.ToString();
            labelDateTime.Text     = checkInfo.CurrentDateTimeNote(currentNote);
            labelGeolocation.Text  = checkInfo.CurrentGeolocationNote(currentNote);
            labelLoginUser.Text    = checkInfo.CurrentUserNote(currentNote);
            labelEnjoy.Text        = checkInfo.CurrentEnjoy(currentNote).ToString();
            labelUnenjoy.Text      = checkInfo.CurrentUnenjoy(currentNote).ToString();
        }

        private void labelCreatNote_Click(object sender, EventArgs e)
        {
            string textNote = textBoxCreatNote.Text;

            if (NoteValidation.ValidationNoteText(textNote))
            {
                ThreadPool.QueueUserWorkItem((object? timeOperation) =>
                {
                    WaitCallback waitCallback = new WaitCallback(insertNote.InsertNote);
                    this.InvokeExCallback(waitCallback, textNote);
                }, textNote);

                textBoxCreatNote.ResetText();
            }
            else
                EventManagment.InvokeMessageBox();
        }

        private void labelBackNote_Click(object sender, EventArgs e)
        {
            string noteText = checkInfo.CurrentNoteText(--currentNote);

            if (noteText != string.Empty)
                textBoxNote.Text = noteText;
            else
            {
                EventManagment.InvokeMessageBox();
                ++currentNote;
            }

        }

        private void labelNextNote_Click(object sender, EventArgs e)
        {
            string noteText = checkInfo.CurrentNoteText(++currentNote);

            if (noteText != string.Empty)
                textBoxNote.Text = noteText;
            else
            {
                EventManagment.InvokeMessageBox();
                --currentNote;
            }

        }

        private void labelSearch_Click(object sender, EventArgs e)
        {
            string searchNote = textBoxSearch.Text;

            if (SearchValidation.SearchValidationMain(searchNote))
            {
                currentNote = int.Parse(searchNote);
                textBoxNote.Text = checkInfo.CurrentNoteText(currentNote);
            }
            else
                EventManagment.InvokeMessageBox();

        }

        private void labelEnjoy_Click(object sender, EventArgs e)
        {
            if (!checkInfo.IsEnjoy(currentNote))
            {
                updateDataBase.AddEnjoy(currentNote);
                cookieUser.AddUserEnjoy(currentNote);

            }
            else
            {
                updateDataBase.RemoveEnjoy(currentNote);
                cookieUser.DeleteUserEnjoy(currentNote);

            }
            labelEnjoy.Text = checkInfo.CurrentEnjoy(currentNote).ToString();

        }

        private void labelUnenjoy_Click(object sender, EventArgs e)
        {
            if (!checkInfo.IsUnenjoy(currentNote))
            {
                updateDataBase.AddUnenjoy(currentNote);
                cookieUser.AddUserUnenjoy(currentNote);
            }
            else
            {
                updateDataBase.RemoveUnenjoy(currentNote);
                cookieUser.DeleteUserUnenjoy(currentNote);
            }
            labelUnenjoy.Text = checkInfo.CurrentUnenjoy(currentNote).ToString();
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile profileForm = new Profile();
            profileForm.Show();
        }

        private void labelLoginUser_Click(object sender, EventArgs e)
        {

        }

        private void labelGeolocation_Click(object sender, EventArgs e)
        {

        }

        private void labelDateTime_Click(object sender, EventArgs e)
        {

        }

        private void labelUniqueNumber_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCreatNote_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelIsUserNote_Click(object sender, EventArgs e)
        {

        }
    }
}
