using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCreatNoteWinForm
{
    class NoteManagment
    {
        private readonly CookieUser cookieUser = new CookieUser();


        [StackTraceHidden]
        public DateTime CurrentDateTimeNote(int currentNote)
        {
            int currentNoteNumber = currentNote;
            DateTime currentDateTime = default;

            DBManagment.DBConnect();
            using (MySqlCommand msCommand = new MySqlCommand("SELECT datetime FROM note WHERE id_note = @cN", DBManagment.GetConnect()))
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
            DBManagment.DBCloseConnect();
            return currentDateTime;
        }

        [StackTraceHidden]
        public string CurrentGeolocationNote(int currentNote)
        {
            int currentNoteNumber = currentNote;
            string currentGeolocation = string.Empty;

            DBManagment.DBConnect();
            using (MySqlCommand msCommand = new MySqlCommand("SELECT geoloc FROM note WHERE id_note = @cN", DBManagment.GetConnect()))
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
            DBManagment.DBCloseConnect();
            return currentGeolocation;
        }

        [StackTraceHidden]
        public string CurrentNoteText(int currentNote)
        {
            int currentNoteNumber = currentNote;
            string currentNoteText = string.Empty;

            DBManagment.DBConnect();
            using (MySqlCommand msCommand = new MySqlCommand("SELECT text FROM note WHERE id_note = @cN", DBManagment.GetConnect()))
            {
                msCommand.Parameters.Add("@cN", MySqlDbType.Int32).Value = currentNoteNumber;

                using (MySqlDataReader dataReader = msCommand.ExecuteReader())
                {
                    if (dataReader.Read())
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
            DBManagment.DBCloseConnect();
            return currentNoteText;
        }

        [StackTraceHidden]
        public string CurrentNoteUserLogin(int currentNote)
        {
            int currentNoteNumber = currentNote;
            string currentUserNote = string.Empty;

            DBManagment.DBConnect();
            using (MySqlCommand msCommand = new MySqlCommand("SELECT login_user FROM note WHERE id_note = @cN", DBManagment.GetConnect()))
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
            DBManagment.DBCloseConnect();
            return currentUserNote;
        }

        [StackTraceHidden]
        public int GetMaxNumberNote()
        {
            int maxNumberNote = default;

            DBManagment.DBConnect();
            using (MySqlCommand msCommand = new MySqlCommand("SELECT MAX(id_note) FROM note", DBManagment.GetConnect()))
            {
                using (MySqlDataReader dataReader = msCommand.ExecuteReader())
                {
                    if (dataReader.Read())
                    {
                        maxNumberNote = dataReader.GetInt32(0);
                    }
                    dataReader.Close();
                }
            }
            DBManagment.DBCloseConnect();
            return maxNumberNote;
        }

        [StackTraceHidden]
        public int GetMinNumberNote()
        {
            int minNumberNote = default;

            DBManagment.DBConnect();
            using (MySqlCommand msCommand = new MySqlCommand("SELECT MIN(id_note) FROM note", DBManagment.GetConnect()))
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
            DBManagment.DBCloseConnect();
            return minNumberNote;
        }

        [StackTraceHidden]
        public bool ThisNoteBelongUser(int id_note)
        {
            bool IsUserNote = false;
            int currentNoteNumber = id_note;

            DBManagment.DBConnect();
            using (MySqlCommand msCommand = new MySqlCommand("SELECT login_user FROM note WHERE id_note = @iN", DBManagment.GetConnect()))
            {
                msCommand.Parameters.Add("@iN", MySqlDbType.Int32).Value = currentNoteNumber;
                using (MySqlDataReader dataReader = msCommand.ExecuteReader())
                {
                    if (dataReader.Read())
                    {
                        if (dataReader.GetString(0) == cookieUser.GetUserLogin())
                            IsUserNote = true;
                    }
                    dataReader.Close();
                }
            }
            DBManagment.DBCloseConnect();
            return IsUserNote;
        }

        [StackTraceHidden]
        public int CurrentNoteEnjoy(int id_note)
        {
            int currentEnjoy = default;
            int currentNoteNumber = id_note;

            DBManagment.DBConnect();
            using (MySqlCommand msCommand = new MySqlCommand("SELECT enjoy FROM note WHERE id_note = @iN", DBManagment.GetConnect()))
            {
                msCommand.Parameters.Add("@iN", MySqlDbType.Int32).Value = currentNoteNumber;
                using (MySqlDataReader dataReader = msCommand.ExecuteReader())
                {
                    if (dataReader.Read())
                    {
                        currentEnjoy = dataReader.GetInt32(0);
                    }
                    dataReader.Close();
                }
            }
            DBManagment.DBCloseConnect();
            return currentEnjoy;
        }


        [StackTraceHidden]
        public int CurrentNoteUnenjoy(int id_note)
        {
            int currentUnenjoy = default;
            int currentNoteNumber = id_note;

            DBManagment.DBConnect();
            using (MySqlCommand msCommand = new MySqlCommand("SELECT unenjoy FROM note WHERE id_note = @iN", DBManagment.GetConnect()))
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
            DBManagment.DBCloseConnect();
            return currentUnenjoy;
        }

        [StackTraceHidden]
        public bool IsEnjoyed(int id_note)
        {
            List<int> userEnjoy = cookieUser.GetUserEnjoy();


            return userEnjoy.IndexOf(id_note) == -1 ? false : true;
        }

        [StackTraceHidden]
        public bool IsUnenjoyed(int id_note)
        {
            List<int> userUnenjoy = cookieUser.GetUserUnenjoy();


            return userUnenjoy.IndexOf(id_note) == -1 ? false : true;
        }

    }
}
