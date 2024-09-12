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
        private int currentNote                  = numberNoteDefaultValue;

        public Main()
        {
            InitializeComponent();
            CheckInfo checkInfo = new CheckInfo();

            textBoxNote.Text       = checkInfo.CurrentNoteText(currentNote);
            labelUniqueNumber.Text = currentNote.ToString();
            labelDateTime.Text     = checkInfo.CurrentDateTimeNote(currentNote).ToString();
            labelGeolocation.Text  = checkInfo.CurrentGeolocationNote(currentNote);
        }

        private void labelCreatNote_Click(object sender, EventArgs e)
        {
            string textNote = textBoxCreatNote.Text;

            if (NoteValidation.ValidationNoteText(textNote))
            {
                InsertInto insertNote = new InsertInto();
                ThreadPool.QueueUserWorkItem((object? timeOperation) =>
                {
                    WaitCallback waitCallback = new WaitCallback(insertNote.InsertNote);
                    this.InvokeExCallback(waitCallback, textNote);
                }, textNote);
            }
            else
                EventManagment.InvokeMessageBox();
        }

        private void labelBackNote_Click(object sender, EventArgs e)
        {
            CheckInfo checkInfo = new CheckInfo();
            string noteText     = checkInfo.CurrentNoteText(--currentNote);

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
            CheckInfo checkInfo = new CheckInfo();
            string noteText     = checkInfo.CurrentNoteText(++currentNote);

            if (noteText != string.Empty)
                textBoxNote.Text = noteText;

            else
            {
                EventManagment.InvokeMessageBox();
                --currentNote;
            }

        }

        private void textBoxNote_TextChanged(object sender, EventArgs e)
        {
            labelUniqueNumber.Text = currentNote.ToString();

            CheckInfo checkInfo   = new CheckInfo();
            labelDateTime.Text    = checkInfo.CurrentDateTimeNote(currentNote).ToString();
            labelGeolocation.Text = checkInfo.CurrentGeolocationNote(currentNote);
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

        private void buttonProfile_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCreatNote_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
