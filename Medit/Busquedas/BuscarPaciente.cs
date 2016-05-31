using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataEntities;
using BussinessLayer;
namespace Medit
{
    public partial class BuscarPaciente : Form
    {
       public  long idpaciente;
        public BuscarPaciente()
        {
            
            InitializeComponent();
        }

        private void BuscarPaciente_Load(object sender, EventArgs e)
        {
            PacientesManager cm = new PacientesManager();

            this.dataGridView1.DataSource=cm.GetPacientesView(this.textB1.Text);
            this.dataGridView1.Columns[0].Visible = false;

        }

        private void textB1_TextChanged(object sender, EventArgs e)
        {
            PacientesManager cm = new PacientesManager();
            this.dataGridView1.DataSource = cm.GetPacientesView(this.textB1.Text);
            this.dataGridView1.Columns[0].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count == 1)
            {
                idpaciente=(long)this.dataGridView1.SelectedRows[0].Cells[0].Value;
                this.Close();
            }
        }
    }
}
