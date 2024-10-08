﻿
namespace BasicCreatNoteWinForm
{
    public partial class Main : Form
    {
        private const int numberNoteDefaultValue = 1;
        private static int currentNote           = numberNoteDefaultValue;


        private readonly CookieUser cookieUser              = new CookieUser();
        private readonly NoteManagment checkCurrentNoteInfo = new NoteManagment();
        private readonly InsertManagment insertNote         = new InsertManagment();
        private readonly UpdateManagment updateNote         = new UpdateManagment();
        private readonly SearchValidation searchValidation  = new SearchValidation();
        private readonly NoteValidation noteValidation      = new NoteValidation();


        public Main()
        {
            InitializeComponent();

            if (checkCurrentNoteInfo.ThisNoteBelongUser(currentNote))
                labelIsUserNote.Text = "Is yours note";
            else
                labelIsUserNote.Text = string.Empty;

            textBoxNote.Text       = checkCurrentNoteInfo.CurrentNoteText(currentNote);
            labelUniqueNumber.Text = currentNote.ToString();
            labelDateTime.Text     = checkCurrentNoteInfo.CurrentDateTimeNote(currentNote).ToString();
            labelGeolocation.Text  = checkCurrentNoteInfo.CurrentGeolocationNote(currentNote);
            labelLoginUser.Text    = checkCurrentNoteInfo.CurrentNoteUserLogin(currentNote);
            labelEnjoy.Text        = checkCurrentNoteInfo.CurrentNoteEnjoy(currentNote).ToString();
            labelUnenjoy.Text      = checkCurrentNoteInfo.CurrentNoteUnenjoy(currentNote).ToString();
        }

        private void textBoxNote_TextChanged(object sender, EventArgs e)
        {
            if (checkCurrentNoteInfo.ThisNoteBelongUser(currentNote))
                labelIsUserNote.Text = "Is yours note";
            else
                labelIsUserNote.Text = string.Empty;

            labelUniqueNumber.Text = currentNote.ToString();
            labelDateTime.Text     = checkCurrentNoteInfo.CurrentDateTimeNote(currentNote).ToString();
            labelGeolocation.Text  = checkCurrentNoteInfo.CurrentGeolocationNote(currentNote);
            labelLoginUser.Text    = checkCurrentNoteInfo.CurrentNoteUserLogin(currentNote);
            labelEnjoy.Text        = checkCurrentNoteInfo.CurrentNoteEnjoy(currentNote).ToString();
            labelUnenjoy.Text      = checkCurrentNoteInfo.CurrentNoteUnenjoy(currentNote).ToString();
        }

        private void labelCreatNote_Click(object sender, EventArgs e)
        {
            string textNote = textBoxCreatNote.Text;

            if (noteValidation.Validation(textNote))
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
            string noteText = checkCurrentNoteInfo.CurrentNoteText(--currentNote);

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
            string noteText = checkCurrentNoteInfo.CurrentNoteText(++currentNote);

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

            if (searchValidation.Validation(searchNote))
            {
                currentNote = int.Parse(searchNote);
                textBoxNote.Text = checkCurrentNoteInfo.CurrentNoteText(currentNote);
            }
            else
                EventManagment.InvokeMessageBox();

        }

        private void labelEnjoy_Click(object sender, EventArgs e)
        {
            if (!checkCurrentNoteInfo.IsEnjoyed(currentNote))
            {
                updateNote.AddEnjoyNote(currentNote);
                cookieUser.AddUserEnjoy(currentNote);

            }
            else
            {
                updateNote.RemoveEnjoyNote(currentNote);
                cookieUser.DeleteUserEnjoy(currentNote);

            }
            labelEnjoy.Text = checkCurrentNoteInfo.CurrentNoteEnjoy(currentNote).ToString();

        }

        private void labelUnenjoy_Click(object sender, EventArgs e)
        {
            if (!checkCurrentNoteInfo.IsUnenjoyed(currentNote))
            {
                updateNote.AddUnenjoyNote(currentNote);
                cookieUser.AddUserUnenjoy(currentNote);
            }
            else
            {
                updateNote.RemoveUnenjoyNote(currentNote);
                cookieUser.DeleteUserUnenjoy(currentNote);
            }
            labelUnenjoy.Text = checkCurrentNoteInfo.CurrentNoteUnenjoy(currentNote).ToString();
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
