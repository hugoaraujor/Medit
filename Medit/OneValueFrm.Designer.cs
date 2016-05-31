
namespace Medit
{
    partial class OneValueFrm
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
            this.customButton2 = new CustomButton();
            this.customButton1 = new CustomButton();
            this.textB1 = new TextB();
            this.SuspendLayout();
            // 
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.customButton2.ForeColor = System.Drawing.Color.White;
            this.customButton2.Location = new System.Drawing.Point(263, 40);
            this.customButton2.Name = "customButton2";
            this.customButton2.RoundCorners = ((Corners)((((Corners.TopLeft | Corners.TopRight) 
            | Corners.BottomLeft) 
            | Corners.BottomRight)));
            this.customButton2.Size = new System.Drawing.Size(68, 28);
            this.customButton2.TabIndex = 2;
            this.customButton2.Text = "Cancelar";
            this.customButton2.Click += new System.EventHandler(this.customButton2_Click);
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.customButton1.Enabled = false;
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(189, 39);
            this.customButton1.Name = "customButton1";
            this.customButton1.RoundCorners = ((Corners)((((Corners.TopLeft | Corners.TopRight) 
            | Corners.BottomLeft) 
            | Corners.BottomRight)));
            this.customButton1.Size = new System.Drawing.Size(68, 28);
            this.customButton1.TabIndex = 1;
            this.customButton1.Text = "Aceptar";
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // textB1
            // 
            this.textB1.AllowSpace = false;
            this.textB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textB1.Location = new System.Drawing.Point(12, 12);
            this.textB1.MaxLength = 40;
            this.textB1.Name = "textB1";
            this.textB1.Numerico = false;
            this.textB1.Size = new System.Drawing.Size(319, 22);
            this.textB1.TabIndex = 0;
            this.textB1.TextChanged += new System.EventHandler(this.textB1_TextChanged);
            // 
            // OneValueFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(343, 72);
            this.ControlBox = false;
            this.Controls.Add(this.customButton2);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.textB1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OneValueFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingrese el Valor";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextB textB1;
        private CustomButton customButton1;
        private CustomButton customButton2;
    }
}