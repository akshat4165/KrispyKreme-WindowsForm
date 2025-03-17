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

            LoginForm loginForm = new LoginForm();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                // ✅ Retrieve the username stored in LoginForm.Tag
                string loggedInUser = loginForm.Tag as string ?? "default_user";
                Application.Run(new Form1(loggedInUser));
            }

        }
    }
}