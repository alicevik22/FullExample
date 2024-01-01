using _20_ownerForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ownerForm {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        // хороший пример достучатся до элементов в др классах (3 примера)
        //https://codernotes.ru/articles/c-c/upravlenie-odnoj-formoj-iz-drugoj.html

        private void button1_Click(object sender, EventArgs e) {
            new Form2(this).Show();
            this.button1.Text = "form2";
            this.label1.Text = "form2";
        }
    }
}
