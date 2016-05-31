using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLayer;
using DataEntities;
using System.IO;
using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Medit
{
    public partial class Historia : Form
    {
      
        public long idcurrent=2;
        private PacienteDTO paciente;
        private bool nuevoDep=false;
        private bool nuevoDoc = false;
        public bool agregar = false;
        public bool editar= false;
        public const int MODOREG= 0;
        public const int MODOEDIT= 1;
        public const int MODOREGDOC = 0;
        public const int MODOEDITDOC = 1;

        public Historia()
        {
            InitializeComponent();
        }

       
       private void Form1_Load(object sender, EventArgs e)
        {
            //http://docs.telerik.com/devtools/winforms/gridview/populating-with-data/binding-to-a-collection-of-interfaces//
            DesabilitarControles();
             Cargacombos();
           // CargaPaciente(idcurrent);   
                  
        }

        private void DesabilitarControles()
        {
            this.groupBox1.Enabled = false;
            this.groupBox3.Enabled = false;
            this.groupBox2.Enabled = false;
        
            dataGridView1.Enabled = false;
   
            dataGridView2.Enabled = false;
        }
        private void HabilitarControles()
        {
            this.groupBox1.Enabled = true;
            this.groupBox3.Enabled = true;
            this.groupBox2.Enabled = true;
            dataGridView1.Enabled = true;
            dataGridView2.Enabled = true;
            txtidentificacion.Focus();
            
        }
        private void CargaPaciente(long id)
        {
            Cargacombos();
            PacientesManager pm = new PacientesManager();
            paciente = pm.GetPaciente(id);
            desplegar(paciente);

        }
        #region Combos
        private void Cargacombos()
        {
        
           
            CargaComboCiudades();
            CargaComboEstados();
            CargacomboCargos();
            CargaComboEmpresas();
            CargacomboAseguradoras();
            txtCmbSex.DataSource = Enum.GetValues(typeof(PacienteDTO.Sexo));
            comboBox1.DataSource = Enum.GetValues(typeof(PacienteDTO.EdoCivil));
           Dep_CmbParentesco.DataSource = Enum.GetValues(typeof(DependientesDTO.parentesco));
        }
        private void CargacomboAseguradoras()
        {
            EmpresasManager cm = new EmpresasManager();
            DataTable tabla2 = cm.GetEmpresasTable(1);
            DataTable tabla3 = cm.GetEmpresasTable(1);
            this.txtCmbAseguradoras.DataSource = tabla2;
            txtCmbAseguradoras.ValueMember = tabla2.Columns[0].Caption.ToString();
            txtCmbAseguradoras.DisplayMember = tabla2.Columns[1].Caption.ToString();
            this.txtComboAseguradoras2.DataSource = tabla3;
            txtComboAseguradoras2.ValueMember = tabla3.Columns[0].Caption.ToString();
            txtComboAseguradoras2.DisplayMember = tabla3.Columns[1].Caption.ToString();

        }
        private void CargaComboEmpresas()
        {
            EmpresasManager cm = new EmpresasManager();
            DataTable tabla = cm.GetEmpresasTable(0);
            this.txtCmbEmpresa.DataSource = tabla;
            txtCmbEmpresa.ValueMember = tabla.Columns[0].Caption.ToString();
            txtCmbEmpresa.DisplayMember = tabla.Columns[1].Caption.ToString();
        }
        private void CargacomboCargos()
        {
           OcupacionesManager cm = new OcupacionesManager();
            DataTable tabla = cm.GetOcupacionesTable();
            this.txtcmbcargo.DataSource = tabla;
            txtcmbcargo.ValueMember = tabla.Columns[0].Caption.ToString();
            txtcmbcargo.DisplayMember = tabla.Columns[1].Caption.ToString();
        }

        //carga  combo Ciudades
        private void CargaComboCiudades()
        {
            CitiesManager cm = new CitiesManager();
            DataTable tabla = cm.GetCityTable();
            txtCmbCiudad.DataSource = tabla;
            txtCmbCiudad.ValueMember = tabla.Columns[0].Caption.ToString();
            txtCmbCiudad.DisplayMember = tabla.Columns[1].Caption.ToString();
        }
        //carga Combo Estados
        private void CargaComboEstados()
        {  
            EdoManager em = new EdoManager();
            DataTable tabla = em.GetEstadosTable();
            txtCmbEstado.DataSource = tabla;
            txtCmbEstado.ValueMember = tabla.Columns[0].Caption.ToString();
            txtCmbEstado.DisplayMember = tabla.Columns[1].Caption.ToString();
            
        }
        #endregion
        private void desplegar(PacienteDTO paciente)
        {   try
            {
                txtComboAseguradoras2.SelectedValue = paciente.ASEGURADORA2;
            }
            catch
            {
                txtComboAseguradoras2.Text = "";
            }
            if(paciente.ASEGURADORA==null)
            txtCmbAseguradoras.SelectedValue =0 ;
            else
                txtCmbAseguradoras.SelectedValue = paciente.ASEGURADORA;
            txtApellidos.Text = paciente.APELLIDOS;
            this.txtNombre.Text = paciente.NOMBRES;
            txtDireccion.Text = paciente.DIRECCION;
            txtFecha.Value = paciente.FECHANAC;
            PacienteDTO.Sexo status;
            Enum.TryParse(paciente.SEXO.ToString(), out status);
            txtCmbSex.SelectedIndex = paciente.SEXO;
            this.txtficha.Text = paciente.FICHALABORAL;
            this.txtidentificacion.Text = paciente.IDENTIFICACION;
            this.txtMovil.Text = paciente.MOVIL;
            txtedad.Text = calcularEdad(paciente.FECHANAC).ToString();
            txtcmbcargo.SelectedValue = paciente.CARGO;
            txtidentificacion.Text = paciente.IDENTIFICACION;
            txtCmbSex.SelectedIndex = paciente.SEXO;
            txtCmbCiudad.SelectedValue = paciente.CIUDAD;
            txtCmbEstado.SelectedValue = paciente.ESTADO;
            if (paciente.EMPRESA==null)
            txtCmbEmpresa.SelectedValue = 0;
            else
             txtCmbEmpresa.SelectedValue = paciente.EMPRESA;
            txtTelefono2.Text = paciente.TELEFONO2;
            txtNacionalidad.Text = paciente.NACIONALIDAD;
            txtTelefono.Text = paciente.TELEFONO;
            txtObservaciones.Text = paciente.OBSERVACIONES;
            this.comboBox1.SelectedIndex = paciente.TIPO;
            //paciente.ULTIMAVISITA
            //paciente.PACIENTEID
            textB1.Text = paciente.SECTOR;
            textB2.Text = paciente.NOMBRECONYUGUE;
            comboPlus1.SelectedIndex = paciente.TIPO;
            comboBox1.SelectedIndex = ((int)paciente.EDOCIVIL);
            this.dataGridView1.DataSource = paciente.ListaDependientes;
            this.dataGridView2.DataSource = paciente.ListaDeDocumentos;
            Photofile.Text = paciente.ARCHIVOCEDULA;
            loadPhoto(paciente.ARCHIVOCEDULA);
            formatDataGrid();
        }

        private void loadPhoto(string aRCHIVOCEDULA)
        {
            Properties.Settings s = new Properties.Settings();
            var directory = s.DirectorioImagenes + "\\";
            if (File.Exists(@directory + aRCHIVOCEDULA))
                Photo.Image = Image.FromFile(directory + Photofile.Text);
            Photo.Refresh();
        }

        private void formatDataGrid()
        {
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[5].Visible = false;


            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[1].Visible = false;
        }
        private void UpdatedataGrid1()
        {
            PacientesManager dm = new PacientesManager();
            this.dataGridView1.DataSource = dm.GetDependientes(paciente.PACIENTEID);
            if (dataGridView1.SelectedRows.Count == 0)
            {
                
                BlanquearFormaDep();
                groupBox2.Enabled = false;
            }
        }
        private int calcularEdad(DateTime fechanac)
        {
            TimeSpan z = DateTime.Now.Subtract(fechanac);
            return (z.Days / 365);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dependiente dp = new Dependiente();
            dp.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dependiente dp = new Dependiente();
            dp.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dependiente dp = new Dependiente();
            dp.ShowDialog();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
         

        }

        private void txtCmbCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.txtCmbCiudad.Text == "Nuevo...")
            {
                this.txtCmbCiudad.SelectedText = "";
                this.txtCmbCiudad.Text = "";
                this.txtCmbCiudad.Focus();
            }
          
        }

        private void txtCmbCiudad_Leave(object sender, EventArgs e)
        {  //Si la ciudad no existe en el combo Se agrega y se muestra en la lista
            CitiesManager cm = new CitiesManager();
            if (!cm.ExisteCity(txtCmbCiudad.Text)&& txtCmbCiudad.Text.Length>0)
            { var nuevaciudad = new CiudadesDTO() {
                                Ciudad = ToTitleCase(txtCmbCiudad.Text),
                                Estado = 0};
                cm.InsertCity(nuevaciudad);
                CargaComboCiudades();
                txtCmbCiudad.Text = nuevaciudad.Ciudad;
             }
        }
        public string ToTitleCase(string str)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str.ToLower());
        }

        private void txtcmbcargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.txtcmbcargo.Text == "Nuevo...")
            {
                txtcmbcargo.SelectedText = "";
                txtcmbcargo.Text = "";
                txtcmbcargo.Focus();

            }
        }

        private void txtcmbcargo_Leave(object sender, EventArgs e)
        {
            //Si la ciudad no existe en el combo Se agrega y se muestra en la lista
            OcupacionesManager cm = new OcupacionesManager();
            if (!cm.ExisteOcupacion(this.txtcmbcargo.Text)&& this.txtcmbcargo.Text.Length>0)
            {
                var nuevaocp = new OcupacionesDTO()
                {
                    Ocupacion = ToTitleCase(txtcmbcargo.Text)
               };
                var resp = MessageBox.Show("Esta seguro de Agregar el nuevo Cargo como:\n" + txtcmbcargo.Text, "Confirmación",MessageBoxButtons.YesNo);
                    if (resp == DialogResult.Yes) {
                    cm.InsertOcupacion(nuevaocp);
                    CargacomboCargos();
                    txtcmbcargo.Text = nuevaocp.Ocupacion;
                }   
            }
        }

        private void comboPlus1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboPlus1.Text != "Particular")
            {
                txtficha.Enabled = true;
                txtcmbcargo.Enabled = true;
                txtCmbAseguradoras.Enabled = true;
                txtComboAseguradoras2.Enabled = true;
                txtCmbEmpresa.Enabled = true;

            }
           else
            {
                txtficha.Text =null;
                txtCmbEmpresa.Text = null;
                txtcmbcargo.Text=null;
                txtCmbAseguradoras.Text = null;
                txtficha.Enabled = false;
                txtcmbcargo.Enabled = false;
                txtCmbAseguradoras.Enabled = false;
                txtComboAseguradoras2.Enabled = false;
                txtCmbEmpresa.Enabled = false;
            }
        }

        private void txtCmbEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.txtCmbEmpresa.Text == "Nuevo...")
            {
                txtCmbEmpresa.SelectedText = "";
                txtCmbEmpresa.Text = "";
                txtCmbEmpresa.Focus();
                Frm_Empresas Frmemp = new Frm_Empresas();
                Frmemp.ShowDialog();

            }
        }

        private void txtCmbEmpresa_Leave(object sender, EventArgs e)
        {
            //Si la Empresa no existe en el combo Se agrega y se muestra en la lista al salir del combo
            EmpresasManager cm = new EmpresasManager();
            if (!cm.ExisteEmpresa(this.txtCmbEmpresa.Text) && this.txtCmbEmpresa.Text.Length > 0)
            {

                var resp = MessageBox.Show("Esta seguro de Agregar la nueva Empresa como:\n" +  txtCmbEmpresa.Text.ToUpper(), "Confirmación", MessageBoxButtons.YesNo);
                if (resp == DialogResult.Yes)
                {
                    Frm_Empresas Frmemp = new Frm_Empresas();
                    Frmemp.XEMPRESA = txtCmbEmpresa.Text;
                    Frmemp.Aseguradoras = false;
                    Frmemp.ShowDialog();
                    CargaComboEmpresas();
                      txtCmbEmpresa.Text = txtCmbEmpresa.Text;
                }
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.txtCmbAseguradoras.Text == "Nuevo...")
            {
                
                txtCmbAseguradoras.SelectedText = "";
                txtCmbAseguradoras.Text = "";
                txtCmbAseguradoras.Focus();
                Frm_Empresas Frmemp = new Frm_Empresas();
                Frmemp.Aseguradoras = true;
                Frmemp.XEMPRESA = "<<Nueva>>";
                Frmemp.ShowDialog();
                this.Focus();
            }
        }

        private void comboBox3_Leave(object sender, EventArgs e)
        {   //Si la ciudad no existe en el combo Se agrega y se muestra en la lista
            EmpresasManager cm = new EmpresasManager();
            if (!cm.ExisteAseguradora(this.txtCmbAseguradoras.Text) && this.txtCmbAseguradoras.Text.Length > 0)
            {
          
                var resp = MessageBox.Show("Esta seguro de Agregar la nueva Empresa Aseguradora como:\n" +  txtCmbAseguradoras.Text.ToUpper(), "Confirmación", MessageBoxButtons.YesNo);
                if (resp == DialogResult.Yes)
                {
                 
                    Frm_Empresas Frmemp = new Frm_Empresas();
                    Frmemp.XEMPRESA = txtCmbAseguradoras.Text;
                    Frmemp.Aseguradoras = true;
                    Frmemp.ShowDialog();
                    CargacomboAseguradoras();
                    txtCmbAseguradoras.Text = txtCmbAseguradoras.Text;
                }
            }

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Btn_EditarPaciente.Enabled = true;
            Btn_NuevoPaciente.Enabled = true;
            Btn_GuardarPaciente.Enabled = false;
            Btn_cancelarEdicionPaciente.Enabled = false;
            if (this.comboPlus1.SelectedIndex == 1)
            {
                paciente.CARGO = ((int)txtcmbcargo.SelectedValue);
                if (txtCmbEmpresa.SelectedValue == null)
                    paciente.EMPRESA = null;
                else
                    paciente.EMPRESA = ((int)txtCmbEmpresa.SelectedValue);
                paciente.FICHALABORAL = this.txtficha.Text;
                
            }

            if (txtCmbAseguradoras.SelectedValue != null)
                paciente.ASEGURADORA = ((int)txtComboAseguradoras2.SelectedValue);
            if (txtCmbAseguradoras.Text == "")
                paciente.ASEGURADORA = null;

            paciente.APELLIDOS = txtApellidos.Text;
            paciente.NOMBRES = this.txtNombre.Text;
            paciente.DIRECCION = txtDireccion.Text;
            paciente.FECHANAC = txtFecha.Value;
            paciente.SEXO = txtCmbSex.SelectedIndex;

            paciente.IDENTIFICACION = this.txtidentificacion.Text;
            paciente.MOVIL = this.txtMovil.Text;
            paciente.EDAD = Convert.ToInt32(txtedad.Text);

            paciente.IDENTIFICACION = txtidentificacion.Text;
            paciente.CIUDAD = ((int)txtCmbCiudad.SelectedValue);
            paciente.ESTADO = ((int)txtCmbEstado.SelectedValue);
            paciente.NACIONALIDAD = txtNacionalidad.Text;
            paciente.TELEFONO2 = txtTelefono2.Text;
            paciente.OBSERVACIONES = txtObservaciones.Text;

            paciente.NOMBRECONYUGUE = textB2.Text;
            paciente.SECTOR = textB1.Text;
            paciente.TIPO = comboPlus1.SelectedIndex;
            paciente.EDOCIVIL = ((int?)comboBox1.SelectedIndex);
            paciente.ARCHIVOCEDULA = Photofile.Text;
            if (txtComboAseguradoras2.SelectedValue != null)
                paciente.ASEGURADORA2 = ((int)txtComboAseguradoras2.SelectedValue);
            if (txtComboAseguradoras2.Text == "")
                paciente.ASEGURADORA2 = null;

            //paciente.ULTIMAVISITA
            //paciente.PACIENTEID
            PacientesManager pm = new PacientesManager();
            pm.Edit(paciente);
            DesabilitarControles();
        }

        private void txtFecha_ValueChanged(object sender, EventArgs e)
        {
            txtedad.Text = calcularEdad(txtFecha.Value).ToString();
        }

     

        

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
            fillformDependiente();
            nuevoDep = false;
            customButtonEdit.Visible=true;
            customButtonAdd.Visible=true;
        }

        private void fillformDependiente()
        {
            DependientesDTO dp = new DependientesDTO();
            DependientesManager dm = new DependientesManager();
            if (dataGridView1.SelectedRows.Count == 1)
            {
                label27.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                dp = dm.GetDependiente(Convert.ToInt32(label27.Text));
                Dep_Nombres.Text = dp.Nombre;
                Dep_Identificacion.Text = dp.Identificacion;
             
         Dep_CmbParentesco.Text = dp.Parentesco.ToString();
                Dep_Nombres.Text = dp.Nombre;
                Dep_Fecha.Value = dp.FechaNacimiento;
            }

        }

       

        private void customButtonCancelar_Click(object sender, EventArgs e)
        {
            if (nuevoDep) { 
                fillformDependiente();
                nuevoDep = false;
             }
            groupBox2.Enabled = false;
            ActualizarBotones(MODOREG);
        }

        private void customButtonGuardar_Click(object sender, EventArgs e)
        {
        
            DependientesDTO dp = new DependientesDTO();
            dp.Dependienteid = Convert.ToInt16(label27.Text);
            dp.Nombre = Dep_Nombres.Text;
            dp.Identificacion = Dep_Identificacion.Text;
            dp.Nombre = Dep_Nombres.Text;
            dp.FechaNacimiento =  Dep_Fecha.Value;
            dp.PacienteId = paciente.PACIENTEID;
            dp.Parentesco = (DependientesDTO.parentesco)Dep_CmbParentesco.SelectedValue;
            DependientesManager cm = new DependientesManager();
            if (nuevoDep)
            {
                cm.InsertDep(dp);
                nuevoDep = false;
            }
            else
            {
                cm.Edit(dp);
                nuevoDep = false;
            }
            groupBox2.Enabled = false;
          
            UpdatedataGrid1();
            ActualizarBotones(MODOREG);

        }
        private void ActualizarBotones(int modo)
        {if (modo == MODOREG)
            {
                if (this.dataGridView1.Rows.Count > 0)
                {
                    Btndelete.Visible = true;
                    customButtonEdit.Visible = true;
                }
                else
                {
                    Btndelete.Visible = false;
                    customButtonEdit.Visible = false;
                }
                customButtonGuardar.Visible = false;
                customButtonCancelar.Visible = false;
                customButtonAdd.Visible = true;
            }else
            {
                Btndelete.Visible = false;
                customButtonGuardar.Visible = true;
                customButtonCancelar.Visible = true;
                customButtonEdit.Visible = false;
                customButtonAdd.Visible = false;

            }
        }
        private void customButton1_Click(object sender, EventArgs e)
        {
            BlanquearFormaDep();
            nuevoDep = true;
            ActualizarBotones(MODOEDIT);
            Dep_Identificacion.Focus();
        }

        private void BlanquearFormaDep()
        {
            Dep_CmbParentesco.Text = "";
            Dep_Nombres.Text = "";
            Dep_Fecha.Text = "";
            Dep_CmbParentesco.Text = "";
            Dep_Identificacion.Text = "";
            groupBox2.Enabled = true;
            label27.Text = "0";
        }

        private void customButtonEdit_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
            ActualizarBotones(MODOEDIT);
            Dep_Identificacion.Focus();
        }
                
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult resp = MessageBox.Show("Esta Seguro de Eliminar este Beneficiario", "Confirmación", MessageBoxButtons.YesNo);
            if (resp == DialogResult.Yes)
            {
                DependientesManager cm = new DependientesManager();
                cm.Delete(Convert.ToInt16(label27.Text));
                UpdatedataGrid1();
               
                ActualizarBotones(MODOREG);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            BuscarPaciente bp = new BuscarPaciente();
            bp.ShowDialog();
            CargaPaciente(bp.idpaciente);
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            camara bp = new camara();
            bp.ShowDialog();
            if(bp.filename!= null)
                {
                paciente.ARCHIVOCEDULA = bp.filename;
                Photofile.Text = bp.filename;
                loadPhoto(paciente.ARCHIVOCEDULA);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            blanquearimagen();
        }

        private void blanquearimagen()
        {
            Image imgb = null;
            Photo.Image = imgb;
            Photofile.Text = "";
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            editar = true;
            Btn_EditarPaciente.Enabled = false;
            Btn_GuardarPaciente.Enabled = true;
            Btn_cancelarEdicionPaciente.Enabled = true;
            
              
            HabilitarControles();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Utiles.BlanquearControles(this);
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
            HabilitarControles();
        }

      
      

        private void customButton2_Click_1(object sender, EventArgs e)
        {
            customButtonscandoc.Enabled = true;
            customButtonscandoc.Visible=true;
            BlanquearSubFormaDoc();
            nuevoDoc = true;
            ActualizarBotonesDoc(MODOEDIT);
           Doc_TipoDocumento.Focus();
        }

        private void BlanquearSubFormaDoc()
        {
            Doc_TipoDocumento.Text = "";
            Doc_Observaciones.Text = "";
            Doc_Archivo.Text = "";
            groupBox4.Enabled = true;
            label35.Text = "0";
        }

        private void customButton4_Click(object sender, EventArgs e)
        {
            Scanner sc = new Scanner();
            sc.ShowDialog();
            Doc_Archivo.Text = sc.finalfile;
        }

        private void customButton7_Click(object sender, EventArgs e)
        {
            DocumentosDTO Doc = new DocumentosDTO();
            Doc.idPaciente = paciente.PACIENTEID;
            if (!nuevoDoc)
                   Doc.idDocumento = Convert.ToInt16(label35.Text);
            Doc.TipoDocumento = Doc_TipoDocumento.Text;
            Doc.observaciones = Doc_Observaciones.Text;
            Doc.Archivo = Doc_Archivo.Text;
            DocumentosManager dcm = new DocumentosManager();
            if (nuevoDoc)
            {
                dcm.InsertDoc(Doc);
                nuevoDoc = false;
            }
            else
            {
                dcm.Edit(Doc);
                nuevoDoc = false;
            }
            groupBox4.Enabled = false;

            UpdatedataGrid2();
            ActualizarBotonesDoc(MODOREGDOC);
        }

        private void ActualizarBotonesDoc(int modo)
        {
            if (modo == MODOREGDOC)
            {
                if (this.dataGridView1.Rows.Count > 0)
                {
                    this.BtnDeleteDoc.Visible = true;
                    customButtonEditDoc.Visible = true;
                }
                else
                {
                    BtnDeleteDoc.Visible = false;
                    customButtonEditDoc.Visible = false;
                }
                customButtonGuardarDoc.Visible = false;
                customButtonCancelarDoc.Visible = false;
                customButtonNuevoDoc.Visible = true;
            }
            else
            {
                Btndelete.Visible = false;
                customButtonGuardarDoc.Visible = true;
                customButtonCancelarDoc.Visible = true;
                customButtonEditDoc.Visible = false;
                customButtonNuevoDoc.Visible = false;

            }
        }

        private void UpdatedataGrid2()
        {
            DocumentosManager dm = new DocumentosManager();
            this.dataGridView2.DataSource = dm.GetDocumentos(paciente.PACIENTEID);
            if (dataGridView2.SelectedRows.Count == 0)
            {

                BlanquearSubFormaDoc();
                groupBox4.Enabled = false;
            }
        }

     

        private void customButton3_Click(object sender, EventArgs e)
        {

        }

        private void Btn_cancelarEdicionPaciente_Click(object sender, EventArgs e)
        {
            editar = false;
            agregar = false;
            Btn_EditarPaciente.Enabled = true;
            Btn_GuardarPaciente.Enabled = false;
            Btn_NuevoPaciente.Enabled = true;
            DesabilitarControles();
        }

        private void BtnDeleteDoc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult resp = MessageBox.Show("Esta Seguro de Eliminar este Documento", "Confirmación", MessageBoxButtons.YesNo);
            if (resp == DialogResult.Yes)
            {
                if (this.dataGridView2.SelectedRows.Count == 1)
                {
                    DocumentosManager cm = new DocumentosManager();
                    cm.Delete(Convert.ToInt32(this.dataGridView2.SelectedRows[0].Cells[0].Value));
                    UpdatedataGrid2();
                }
                ActualizarBotones(MODOREG);
            }
        }

        private void customButtonEditDoc_Click(object sender, EventArgs e)
        {
            if (this.dataGridView2.SelectedRows.Count == 1)
            {
                Properties.Settings s = new Properties.Settings();
                string pathfile = s.DirectorioImagenes + "\\" + this.dataGridView2.SelectedRows[0].Cells["Archivo"].Value;
                View v = new View(pathfile);
                v.ShowDialog();
                
            }
           
        }
    }
}
