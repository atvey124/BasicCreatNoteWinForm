
namespace BasicCreatNoteWinForm
{
    public partial class Profile : Form
    {
        private readonly CheckInfo checkInfo   = new CheckInfo();
        private readonly CookieUser cookieUser = new CookieUser();


        public Profile()
        {
            InitializeComponent();

            labelCountNotePost.Text         = checkInfo.TotalCurrentUserNote(cookieUser.GetUserLogin()).ToString();
            labelCountTotalEnjoyNote.Text   = checkInfo.TotalCurrentUserEnjoy(cookieUser.GetUserLogin()).ToString();
            labelTotalUnenjoyCountNote.Text = checkInfo.TotalCurrentUserUnenjoy(cookieUser.GetUserLogin()).ToString();

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
