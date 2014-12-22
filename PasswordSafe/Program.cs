using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;
using PasswordSafe.Model;
using PasswordSafe.View;


namespace PasswordSafe
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
            
            Encryption en = new Encryption();
            string file = @"./filedata";
            if (!File.Exists(file))
                Application.Run(new ChangePassword());
            Application.Run(new DialogBox());     
        }
    }
}
