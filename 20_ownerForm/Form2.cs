using ownerForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20_ownerForm {
    public partial class Form2 : Form {
        public readonly Form1 form1;
        public Form2(Form1 owner) {
            form1 = owner;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) {
            //незабыть убрать уровено защиты: modifiers
            form1.button1.Text = "получилось";
            form1.label1.Text = "получилось";
        }
    }
}
