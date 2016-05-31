

namespace Medit
{
    partial class IdEntry
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textB1 = new TextB();
            this.customButton1 = new CustomButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textB1
            // 
            this.textB1.AllowSpace = false;
            this.textB1.ForeColor = System.Drawing.Color.Black;
            this.textB1.Location = new System.Drawing.Point(95, 12);
            this.textB1.Name = "textB1";
            this.textB1.Numerico = false;
            this.textB1.Size = new System.Drawing.Size(100, 20);
            this.textB1.TabIndex = 0;
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.White;
            this.customButton1.ForeColor = System.Drawing.Color.Black;
            this.customButton1.Location = new System.Drawing.Point(201, 9);
            this.customButton1.Name = "customButton1";
            this.customButton1.RoundCorners = ((Corners)((((Corners.TopLeft | Corners.TopRight) 
            | Corners.BottomLeft) 
            | Corners.BottomRight)));
            this.customButton1.Size = new System.Drawing.Size(75, 26);
            this.customButton1.TabIndex = 1;
            this.customButton1.Text = "Aceptar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Identificación";
            // 
            // IdEntry
            // 
            this.AcceptButton = this.customButton1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(328, 47);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.textB1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IdEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Identificación";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.IdEntry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextB textB1;
        private CustomButton customButton1;
        private System.Windows.Forms.Label label1;
    }
}