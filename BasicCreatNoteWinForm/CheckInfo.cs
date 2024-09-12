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
                }
            }
            DBConnection.DBCloseConnect();
            return currentNoteText;
        }

        [StackTraceHidden]
        public DateTime CurrentDateTimeNote(int currentNote)
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
                        currentDateTime = dataReader.GetDateTime(0);
                }
            }
            DBConnection.DBCloseConnect();
            return currentDateTime;
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
                        currentGeolocation = dataReader.GetString(0);
                }
            }
            DBConnection.DBCloseConnect();
            return currentGeolocation;
        }

        [StackTraceHidden]
        public string GetCurrentGeolocation() => RegionInfo.CurrentRegion.ThreeLetterWindowsRegionName;

        [StackTraceHidden]
        public DateTime GetCurrentDateTime()  => DateTime.Now;

    }
}
