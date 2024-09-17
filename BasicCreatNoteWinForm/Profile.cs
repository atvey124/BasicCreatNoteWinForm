
namespace BasicCreatNoteWinForm
{
    public partial class Profile : Form
    {
        private readonly UserManagment checkCurrentUserInfo = new UserManagment();
        private readonly CookieUser cookieUser              = new CookieUser();


        public Profile()
        {
            InitializeComponent();

            labelCountNotePost.Text         = checkCurrentUserInfo.TotalCreateNoteUser(cookieUser.GetUserLogin()).ToString();
            labelCountTotalEnjoyNote.Text   = checkCurrentUserInfo.TotalEnjoyUser(cookieUser.GetUserLogin()).ToString();
            labelTotalUnenjoyCountNote.Text = checkCurrentUserInfo.TotalUnenjoyUser(cookieUser.GetUserLogin()).ToString();

        }

        private void labelRedirectMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main mainProfile = new Main();
            mainProfile.Show();
        }

        private void labelCountNotePost_Click(object sender, EventArgs e)
        {

        }

        private void labelCountTotalEnjoyNote_Click(object sender, EventArgs e)
        {

        }

        private void labelTotalUnenjoyCountNote_Click(object sender, EventArgs e)
        {

        }
    }
}
