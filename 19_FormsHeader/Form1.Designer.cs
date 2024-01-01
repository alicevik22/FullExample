using System.Drawing;
using System.Windows.Forms;
namespace _19_FormsHeader {
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
            this.headInterface1 = new _19_FormsHeader.HeadInterface();
            this.label1 = new System.Windows.Forms.Label();
            this.headInterface1.SuspendLayout();
            this.SuspendLayout();
            // 
            // headInterface1
            // 
            this.headInterface1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.headInterface1.Controls.Add(this.label1);
            this.headInterface1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headInterface1.IntHeight = 222;
            this.headInterface1.IntWidth = 555;
            this.headInterface1.Location = new System.Drawing.Point(0, 0);
            this.headInterface1.Name = "headInterface1";
            this.headInterface1.Size = new System.Drawing.Size(555, 222);
            this.headInterface1.StringTitle = "J";
            this.headInterface1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(57, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 222);
            this.Controls.Add(this.headInterface1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "Form1";
            this.Text = "Form1";
            this.headInterface1.ResumeLayout(false);
            this.headInterface1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private HeadInterface headInterface1;
        private Label label1;




    }
}

