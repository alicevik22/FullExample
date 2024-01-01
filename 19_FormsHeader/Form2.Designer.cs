namespace _19_FormsHeader {
    partial class Form2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.headInterface1 = new _19_FormsHeader.HeadInterface();
            this.SuspendLayout();
            // 
            // headInterface1
            // 
            this.headInterface1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.headInterface1.BoolQ = false;
            this.headInterface1.IntHeight = 200;
            this.headInterface1.IntWidth = 280;
            this.headInterface1.Location = new System.Drawing.Point(0, 0);
            this.headInterface1.Name = "headInterface1";
            this.headInterface1.Size = new System.Drawing.Size(280, 200);
            this.headInterface1.StringTitle = "Info";
            this.headInterface1.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 200);
            this.Controls.Add(this.headInterface1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private HeadInterface headInterface1;
    }
}