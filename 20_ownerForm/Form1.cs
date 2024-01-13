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
            if (Application.OpenForms["Form2"] == null) // если форма не открыта
                new Form2(this).Show();
            this.button1.Text = "form2";
            this.label1.Text = "form2";
        }


        // использование элемента в другом потоке

        //on WinForm
        //progressBar1.Invoke(new Action(() => 
        //{ 
        //    progressBar1.Value = (((double)progress / progressTotal) * 100)+1;
        //}));

        //on WPF
        //this.Dispatcher.Invoke((Action)(() => {
        //    progressBar1.Value = progress + 1;
        //}));
    }
}
