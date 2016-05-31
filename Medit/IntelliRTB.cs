using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;

namespace Medit
{
    public partial class IntelliSenseTextBox : TextBox
    {
        #region Class Members
        List<string> dictionary;
        ListBox listbox = new ListBox();
       
        #endregion

        #region Extern functions
        [DllImport("user32")]
        private extern static int GetCaretPos(out Point p);
        #endregion

        #region Constructors

        public IntelliSenseTextBox() : base()
        {
            listbox.Width = 650;
            listbox.Height = 147;
            this.Multiline = true;
            // listbox = new ListBox();
            this.Controls.Add(listbox);
            listbox.Parent = this;
            listbox.BringToFront();

            // listbox.Location = new Point(100, 100);

            listbox.KeyUp += OnKeyUp;
            this.KeyUp += OnKeyUp2;
            listbox.Visible = false;
            this.dictionary = new List<string>();
        }

       
        #endregion

        #region Properties

        public List<string> Dictionary
        {
            get { return this.dictionary; }
            set { this.dictionary = value; }
        }
        #endregion

        #region Methods


        private static string GetLastString(string s)
        {
            string[] strArray = s.Split(' ');
            return strArray[strArray.Length-1 ];
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            Point cp;

            GetCaretPos(out cp);
            List<string> lstTemp = new List<string>();
           listbox.Location = new Point(cp.X+4 , cp.Y + 15);
            //  listbox.SetBounds(cp.X + this.Location.X, cp.Y + this.Location.Y + 20, 650, 100);
            //var este = this.Text.Replace("\r\n", " ");
           
            var TempFilteredList = dictionary.Where(n => n.ToUpperInvariant().Contains(GetLastString(this.Text).ToUpperInvariant())|| n.ToUpperInvariant().StartsWith(GetLastString(this.Text).ToUpperInvariant())).Select(r => r);
          
            lstTemp = TempFilteredList.ToList<string>();
            if (lstTemp.Count != 0 && GetLastString(this.Text) != "")
            {
                listbox.DataSource = lstTemp;
                listbox.Refresh();
              listbox.Show();
            }
            else
            {

               // listbox.Hide();
            }
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            //e.KeyChar == (char)Keys.Enter ||
           if ( e.KeyChar == (char)Keys.Down)
            {
                if (listbox.Visible == true)
                {
                    listbox.Focus();
                }
                e.Handled = true;
            }
            else if (e.KeyChar == (char)Keys.Escape)
            {
                listbox.Visible = false;
                e.Handled = true;
            }

        }

        private void OnKeyUp2(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                if (listbox.Visible == true)
                {
                    listbox.Focus();
                }
                e.Handled = true;
            }
           

        }

        private void OnKeyUp(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                string StrLS = GetLastString(this.Text);
                int LIOLS = this.Text.LastIndexOf(StrLS);
                string TempStr = this.Text.Remove(LIOLS);
                this.Text = TempStr + ((ListBox)sender).SelectedItem.ToString();
                this.Select(this.Text.Length, 0);
                listbox.Hide();
                this.Focus();
               

            }
          

        }
        #endregion
       
    }
    }

