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
    public partial class login : Form
    {
        private readonly CheckInfo checkAutorized = new CheckInfo();


        public login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string password = textBoxPassword.Text;
            string login    = textBoxLogin.Text;

            if (PassValidation.ValidationLogin(password))
            {
                if (checkAutorized.IsAuthorized(password, login))
                {
                    CookieUser cookieUser = new CookieUser();
                    cookieUser.SetUserLogin(login);
                    cookieUser.SetUserPassword(password);


                    this.Hide();
                    Main mainForm = new Main(); 
                    mainForm.Show();
                } 
            }
            EventManagment.InvokeMessageBox();

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxPassword.ResetText();
            textBoxLogin.ResetText();
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
