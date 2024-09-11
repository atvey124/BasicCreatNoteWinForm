namespace BasicCreatNoteWinForm
{
    internal static class MainSolution
    {

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FormMain());
        }
    }
}