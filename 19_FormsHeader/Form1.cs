using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19_FormsHeader {
    public partial class Form1 : Form {

        // хороший пример достучатся до элементов в др классах
        //https://codernotes.ru/articles/c-c/upravlenie-odnoj-formoj-iz-drugoj.html

        public Form1() {
            InitializeComponent();
            Program.GlobalForm1 = this; // GlobalForm1 будет ссылкой на форму Form1
        }


    }
}
