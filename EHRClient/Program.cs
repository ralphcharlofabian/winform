using System;
using System.Configuration;
using System.Windows.Forms;
using EHRClient.Service;

namespace EHRClient
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var authUrlApi = ConfigurationManager.AppSettings["AuthUrlApi"];
            var authClientId = ConfigurationManager.AppSettings["AuthClientId"];
            var authClientSecret = ConfigurationManager.AppSettings["AuthClientSecret"];
            var ehrUrlApi = ConfigurationManager.AppSettings["EHRUrlApi"];

            if (string.IsNullOrEmpty(authUrlApi) ||
                string.IsNullOrEmpty(authClientId) ||
                string.IsNullOrEmpty(authClientSecret) ||
                string.IsNullOrEmpty(ehrUrlApi))
            {
                throw new Exception("Please configure the app.config first.");
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(new AuthApiClient(), new EHRApiClient()));
        }
    }
}
