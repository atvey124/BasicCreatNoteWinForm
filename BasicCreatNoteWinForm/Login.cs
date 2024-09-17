
namespace BasicCreatNoteWinForm
{
    public partial class login : Form
    {
        private readonly UserManagment checkCurrentUserInfo       = new UserManagment();
        private readonly LoginValidation loginValidation          = new LoginValidation();   
        private readonly PasswordValidation passwordValidation    = new PasswordValidation();


        public login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string password = textBoxPassword.Text;
            string login    = textBoxLogin.Text;

            if (passwordValidation.Validation(password) && 
                loginValidation.Validation(login))
            {
                if (checkCurrentUserInfo.IsAuthorizedUser(password, login))
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
