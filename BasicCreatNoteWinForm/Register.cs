
namespace BasicCreatNoteWinForm
{
    public partial class FormMain : Form
    {
        private readonly InsertManagment insertUser            = new InsertManagment();
        private readonly CookieUser cookieUser                 = new CookieUser();
        private readonly LoginValidation loginValidation       = new LoginValidation();
        private readonly PasswordValidation passwordValidation = new PasswordValidation();


        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string password       = textBoxPassword.Text;
            string passwordRepeat = textBoxRepeatPassword.Text;
            string login          = textBoxLogin.Text;

            if(password == passwordRepeat)
            {
                if (passwordValidation.Validation(password) &&
                loginValidation.Validation(login))
                {
                    cookieUser.SetUserLogin(login);
                    cookieUser.SetUserPassword(password);


                    ThreadPool.QueueUserWorkItem((object? _timeOperation) =>
                    {
                        WaitCallback waitCallback = new WaitCallback(insertUser.InsertUser);
                        this.InvokeExCallback(waitCallback, cookieUser);
                    }, cookieUser);

                }
            }
            else
                EventManagment.SetMessageBox(new Action(() =>
                                             MessageBox.Show("Passwords don't match")));

            EventManagment.InvokeMessageBox();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxLogin.ResetText();
            textBoxPassword.ResetText();
            textBoxRepeatPassword.ResetText();
        }

        private void labelredirectLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            login loginForm = new login();
            loginForm.Show();
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxRepeatPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
