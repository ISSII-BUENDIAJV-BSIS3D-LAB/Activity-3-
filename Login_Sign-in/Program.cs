namespace Login_Sign_in
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {

            // https://aka.ms/applicationconfiguration
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
