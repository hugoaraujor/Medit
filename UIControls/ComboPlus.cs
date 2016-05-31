using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIControls
{
    public partial class ComboPlus :ComboBox
    {
        public bool addMsg { get; set; }
        public bool Autoadd { get; set; }
        // expose properties as needed
        public Color SelectedBackColor { get; set; }
        public ComboPlus()
        {
            InitializeComponent();
            DrawItem += new DrawItemEventHandler(Combobox_DrawItem);
            DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            SelectedBackColor = Color.LightSeaGreen;
                
                      
        }


        string sugerencia = "";
        public string Sugerencia
        {
            set
            {
                this.sugerencia = value;
            }

            get
            {
                return this.sugerencia;
            }
        }
        private void Combobox_DrawItem(object sender, DrawItemEventArgs e)
        {
       
          
            if (Autoadd) {
            Color CurrentColor = Color.Blue;
            Rectangle SizeRect = new Rectangle(2, e.Bounds.Top + 2, e.Bounds.Width, e.Bounds.Height - 2);
            Brush ComboBrush;
                Brush ComboBrush2=Brushes.BlueViolet;
                e.DrawBackground();
            if (e.State == DrawItemState.Selected)
                ComboBrush = Brushes.White;
            else
                ComboBrush = Brushes.Black;

            if (e.Index == 0)
                ComboBrush = Brushes.Blue;

            SizeRect.Inflate(1, 1);
                if (addMsg)
                {
                    bool sw = false;
                    if (this.DataSource != null)
                    {
                        ComboBrush = ComboBrush2;
                        for (int i = 0; i < ((DataTable)this.DataSource).Rows.Count; i++)
                        {
                            DataRowView drv2 = (DataRowView)this.Items[i];
                            if (drv2[((ComboBox)sender).DisplayMember.ToString()].ToString() == "Nuevo...")
                                sw = true;
                        }
                    }
                    if (sw==false&& (this.DataSource != null))
                    {

                        DataRow dr = ((DataTable)(this.DataSource)).NewRow();
                        dr[0] = 0;
                        dr[1] = "Nuevo...";
                        ((DataTable)(this.DataSource)).Rows.Add(dr);
                        this.Refresh();

                    }
                }
                try {
                    DataRowView drv = (DataRowView)this.Items[e.Index];
                    e.Graphics.DrawString(drv[((ComboBox)sender).DisplayMember.ToString()].ToString(), this.Font, ComboBrush, e.Bounds.Height + 5, (((int)(e.Bounds.Height - this.Font.Height) / 2)) + e.Bounds.Top);
                }catch
                {
                    
                    e.Graphics.DrawString(this.Items[e.Index].ToString(), this.Font, ComboBrush, e.Bounds.Height + 5, (((int)(e.Bounds.Height - this.Font.Height) / 2)) + e.Bounds.Top);
                }
                //kljlkk
                    
            }
    }
    }
}
