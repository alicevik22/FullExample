using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace Burevestnik {

    public class PultTrackBar : Panel {

        #region Настройки

        #endregion

        public delegate void Handler0(int value);
        public event Handler0 TrackBar_Scroll;

        private TrackBar _trackBar = new TrackBar();
        private Label _label = new Label();
        private int _value;

        public int Value {
            get { return _trackBar.Value; }
            set {
                _value = _trackBar.Value = value;
                _trackBar_Scroll(null, null);
            }
        }


        public PultTrackBar() {
            this.Size = new System.Drawing.Size(167, 57);
            this.Controls.Add(_trackBar);
            this.Controls.Add(_label);

            _trackBar.Scroll += new System.EventHandler(this._trackBar_Scroll);
            _trackBar.LargeChange = 1;
            _trackBar.Location = new System.Drawing.Point(2, 21);
            _trackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            _trackBar.Size = new System.Drawing.Size(136, 45);

            _label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            _label.Size = new System.Drawing.Size(30, 18);
            _label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            _label.Text = Value.ToString();
            _label.Location = new Point((this.Width - 50) / (_trackBar.Maximum - _trackBar.Minimum) * Value, 1);
            _label.BackColor = System.Drawing.SystemColors.ScrollBar;
        }

        private void _trackBar_Scroll(object sender, EventArgs e) {
            _label.Text = string.Format("{0}", Value);
            _label.Location = new Point((this.Width - 50) / (_trackBar.Maximum - _trackBar.Minimum) * Value, 1);
            if (TrackBar_Scroll != null) TrackBar_Scroll(Value);
        }

        //protected override void OnValueChanged(EventArgs e) {
        //    base.OnValueChanged(e);
        //}
    }
}
