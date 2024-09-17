using MySqlConnector;
using System.Diagnostics;

namespace BasicCreatNoteWinForm
{
    class InsertManagment
    {
        private MySqlCommand msCommand = new MySqlCommand();    
        private object _lockObj        = new object();

        private readonly UserManagment checkInfo = new UserManagment();
        private readonly CookieUser cookieUser   = new CookieUser();


        [StackTraceHidden]
        public void InsertUser(object cUser)
        {
            CookieUser cookieUser = cUser as CookieUser;

            lock(_lockObj)
            {
                if (cookieUser != null)
                {
                    if (checkInfo.IsUniqueUserLogin(cookieUser.GetUserLogin()))
                    {
                        using(MySqlCommand msCommand = new MySqlCommand("INSERT INTO users(password,login) VALUES (@uP,@uL)", DBManagment.GetConnect()))
                        {
                            msCommand.Parameters.Add("@uP", MySqlDbType.VarChar).Value = Hashing.HashSha128(cookieUser.GetUserPassword());
                            msCommand.Parameters.Add("@uL", MySqlDbType.VarChar).Value = Hashing.HashSha128(cookieUser.GetUserLogin());


                            DBManagment.DBConnect();
                            msCommand.ExecuteNonQuery();
                            DBManagment.DBCloseConnect();


                            EventManagment.SetMessageBox(new Action(() =>
                                                         MessageBox.Show("Register succesfully")));
                        }

                    }
                    EventManagment.InvokeMessageBox();
                }
            }
        }

        [StackTraceHidden]
        public void InsertNote(object text)
        {
            string noteText = text as string;

            lock (_lockObj)
            {
                if (noteText != null)
                {
                    using (MySqlCommand msCommand = new MySqlCommand("INSERT INTO note(text,datetime,geoloc,login_user) VALUES (@uT,@uDT,@uG,@uL)", DBManagment.GetConnect()))
                    {
                        msCommand.Parameters.Add("@uT", MySqlDbType.VarChar).Value   = noteText;
                        msCommand.Parameters.Add("@uDT", MySqlDbType.DateTime).Value = checkInfo.GetCurrentDateTimeUser();
                        msCommand.Parameters.Add("@uG", MySqlDbType.VarChar).Value   = checkInfo.GetCurrentGeolocationUser();
                        msCommand.Parameters.Add("@uL", MySqlDbType.VarChar).Value   = cookieUser.GetUserLogin();


                        DBManagment.DBConnect();
                        msCommand.ExecuteNonQuery();
                        DBManagment.DBCloseConnect();


                        EventManagment.SetMessageBox(new Action(() =>
                                                     MessageBox.Show("Note add succesfully")));
                    }
                }
                EventManagment.InvokeMessageBox();
            }
        }

    }
}
