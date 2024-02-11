using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_User_label {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            pultTrackBar1.Value = 0;
        }

        private void pultTrackBar1_TrackBar_Scroll(int value) {
            labelText1.setSecondText(pultTrackBar1.Value.ToString());
        }

        private static int cnt;
        private void button2_Click(object sender, EventArgs e) {
            labelText1.setSecondText(cnt, 0x2A, new string[] { "zero" ,"first", "tright", "fore"});
            if (cnt++ > 4) cnt = 0;
        }
    }
}
