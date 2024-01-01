using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19_FormsHeader {
    class HeadInterface : Panel {

        #region Настройки

        // Использовать ?
        [Description("Использовать \"?\"")]
        [DefaultValue(true)]
        [Category("Settings Head")]
        public bool BoolQ { get { return this._boolQ; } set { this._boolQ = value; } }
        private bool _boolQ = true;

        // Высота окна
        [Description("Высота окна")]
        [DefaultValue(100)]
        [Category("Settings Head")]
        public int IntHeight { get { return this._IntHeight; } set { this._IntHeight = value; } }
        private int _IntHeight = 100;

        // Ширина окна
        [Description("Ширина окна")]
        [DefaultValue(100)]
        [Category("Settings Head")]
        public int IntWidth { get { return this._IntWidth; } set { this._IntWidth = value; } }
        private int _IntWidth = 100;

        // Возвращает или устанавливает надпись названия
        [Description("Название окна")]
        [DefaultValue("Window")]
        [Category("Settings Head")]
        public string StringTitle { get { return this._stringTitle; } set { this._stringTitle = value; } }
        private string _stringTitle = "Window";

        //цвет шапки
        private Color _ColorHead = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));

        //цвет рамки
        private Color _ColorBorder = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));

        // цвет титульного шрифта
        private Color _ColorTitleFont = System.Drawing.Color.Coral;
        #endregion

        protected static Form2 newForm2;

        private Button buttonClouse;
        private Button buttonInfo;
        private Button buttonMinimized;
        private Panel panelHead;
        private Label labelTitle;
        private PictureBox pictureBoxLogo = new System.Windows.Forms.PictureBox();

        static bool drag = false;
        Point startPoint = new Point(0, 0);

        // перрерисовываем с настройки
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e) {
            base.OnPaint(e);
            labelTitle.Text = _stringTitle;
            panelHead.Size = new System.Drawing.Size(_IntWidth - 4, 27);
            buttonClouse.Location = new System.Drawing.Point(_IntWidth - 27, 0);
            if (_boolQ) {
                buttonInfo.Location = new System.Drawing.Point(_IntWidth - 27 - 27, 0);
                buttonMinimized.Location = new System.Drawing.Point(_IntWidth - 27 - 27 - 27, 0);
            }

            Pen p = new Pen(_ColorHead, 2);
            e.Graphics.DrawRectangle(p, 1, 1, this.Width - 2, this.Height - 2);
            p.Dispose();
        }

        public HeadInterface() {
            buttonClouse = new System.Windows.Forms.Button();
            buttonInfo = new System.Windows.Forms.Button();
            buttonMinimized = new System.Windows.Forms.Button();
            panelHead = new System.Windows.Forms.Panel();
            labelTitle = new System.Windows.Forms.Label();
            pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBoxLogo)).BeginInit();
            // 
            // panelHead
            // 
            panelHead.BackColor = _ColorHead;
            panelHead.Controls.Add(labelTitle);
            panelHead.Controls.Add(pictureBoxLogo);
            if (_boolQ) {
                panelHead.Controls.Add(buttonInfo);
                panelHead.Controls.Add(buttonMinimized);
            }
            panelHead.Controls.Add(buttonClouse);
            panelHead.Location = new System.Drawing.Point(2, 2);
            panelHead.Name = "panel1";
            panelHead.Size = new System.Drawing.Size(500, 27 + 2);
            panelHead.TabIndex = 0;
            panelHead.ResumeLayout(false);
            panelHead.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            panelHead.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            panelHead.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            //
            // buttonClouse
            // 
            buttonClouse.Dock = System.Windows.Forms.DockStyle.Right;
            buttonClouse.FlatAppearance.BorderSize = 0;
            buttonClouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonClouse.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonClouse.ForeColor = System.Drawing.Color.White;
            buttonClouse.Location = new System.Drawing.Point(473, 2);
            buttonClouse.Name = "buttonClouse";
            buttonClouse.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            buttonClouse.Size = new System.Drawing.Size(27, 27);
            buttonClouse.TabIndex = 1;
            buttonClouse.Text = "X";
            buttonClouse.UseVisualStyleBackColor = true;
            buttonClouse.Click += new System.EventHandler(this.buttonClouse_Click);
            buttonClouse.MouseEnter += new System.EventHandler(this.buttonClouse_MouseEnter);
            buttonClouse.MouseLeave += new System.EventHandler(this.buttonClouse_MouseLeave);
            if (_boolQ) {
                // 
                // buttonInfo
                // 
                buttonInfo.Dock = System.Windows.Forms.DockStyle.Right;
                buttonInfo.FlatAppearance.BorderSize = 0;
                buttonInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                buttonInfo.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                buttonInfo.ForeColor = System.Drawing.Color.White;
                buttonInfo.Location = new System.Drawing.Point(446, 2);
                buttonInfo.Name = "buttonInfo";
                buttonInfo.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
                buttonInfo.Size = new System.Drawing.Size(27, 27);
                buttonInfo.TabIndex = 2;
                buttonInfo.Text = "?";
                buttonInfo.UseVisualStyleBackColor = true;
                buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
                buttonInfo.MouseEnter += new System.EventHandler(this.buttonInfo_MouseEnter);
                buttonInfo.MouseLeave += new System.EventHandler(this.buttonInfo_MouseLeave);
                // 
                // buttonMaximized
                // 
                buttonMinimized.Dock = System.Windows.Forms.DockStyle.Right;
                buttonMinimized.FlatAppearance.BorderSize = 0;
                buttonMinimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                buttonMinimized.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                buttonMinimized.ForeColor = System.Drawing.Color.White;
                buttonMinimized.Location = new System.Drawing.Point(419, 2);
                buttonMinimized.Name = "button1";
                buttonMinimized.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
                buttonMinimized.Size = new System.Drawing.Size(27, 27);
                buttonMinimized.TabIndex = 3;
                buttonMinimized.Text = "__";
                buttonMinimized.UseVisualStyleBackColor = true;
                buttonMinimized.Click += new System.EventHandler(this.buttonMinimized_Click);
                buttonMinimized.MouseEnter += new System.EventHandler(this.buttonMinimized_MouseEnter);
                buttonMinimized.MouseLeave += new System.EventHandler(this.buttonMinimized_MouseLeave);
            }
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Left;
            pictureBoxLogo.Location = new System.Drawing.Point(2, 2);
            pictureBoxLogo.Name = "pictureBox1";
            pictureBoxLogo.Size = new System.Drawing.Size(27, 27);
            pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 1;
            pictureBoxLogo.TabStop = false;
            pictureBoxLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            pictureBoxLogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            pictureBoxLogo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // labelTitle
            // 
            labelTitle.Dock = System.Windows.Forms.DockStyle.Left;
            labelTitle.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            labelTitle.ForeColor = _ColorTitleFont;
            labelTitle.Location = new System.Drawing.Point(27 + 2, 2);
            labelTitle.Padding = new System.Windows.Forms.Padding(2, 4, 0, 0);
            labelTitle.Size = new System.Drawing.Size(128, 27);
            labelTitle.TabIndex = 1;
            labelTitle.Text = _stringTitle;
            labelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            labelTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            labelTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);

            Controls.Add(this.panelHead);
            this.panelHead.SuspendLayout();
            this.SuspendLayout();


        }

        private void buttonInfo_Click(object sender, EventArgs e) {
            //string msg = "Info";
            //MessageBox.Show(msg);
            newForm2 = new Form2();
            newForm2.Show();
        }

        private void buttonClouse_Click(object sender, EventArgs e) {
            if (Form.ActiveForm.Text == "Form2") {
                if (newForm2 != null) {
                    newForm2.Close();
                    newForm2.Dispose();
                }

            } else
                Application.Exit();
        }
        private void buttonMinimized_Click(object sender, EventArgs e) {
            if (Form.ActiveForm.Text == "Form2") {
                newForm2.WindowState = FormWindowState.Minimized;
            } else {
                Program.GlobalForm1.WindowState = FormWindowState.Minimized;
            }
        }
        private void buttonMinimized_MouseEnter(object sender, EventArgs e) {
            this.buttonMinimized.BackColor = Color.Gray;
        }
        private void buttonInfo_MouseLeave(object sender, EventArgs e) {
            this.buttonInfo.BackColor = _ColorHead;
        }
        private void buttonInfo_MouseEnter(object sender, EventArgs e) {
            this.buttonInfo.BackColor = Color.Gray;
        }
        private void buttonMinimized_MouseLeave(object sender, EventArgs e) {
            this.buttonMinimized.BackColor = _ColorHead;
        }
        private void buttonClouse_MouseEnter(object sender, EventArgs e) {
            this.buttonClouse.BackColor = Color.Red;
        }
        private void buttonClouse_MouseLeave(object sender, EventArgs e) {
            this.buttonClouse.BackColor = Color.FromArgb(64, 64, 64);
        }




        private void panel1_MouseDown(object sender, MouseEventArgs e) {
            drag = true;
            startPoint = new Point(e.X, e.Y);
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e) {
            if (drag) {
                Point p = PointToScreen(e.Location);
                if (Form.ActiveForm.Text == "Form2") {
                    newForm2.Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
                } else {
                    Program.GlobalForm1.Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
                }
            }
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e) {
            drag = false;
        }
        // TODO подвинуть кнопки
        // и проработать фокусы
    }
}
