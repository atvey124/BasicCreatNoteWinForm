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

namespace BasicCreatNoteWinForm
{
    class CheckInfo
    {

        [StackTraceHidden]
        public bool IsUniqueUserLogin(string login)
        {
            string userLogin = login;
            bool isUniqueUser = true;

            using(MySqlCommand msCommand = new MySqlCommand("SELECT login FROM users WHERE login = @uL", DBConnection.GetConnect()))
            {
                msCommand.Parameters.Add("@uL", MySqlDbType.VarChar).Value = Hashing.HashSha128(login);
                using(MySqlDataAdapter dataAdapter = new MySqlDataAdapter())
                {
                    dataAdapter.SelectCommand = msCommand;
                    using (DataTable dataTable = new DataTable())
                    {
                        dataTable.Clear();
                        dataAdapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            EventManagment.SetMessageBox(new Action(() =>
                                                         MessageBox.Show("User Already exist")));
                            isUniqueUser = false;
                        }

                        return isUniqueUser;
                    }  
                }
            }
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
                        else
                            EventManagment.SetMessageBox(new Action(() =>
                                                         MessageBox.Show("the login or password is not correct")));
                    }
                }
            }
            DBConnection.DBCloseConnect();
            return lockAutorized;
        }

        [StackTraceHidden]
        public int IsMaxNumberNote()
        {
            int maxNumberNote = 0;

            DBConnection.DBConnect();
            using (MySqlCommand msCommand = new MySqlCommand("SELECT MAX(id_note) FROM note", DBConnection.GetConnect()))
            {

                using (MySqlDataReader dataReader = msCommand.ExecuteReader())
                {

                    if (dataReader.Read())
                    {
                        maxNumberNote = dataReader.GetInt32(0);
                    }
                }
            }

            DBConnection.DBCloseConnect();
            return maxNumberNote;
        }

        [StackTraceHidden]
        public string IsCurrentNote(int currentNote,int minNumberNote)
        {
            int currentNoteNumber = currentNote;
            string currentNoteText = string.Empty;

            if(currentNoteNumber < minNumberNote)
            {
                EventManagment.SetMessageBox(new Action(() =>
                                             MessageBox.Show("It is first note")));
            }
            else if(currentNoteNumber > IsMaxNumberNote()) 
            {
                EventManagment.SetMessageBox(new Action(() =>
                                             MessageBox.Show("It is last note")));
            }
            else
            {
                DBConnection.DBConnect();

                using (MySqlCommand msCommand = new MySqlCommand("SELECT text FROM note WHERE id_note = @cN", DBConnection.GetConnect()))
                {
                    msCommand.Parameters.Add("@cN", MySqlDbType.Int32).Value = currentNoteNumber;

                    using (MySqlDataReader dataReader = msCommand.ExecuteReader())
                    {

                        if (dataReader.Read())
                        {
                            currentNoteText = dataReader.GetString(0);
                        }
                    }
                }
                DBConnection.DBCloseConnect();
                return currentNoteText;
            }

            return string.Empty;
        }
    }
}
