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
    public partial class BuscarCargos : Form
    {
        public int idCargoSel;
        private int tipo;
        public BuscarCargos()
        {
           // tipo = Type;
            InitializeComponent();
        }

        private void BuscarCargos_Load(object sender, EventArgs e)
        {
            Mensaje.Text = "Seleccione un Registro haciendo Click y luego presione Seleccionar.";
                var filtro = "";
            CargosManager cm = new CargosManager();
            dataGridView1.DataSource = cm.GetCargosTable(filtro);
            dataGridView1.Columns[0].Visible = false;
        }

        private void textB1_TextChanged(object sender, EventArgs e)
        {
            var filtro = ((TextB)sender).Text;
            CargosManager cm = new CargosManager();
            dataGridView1.DataSource = cm.GetCargosTable(filtro);
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            Mensaje.Text = "";
            if (this.dataGridView1.SelectedRows.Count == 1)
            {
                idCargoSel = (int)this.dataGridView1.SelectedRows[0].Cells[0].Value;
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
                Mensaje.Text = this.dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                
            }
        }
    }
}
