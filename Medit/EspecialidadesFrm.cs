using BussinessLayer;
using DataEntities;
using System;
using System.Windows.Forms;

namespace Medit
{
    public partial class EspecialidadesFrm : Form
    {
        public int tipo;
        EspecialidadesManager ccm = new EspecialidadesManager();
        public EspecialidadesFrm()
        {
            InitializeComponent();
        }

        private void CargoClases_Load(object sender, EventArgs e)
        {
            try
            {
               
                cargarlista();
            }
            catch { }
        }

       

        private void cargarlista()
        {
            listBox1.DataSource = ccm.GetEspecialidades();
            listBox1.DisplayMember = "Especialidad";
            listBox1.ValueMember = "Id";
        }

        private void Btn_NuevoUsuario_Click(object sender, EventArgs e)
        {
            OneValueFrm One = new OneValueFrm("");
            One.ShowDialog();
            string clase = One.value();
            if (!(ccm.ExisteEsp(clase)))
            {
                ccm.Insert(new EspecialidadDTO { Especialidad = clase });
                toolStripStatusLabel1.Text = "OK.";
               cargarlista();
            }
            else
                toolStripStatusLabel1.Text = "El valor ya existe en la Lista.";


        }

        private void Btn_Edita_Click(object sender, EventArgs e)
        {
            OneValueFrm One = new OneValueFrm(this.listBox1.Text);
            One.ShowDialog();
            string clase = One.value();
            if (!ccm.ExisteEsp(clase))
            {
                ccm.Edit(new EspecialidadDTO { Id =(int)listBox1.SelectedValue, Especialidad = clase});
                toolStripStatusLabel1.Text = "OK.";
                
                cargarlista();
            }
            else
                toolStripStatusLabel1.Text = "El valor ya existe en la Lista.";
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            MedicosManager mm = new MedicosManager();
            if (mm.CountDoctorsbyEspecialidad((int)listBox1.SelectedValue) > 0)
                MessageBox.Show("No se puede Eliminar. " + Environment.NewLine + "Hay Médicos Asociados a esta Especialidad", "Mensaje");
            else
            {
                DialogResult resp = MessageBox.Show("Esta Seguro de Eliminar Registro", "Confirmación", MessageBoxButtons.YesNoCancel);
                if (resp == DialogResult.Yes)
                {
                    ccm.Delete((int)listBox1.SelectedValue);
                    toolStripStatusLabel1.Text = "OK.";
                    cargarlista();
                }
            }

        }

       
    }
}
