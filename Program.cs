﻿using System;
using System.Windows.Forms;
using WindowsFormsAppFinalTestReject;

namespace WindowsFormsAppWithDatabase
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
            Application.Run(new Form2());

        }
    }
}
