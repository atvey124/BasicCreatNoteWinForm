using MySqlConnector;
using System.Diagnostics;

namespace BasicCreatNoteWinForm
{
    
    class UpdateManagment
    {
        private object _lockObj = new object();


        [StackTraceHidden]
        public void AddEnjoyNote(int idNote)
        {
            lock (_lockObj)
            {
                using (MySqlCommand msCommand = new MySqlCommand("UPDATE note SET enjoy = enjoy + 1 WHERE id_note = @iN", DBManagment.GetConnect()))
                {
                    msCommand.Parameters.Add("@iN", MySqlDbType.Int32).Value = idNote;


                    DBManagment.DBConnect();
                    msCommand.ExecuteNonQuery();
                    DBManagment.DBCloseConnect();


                    EventManagment.SetMessageBox(new Action(() =>
                                                 MessageBox.Show("Like add succesfully :D")));
                }
                EventManagment.InvokeMessageBox();
            }
        }

        [StackTraceHidden]
        public void AddUnenjoyNote(int idNote)
        {
            lock (_lockObj)
            {
                using (MySqlCommand msCommand = new MySqlCommand("UPDATE note SET unenjoy = unenjoy + 1 WHERE id_note = @iN", DBManagment.GetConnect()))
                {
                    msCommand.Parameters.Add("@iN", MySqlDbType.Int32).Value = idNote;


                    DBManagment.DBConnect();
                    msCommand.ExecuteNonQuery();
                    DBManagment.DBCloseConnect();


                    EventManagment.SetMessageBox(new Action(() =>
                                                 MessageBox.Show("Dislike add succesfully :(")));
                }
                EventManagment.InvokeMessageBox();
            }
        }

        [StackTraceHidden]
        public void RemoveUnenjoyNote(int idNote)
        {
            lock (_lockObj)
            {
                using (MySqlCommand msCommand = new MySqlCommand("UPDATE note SET unenjoy = unenjoy - 1 WHERE id_note = @iN", DBManagment.GetConnect()))
                {
                    msCommand.Parameters.Add("@iN", MySqlDbType.Int32).Value = idNote;


                    DBManagment.DBConnect();
                    msCommand.ExecuteNonQuery();
                    DBManagment.DBCloseConnect();


                    EventManagment.SetMessageBox(new Action(() =>
                                                 MessageBox.Show("Dislike remove :D")));
                }
                EventManagment.InvokeMessageBox();
            }
        }

        [StackTraceHidden]
        public void RemoveEnjoyNote(int idNote)
        {
            lock (_lockObj)
            {
                using (MySqlCommand msCommand = new MySqlCommand("UPDATE note SET enjoy = enjoy - 1 WHERE id_note = @iN", DBManagment.GetConnect()))
                {
                    msCommand.Parameters.Add("@iN", MySqlDbType.Int32).Value = idNote;


                    DBManagment.DBConnect();
                    msCommand.ExecuteNonQuery();
                    DBManagment.DBCloseConnect();


                    EventManagment.SetMessageBox(new Action(() =>
                                                 MessageBox.Show("like remove :(")));
                }
                EventManagment.InvokeMessageBox();
            }
        }
    }
}
