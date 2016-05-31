

namespace Medit
{
    partial class Ingresofrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ingresofrm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Mensaje = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboPlus1 = new ComboPlus();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.customButton1 = new CustomButton();
            this.textB5 = new TextB();
            this.textB4 = new TextB();
            this.textB3 = new TextB();
            this.textB2 = new TextB();
            this.textB1 = new TextB();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.observaciones = new TextB();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textB6 = new TextB();
            this.textB7 = new TextB();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.customButton3 = new CustomButton();
            this.customButton2 = new CustomButton();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cedula Paciente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Trabajador/Paciente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(18, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Motivo de Ingreso";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(18, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Tipo de Ingreso";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "PARTICULAR"});
            this.comboBox1.Location = new System.Drawing.Point(146, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(130, 24);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.Enter += new System.EventHandler(this.Ingresofrm_Enter);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mensaje,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 432);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(628, 22);
            this.statusStrip1.TabIndex = 21;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Mensaje
            // 
            this.Mensaje.Name = "Mensaje";
            this.Mensaje.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(18, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Observaciones";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(282, 13);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(266, 24);
            this.comboBox2.TabIndex = 22;
            this.comboBox2.Tag = "0";
            this.comboBox2.Visible = false;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.comboBox2.Enter += new System.EventHandler(this.Ingresofrm_Enter);
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(146, 45);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(283, 24);
            this.comboBox3.TabIndex = 23;
            this.comboBox3.Visible = false;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            this.comboBox3.VisibleChanged += new System.EventHandler(this.comboBox3_VisibleChanged);
            this.comboBox3.Enter += new System.EventHandler(this.Ingresofrm_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(18, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "Medico";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboPlus1);
            this.groupBox1.Location = new System.Drawing.Point(12, 170);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(604, 78);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboPlus1
            // 
            this.comboPlus1.addMsg = false;
            this.comboPlus1.Autoadd = true;
            this.comboPlus1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboPlus1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPlus1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboPlus1.FormattingEnabled = true;
            this.comboPlus1.Items.AddRange(new object[] {
            "CONSULTA MEDICINA GENERAL ",
            "CONSULTA ESPECIALISTA",
            "LABORATORIO",
            "ECOGRAFIA",
            "ELECTROCARDIOGRAMA",
            "RADIOGRAFIA RX",
            "AMBULATORIO DE EMERGENCIA MAS TRATAMIENTO",
            "HOSPITALIZACION",
            "QUIROFANO O SALA DE PARTO"});
            this.comboPlus1.Location = new System.Drawing.Point(146, 16);
            this.comboPlus1.Name = "comboPlus1";
            this.comboPlus1.SelectedBackColor = System.Drawing.Color.LightSeaGreen;
            this.comboPlus1.Size = new System.Drawing.Size(402, 23);
            this.comboPlus1.Sugerencia = "";
            this.comboPlus1.TabIndex = 12;
            this.comboPlus1.SelectedIndexChanged += new System.EventHandler(this.comboPlus1_SelectedIndexChanged);
            this.comboPlus1.Enter += new System.EventHandler(this.Ingresofrm_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.customButton1);
            this.groupBox2.Controls.Add(this.textB5);
            this.groupBox2.Controls.Add(this.textB4);
            this.groupBox2.Controls.Add(this.textB3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textB2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textB1);
            this.groupBox2.Location = new System.Drawing.Point(11, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(605, 97);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(267, 19);
            this.customButton1.Name = "customButton1";
            this.customButton1.RoundCorners = ((Corners)((((Corners.TopLeft | Corners.TopRight) 
            | Corners.BottomLeft) 
            | Corners.BottomRight)));
            this.customButton1.Size = new System.Drawing.Size(78, 22);
            this.customButton1.TabIndex = 2;
            this.customButton1.Text = "Beneficiarios";
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // textB5
            // 
            this.textB5.AllowSpace = false;
            this.textB5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textB5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textB5.Esdecimal = false;
            this.textB5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textB5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textB5.Location = new System.Drawing.Point(479, 70);
            this.textB5.Longitud = 32000;
            this.textB5.Name = "textB5";
            this.textB5.Numerico = false;
            this.textB5.ReadOnly = true;
            this.textB5.Size = new System.Drawing.Size(107, 15);
            this.textB5.Sugerencia = "";
            this.textB5.TabIndex = 7;
            this.textB5.Visible = false;
            // 
            // textB4
            // 
            this.textB4.AllowSpace = false;
            this.textB4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textB4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textB4.Esdecimal = false;
            this.textB4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textB4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textB4.Location = new System.Drawing.Point(479, 49);
            this.textB4.Longitud = 32000;
            this.textB4.Name = "textB4";
            this.textB4.Numerico = false;
            this.textB4.ReadOnly = true;
            this.textB4.Size = new System.Drawing.Size(107, 15);
            this.textB4.Sugerencia = "";
            this.textB4.TabIndex = 4;
            this.textB4.Visible = false;
            // 
            // textB3
            // 
            this.textB3.AllowSpace = false;
            this.textB3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textB3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textB3.Esdecimal = false;
            this.textB3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textB3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textB3.Location = new System.Drawing.Point(151, 70);
            this.textB3.Longitud = 32000;
            this.textB3.Name = "textB3";
            this.textB3.Numerico = false;
            this.textB3.ReadOnly = true;
            this.textB3.Size = new System.Drawing.Size(322, 15);
            this.textB3.Sugerencia = "";
            this.textB3.TabIndex = 8;
            this.textB3.Visible = false;
            // 
            // textB2
            // 
            this.textB2.AllowSpace = false;
            this.textB2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textB2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textB2.Esdecimal = false;
            this.textB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textB2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textB2.Location = new System.Drawing.Point(151, 49);
            this.textB2.Longitud = 32000;
            this.textB2.Name = "textB2";
            this.textB2.Numerico = false;
            this.textB2.ReadOnly = true;
            this.textB2.Size = new System.Drawing.Size(322, 15);
            this.textB2.Sugerencia = "";
            this.textB2.TabIndex = 5;
            // 
            // textB1
            // 
            this.textB1.AllowSpace = false;
            this.textB1.Esdecimal = false;
            this.textB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textB1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textB1.Location = new System.Drawing.Point(150, 19);
            this.textB1.Longitud = 32000;
            this.textB1.Name = "textB1";
            this.textB1.Numerico = false;
            this.textB1.Size = new System.Drawing.Size(107, 22);
            this.textB1.Sugerencia = "Escriba la Cedula del Paciente";
            this.textB1.TabIndex = 1;
            this.textB1.TextChanged += new System.EventHandler(this.textB1_TextChanged);
            this.textB1.Enter += new System.EventHandler(this.Ingresofrm_Enter);
            this.textB1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textB1_KeyDown);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(12, 116);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(604, 42);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(282, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(266, 20);
            this.label10.TabIndex = 9;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.observaciones);
            this.groupBox4.Location = new System.Drawing.Point(12, 297);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(604, 76);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            // 
            // observaciones
            // 
            this.observaciones.AllowSpace = false;
            this.observaciones.BackColor = System.Drawing.Color.White;
            this.observaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.observaciones.Esdecimal = false;
            this.observaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.observaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.observaciones.Location = new System.Drawing.Point(146, 19);
            this.observaciones.Longitud = 32000;
            this.observaciones.MaxLength = 80;
            this.observaciones.Multiline = true;
            this.observaciones.Name = "observaciones";
            this.observaciones.Numerico = false;
            this.observaciones.Size = new System.Drawing.Size(402, 48);
            this.observaciones.Sugerencia = "";
            this.observaciones.TabIndex = 18;
            this.observaciones.Enter += new System.EventHandler(this.Ingresofrm_Enter);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.textB6);
            this.groupBox5.Controls.Add(this.textB7);
            this.groupBox5.Location = new System.Drawing.Point(12, 247);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(604, 50);
            this.groupBox5.TabIndex = 29;
            this.groupBox5.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(263, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Ticket";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(18, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Clave";
            // 
            // textB6
            // 
            this.textB6.AllowSpace = false;
            this.textB6.Esdecimal = false;
            this.textB6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textB6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textB6.Location = new System.Drawing.Point(333, 17);
            this.textB6.Longitud = 32000;
            this.textB6.MaxLength = 10;
            this.textB6.Name = "textB6";
            this.textB6.Numerico = false;
            this.textB6.Size = new System.Drawing.Size(96, 22);
            this.textB6.Sugerencia = "";
            this.textB6.TabIndex = 20;
            this.textB6.Visible = false;
            this.textB6.Enter += new System.EventHandler(this.Ingresofrm_Enter);
            // 
            // textB7
            // 
            this.textB7.AllowSpace = false;
            this.textB7.Esdecimal = false;
            this.textB7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textB7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textB7.Location = new System.Drawing.Point(146, 17);
            this.textB7.Longitud = 32000;
            this.textB7.MaxLength = 10;
            this.textB7.Name = "textB7";
            this.textB7.Numerico = false;
            this.textB7.Size = new System.Drawing.Size(107, 22);
            this.textB7.Sugerencia = "";
            this.textB7.TabIndex = 18;
            this.textB7.Enter += new System.EventHandler(this.Ingresofrm_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(29, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 30;
            this.label3.Text = "Fecha:";
            // 
            // timer1
            // 
            this.timer1.Interval = 600;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // customButton3
            // 
            this.customButton3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.customButton3.ForeColor = System.Drawing.Color.White;
            this.customButton3.Location = new System.Drawing.Point(535, 379);
            this.customButton3.Name = "customButton3";
            this.customButton3.RoundCorners = ((Corners)((((Corners.TopLeft | Corners.TopRight) 
            | Corners.BottomLeft) 
            | Corners.BottomRight)));
            this.customButton3.Size = new System.Drawing.Size(78, 37);
            this.customButton3.TabIndex = 20;
            this.customButton3.Text = "Cancelar";
            this.customButton3.Click += new System.EventHandler(this.customButton3_Click);
            // 
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.Color.Orange;
            this.customButton2.ForeColor = System.Drawing.Color.White;
            this.customButton2.Location = new System.Drawing.Point(451, 379);
            this.customButton2.Name = "customButton2";
            this.customButton2.RoundCorners = ((Corners)((((Corners.TopLeft | Corners.TopRight) 
            | Corners.BottomLeft) 
            | Corners.BottomRight)));
            this.customButton2.Size = new System.Drawing.Size(78, 37);
            this.customButton2.TabIndex = 19;
            this.customButton2.Text = "Ingresar";
            this.customButton2.Click += new System.EventHandler(this.customButton2_Click);
            // 
            // Ingresofrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(628, 454);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.customButton3);
            this.Controls.Add(this.customButton2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ingresofrm";
            this.Text = "Ingreso";
            this.Load += new System.EventHandler(this.Ingreso_Load);
            this.Enter += new System.EventHandler(this.Ingresofrm_Enter);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextB textB1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private TextB textB2;
        private TextB textB3;
        private TextB textB4;
        private TextB textB5;
        private CustomButton customButton1;
        private ComboPlus comboPlus1;
        private System.Windows.Forms.Label label6;
        private CustomButton customButton2;
        private CustomButton customButton3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Mensaje;
        private TextB observaciones;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private TextB textB6;
        private TextB textB7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label10;
    }
}