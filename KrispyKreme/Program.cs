using YourNamespace;

namespace KrispyKreme
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Create an instance of LoginForm
            LoginForm loginForm = new LoginForm();

            // Show LoginForm first
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Form1()); // Open Form1 after successful login
            }
        }
    }
}