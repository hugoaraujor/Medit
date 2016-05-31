

namespace Medit
{
    partial class Clinica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clinica));
            this.customButton2 = new CustomButton();
            this.customButton1 = new CustomButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.TCiudad = new TextB();
            this.label10 = new System.Windows.Forms.Label();
            this.TResponsable = new TextB();
            this.label8 = new System.Windows.Forms.Label();
            this.TTelefonos = new TextB();
            this.label9 = new System.Windows.Forms.Label();
            this.TCorreo = new TextB();
            this.label7 = new System.Windows.Forms.Label();
            this.TDireccion4 = new TextB();
            this.label4 = new System.Windows.Forms.Label();
            this.TDireccion3 = new TextB();
            this.label3 = new System.Windows.Forms.Label();
            this.TDireccion2 = new TextB();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TDireccion1 = new TextB();
            this.TRIF = new TextB();
            this.TClinica = new TextB();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TDirExportados = new TextB();
            this.TDirImagenes = new TextB();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.TArchivo = new TextB();
            this.customButton3 = new CustomButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // customButton2
            // 
            this.customButton2.Location = new System.Drawing.Point(717, 56);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(90, 36);
            this.customButton2.TabIndex = 0;
            this.customButton2.Text = "Cancelar";
            this.customButton2.Click += new System.EventHandler(this.customButton2_Click);
            // 
            // customButton1
            // 
            this.customButton1.Location = new System.Drawing.Point(717, 12);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(90, 36);
            this.customButton1.TabIndex = 2;
            this.customButton1.Text = "Guardar";
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(819, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(688, 401);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.TCiudad);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.TResponsable);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.TTelefonos);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.TCorreo);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.TDireccion4);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.TDireccion3);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.TDireccion2);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.TDireccion1);
            this.tabPage1.Controls.Add(this.TRIF);
            this.tabPage1.Controls.Add(this.TClinica);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(680, 372);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos Clínica";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(46, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ciudad";
            // 
            // TCiudad
            // 
            this.TCiudad.AllowSpace = false;
            this.TCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCiudad.Location = new System.Drawing.Point(174, 86);
            this.TCiudad.Name = "TCiudad";
            this.TCiudad.Numerico = false;
            this.TCiudad.Size = new System.Drawing.Size(161, 22);
            this.TCiudad.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(46, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 16);
            this.label10.TabIndex = 6;
            this.label10.Text = "Responsable:";
            // 
            // TResponsable
            // 
            this.TResponsable.AllowSpace = false;
            this.TResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TResponsable.Location = new System.Drawing.Point(174, 114);
            this.TResponsable.Name = "TResponsable";
            this.TResponsable.Numerico = false;
            this.TResponsable.Size = new System.Drawing.Size(233, 22);
            this.TResponsable.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(46, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Teléfonos:";
            // 
            // TTelefonos
            // 
            this.TTelefonos.AllowSpace = false;
            this.TTelefonos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TTelefonos.Location = new System.Drawing.Point(174, 327);
            this.TTelefonos.Name = "TTelefonos";
            this.TTelefonos.Numerico = false;
            this.TTelefonos.Size = new System.Drawing.Size(302, 22);
            this.TTelefonos.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(46, 302);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Correo:";
            // 
            // TCorreo
            // 
            this.TCorreo.AllowSpace = false;
            this.TCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCorreo.Location = new System.Drawing.Point(174, 299);
            this.TCorreo.Name = "TCorreo";
            this.TCorreo.Numerico = false;
            this.TCorreo.Size = new System.Drawing.Size(302, 22);
            this.TCorreo.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(106, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "4:";
            // 
            // TDireccion4
            // 
            this.TDireccion4.AllowSpace = false;
            this.TDireccion4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TDireccion4.Location = new System.Drawing.Point(174, 250);
            this.TDireccion4.Name = "TDireccion4";
            this.TDireccion4.Numerico = false;
            this.TDireccion4.Size = new System.Drawing.Size(363, 22);
            this.TDireccion4.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(106, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "3:";
            // 
            // TDireccion3
            // 
            this.TDireccion3.AllowSpace = false;
            this.TDireccion3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TDireccion3.Location = new System.Drawing.Point(174, 222);
            this.TDireccion3.Name = "TDireccion3";
            this.TDireccion3.Numerico = false;
            this.TDireccion3.Size = new System.Drawing.Size(363, 22);
            this.TDireccion3.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(106, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "2:";
            // 
            // TDireccion2
            // 
            this.TDireccion2.AllowSpace = false;
            this.TDireccion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TDireccion2.Location = new System.Drawing.Point(174, 191);
            this.TDireccion2.Name = "TDireccion2";
            this.TDireccion2.Numerico = false;
            this.TDireccion2.Size = new System.Drawing.Size(363, 22);
            this.TDireccion2.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(46, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Dirección 1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(46, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "RIF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(46, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Razón Social:";
            // 
            // TDireccion1
            // 
            this.TDireccion1.AllowSpace = false;
            this.TDireccion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TDireccion1.Location = new System.Drawing.Point(174, 159);
            this.TDireccion1.Name = "TDireccion1";
            this.TDireccion1.Numerico = false;
            this.TDireccion1.Size = new System.Drawing.Size(363, 22);
            this.TDireccion1.TabIndex = 9;
            // 
            // TRIF
            // 
            this.TRIF.AllowSpace = false;
            this.TRIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TRIF.Location = new System.Drawing.Point(174, 58);
            this.TRIF.Name = "TRIF";
            this.TRIF.Numerico = false;
            this.TRIF.Size = new System.Drawing.Size(161, 22);
            this.TRIF.TabIndex = 3;
            // 
            // TClinica
            // 
            this.TClinica.AllowSpace = false;
            this.TClinica.BackColor = System.Drawing.Color.White;
            this.TClinica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TClinica.Location = new System.Drawing.Point(174, 30);
            this.TClinica.MaxLength = 80;
            this.TClinica.Name = "TClinica";
            this.TClinica.Numerico = false;
            this.TClinica.Size = new System.Drawing.Size(363, 22);
            this.TClinica.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.TDirExportados);
            this.tabPage2.Controls.Add(this.TDirImagenes);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(680, 372);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Directorios";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label11.ForeColor = System.Drawing.Color.Gray;
            this.label11.Location = new System.Drawing.Point(32, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(141, 16);
            this.label11.TabIndex = 6;
            this.label11.Text = "Directorio Exportados:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label12.ForeColor = System.Drawing.Color.Gray;
            this.label12.Location = new System.Drawing.Point(32, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 16);
            this.label12.TabIndex = 4;
            this.label12.Text = "Directorio Imágenes:";
            // 
            // TDirExportados
            // 
            this.TDirExportados.AllowSpace = false;
            this.TDirExportados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TDirExportados.Location = new System.Drawing.Point(205, 66);
            this.TDirExportados.Name = "TDirExportados";
            this.TDirExportados.Numerico = false;
            this.TDirExportados.Size = new System.Drawing.Size(363, 22);
            this.TDirExportados.TabIndex = 7;
            // 
            // TDirImagenes
            // 
            this.TDirImagenes.AllowSpace = false;
            this.TDirImagenes.BackColor = System.Drawing.Color.White;
            this.TDirImagenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TDirImagenes.Location = new System.Drawing.Point(205, 38);
            this.TDirImagenes.MaxLength = 80;
            this.TDirImagenes.Name = "TDirImagenes";
            this.TDirImagenes.Numerico = false;
            this.TDirImagenes.Size = new System.Drawing.Size(363, 22);
            this.TDirImagenes.TabIndex = 5;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.TArchivo);
            this.tabPage3.Controls.Add(this.customButton3);
            this.tabPage3.Controls.Add(this.pictureBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(680, 372);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Logotipo";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label13.Location = new System.Drawing.Point(238, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 16);
            this.label13.TabIndex = 3;
            this.label13.Text = "Archivo de Imagen";
            // 
            // TArchivo
            // 
            this.TArchivo.AllowSpace = false;
            this.TArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TArchivo.Location = new System.Drawing.Point(241, 74);
            this.TArchivo.Multiline = true;
            this.TArchivo.Name = "TArchivo";
            this.TArchivo.Numerico = false;
            this.TArchivo.Size = new System.Drawing.Size(308, 29);
            this.TArchivo.TabIndex = 2;
            // 
            // customButton3
            // 
            this.customButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.customButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.customButton3.Location = new System.Drawing.Point(555, 74);
            this.customButton3.Name = "customButton3";
            this.customButton3.Size = new System.Drawing.Size(105, 29);
            this.customButton3.TabIndex = 1;
            this.customButton3.Text = "Cargar Archivo";
            this.customButton3.Click += new System.EventHandler(this.customButton3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(35, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Clinica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(819, 446);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.customButton2);
            this.Controls.Add(this.customButton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Clinica";
            this.Text = "Clinica";
            this.Load += new System.EventHandler(this.Clinica_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomButton customButton1;
        private CustomButton customButton2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label13;
        private TextB TArchivo;
        private CustomButton customButton3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private TextB TDirImagenes;
        private TextB TDirExportados;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabPage2;
        private TextB TClinica;
        private TextB TRIF;
        private TextB TDireccion1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private TextB TDireccion2;
        private System.Windows.Forms.Label label3;
        private TextB TDireccion3;
        private System.Windows.Forms.Label label4;
        private TextB TDireccion4;
        private System.Windows.Forms.Label label7;
        private TextB TCorreo;
        private System.Windows.Forms.Label label9;
        private TextB TTelefonos;
        private System.Windows.Forms.Label label8;
        private TextB TResponsable;
        private System.Windows.Forms.Label label10;
        private TextB TCiudad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}