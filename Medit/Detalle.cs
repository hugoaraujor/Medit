using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medit
{
   
    public partial class Detalle : UserControl
    {
        bool activa= true;
        public bool Activa
        {
            set
            {
                this.activa= value;
            }

            get
            {
                return this.activa;
            }
        }
        int id = 0;
        public int Id
        {
            set
            {
                this.id = value;
            }

            get
            {
                return this.id;
            }
        }
        string medicamento = "";
        public string Medicamento
        {
            set
            {
                this.medicamento = value;
                label1.Text = medicamento;
            }

            get
            {
                return this.medicamento;
            }
        }
        string presentacion = "";
        public string Presentacion
        {
            set
            {
                this.presentacion = value;
                label2.Text = presentacion;
            }

            get
            {
                return this.presentacion;
            }
        }
        string indicaciones = "";
        public string Indicaciones
        {
            set
            {
                this.indicaciones = value;
                label3.Text = indicaciones;
            }

            get
            {
                return this.indicaciones;
            }
        }
        public Detalle()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {this.activa = false;
            this.Visible = false;
        }
    }
}
