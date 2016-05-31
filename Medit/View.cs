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
    public partial class View : Form
    {
        string archivo{get;set;}
        public View(string Archivo)
        {
            archivo = Archivo;
            InitializeComponent();
        }

        private void View_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(archivo);

        }

        private void View_FormClosing(object sender, FormClosingEventArgs e)
        {
            Image img= null;
            pictureBox1.Image = img;
        }
    }
}
