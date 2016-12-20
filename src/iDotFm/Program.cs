/*
 * iDotFm - LastFm scrobbler for iTunes
 * Dominik Cebula
 * dominikcebula@gmail.com
 * gg: 3837462
 * 
 */

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace iDotFm
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
            Application.Run(new main());
        }
    }
}
