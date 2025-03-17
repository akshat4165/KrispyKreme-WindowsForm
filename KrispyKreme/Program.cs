using System;
using System.Windows.Forms;

namespace KrispyKreme
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            bool restart;
            do
            {
                restart = false;
                LoginForm loginForm = new LoginForm();

                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    string loggedInUser = loginForm.Tag as string ?? "default_user";

                    Form1 mainForm = new Form1(loggedInUser);

                    // ✅ Handle logout properly
                    mainForm.FormClosed += (s, e) => { restart = mainForm.Tag as string == "restart"; };

                    Application.Run(mainForm);
                }

            } while (restart); // ✅ Restart login process when logging out
        }
    }
}
