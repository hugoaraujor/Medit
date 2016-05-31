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
    public partial class SintomaTag: UserControl
    {
        public SintomaTag()
        {
            InitializeComponent();
            this.label1.Height = 25;
            this.label1.Width = 40;
            this.Height = 25;
           
        }

    

        bool active;
        public bool Active
        {
            get { return this.active; }
            set { this.active = value; }
        }
        string palabra = "";
        public string Palabra
        {
            set
            {
                label1.AutoSize = false;
                this.palabra = value;
                this.label1.Text = palabra;
                this.Width = (palabra.Length*5)+30;
                this.label1.Width = (palabra.Length * 5) + 5;

                
            }

            get
            {
                return this.palabra;
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {
            this.active = false;

            this.Hide();
        }
    
    }
}
