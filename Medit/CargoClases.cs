using BussinessLayer;
using DataEntities;
using System;
using System.Windows.Forms;

namespace Medit
{
    public partial class CargoClases : Form
    {
        public int tipo;
        CargoClasesManager ccm = new CargoClasesManager();
        public CargoClases()
        {
            InitializeComponent();
        }

        private void CargoClases_Load(object sender, EventArgs e)
        {
            TipoCargosManager tcm = new TipoCargosManager();
            this.comboBox1.DataSource = tcm.GetTipodeCargos();
            this.comboBox1.DisplayMember = "TipocargoDesc";
            this.comboBox1.ValueMember = "TipoCargoId";
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                tipo = (int)comboBox1.SelectedValue;
                cargarlista(tipo);
            }
            catch { }
        }

        private void cargarlista(int tipo)
        {
            CargoClasesManager ccm = new CargoClasesManager();
            listBox1.DataSource = ccm.GetClases(tipo);
            listBox1.DisplayMember = "Clase";
            listBox1.ValueMember = "ClaseId";
        }

        private void Btn_NuevoUsuario_Click(object sender, EventArgs e)
        {
            OneValueFrm One = new OneValueFrm("");
            One.ShowDialog();
            string clase = One.value();
            if (!ccm.ExisteClase(clase, tipo))
            {
                ccm.InsertClase(new DataEntities.CargosClasesDTO { Clase = clase, TipoCargoId = tipo });
                toolStripStatusLabel1.Text = "OK.";
               cargarlista(tipo);
            }
            else
                toolStripStatusLabel1.Text = "El valor ya existe en la Lista.";


        }

        private void Btn_Edita_Click(object sender, EventArgs e)
        {
            OneValueFrm One = new OneValueFrm(this.listBox1.Text);
            One.ShowDialog();
            string clase = One.value();
            if (!ccm.ExisteClase(clase, tipo))
            {
                ccm.Edit(new CargosClasesDTO { ClaseId =(int)listBox1.SelectedValue, Clase = clase, TipoCargoId = tipo });
                toolStripStatusLabel1.Text = "OK.";
                
                cargarlista(tipo);
            }
            else
                toolStripStatusLabel1.Text = "El valor ya existe en la Lista.";
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

            DialogResult resp = MessageBox.Show("Esta Seguro de Eliminar Registro", "Confirmación", MessageBoxButtons.YesNoCancel);
            if (resp == DialogResult.Yes)
            {
                ccm.Delete((int)listBox1.SelectedValue);
                toolStripStatusLabel1.Text = "OK.";
                cargarlista(tipo);
            }


        }

       
    }
}
