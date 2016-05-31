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
  
    public partial class Busqueda : Form
    {
        public int seleccion=0;
        private DataTable tabla;
        private string filter;
        public  Busqueda(DataTable t,string filtro)
        {
            tabla = t;
            filter = filtro;
            InitializeComponent();

        }
      

        private void Busqueda_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = tabla;
            
         }

        private void customButton1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                seleccion = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                this.Close();
            }
        }

        private void textB1_TextChanged(object sender, EventArgs e)
        {
            DataTable tabla2=new DataTable();
            if (tabla.Rows.Count > 0)
            {
                try
                {
                    tabla2 = tabla.Select(filter+" LIKE '" + textB1.Text + "*'").CopyToDataTable();
                }
                catch { };
            }
            dataGridView1.DataSource = tabla2;
        }
    }
}

