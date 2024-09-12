using MySqlConnector;
using System.Data;
using System.Diagnostics;


namespace BasicCreatNoteWinForm
{
    static class DBConnection
    {
        private static readonly MySqlConnection DBconnect = new MySqlConnection("server=localhost;port=3306;username=root;password=1234;database=main_db;Allow User Variables=True");


        [StackTraceHidden]
        public static void DBConnect()
        {
            if (DBconnect.State == System.Data.ConnectionState.Closed)
                DBconnect.Open();
        }

        [StackTraceHidden]
        public static void DBCloseConnect()
        {
            if (DBconnect.State == System.Data.ConnectionState.Open)
                DBconnect.Close();
        }

        [StackTraceHidden]
        public static MySqlConnection GetConnect()
        {
            return DBconnect;
        }
    }
}