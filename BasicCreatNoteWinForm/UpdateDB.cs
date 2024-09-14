using MySqlConnector;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCreatNoteWinForm
{
    
    class UpdateDB
    {
        private object _lockObj = new object();


        [StackTraceHidden]
        public void AddEnjoy(int idNote)
        {
            lock (_lockObj)
            {
                using (MySqlCommand msCommand = new MySqlCommand("UPDATE note SET enjoy = enjoy + 1 WHERE id_note = @iN", DBConnection.GetConnect()))
                {
                    msCommand.Parameters.Add("@iN", MySqlDbType.Int32).Value = idNote;


                    DBConnection.DBConnect();
                    msCommand.ExecuteNonQuery();
                    DBConnection.DBCloseConnect();


                    EventManagment.SetMessageBox(new Action(() =>
                                                 MessageBox.Show("Like add succesfully :D")));
                }
                EventManagment.InvokeMessageBox();
            }
        }

        [StackTraceHidden]
        public void AddUnenjoy(int idNote)
        {
            lock (_lockObj)
            {
                using (MySqlCommand msCommand = new MySqlCommand("UPDATE note SET unenjoy = unenjoy + 1 WHERE id_note = @iN", DBConnection.GetConnect()))
                {
                    msCommand.Parameters.Add("@iN", MySqlDbType.Int32).Value = idNote;


                    DBConnection.DBConnect();
                    msCommand.ExecuteNonQuery();
                    DBConnection.DBCloseConnect();


                    EventManagment.SetMessageBox(new Action(() =>
                                                 MessageBox.Show("Dislike add succesfully :(")));
                }
                EventManagment.InvokeMessageBox();
            }
        }

        [StackTraceHidden]
        public void RemoveUnenjoy(int idNote)
        {
            lock (_lockObj)
            {
                using (MySqlCommand msCommand = new MySqlCommand("UPDATE note SET unenjoy = unenjoy - 1 WHERE id_note = @iN", DBConnection.GetConnect()))
                {
                    msCommand.Parameters.Add("@iN", MySqlDbType.Int32).Value = idNote;


                    DBConnection.DBConnect();
                    msCommand.ExecuteNonQuery();
                    DBConnection.DBCloseConnect();


                    EventManagment.SetMessageBox(new Action(() =>
                                                 MessageBox.Show("Dislike remove :D")));
                }
                EventManagment.InvokeMessageBox();
            }
        }

        [StackTraceHidden]
        public void RemoveEnjoy(int idNote)
        {
            lock (_lockObj)
            {
                using (MySqlCommand msCommand = new MySqlCommand("UPDATE note SET enjoy = enjoy - 1 WHERE id_note = @iN", DBConnection.GetConnect()))
                {
                    msCommand.Parameters.Add("@iN", MySqlDbType.Int32).Value = idNote;


                    DBConnection.DBConnect();
                    msCommand.ExecuteNonQuery();
                    DBConnection.DBCloseConnect();


                    EventManagment.SetMessageBox(new Action(() =>
                                                 MessageBox.Show("like remove :(")));
                }
                EventManagment.InvokeMessageBox();
            }
        }
    }
}
