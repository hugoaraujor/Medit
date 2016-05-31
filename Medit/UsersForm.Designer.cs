

namespace Medit
{
    partial class UsersForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chActivo = new System.Windows.Forms.CheckBox();
            this.Btn_Buscar = new System.Windows.Forms.ToolStripButton();
            this.BtnEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Btn_NuevoUsuario = new System.Windows.Forms.ToolStripButton();
            this.Btn_Edita = new System.Windows.Forms.ToolStripButton();
            this.Btn_Guardar = new System.Windows.Forms.ToolStripButton();
            this.Btn_cancelar = new System.Windows.Forms.ToolStripButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtTelefonos = new TextB();
            this.txtCorreo = new TextB();
            this.txtContrasena = new TextB();
            this.txtUsuario = new TextB();
            this.comboRol = new ComboPlus();
            this.txtNombre = new TextB();
            this.txtxid = new TextB();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Location = new System.Drawing.Point(0, 400);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(721, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTelefonos);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chActivo);
            this.groupBox1.Controls.Add(this.txtCorreo);
            this.groupBox1.Controls.Add(this.txtContrasena);
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Controls.Add(this.comboRol);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtxid);
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(709, 342);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(37, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Teléfonos:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(430, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Activo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(37, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Correo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(37, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Contraseña";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(37, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(37, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Rol";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(37, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombres:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(37, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id.";
            // 
            // chActivo
            // 
            this.chActivo.AutoSize = true;
            this.chActivo.Enabled = false;
            this.chActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chActivo.Location = new System.Drawing.Point(503, 290);
            this.chActivo.Name = "chActivo";
            this.chActivo.Size = new System.Drawing.Size(15, 14);
            this.chActivo.TabIndex = 15;
            this.chActivo.UseVisualStyleBackColor = true;
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.AutoSize = false;
            this.Btn_Buscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_Buscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(75, 36);
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.AutoSize = false;
            this.BtnEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(66, 36);
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btn_NuevoUsuario,
            this.Btn_Edita,
            this.Btn_Guardar,
            this.Btn_cancelar,
            this.BtnEliminar,
            this.Btn_Buscar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(721, 39);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Btn_NuevoUsuario
            // 
            this.Btn_NuevoUsuario.AutoSize = false;
            this.Btn_NuevoUsuario.Image = ((System.Drawing.Image)(resources.GetObject("Btn_NuevoUsuario.Image")));
            this.Btn_NuevoUsuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_NuevoUsuario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_NuevoUsuario.Name = "Btn_NuevoUsuario";
            this.Btn_NuevoUsuario.Size = new System.Drawing.Size(96, 36);
            this.Btn_NuevoUsuario.Text = "Nuevo";
            this.Btn_NuevoUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_NuevoUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Btn_NuevoUsuario.Click += new System.EventHandler(this.Btn_NuevoCargo_Click);
            // 
            // Btn_Edita
            // 
            this.Btn_Edita.AutoSize = false;
            this.Btn_Edita.Image = global::Medit.Properties.Resources.edit;
            this.Btn_Edita.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_Edita.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Edita.Name = "Btn_Edita";
            this.Btn_Edita.Size = new System.Drawing.Size(96, 36);
            this.Btn_Edita.Text = "Edita";
            this.Btn_Edita.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Edita.Click += new System.EventHandler(this.Btn_Edita_Click);
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.AutoSize = false;
            this.Btn_Guardar.Enabled = false;
            this.Btn_Guardar.Image = global::Medit.Properties.Resources.saveok;
            this.Btn_Guardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_Guardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(96, 36);
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.AutoSize = false;
            this.Btn_cancelar.Enabled = false;
            this.Btn_cancelar.Image = global::Medit.Properties.Resources.savecancel;
            this.Btn_cancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_cancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(96, 36);
            this.Btn_cancelar.Text = "Cancelar";
            this.Btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // txtTelefonos
            // 
            this.txtTelefonos.AllowSpace = false;
            this.txtTelefonos.Enabled = false;
            this.txtTelefonos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonos.Location = new System.Drawing.Point(165, 282);
            this.txtTelefonos.Name = "txtTelefonos";
            this.txtTelefonos.Numerico = false;
            this.txtTelefonos.Size = new System.Drawing.Size(232, 22);
            this.txtTelefonos.TabIndex = 13;
            // 
            // txtCorreo
            // 
            this.txtCorreo.AllowSpace = false;
            this.txtCorreo.Enabled = false;
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(165, 244);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Numerico = false;
            this.txtCorreo.Size = new System.Drawing.Size(265, 22);
            this.txtCorreo.TabIndex = 11;
            this.txtCorreo.Validating += new System.ComponentModel.CancelEventHandler(this.txtCorreo_Validating);
            this.txtCorreo.Validated += new System.EventHandler(this.txtCorreo_Validated);
            // 
            // txtContrasena
            // 
            this.txtContrasena.AllowSpace = false;
            this.txtContrasena.Enabled = false;
            this.txtContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.Location = new System.Drawing.Point(165, 205);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Numerico = false;
            this.txtContrasena.Size = new System.Drawing.Size(154, 22);
            this.txtContrasena.TabIndex = 9;
            this.txtContrasena.UseSystemPasswordChar = true;
            this.txtContrasena.Validating += new System.ComponentModel.CancelEventHandler(this.txtContrasena_Validating);
            this.txtContrasena.Validated += new System.EventHandler(this.txtContrasena_Validated);
            // 
            // txtUsuario
            // 
            this.txtUsuario.AllowSpace = false;
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(165, 169);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Numerico = false;
            this.txtUsuario.Size = new System.Drawing.Size(154, 22);
            this.txtUsuario.TabIndex = 7;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            this.txtUsuario.Validating += new System.ComponentModel.CancelEventHandler(this.txtUsuario_Validating);
            this.txtUsuario.Validated += new System.EventHandler(this.txtUsuario_Validated);
            // 
            // comboRol
            // 
            this.comboRol.addMsg = false;
            this.comboRol.Autoadd = true;
            this.comboRol.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboRol.Enabled = false;
            this.comboRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboRol.FormattingEnabled = true;
            this.comboRol.Items.AddRange(new object[] {
            "Operador",
            "Supervisor",
            "Administrador",
            "Master",
            "System"});
            this.comboRol.Location = new System.Drawing.Point(165, 123);
            this.comboRol.Name = "comboRol";
            this.comboRol.SelectedBackColor = System.Drawing.Color.LightSeaGreen;
            this.comboRol.Size = new System.Drawing.Size(191, 23);
            this.comboRol.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.AllowSpace = false;
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(165, 75);
            this.txtNombre.MaxLength = 80;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Numerico = false;
            this.txtNombre.Size = new System.Drawing.Size(346, 22);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.Validating += new System.ComponentModel.CancelEventHandler(this.txtNombre_Validating);
            this.txtNombre.Validated += new System.EventHandler(this.txtNombre_Validated);
            // 
            // txtxid
            // 
            this.txtxid.AllowSpace = false;
            this.txtxid.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtxid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtxid.Enabled = false;
            this.txtxid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtxid.Location = new System.Drawing.Point(165, 41);
            this.txtxid.Name = "txtxid";
            this.txtxid.Numerico = false;
            this.txtxid.Size = new System.Drawing.Size(100, 15);
            this.txtxid.TabIndex = 1;
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(721, 422);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UsersForm";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.UsersForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chActivo;
        private TextB txtCorreo;
        private TextB txtContrasena;
        private TextB txtUsuario;
        private ComboPlus comboRol;
        private TextB txtNombre;
        private TextB txtxid;
        private System.Windows.Forms.ToolStripButton Btn_Buscar;
        private System.Windows.Forms.ToolStripButton BtnEliminar;
        private System.Windows.Forms.ToolStripButton Btn_cancelar;
        private System.Windows.Forms.ToolStripButton Btn_Guardar;
        private System.Windows.Forms.ToolStripButton Btn_Edita;
        private System.Windows.Forms.ToolStripButton Btn_NuevoUsuario;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label label3;
        private TextB txtTelefonos;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}