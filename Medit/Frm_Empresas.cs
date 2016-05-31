using BussinessLayer;
using DataEntities;
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
    public partial class Frm_Empresas : Form
    {
        public string  XEMPRESA;
        public bool Aseguradoras = false;
        public Frm_Empresas()
        {
            InitializeComponent();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
           bool esaseguradora = false;
            if (Aseguradoras)
            {
                esaseguradora = true;
            }
            EmpresasDTO newemp = new EmpresasDTO() {
                Active = true,
                Empresa = txtNombre.Text,
                RIF = txtrif.Text,
                Contacto = txtPersona.Text,
                Aseguradora = esaseguradora,
                limite=0,
                creditodias=0,

           
              
            };
            EmpresasManager em = new EmpresasManager();
            em.InsertEmpresa(newemp);
            XEMPRESA=newemp.Empresa;
            this.Close();
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Empresas_Load(object sender, EventArgs e)
        {
            if (Aseguradoras)
                this.Text = "Empresas de Seguros";
            if (XEMPRESA!=null)
            {
                txtNombre.Text = XEMPRESA;
                txtrif.Focus();
            }
        }
    }
}
