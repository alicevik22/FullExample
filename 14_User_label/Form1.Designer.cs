namespace _14_User_label {
    partial class Form1 {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pultTrackBar1 = new Burevestnik.PultTrackBar();
            this.labelText1 = new Burevestnik.LabelText();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Zero";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(197, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Step";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pultTrackBar1
            // 
            this.pultTrackBar1.Location = new System.Drawing.Point(12, 36);
            this.pultTrackBar1.Name = "pultTrackBar1";
            this.pultTrackBar1.Size = new System.Drawing.Size(167, 57);
            this.pultTrackBar1.TabIndex = 1;
            this.pultTrackBar1.Value = 0;
            this.pultTrackBar1.TrackBar_Scroll += new Burevestnik.PultTrackBar.Handler0(this.pultTrackBar1_TrackBar_Scroll);
            // 
            // labelText1
            // 
            this.labelText1.Location = new System.Drawing.Point(12, 9);
            this.labelText1.Name = "labelText1";
            this.labelText1.Size = new System.Drawing.Size(138, 13);
            this.labelText1.TabIndex = 0;
            this.labelText1.Text = "FirstText2:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pultTrackBar1);
            this.Controls.Add(this.labelText1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Burevestnik.LabelText labelText1;
        private Burevestnik.PultTrackBar pultTrackBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

