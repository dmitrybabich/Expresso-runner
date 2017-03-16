using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ultrapico.Expresso;

namespace RunMe
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var mainForm = new MainForm(new string[0]);
            mainForm.registration.AlreadyRegistered = true;
            mainForm.registration.UserName = "%Skipped%";
            Application.Run(mainForm);
        }
    }
}
