using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using BussinessLayer;
using DataEntities;

namespace Medit
{
    public partial class MedicosFrm : Form
    {
        public long idcurrent = 2;
        List<int> borrados = new List<int>();
        ComboBox cbm;
        DataGridViewCell currentCell;

        // This DataTable will become a data source for the DataGridView
        DataTable dt = new DataTable();


        private bool nuevo = false;
        public bool agregar = false;
        public bool editar = false;
        public const int MODOREG = 0;
        public const int MODOEDIT = 1;
        public const int MODOREGDOC = 0;
        public const int MODOEDITDOC = 1;
        private int tipo;
        MedicosManager cm = new MedicosManager();
        public MedicosFrm()
        {
            InitializeComponent();
        }

        private void Btn_NuevoCargo_Click(object sender, EventArgs e)
        {
            Btn_BuscarCargo.Enabled = false;
           
            idcurrent = 0;
            nuevo = true;
            toolStripButton1.Enabled = false;
            Btn_NuevoCargo.Enabled = false;
            Btn_GuardarCargo.Enabled = true;
            Btn_cancelarEdicionCargo.Enabled = true;
            Utiles.BlanquearControles(this);
            Utiles.HabilitarControles(this);
            textB1.Text = "0";
            textB8.Focus();
            CargaCombo();
        }

        private void Btn_EditarCargo_Click(object sender, EventArgs e)
        {
            if (textB1.Text.ToString() == "")
                return;
            editar = true;
            Btn_GuardarCargo.Enabled = true;
            Btn_cancelarEdicionCargo.Enabled = true;
            toolStripButton1.Enabled = false;

            Utiles.HabilitarControles(this);
            textB8.Focus();
        }

        private void Btn_GuardarCargo_Click(object sender, EventArgs e)
        {
            
            int retorno = 0;
            if (nuevo && textB1.Text == "0")
            {       retorno = cm.InsertDoctor(new MedicosDTO {
                    activo = checkBox1.Checked,
                    apellidos = textB2.Text,
                    nombres = textB8.Text,
                    especialidad = (int)comboPlus1.SelectedValue,
                    especialista = checkBox2.Checked,
                    horariodeconsulta = textB5.Text,
                    telefono = textB4.Text,
                    telefono2 = textB3.Text,
                    ncm = textB7.Text });
        }
            else
            {
              retorno = (Convert.ToInt32(textB1.Text));
              cm.Edit(new MedicosDTO {


          activo=checkBox1.Checked,
                especialista =  checkBox2.Checked,
                doctorid= Convert.ToInt32(textB1.Text),
                especialidad = (int)comboPlus1.SelectedValue,
                nombres=textB8.Text,
                apellidos=textB2.Text,
                  telefono=textB4.Text,
                telefono2 = textB3.Text,
                 horariodeconsulta=textB5.Text,
                ncm=textB7.Text


            });

            }
            toolStripButton1.Enabled = true;
            Btn_BuscarCargo.Enabled = true;
            Btn_GuardarCargo.Enabled = false;
            Btn_cancelarEdicionCargo.Enabled = false;
            Btn_NuevoCargo.Enabled = true;
            Utiles.DesHabilitarControles(this);
            textB1.Text = retorno.ToString();
        }

        private void Btn_cancelarEdicionCargo_Click(object sender, EventArgs e)
        {
            Btn_BuscarCargo.Enabled = true;

            Btn_cancelarEdicionCargo.Enabled = false;
            editar = false;
            agregar = false;


            if (idcurrent != 0)
                Btn_NuevoCargo.Enabled = false;
            toolStripButton1.Enabled = true;
            Btn_GuardarCargo.Enabled = false;
            Btn_NuevoCargo.Enabled = true;
            Utiles.DesHabilitarControles(this);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
          
            if (textB1.Text == "")
                return;
            DialogResult resp = MessageBox.Show("Esta Seguro de Eliminar Registro", "Confirmación", MessageBoxButtons.YesNoCancel);
            if (resp == DialogResult.Yes)
            {
                cm.Delete(Convert.ToInt16(textB1.Text));
                Utiles.BlanquearControles(this);
               

            }
        }
        private void CargaMedico(int iddoctor)
        {
            if (iddoctor == 0)
                return;

            MedicosManager tcm = new MedicosManager();
            DataEntities.MedicosDTO cmed = tcm.GetDoctor(iddoctor);

            if (cmed.activo == null || cmed.activo == false)
                checkBox1.Checked = false;
            else
                checkBox1.Checked = true;

            if (cmed.especialista == null || cmed.especialista == false)
                checkBox2.Checked = false;
            else
                checkBox2.Checked = true;

            textB1.Text = cmed.doctorid.ToString();

            tipo = (int)cmed.especialidad;
            CargaCombo();
            textB8.Text = cmed.nombres;
            textB2.Text = cmed.apellidos;
            textB4.Text = cmed.telefono;
            textB3.Text = cmed.telefono2;
            textB5.Text = cmed.horariodeconsulta;
            comboPlus1.SelectedValue = tipo;
            textB7.Text = cmed.ncm;

            idcurrent = cmed.doctorid;


        }
        private void Btn_BuscarCargo_Click(object sender, EventArgs e)
        {
            BuscarMedicos bp = new BuscarMedicos();
            bp.ShowDialog();
            var aux = bp.idDoctorSel;
            if ( aux!= 0)
            {
                CargaMedico(bp.idDoctorSel);
                textB1.Text = aux.ToString();
            }
        }
    

        private void MedicosFrm_Load(object sender, EventArgs e)
        {
            Utiles.DesHabilitarControles(this);
        }
        private void CargaCombo()
        {
            EspecialidadesManager em = new EspecialidadesManager();
            this.comboPlus1.DataSource = em.GetEspecialidadesTable();
            this.comboPlus1.DisplayMember = "Especialidad";
            this.comboPlus1.ValueMember = "Id";
            

        }

        private void comboPlus1_Enter(object sender, EventArgs e)
        {
            if (((TextB)sender).Text == "")
                mensaje.Text = ((TextB)sender).Sugerencia;
            else
                mensaje.Text = "";
        }

        private void textB4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
