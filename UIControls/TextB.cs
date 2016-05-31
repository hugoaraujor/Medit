using System;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;
using System.Drawing.Drawing2D;
using System.Drawing.Design;
using System.Windows.Forms.Design;
using System.Security.Permissions;
using System.Runtime.InteropServices;

namespace UIControls
{
    public class TextB : TextBox
    {
        public TextB()
        {
            this.GotFocus += TextB_GotFocus;
            this.LostFocus += TextB_LostFocus;
            this.KeyPress += TextB_KeyPress;
            this.KeyDown += TextB_KeyDown;
        }

        private void TextB_KeyDown(object sender, KeyEventArgs e)
        {
            var keyData = e.KeyData;
                     if ( keyData==  Keys.Enter || keyData == Keys.Down)
                SendKeys.Send("{Tab}");

            
            if (keyData == Keys.Up )
                SendKeys.Send("+{Tab}");


            


        }

        bool allowSpace = false;
        bool numerico = false;
        bool esdecimal = false;
        int longitud = 32000;
        public int Longitud
        {
            set
            {
                this.longitud = value;
            }

            get
            {
                return this.longitud;
            }
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

        public bool Numerico
        {
            set
            {
                this.numerico = value;
            }

            get
            {
                return this.numerico;
            }
        }

        public int IntValue
        {
            get
            {
                return Int32.Parse(this.Text);
            }
        }

        public decimal DecimalValue
        {
            get
            { if (this.Text != null)
                    return Decimal.Parse(this.Text);
                else
                    return 0;
            }
        }

        public bool AllowSpace
        {
            set
            {
                this.allowSpace = value;
            }

            get
            {
                return this.allowSpace;
            }
        }

        public bool Esdecimal
        {
            get
            {
                return esdecimal;
            }

            set
            {
                esdecimal = value;
            }
        }

        private void TextB_LostFocus(object sender, EventArgs e)
        {

            this.BackColor = Color.White;
            if (numerico)
            {
                if (Esdecimal)
                {
                    // this.Text = (String.Format("{0:00.00}", this.Text));
                    try
                    {
                        if (this.Text != "")
                            this.Text = (String.Format("{0:0.00}", Decimal.Parse(this.Text)));

                    }
                    catch
                    { }
                }
                TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            }


        }
      

   
    private void TextB_GotFocus(object sender, EventArgs e)
    {
        this.BackColor = Color.Aquamarine;

        }
    

private void TextB_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (numerico)
        {
            NumberFormatInfo numberFormatInfo = System.Globalization.CultureInfo.CurrentCulture.NumberFormat;
            string decimalSeparator = numberFormatInfo.NumberDecimalSeparator;
            string groupSeparator = numberFormatInfo.NumberGroupSeparator;
            string negativeSign = numberFormatInfo.NegativeSign;
            // Workaround for groupSeparator equal to non-breaking space 
            if (groupSeparator == ((char)160).ToString())
            {
                groupSeparator = " ";
            }
            string keyInput = e.KeyChar.ToString();
            if (Char.IsDigit(e.KeyChar))
            {
                // Digits are OK
            }
            else if (keyInput.Equals(decimalSeparator) || keyInput.Equals(groupSeparator) ||
             keyInput.Equals(negativeSign))
            {
                // Decimal separator is OK
            }
            else if (e.KeyChar == '\b')
            {
                // Backspace key is OK
            }
            //    else if ((ModifierKeys & (Keys.Control | Keys.Alt)) != 0) 
            //    { 
            //     // Let the edit control handle control and alt key combinations 
            //    } 
            else if (this.allowSpace && e.KeyChar == ' ')
            {

            }
            else
            {
                // Consume this invalid key and beep
                e.Handled = true;
                //    MessageBeep();
            }
        }
    }


}
      
    }

