using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using BussinessLayer;
using System.Data.SqlClient;
using DataEntities;
namespace Medit
{

    //class crecipe
    //{
    //    //int pacienteid;
    //    //int medicoid;
    //    //string sintomas;
    //    //string diagnostico;
    //    //string recipe;
    //    //string informe;
    //    //string laboratorio;
    //     // string seguimiento;
    //  string otroslab;
            
    //}

    public partial class Recipe : Form
    {
        DiagnosticoManager DM = new DiagnosticoManager();
        MedicinasManager MM = new MedicinasManager();
        SintomasManager SM = new SintomasManager();

        [DllImport("user32")]
        private extern static int GetCaretPos(out Point p);
       List<string> ISList = new List<string>(new string[] { "SELECT", "CREATE", "TABLE", "JOB", "INFO", "SOLUTIONS", "GOOGLE", "VISUAL STUDIO" });


        #region intvars
        enum operacionenum { guardar=99,leer=100 };

        operacionenum operacion;
       
        //   IniFile Myini = Main.MyInis;
        long ingresonro;
        int ingresotipo;
        MedicosDTO miMedico { get; set; }
        PacienteDTO miPaciente { get; set; }
        string action = "";
        string letra = "";
        NumberFormatInfo numberFormatInfo;
        char decimalSeparator;
        public string modo = "a";
        public static Point posicion = new Point();
        int altoitem = 20;
        private int indent = 10;
        int indice = 0;
        string[] Lista = (new string[] { "" });

        #endregion
        
       
        public Recipe(IngresosDTO tingreso,MedicosDTO MiMedico,PacienteDTO MiPaciente)
        {
            operacion = operacionenum.leer;
            miMedico = MiMedico;
            miPaciente = MiPaciente;
            ingresonro = tingreso.admisionid;
            ingresotipo= tingreso.tipodeingreso;
            IngresosDTO.TipoIngresoenum s =(IngresosDTO.TipoIngresoenum)tingreso.tipodeingreso;
            InitializeComponent();
            this.label3.Text = IngresosDTO.Enum<IngresosDTO.TipoIngresoenum>.Description(0);
            this.intelliSenseTextBox1.Dictionary = ISList;
           
        }


        private void textBoxa_GotFocus(object sender, EventArgs e)
        {
            if ((((TextBox)sender).Name == "textBoxa"))
            {
                Estado.Text = "Escriba el Codigo o Invocar usando la Tecla de Funcion Catalogos [F3]-Productos o [F4]-Insumos [F5]-Recetas";
            }

        }
   
      
   
        private void Recetas_Load(object sender, EventArgs e)
        {
            cabezera();
            llenacombos();
            llenaexamaneslab();
        }
        #region forma;

        private void llenaexamaneslab()
        {
            foreach (DataRow row in MM.GetExamenesLaboratorio().Rows)
            {
                CheckBox chcontrol = new CheckBox();
                chcontrol.Text = row["examen"].ToString();
                chcontrol.Tag = row["id"].ToString();
                Size ns = new Size(150, 25);
                chcontrol.Size = ns;
                chcontrol.CheckedChanged += Chcontrol_CheckedChanged;
                
                flowLayoutPanel3.Controls.Add(chcontrol);
            }
        }

        private void Chcontrol_CheckedChanged(object sender, EventArgs e)
        {
            Control c =(Control)sender;
            if (((CheckBox)sender).Checked == true && ((CheckBox)sender).Text=="OTRO")
            {
                c.Tag = "1";
                TextB T = new TextB();
                flowLayoutPanel3.Controls.Add(T);
                T.Tag = c;
                T.Focus();
                T.Leave += T_Leave;
                T.ForeColor = Color.Blue;
                    
            }

            if (((CheckBox)sender).Checked == false && ((CheckBox)sender).Tag.ToString() == "1")
            {
                ((CheckBox)sender).Checked = false;
                ((CheckBox)sender).Visible = false;
            }
        }

        private void T_Leave(object sender, EventArgs e)
        {
            TextB T2 = ((TextB)sender);
            Control C1=(Control) T2.Tag;
            C1.Text = T2.Text;
            T2.Visible = false;
            CheckBox chcontrol = new CheckBox();
            chcontrol.Text = "OTRO";
            chcontrol.Tag = 0;
            Size ns = new Size(150, 25);
            chcontrol.Size = ns;
            chcontrol.CheckedChanged += Chcontrol_CheckedChanged;
            flowLayoutPanel3.Controls.Add(chcontrol);
            if (T2.Text == "")
            {
                chcontrol.Checked = false;
                chcontrol.Visible = false;
            }
        }

        private void llenacombos()
        {
            ISList = DM.Getsintomas();
            intelliSenseTextBox1.Dictionary = ISList;
            comboBox4.DataSource = SM.Getsintomas();
            comboBox4.DisplayMember = "sintoma";
            comboBox4.ValueMember = "id";

            comboBox3.DataSource = MM.Getmedicinas();
            comboBox3.DisplayMember = "medicamento";
            comboBox3.ValueMember = "id";

        }

        private void cabezera()
        {
            label16.Text = "Dr."+miMedico.apellidos.ToUpper() + ", " + miMedico.nombres;
            EspecialidadBAL eb = new EspecialidadBAL();
            label9.Text = eb.GetEsp(miMedico.especialidad);

            EmpresasManager em = new EmpresasManager();
            OcupacionesManager om = new OcupacionesManager();
            label8.Text = miPaciente.APELLIDOS + ", " + miPaciente.NOMBRES;
            label13.Text = miPaciente.IDENTIFICACION;
            label15.Text = em.GetEmpresa((int)miPaciente.EMPRESA).Empresa + " " + om.GetOcupacion((int)miPaciente.CARGO).Ocupacion;
            label14.Text = Enum.GetName(typeof(PacienteDTO.EdoCivil), miPaciente.EDOCIVIL) + ", " + miPaciente.EDAD + " años.";

        }
        #endregion

        #region Editor de Texto 
        [Category("Settings")]
        [Description("Value indicating the number of characters used for indentation")]
        public int INDENT
        {
            get { return indent; }
            set { indent = value; }
        }

        public enum RicherTextBoxToolStripGroups
        {
            SaveAndLoad = 0x1,
            FontNameAndSize = 0x2,
            BoldUnderlineItalic = 0x4,
            Alignment = 0x8,
            FontColor = 0x10,
            IndentationAndBullets = 0x20,
            Insert = 0x40,
            Zoom = 0x80
        }
        //-----------------------------------------------
        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
           // String dreceta = Myini.Read("Directorios", "Recetas");

            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "Rich text format|*.rtf";
         //       dlg.InitialDirectory = dreceta;
                dlg.FilterIndex = 0;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        rtbDocument.LoadFile(dlg.FileName, RichTextBoxStreamType.RichText);
                    }
                    catch (IOException exc)
                    {
                        MessageBox.Show("Error reading file: \n" + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (ArgumentException exc_a)
                    {
                        MessageBox.Show("Error reading file: \n" + exc_a.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            using (FontDialog dlg = new FontDialog())
            {
                if (rtbDocument.SelectionFont != null) dlg.Font = rtbDocument.SelectionFont;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    rtbDocument.SelectionFont = dlg.Font;
                }
            }
        }

        private void tsbtnBIU_Click(object sender, EventArgs e)
        {
            // bold, italic, underline
            try
            {
                if (!(rtbDocument.SelectionFont == null))
                {
                    Font currentFont = rtbDocument.SelectionFont;
                    FontStyle newFontStyle = rtbDocument.SelectionFont.Style;
                    string txt = (sender as ToolStripButton).Name;
                    if (txt.IndexOf("Bold") >= 0)
                        newFontStyle = rtbDocument.SelectionFont.Style ^ FontStyle.Bold;
                    else if (txt.IndexOf("Italic") >= 0)
                        newFontStyle = rtbDocument.SelectionFont.Style ^ FontStyle.Italic;
                    else if (txt.IndexOf("Underline") >= 0)
                        newFontStyle = rtbDocument.SelectionFont.Style ^ FontStyle.Underline;

                    rtbDocument.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            tsbtnBIU_Click(sender, e);
        }

        private void Italic_Click(object sender, EventArgs e)
        {
            tsbtnBIU_Click(sender, e);
        }

        private void Underline_Click(object sender, EventArgs e)
        {
            tsbtnBIU_Click(sender, e);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Insert picture";
                dlg.DefaultExt = "jpg";
                dlg.Filter = "Bitmap Files|*.bmp|JPEG Files|*.jpg|GIF Files|*.gif|All files|*.*";
                dlg.FilterIndex = 1;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string strImagePath = dlg.FileName;
                        Image img = Image.FromFile(strImagePath);
                        Clipboard.SetDataObject(img);
                        DataFormats.Format df;
                        df = DataFormats.GetFormat(DataFormats.Bitmap);
                        if (this.rtbDocument.CanPaste(df))
                        {
                            this.rtbDocument.Paste(df);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Unable to insert image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            // bullets, indentation
            try
            {
                string name = (sender as ToolStripButton).Name;
                if (name.IndexOf("Bullets") >= 0)
                    rtbDocument.SelectionBullet = Bullets.Checked;
                else if (name.IndexOf("Indent2") >= 0)
                    rtbDocument.SelectionIndent -= INDENT;
                else if (name.IndexOf("Outdent") >= 0)
                    rtbDocument.SelectionIndent += INDENT;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {

            try
            {
                string txt = (sender as ToolStripButton).Name;
                if (txt.IndexOf("Left") >= 0)
                {
                    rtbDocument.SelectionAlignment = HorizontalAlignment.Left;
                    tsbtnAlignLeft.Checked = true;
                    tsbtnAlignCenter.Checked = false;
                    tsbtnAlignRight.Checked = false;
                }
                else if (txt.IndexOf("Center") >= 0)
                {
                    rtbDocument.SelectionAlignment = HorizontalAlignment.Center;
                    tsbtnAlignLeft.Checked = false;
                    tsbtnAlignCenter.Checked = true;
                    tsbtnAlignRight.Checked = false;
                }
                else if (txt.IndexOf("Right") >= 0)
                {
                    rtbDocument.SelectionAlignment = HorizontalAlignment.Right;
                    tsbtnAlignLeft.Checked = false;
                    tsbtnAlignCenter.Checked = false;
                    tsbtnAlignRight.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }


        private void tsbtnAlignCenter_Click(object sender, EventArgs e)
        {
            toolStripButton7_Click(sender, e);
        }

        private void tsbtnAlignRight_Click(object sender, EventArgs e)
        {
            toolStripButton7_Click(sender, e);
        }

        private void Indent2_Click(object sender, EventArgs e)
        {
            toolStripButton6_Click(sender, e);
        }

        private void Outdent_Click(object sender, EventArgs e)
        {
            toolStripButton6_Click(sender, e);
        }

        private void toolStripButton4_Click_1(object sender, EventArgs e)
        {
            // font color
            try
            {
                using (ColorDialog dlg = new ColorDialog())
                {
                    dlg.Color = rtbDocument.SelectionColor;
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        rtbDocument.SelectionColor = dlg.Color;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        #endregion Editor de Texto

        #region SuggestWords

        private void rtbDocument_KeyPress(object sender, KeyPressEventArgs e)
        {
            Point p = comboBox1.Location;

            if ((e.KeyChar>='A' & e.KeyChar<='Z')|| (e.KeyChar >= 'a' & e.KeyChar <= 'z'))
            {
              GetCaretPos(out p);
              comboBox1.Location = p;
              comboBox1.Focus();
              SendKeys.Send(e.KeyChar.ToString());
              //  comboBox1.Text = comboBox1.Text+ e.KeyChar.ToString();
              // comboBox1.SelectedText = "";
               
               comboBox1.Visible = true;
              
                e.Handled = true;
                //return;
            }
        }

    
        private void comboBox1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
               
                this.rtbDocument.AppendText(comboBox1.Text);
                rtbDocument.Focus();
                comboBox1.Visible = false;
                comboBox1.Text = "";
            }

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text != "")
            {
                comboBox2.DataSource = MM.Getpresentaciones(comboBox3.Text);
                comboBox2.DisplayMember = "presentacion";
                comboBox2.ValueMember = "id";
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox7.Text =MM.Getindicaciones((int)comboBox2.SelectedValue);
        }

        private void intelliSenseTextBox1_Enter(object sender, EventArgs e)
        {
            this.intelliSenseTextBox1.Height = 165;
        }

        private void intelliSenseTextBox1_Leave(object sender, EventArgs e)
        {
            this.intelliSenseTextBox1.Height = 50;
        }
        #endregion



#region "add med  to recipe"
        private void customButton1_Click(object sender, EventArgs e)
        {
            Detalle detal = new Detalle();
            detal.Id = (int)this.comboBox2.SelectedValue;
            detal.Medicamento = this.comboBox3.Text;
            detal.Presentacion = this.comboBox2.Text;
            detal.Indicaciones = this.TextBox7.Text;
            this.flowLayoutPanel1.Controls.Add(detal);
            this.comboBox3.Text = "";
            this.comboBox2.Text = "";
            this.TextBox7.Text = "";
            GroupBox1.Visible = false;
            panel1.Visible = true;
        }

        private void customButton3_Click(object sender, EventArgs e)
        {
            
            SintomaTag sintomaStr = new SintomaTag();
            sintomaStr.Palabra = comboBox4.Text;
            this.flowLayoutPanel2.Controls.Add(sintomaStr);
            this.comboBox4.Text = "";
            
        }
        #endregion
        private void customButton2_Click(object sender, EventArgs e)
        {
            GroupBox1.Visible =true;
            panel1.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            GroupBox1.Visible = true;
            panel1.Visible = false;
        }

 


        private void button1_Click(object sender, EventArgs e)
        {
            TabPage n = new TabPage();
            n = this.tabControl1.TabPages[3];
            ((Control)n).Visible = false;
        }

        private void toolStripDropDownButton2_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void customButton4_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
       
        private void Btn_GuardarCargo_Click(object sender, EventArgs e)
        {
            operacion = operacionenum.guardar;
            ImprimeBtn.Enabled = true;


        }

        private void rtbDocument_TextChanged(object sender, EventArgs e)
        {
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            SintomasDTO sdto = new SintomasDTO();
            SintomasManager sm = new SintomasManager();
            sdto = sm.Getsintoma(51);
            rtbDocument.Rtf = sdto.sintoma;
            try
            {
                //rtbDocument.LoadFile("c:\\corinto\\8.rtf", RichTextBoxStreamType.RichText);
            }
            catch (IOException exc)
            {
                MessageBox.Show("Error reading file: \n" + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException exc_a)
            {
                MessageBox.Show("Error reading file: \n" + exc_a.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            SintomasManager cct = new SintomasManager();
            SintomasDTO nc = new SintomasDTO();
           
            nc.sintoma = rtbDocument.Rtf;
            cct.Insert(nc);
            
             try
            {
                rtbDocument.SaveFile("c:\\corinto\\8.rtf", RichTextBoxStreamType.RichText);
            }
            catch (IOException exc)
            {
                MessageBox.Show("Error writing file: \n" + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException exc_a)
            {
                MessageBox.Show("Error writing file: \n" + exc_a.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}

