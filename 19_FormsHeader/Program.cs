﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19_FormsHeader {
    static class Program {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        public static Form1 GlobalForm1; // переменная, которая будет содержать ссылку на форму Form1
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
