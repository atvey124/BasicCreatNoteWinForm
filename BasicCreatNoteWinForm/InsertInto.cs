using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace BasicCreatNoteWinForm
{
    class InsertInto
    {
        private MySqlCommand msCommand = new MySqlCommand();    
        private object _lockObj        = new object();


        [StackTraceHidden]
        public void InsertUser(object cUser)
        {
            CookieUser cookieUser = cUser as CookieUser;

            lock(_lockObj)
            {
                if (cookieUser != null)
                {
                    CheckInfo checkUniqueUser = new CheckInfo();

                    if (checkUniqueUser.IsUniqueUserLogin(cookieUser.GetUserLogin()))
                    {
                        using(MySqlCommand msCommand = new MySqlCommand("INSERT INTO users(password,login) VALUES (@uP,@uL)", DBConnection.GetConnect()))
                        {
                            msCommand.Parameters.Add("@uP", MySqlDbType.VarChar).Value = Hashing.HashSha128(cookieUser.GetUserPassword());
                            msCommand.Parameters.Add("@uL", MySqlDbType.VarChar).Value = Hashing.HashSha128(cookieUser.GetUserLogin());

                            DBConnection.DBConnect();
                            msCommand.ExecuteNonQuery();
                            DBConnection.DBCloseConnect();

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
                    using (MySqlCommand msCommand = new MySqlCommand("INSERT INTO note(text) VALUES (@uT)",DBConnection.GetConnect()))
                    {
                        msCommand.Parameters.Add("@uT", MySqlDbType.VarChar).Value = noteText;

                        DBConnection.DBConnect();
                        msCommand.ExecuteNonQuery();
                        DBConnection.DBCloseConnect();

                        EventManagment.SetMessageBox(new Action(() =>
                                                     MessageBox.Show("Note add succesfully")));
                    }
                    EventManagment.InvokeMessageBox();
                }
            }
        }
    }
}
