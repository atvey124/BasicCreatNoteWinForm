using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.Logging;
using System.Diagnostics;
using System.Globalization;

namespace BasicCreatNoteWinForm
{
    class CheckInfo
    {
        private readonly CookieUser cookieUser = new CookieUser();


        [StackTraceHidden]
        public bool IsUniqueUserLogin(string login)
        {
            string userLogin  = login;
            bool isUniqueUser = true;

            DBConnection.DBConnect();
            using(MySqlCommand msCommand = new MySqlCommand("SELECT login FROM users WHERE login = @uL", DBConnection.GetConnect()))
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
            DBConnection.DBCloseConnect();
            return isUniqueUser;
        }

        [StackTraceHidden]
        public bool IsAuthorized(string password,string login)
        {
            bool lockAutorized = false;

            DBConnection.DBConnect();
            using (MySqlCommand msCommand = new MySqlCommand("SELECT * FROM users WHERE login = @uL AND password = @uP", DBConnection.GetConnect()))
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
            DBConnection.DBCloseConnect();
            return lockAutorized;
        }

        [StackTraceHidden]
        public string CurrentNoteText(int currentNote)
        {
            int currentNoteNumber  = currentNote;
            string currentNoteText = string.Empty;

            DBConnection.DBConnect();
            using (MySqlCommand msCommand = new MySqlCommand("SELECT text FROM note WHERE id_note = @cN", DBConnection.GetConnect()))
            {
                msCommand.Parameters.Add("@cN", MySqlDbType.Int32).Value = currentNoteNumber;

                using (MySqlDataReader dataReader = msCommand.ExecuteReader())
                {
                    if(dataReader.Read())
                    {
                        if (dataReader.HasRows)
                            currentNoteText = dataReader.GetString(0);
                    }
                    else
                    {
                        EventManagment.SetMessageBox(new Action(() =>
                                                     MessageBox.Show("Have you scrolled to the end")));
                    }
                    dataReader.Close();
                }
            }
            DBConnection.DBCloseConnect();
            return currentNoteText;
        }

        [StackTraceHidden]
        public string CurrentDateTimeNote(int currentNote)
        {
            int currentNoteNumber    = currentNote;
            DateTime currentDateTime = default;

            DBConnection.DBConnect();
            using (MySqlCommand msCommand = new MySqlCommand("SELECT datetime FROM note WHERE id_note = @cN", DBConnection.GetConnect()))
            {
                msCommand.Parameters.Add("@cN", MySqlDbType.Int32).Value = currentNoteNumber;

                using (MySqlDataReader dataReader = msCommand.ExecuteReader())
                {
                    if (dataReader.Read())
                    {
                        currentDateTime = dataReader.GetDateTime(0);
                    }
                    dataReader.Close();
                }
            }
            DBConnection.DBCloseConnect();
            return currentDateTime.ToString();
        }

        [StackTraceHidden]
        public string CurrentGeolocationNote(int currentNote)
        {
            int currentNoteNumber     = currentNote;
            string currentGeolocation = string.Empty;

            DBConnection.DBConnect();
            using (MySqlCommand msCommand = new MySqlCommand("SELECT geoloc FROM note WHERE id_note = @cN", DBConnection.GetConnect()))
            {
                msCommand.Parameters.Add("@cN", MySqlDbType.Int32).Value = currentNoteNumber;

                using (MySqlDataReader dataReader = msCommand.ExecuteReader())
                {
                    if (dataReader.Read())
                    {
                        currentGeolocation = dataReader.GetString(0);
                    }               
                    dataReader.Close();
                }
            }
            DBConnection.DBCloseConnect();
            return currentGeolocation;
        }

        [StackTraceHidden]
        public string CurrentUserNote(int currentNote)
        {
            int currentNoteNumber  = currentNote;
            string currentUserNote = string.Empty;

            DBConnection.DBConnect();
            using (MySqlCommand msCommand = new MySqlCommand("SELECT login_user FROM note WHERE id_note = @cN", DBConnection.GetConnect()))
            {
                msCommand.Parameters.Add("@cN", MySqlDbType.VarChar).Value = currentNoteNumber;

                using (MySqlDataReader dataReader = msCommand.ExecuteReader())
                {
                    if (dataReader.Read())
                    {
                        currentUserNote = dataReader.GetString(0);
                    }     
                    dataReader.Close();
                }
            }
            DBConnection.DBCloseConnect();
            return currentUserNote;
        }

        [StackTraceHidden]
        public int TotalCurrentUserNote(string loginUser)
        {
            string userLogin  = loginUser;
            int totalUserNote = default;

            DataTable dataTable = new DataTable();
            DBConnection.DBConnect();
            using (MySqlCommand msCommand = new MySqlCommand("SELECT * FROM note WHERE login_user = @uL", DBConnection.GetConnect()))
            {
                msCommand.Parameters.Add("@uL", MySqlDbType.VarChar).Value = userLogin;
                using(MySqlDataReader dataReader = msCommand.ExecuteReader())
                {   
                    while(dataReader.Read())
                    {
                        totalUserNote++;
                    }
                    dataReader.Close();
                }
            }
            DBConnection.DBCloseConnect();
            return totalUserNote;
        }

        [StackTraceHidden]
        public int TotalCurrentUserEnjoy(string loginUser)
        {
            string userLogin   = loginUser;
            int totalUserEnjoy = default;

            DBConnection.DBConnect();
            using (MySqlCommand msCommand = new MySqlCommand("SELECT enjoy FROM note WHERE login_user = @uL", DBConnection.GetConnect()))
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
            DBConnection.DBCloseConnect();
            return totalUserEnjoy;
        }

        [StackTraceHidden]
        public int TotalCurrentUserUnenjoy(string loginUser)
        {
            string userLogin     = loginUser;
            int totalUserUnenjoy = default;


            DBConnection.DBConnect();
            using (MySqlCommand msCommand = new MySqlCommand("SELECT unenjoy FROM note WHERE login_user = @uL", DBConnection.GetConnect()))
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
            DBConnection.DBCloseConnect();
            return totalUserUnenjoy;
        }

        [StackTraceHidden]
        public int GetMaxNumberNote()
        {
            int maxNumberNote = default;

            DBConnection.DBConnect();
            using(MySqlCommand msCommand = new MySqlCommand("SELECT MAX(id_note) FROM note", DBConnection.GetConnect()))
            {
                using(MySqlDataReader dataReader = msCommand.ExecuteReader())
                {
                    if (dataReader.Read())
                    {
                        maxNumberNote = dataReader.GetInt32(0);
                    }                       
                    dataReader.Close();
                }
            }
            DBConnection.DBCloseConnect();
            return maxNumberNote;
        }

        [StackTraceHidden]
        public int GetMinNumberNote()
        {
            int minNumberNote = default;

            DBConnection.DBConnect();
            using (MySqlCommand msCommand = new MySqlCommand("SELECT MIN(id_note) FROM note", DBConnection.GetConnect()))
            {
                using (MySqlDataReader dataReader = msCommand.ExecuteReader())
                {
                    if (dataReader.Read())
                    {
                        minNumberNote = dataReader.GetInt32(0);
                    }   
                    dataReader.Close();
                }
            }
            DBConnection.DBCloseConnect();
            return minNumberNote;
        }

        [StackTraceHidden]
        public int CurrentEnjoy(int id_note)
        {
            int currentEnjoy      = default;
            int currentNoteNumber = id_note;

            DBConnection.DBConnect();
            using (MySqlCommand msCommand = new MySqlCommand("SELECT enjoy FROM note WHERE id_note = @iN", DBConnection.GetConnect()))
            {
                msCommand.Parameters.Add("@iN",MySqlDbType.Int32).Value = currentNoteNumber;
                using (MySqlDataReader dataReader = msCommand.ExecuteReader())
                {
                    if (dataReader.Read())
                    {
                        currentEnjoy = dataReader.GetInt32(0);
                    }
                    dataReader.Close();   
                }
            }
            DBConnection.DBCloseConnect();
            return currentEnjoy;
        }

        [StackTraceHidden]
        public int CurrentUnenjoy(int id_note)
        {
            int currentUnenjoy    = default;
            int currentNoteNumber = id_note;

            DBConnection.DBConnect();
            using (MySqlCommand msCommand = new MySqlCommand("SELECT unenjoy FROM note WHERE id_note = @iN", DBConnection.GetConnect()))
            {
                msCommand.Parameters.Add("@iN", MySqlDbType.Int32).Value = currentNoteNumber;
                using (MySqlDataReader dataReader = msCommand.ExecuteReader())
                {
                    if (dataReader.Read())
                    {
                        currentUnenjoy = dataReader.GetInt32(0);
                    }
                    dataReader.Close();
                }
            }
            DBConnection.DBCloseConnect();
            return currentUnenjoy;
        }

        [StackTraceHidden]
        public bool IsUserNote(int id_note)
        {
            bool IsUserNote       = false;
            int currentNoteNumber = id_note;

            DBConnection.DBConnect();
            using (MySqlCommand msCommand = new MySqlCommand("SELECT login_user FROM note WHERE id_note = @iN", DBConnection.GetConnect()))
            {
                msCommand.Parameters.Add("@iN", MySqlDbType.Int32).Value = currentNoteNumber;
                using (MySqlDataReader dataReader = msCommand.ExecuteReader())
                {
                    if (dataReader.Read())
                    {
                        if(dataReader.GetString(0) == cookieUser.GetUserLogin())
                            IsUserNote = true;                     
                    }
                    dataReader.Close();
                }
            }
            DBConnection.DBCloseConnect();
            return IsUserNote;
        }

        [StackTraceHidden]
        public bool IsEnjoy(int id_note)
        {
            List<int> userEnjoy = cookieUser.GetUserEnjoy();


            return userEnjoy.IndexOf(id_note) == -1 ? false : true;
        }

        [StackTraceHidden]
        public bool IsUnenjoy(int id_note)
        {
            List<int> userUnenjoy = cookieUser.GetUserUnenjoy();


            return userUnenjoy.IndexOf(id_note) == -1 ? false : true;
        }

        [StackTraceHidden]
        public string GetCurrentGeolocation() => RegionInfo.CurrentRegion.ThreeLetterWindowsRegionName;

        [StackTraceHidden]
        public DateTime GetCurrentDateTime()  => DateTime.Now;

    }
}
