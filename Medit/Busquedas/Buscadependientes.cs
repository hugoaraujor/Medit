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
    public partial class Buscadependientes : Form
    {
        
        public int idresult;
        long idcurrent;
        public Buscadependientes(long pacienteid)
        {
            DialogResult = DialogResult.Cancel;
            idcurrent = pacienteid;
            InitializeComponent();
        }

        private void Buscadependientes_Load(object sender, EventArgs e)
        {
            this.dataGridView1.Visible = !this.dataGridView1.Visible;
            if (this.dataGridView1.Visible)
            {
                PacientesManager dm = new PacientesManager();
                this.dataGridView1.DataSource = dm.GetDependientes(idcurrent);
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[5].Visible = false;

            }
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            if (this.dataGridView1.SelectedRows.Count == 1)
            {
                idresult = Convert.ToInt32(this.dataGridView1.SelectedRows[0].Cells[0].Value);
            }
            this.Close();
        }

       
    }
}
