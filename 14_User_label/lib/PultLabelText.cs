using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace Burevestnik {
    public class LabelText : Label {

        #region Настройки
        /// <summary>Возвращает или устанавливает надпись названия (значения)</summary>
        [Description("Текст названия")]
        [DefaultValue("FirstText:")]
        [Category("Буревестник")]
        public string FirstString { get { return this._firstString; } set { this._firstString = value; } }
        private string _firstString = "FirstText:";
        /// <summary>Возвращает или устанавливает начало надписи 2го элемента (значения)</summary>
        [Description("Начало 2го элемента")]
        [DefaultValue(60)]
        [Category("Буревестник")]
        public int LocationWidth { get { return this._locationWidth; } set { this._locationWidth = value; } }
        private int _locationWidth = 60;
        /// <summary>Возвращает или устанавливает надпись названия (значения)</summary>
        [Description("Значение по умолчанию")]
        [DefaultValue("SecondText")]
        [Category("Буревестник")]
        public string SecondString { get { return this._secondString; } set { this._secondString = value; } }
        private string _secondString = "SecondText";
        #endregion

        private Label _labelSecond = new Label();
        private Color _lableSecondColorDefault = Color.RoyalBlue;
        private Color _lableSecondColorError = Color.Red;
        private bool _load = true;

        public LabelText() {
            this.Size = new System.Drawing.Size(138, 13);
            this.AutoSize = false;
            Controls.Add(_labelSecond);
            //_labelSecond.Location = new Point(this.CreateParams.Width, 0);
            _labelSecond.AutoSize = true;
            _labelSecond.ForeColor = _lableSecondColorDefault;
        }

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e) {
            base.OnPaint(e);
            if (_load) {
                _load = false;
                this.Text = _firstString;
                _labelSecond.Location = new Point(_locationWidth, 0);
                _labelSecond.Text = _secondString;
            }
        }

        // выводит int в _labelSecond
        public void setSecondText(int value, int max, int min) {
            _labelSecond.Text = Convert.ToString(value);
            if (max != 0 && min != 0) {
                if (value > max || value < min) {
                    _labelSecond.ForeColor = _lableSecondColorError;
                    return;
                }
            }
            _labelSecond.ForeColor = _lableSecondColorDefault;
        }

        // Установка значения _labelSecond
        public void setSecondText(string text) {
            _labelSecond.Text = text;
        }

        // Установка значения _labelSecond
        public void setSecondText(int num, int pozitionColor, string[] text) {
            if (num >= text.Length) {
                _labelSecond.Text = "error not format";
                _labelSecond.ForeColor = _lableSecondColorError;
                return;
            }
            _labelSecond.Text = text[num];
            if (((pozitionColor >> num) & 0x1) == 1)
                _labelSecond.ForeColor = _lableSecondColorError;
            else
                _labelSecond.ForeColor = _lableSecondColorDefault;
        }

    }
}