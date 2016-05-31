using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medit
{
    public class Utiles
    {
        public double nzs(string valor)

        {
            Double n = 0;
            if (string.IsNullOrEmpty(valor))
                n = 0;
            else
                n = Convert.ToDouble(valor);
            return n;
        }
   
        public static void BlanquearControles(Control o)
        {

            foreach (Control c in o.Controls)
            {
                if (c is DateTimePicker)
                    ((DateTimePicker)c).Value = Convert.ToDateTime("01/01/1980");
                if (c is TextB || c is ComboBox)
                    c.Text = "";
                if (c is FlowLayoutPanel)
                {
                    BlanquearControles(c);
                }
                if (c is GroupBox)
                    BlanquearControles(c);

                if (c is TabControl)
                {
                    foreach (TabPage tp in c.Controls)
                        BlanquearControles(tp);
                }

                if (c is CheckBox)
                    ((CheckBox)c).Checked = false;

                if (c is DataGridView)
                {
                    ((DataGridView)c).DataSource = null;
                   
                    //((DataGridView)c).Columns.RemoveAt(0);
                    if (((DataGridView)c).Columns.Count > 0)
                    {
                        ((DataGridView)c).Columns.Clear();
                    }
                }
            }
        }
        public static void HabilitarControles(Control o)
        {
            foreach (Control c in o.Controls)
            {
                if (c is DataGridView)
                {
                    ((DataGridView)c).Enabled = true;
                    ((DataGridView)c).DefaultCellStyle.BackColor = System.Drawing.Color.White;
                }
                if (c is DateTimePicker)
                    ((DateTimePicker)c).Enabled = true;
                if (c is CheckBox)
                    ((CheckBox)c).Enabled = true;
                if (c is TextB || c is ComboBox)
                    c.Enabled = true;
                if (c is FlowLayoutPanel)
                {
                    c.Enabled = true;
                    HabilitarControles(c);
                }
                if (c is GroupBox)
                {
                    c.Enabled = true;
                    HabilitarControles(c);
                }
                if (c is TabControl)
                {
                    foreach (TabPage tp in c.Controls)
                        HabilitarControles(tp);
                }
            }
        }
        public static void DesHabilitarControles(Control o)
        {
            foreach (Control c in o.Controls)
            {
                if (c is CheckBox)
                    ((CheckBox)c).Enabled = false;
                if (c is DataGridView)
                {       ((DataGridView)c).Enabled = false;
                ((DataGridView)c).DefaultCellStyle.BackColor = System.Drawing.Color.Gainsboro;
            }
                if (c is DateTimePicker)
                    ((DateTimePicker)c).Enabled = false;
                if (c is TextB || c is ComboBox)
                    c.Enabled = false;
                if (c is FlowLayoutPanel)
                {
                    c.Enabled = false;
                    DesHabilitarControles(c);
                }
                if (c is GroupBox)
                {
                    c.Enabled = false;
                    DesHabilitarControles(c);
                }
                if (c is TabControl)
                {
                    foreach (TabPage tp in c.Controls)
                        DesHabilitarControles(tp);
                }
            }
        }
    }
}
