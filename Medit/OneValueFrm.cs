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
    public partial class OneValueFrm : Form
    {
        private string palabra { get; set; }
        public OneValueFrm(string word)
        {
            InitializeComponent();
            palabra = word;
            this.textB1.Text = palabra;

        }
        // Forma para captar un Valor string 
        public String value()
        {
            return palabra; 
        }
        private void customButton1_Click(object sender, EventArgs e)
        {
            palabra = this.textB1.Text;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void textB1_TextChanged(object sender, EventArgs e)
        {
            if (textB1.Text.Length > 0)
                 customButton1.Enabled = true;
            else
                customButton1.Enabled =false;
        }
    }
}
