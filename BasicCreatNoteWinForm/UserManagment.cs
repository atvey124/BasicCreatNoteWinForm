using MySqlConnector;
using System.Data;
using System.Diagnostics;
using System.Globalization;

namespace BasicCreatNoteWinForm
{
    class UserManagment
    {
        private readonly CookieUser cookieUser = new CookieUser();

        [StackTraceHidden]
        public bool IsUniqueUserLogin(string login)
        {
            string userLogin  = login;
            bool isUniqueUser = true;

            DBManagment.DBConnect();
            using(MySqlCommand msCommand = new MySqlCommand("SELECT login FROM users WHERE login = @uL", DBManagment.GetConnect()))
            {
                msCommand.Parameters.Add("@uL", MySqlDbType.VarChar).Value = Hashing.HashSha128(login);

                using(MySqlDataReader dataReader = msCommand.ExecuteReader())
                {
                    if(dataReader.Read())
                    {
                        if(dataReader.HasRows)
                        {
                            isUniqueUser = false;

                            EventManagment.SetMessageBox(new Action(() =>
                                                         MessageBox.Show("User Already exist")));
                        }
                    }   
                    dataReader.Close();
                }
            }
            DBManagment.DBCloseConnect();
            return isUniqueUser;
        }

        [StackTraceHidden]
        public bool IsAuthorizedUser(string password,string login)
        {
            bool lockAutorized = false;

            DBManagment.DBConnect();
            using (MySqlCommand msCommand = new MySqlCommand("SELECT * FROM users WHERE login = @uL AND password = @uP", DBManagment.GetConnect()))
            {
                msCommand.Parameters.Add("@uL", MySqlDbType.VarChar).Value = Hashing.HashSha128(login);
                msCommand.Parameters.Add("@uP", MySqlDbType.VarChar).Value = Hashing.HashSha128(password);

                using(MySqlDataReader dataReader = msCommand.ExecuteReader())
                {
                    if(dataReader.Read())
                    {
                        if (dataReader["password"].ToString() == Hashing.HashSha128(password) && dataReader["login"].ToString() == Hashing.HashSha128(login))
                            lockAutorized = true;
                    }
                    else
                        EventManagment.SetMessageBox(new Action(() =>
                                                     MessageBox.Show("the login or password is not correct")));
                    dataReader.Close();
                }
            }
            DBManagment.DBCloseConnect();
            return lockAutorized;
        }

        [StackTraceHidden]
        public int TotalCreateNoteUser(string loginUser)
        {
            string userLogin = loginUser;
            int totalUserNote = default;

            DataTable dataTable = new DataTable();
            DBManagment.DBConnect();
            using (MySqlCommand msCommand = new MySqlCommand("SELECT * FROM note WHERE login_user = @uL", DBManagment.GetConnect()))
            {
                msCommand.Parameters.Add("@uL", MySqlDbType.VarChar).Value = userLogin;
                using (MySqlDataReader dataReader = msCommand.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        totalUserNote++;
                    }
                    dataReader.Close();
                }
            }
            DBManagment.DBCloseConnect();
            return totalUserNote;
        }

        [StackTraceHidden]
        public int TotalEnjoyUser(string loginUser)
        {
            string userLogin   = loginUser;
            int totalUserEnjoy = default;

            DBManagment.DBConnect();
            using (MySqlCommand msCommand = new MySqlCommand("SELECT enjoy FROM note WHERE login_user = @uL", DBManagment.GetConnect()))
            {
                msCommand.Parameters.Add("@uL", MySqlDbType.VarChar).Value = userLogin;
                using (MySqlDataReader dataReader = msCommand.ExecuteReader())
                {

                    while(dataReader.Read())
                    {
                        totalUserEnjoy += Convert.ToInt32(dataReader["enjoy"]);
                    }
                    dataReader.Close();
                }
            }
            DBManagment.DBCloseConnect();
            return totalUserEnjoy;
        }

        [StackTraceHidden]
        public int TotalUnenjoyUser(string loginUser)
        {
            string userLogin     = loginUser;
            int totalUserUnenjoy = default;


            DBManagment.DBConnect();
            using (MySqlCommand msCommand = new MySqlCommand("SELECT unenjoy FROM note WHERE login_user = @uL", DBManagment.GetConnect()))
            {
                msCommand.Parameters.Add("@uL", MySqlDbType.VarChar).Value = userLogin;
                using (MySqlDataReader dataReader = msCommand.ExecuteReader())
                {

                    while (dataReader.Read())
                    {
                        totalUserUnenjoy += Convert.ToInt32(dataReader["unenjoy"]);
                    }
                    dataReader.Close();
                }
            }
            DBManagment.DBCloseConnect();
            return totalUserUnenjoy;
        }

        [StackTraceHidden]
        public string GetCurrentGeolocationUser() => RegionInfo.CurrentRegion.ThreeLetterWindowsRegionName;

        [StackTraceHidden]
        public DateTime GetCurrentDateTimeUser()  => DateTime.Now;

    }
}
