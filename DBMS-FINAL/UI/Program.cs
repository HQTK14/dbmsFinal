﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
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
            //Application.Run(new MAINFORM());
            // Application.Run(new DANGNHAP());
            //Application.Run(new DKDA("1311325"));
            // Application.Run(new GVRDA("GV00001"));
            Application.Run(new QLMH());
        }
    }
}
