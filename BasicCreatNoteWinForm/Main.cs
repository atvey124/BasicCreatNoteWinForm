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
        private int currentNote = numberNoteDefaultValue;

        public Main()
        {
            InitializeComponent();
            CheckInfo checkInfo = new CheckInfo();

            textBoxNote.Text = checkInfo.IsCurrentNote(currentNote, numberNoteDefaultValue);
            labelUniqueNumber.Text = currentNote.ToString();
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
            string noteText = checkInfo.IsCurrentNote(--currentNote, numberNoteDefaultValue);

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
            string noteText = checkInfo.IsCurrentNote(++currentNote, numberNoteDefaultValue);

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
