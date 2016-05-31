using BussinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medit
{
    public partial class BuscarMedicos : Form
    {
        public int idDoctorSel;
        private int tipo;
        public BuscarMedicos()
        {
           // tipo = Type;
            InitializeComponent();
        }

        private void BuscarCargos_Load(object sender, EventArgs e)
        {
            Mensaje.Text = "Seleccione un Registro haciendo Click y luego presione Seleccionar.";
                var filtro = "";
           MedicosManager cm = new MedicosManager();
            dataGridView1.DataSource = cm.GetDoctorTable(filtro);
            dataGridView1.Columns[0].Visible = false;
        }

        private void textB1_TextChanged(object sender, EventArgs e)
        {
            var filtro = ((TextB)sender).Text;
            MedicosManager cm = new MedicosManager();
            dataGridView1.DataSource = cm.GetDoctorTable(filtro);
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            Mensaje.Text = "";
            if (this.dataGridView1.SelectedRows.Count == 1)
            {
                idDoctorSel = (int)this.dataGridView1.SelectedRows[0].Cells[0].Value;
                this.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count == 1)
            {
                Mensaje.Text = this.dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                
            }
        }
    }
}
