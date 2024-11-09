namespace Database_B_tree
{
    
    internal static class Program
    {
        const string First_Head="Head.txt";
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() { 
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            Console.WriteLine("");
        }
    }
}