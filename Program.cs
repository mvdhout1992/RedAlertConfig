using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RedAlertConfig;

namespace RedAlertConfig
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

            Form MainForm = new Form1();
            Application.Run(MainForm);

            // MainForm.l
        }
    }
}
