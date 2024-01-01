using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_Extensions {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            // добавление метода в существующий
            label1.Red();
        }
    }
    public static class ext{
        public static void Red(this Label lab) {
            lab.ForeColor = System.Drawing.Color.Red;
        }
    }
}
