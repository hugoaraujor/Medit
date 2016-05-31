

namespace Medit
{
    partial class Cargos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cargos));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Btn_NuevoCargo = new System.Windows.Forms.ToolStripButton();
            this.Btn_EditarCargo = new System.Windows.Forms.ToolStripButton();
            this.Btn_GuardarCargo = new System.Windows.Forms.ToolStripButton();
            this.Btn_cancelarEdicionCargo = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.Btn_BuscarCargo = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.combolus1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Panel1 = new System.Windows.Forms.GroupBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Panel2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.customButton1 = new Medit.CustomButton();
            this.customButton2 = new Medit.CustomButton();
            this.textB7 = new Medit.TextB();
            this.textB6 = new Medit.TextB();
            this.comboPlus1 = new Medit.ComboPlus();
            this.comboPlus2 = new Medit.ComboPlus();
            this.textB1 = new Medit.TextB();
            this.textB5 = new Medit.TextB();
            this.textB4 = new Medit.TextB();
            this.textB2 = new Medit.TextB();
            this.textB3 = new Medit.TextB();
            this.toolStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btn_NuevoCargo,
            this.Btn_EditarCargo,
            this.Btn_GuardarCargo,
            this.Btn_cancelarEdicionCargo,
            this.toolStripButton1,
            this.Btn_BuscarCargo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(626, 39);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // Btn_NuevoCargo
            // 
            this.Btn_NuevoCargo.AutoSize = false;
            this.Btn_NuevoCargo.Image = ((System.Drawing.Image)(resources.GetObject("Btn_NuevoCargo.Image")));
            this.Btn_NuevoCargo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_NuevoCargo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_NuevoCargo.Name = "Btn_NuevoCargo";
            this.Btn_NuevoCargo.Size = new System.Drawing.Size(96, 36);
            this.Btn_NuevoCargo.Text = "Nuevo";
            this.Btn_NuevoCargo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_NuevoCargo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Btn_NuevoCargo.Click += new System.EventHandler(this.Btn_NuevoCargo_Click);
            // 
            // Btn_EditarCargo
            // 
            this.Btn_EditarCargo.AutoSize = false;
            this.Btn_EditarCargo.Image = global::Medit.Properties.Resources.edit;
            this.Btn_EditarCargo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_EditarCargo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_EditarCargo.Name = "Btn_EditarCargo";
            this.Btn_EditarCargo.Size = new System.Drawing.Size(96, 36);
            this.Btn_EditarCargo.Text = "Edita";
            this.Btn_EditarCargo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_EditarCargo.Click += new System.EventHandler(this.Btn_EditarCargo_Click);
            // 
            // Btn_GuardarCargo
            // 
            this.Btn_GuardarCargo.AutoSize = false;
            this.Btn_GuardarCargo.Enabled = false;
            this.Btn_GuardarCargo.Image = global::Medit.Properties.Resources.saveok;
            this.Btn_GuardarCargo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_GuardarCargo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_GuardarCargo.Name = "Btn_GuardarCargo";
            this.Btn_GuardarCargo.Size = new System.Drawing.Size(96, 36);
            this.Btn_GuardarCargo.Text = "Guardar";
            this.Btn_GuardarCargo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_GuardarCargo.Click += new System.EventHandler(this.Btn_GuardarCargo_Click);
            // 
            // Btn_cancelarEdicionCargo
            // 
            this.Btn_cancelarEdicionCargo.AutoSize = false;
            this.Btn_cancelarEdicionCargo.Enabled = false;
            this.Btn_cancelarEdicionCargo.Image = global::Medit.Properties.Resources.savecancel;
            this.Btn_cancelarEdicionCargo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_cancelarEdicionCargo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_cancelarEdicionCargo.Name = "Btn_cancelarEdicionCargo";
            this.Btn_cancelarEdicionCargo.Size = new System.Drawing.Size(96, 36);
            this.Btn_cancelarEdicionCargo.Text = "Cancelar";
            this.Btn_cancelarEdicionCargo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_cancelarEdicionCargo.Click += new System.EventHandler(this.Btn_cancelarEdicionCargo_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(66, 36);
            this.toolStripButton1.Text = "Eliminar";
            this.toolStripButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Btn_BuscarCargo
            // 
            this.Btn_BuscarCargo.AutoSize = false;
            this.Btn_BuscarCargo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_BuscarCargo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_BuscarCargo.Name = "Btn_BuscarCargo";
            this.Btn_BuscarCargo.Size = new System.Drawing.Size(75, 36);
            this.Btn_BuscarCargo.Text = "Buscar";
            this.Btn_BuscarCargo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_BuscarCargo.Click += new System.EventHandler(this.Btn_BuscarCargo_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 527);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(626, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // combolus1
            // 
            this.combolus1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.combolus1.FormattingEnabled = true;
            this.combolus1.Location = new System.Drawing.Point(122, 28);
            this.combolus1.Name = "combolus1";
            this.combolus1.Size = new System.Drawing.Size(404, 24);
            this.combolus1.TabIndex = 0;
            this.combolus1.SelectedIndexChanged += new System.EventHandler(this.combolus1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(508, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Kit ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(384, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cargo Id.";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(536, 150);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 14;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(24, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Clasificación";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(448, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 24);
            this.button1.TabIndex = 12;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(467, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Inventario";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(24, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Precio 3:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(24, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Precio 2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(24, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio 1:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(536, 203);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(24, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripción";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Panel1);
            this.flowLayoutPanel1.Controls.Add(this.Panel2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(19, 89);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(583, 415);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.checkBox4);
            this.Panel1.Controls.Add(this.label14);
            this.Panel1.Controls.Add(this.label13);
            this.Panel1.Controls.Add(this.textB7);
            this.Panel1.Controls.Add(this.label12);
            this.Panel1.Controls.Add(this.textB6);
            this.Panel1.Controls.Add(this.comboPlus1);
            this.Panel1.Controls.Add(this.label11);
            this.Panel1.Controls.Add(this.label10);
            this.Panel1.Controls.Add(this.checkBox3);
            this.Panel1.Controls.Add(this.label9);
            this.Panel1.Controls.Add(this.label3);
            this.Panel1.Controls.Add(this.comboPlus2);
            this.Panel1.Controls.Add(this.label1);
            this.Panel1.Controls.Add(this.combolus1);
            this.Panel1.Controls.Add(this.label2);
            this.Panel1.Controls.Add(this.checkBox2);
            this.Panel1.Controls.Add(this.checkBox1);
            this.Panel1.Controls.Add(this.textB1);
            this.Panel1.Controls.Add(this.textB5);
            this.Panel1.Controls.Add(this.label4);
            this.Panel1.Controls.Add(this.label5);
            this.Panel1.Controls.Add(this.button1);
            this.Panel1.Controls.Add(this.textB4);
            this.Panel1.Controls.Add(this.textB2);
            this.Panel1.Controls.Add(this.label6);
            this.Panel1.Controls.Add(this.label8);
            this.Panel1.Controls.Add(this.textB3);
            this.Panel1.Controls.Add(this.label7);
            this.Panel1.Enabled = false;
            this.Panel1.Location = new System.Drawing.Point(3, 3);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(577, 405);
            this.Panel1.TabIndex = 15;
            this.Panel1.TabStop = false;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(536, 229);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(15, 14);
            this.checkBox4.TabIndex = 25;
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(488, 228);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 16);
            this.label14.TabIndex = 24;
            this.label14.Text = "Activo";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(24, 301);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 16);
            this.label13.TabIndex = 22;
            this.label13.Text = "Indicaciones";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(24, 266);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 16);
            this.label12.TabIndex = 20;
            this.label12.Text = "Presentación";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(24, 367);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 16);
            this.label11.TabIndex = 18;
            this.label11.Text = "Vía";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(462, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "Agrupable";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(536, 177);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 17;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(24, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Concepto";
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.dataGridView1);
            this.Panel2.Location = new System.Drawing.Point(3, 414);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(580, 408);
            this.Panel2.TabIndex = 16;
            this.Panel2.TabStop = false;
            this.Panel2.Enter += new System.EventHandler(this.Panel2_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(574, 389);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.customButton1.CornerRadius = 25;
            this.customButton1.Location = new System.Drawing.Point(19, 61);
            this.customButton1.Name = "customButton1";
            this.customButton1.RoundCorners = Medit.Corners.TopRight;
            this.customButton1.Size = new System.Drawing.Size(100, 33);
            this.customButton1.TabIndex = 7;
            this.customButton1.Text = "Cargo";
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.customButton2.CornerRadius = 25;
            this.customButton2.ForeColor = System.Drawing.Color.White;
            this.customButton2.Location = new System.Drawing.Point(114, 61);
            this.customButton2.Name = "customButton2";
            this.customButton2.RoundCorners = Medit.Corners.TopRight;
            this.customButton2.Size = new System.Drawing.Size(93, 33);
            this.customButton2.TabIndex = 8;
            this.customButton2.Text = "Componentes";
            this.customButton2.Visible = false;
            this.customButton2.Click += new System.EventHandler(this.customButton2_Click);
            // 
            // textB7
            // 
            this.textB7.AllowSpace = false;
            this.textB7.Esdecimal = false;
            this.textB7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textB7.Location = new System.Drawing.Point(126, 298);
            this.textB7.Longitud = 32000;
            this.textB7.MaxLength = 200;
            this.textB7.Multiline = true;
            this.textB7.Name = "textB7";
            this.textB7.Numerico = false;
            this.textB7.Size = new System.Drawing.Size(436, 52);
            this.textB7.Sugerencia = "";
            this.textB7.TabIndex = 23;
            // 
            // textB6
            // 
            this.textB6.AllowSpace = false;
            this.textB6.Esdecimal = false;
            this.textB6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textB6.Location = new System.Drawing.Point(126, 260);
            this.textB6.Longitud = 32000;
            this.textB6.MaxLength = 50;
            this.textB6.Name = "textB6";
            this.textB6.Numerico = false;
            this.textB6.Size = new System.Drawing.Size(346, 22);
            this.textB6.Sugerencia = "";
            this.textB6.TabIndex = 21;
            // 
            // comboPlus1
            // 
            this.comboPlus1.addMsg = true;
            this.comboPlus1.Autoadd = true;
            this.comboPlus1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboPlus1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPlus1.FormattingEnabled = true;
            this.comboPlus1.Location = new System.Drawing.Point(126, 365);
            this.comboPlus1.Name = "comboPlus1";
            this.comboPlus1.SelectedBackColor = System.Drawing.Color.LightSeaGreen;
            this.comboPlus1.Size = new System.Drawing.Size(226, 23);
            this.comboPlus1.Sugerencia = "";
            this.comboPlus1.TabIndex = 19;
            // 
            // comboPlus2
            // 
            this.comboPlus2.addMsg = true;
            this.comboPlus2.Autoadd = true;
            this.comboPlus2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboPlus2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPlus2.FormattingEnabled = true;
            this.comboPlus2.Location = new System.Drawing.Point(126, 68);
            this.comboPlus2.Name = "comboPlus2";
            this.comboPlus2.SelectedBackColor = System.Drawing.Color.LightSeaGreen;
            this.comboPlus2.Size = new System.Drawing.Size(316, 23);
            this.comboPlus2.Sugerencia = "";
            this.comboPlus2.TabIndex = 1;
            this.comboPlus2.SelectedIndexChanged += new System.EventHandler(this.comboPlus2_SelectedIndexChanged);
            // 
            // textB1
            // 
            this.textB1.AllowSpace = false;
            this.textB1.BackColor = System.Drawing.Color.White;
            this.textB1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textB1.Esdecimal = false;
            this.textB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textB1.Location = new System.Drawing.Point(462, 384);
            this.textB1.Longitud = 32000;
            this.textB1.Name = "textB1";
            this.textB1.Numerico = false;
            this.textB1.ReadOnly = true;
            this.textB1.Size = new System.Drawing.Size(100, 15);
            this.textB1.Sugerencia = "";
            this.textB1.TabIndex = 1;
            // 
            // textB5
            // 
            this.textB5.AllowSpace = false;
            this.textB5.Esdecimal = true;
            this.textB5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textB5.Location = new System.Drawing.Point(126, 225);
            this.textB5.Longitud = 32000;
            this.textB5.Name = "textB5";
            this.textB5.Numerico = true;
            this.textB5.Size = new System.Drawing.Size(167, 22);
            this.textB5.Sugerencia = "";
            this.textB5.TabIndex = 9;
            // 
            // textB4
            // 
            this.textB4.AllowSpace = false;
            this.textB4.Esdecimal = true;
            this.textB4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textB4.Location = new System.Drawing.Point(126, 186);
            this.textB4.Longitud = 32000;
            this.textB4.Name = "textB4";
            this.textB4.Numerico = true;
            this.textB4.Size = new System.Drawing.Size(167, 22);
            this.textB4.Sugerencia = "";
            this.textB4.TabIndex = 7;
            // 
            // textB2
            // 
            this.textB2.AllowSpace = false;
            this.textB2.Esdecimal = false;
            this.textB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textB2.Location = new System.Drawing.Point(126, 111);
            this.textB2.Longitud = 32000;
            this.textB2.MaxLength = 80;
            this.textB2.Name = "textB2";
            this.textB2.Numerico = false;
            this.textB2.Size = new System.Drawing.Size(346, 22);
            this.textB2.Sugerencia = "";
            this.textB2.TabIndex = 3;
            // 
            // textB3
            // 
            this.textB3.AllowSpace = false;
            this.textB3.Esdecimal = true;
            this.textB3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textB3.Location = new System.Drawing.Point(126, 150);
            this.textB3.Longitud = 32000;
            this.textB3.Name = "textB3";
            this.textB3.Numerico = true;
            this.textB3.Size = new System.Drawing.Size(167, 22);
            this.textB3.Sugerencia = "";
            this.textB3.TabIndex = 5;
            // 
            // Cargos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(626, 549);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.customButton2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cargos";
            this.Text = "Cargos";
            this.Load += new System.EventHandler(this.Cargas_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Btn_NuevoCargo;
        private System.Windows.Forms.ToolStripButton Btn_EditarCargo;
        private System.Windows.Forms.ToolStripButton Btn_GuardarCargo;
        private System.Windows.Forms.ToolStripButton Btn_cancelarEdicionCargo;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton Btn_BuscarCargo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ComboBox combolus1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private TextB textB5;
        private System.Windows.Forms.Label label5;
        private TextB textB4;
        private System.Windows.Forms.Label label6;
        private TextB textB3;
        private System.Windows.Forms.Label label7;
        private ComboPlus comboPlus2;
        private System.Windows.Forms.Label label8;
        private TextB textB2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private TextB textB1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private CustomButton customButton1;
        private CustomButton customButton2;
        private System.Windows.Forms.GroupBox Panel1;
        private System.Windows.Forms.GroupBox Panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label13;
        private TextB textB7;
        private System.Windows.Forms.Label label12;
        private TextB textB6;
        private ComboPlus comboPlus1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Label label14;
    }
}