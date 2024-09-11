using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCreatNoteWinForm
{
    static class EventManagment
    {
        private static event Action MessageBoxError;
        private static event Action MessageString;

        static public void InvokeMessageBox()
        {
            if (MessageBoxError != null)
                MessageBoxError.Invoke();

            MessageBoxError = null;
        }

        static public void InvokeMessageString()
        {
            if(MessageString != null)
                MessageString.Invoke();

            MessageString = null;
        }

        static public void SetMessageString(Action actionEvent) 
        {
            MessageString += actionEvent;
        }

        static public void SetMessageBox(Action actionEvent)
        {
            MessageBoxError += actionEvent;
        }


    }


}
