using MySqlConnector;
using System.Threading;


namespace BasicCreatNoteWinForm
{
    static class ControlHelper
    {
        public static void InvokeExAction(this Control control,Action action)
        {
            if (control.InvokeRequired)
                control.Invoke(action);
            else
                action();
        }

        public static void InvokeExCallback(this Control control,WaitCallback waitCallback,object param) 
        {
            if (control.InvokeRequired)
                control.Invoke(waitCallback, param);
            else
                waitCallback(param);
        }
    }
}
