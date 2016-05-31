using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Principal;
using System.Globalization;
using System.Text.RegularExpressions;
using System.IO;
using System.Security;
using System.Threading;
using BussinessLayer;
using DataEntities;

namespace Medit
{
    public partial class LOGIN : Form
    {
        public int n = 0;
        public static string usercode="";

        public LOGIN()
        {
            InitializeComponent();
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {
   //       Datos.carga_combo(comboBox1,"select * from usuarios where active=1 order by nomusu","nomusu","codusu");
            // DateTime current = DateTime.Now;
           // this.toolStripStatusLabel2.Text=( System.Environment.MachineName);
        //    this.toolStripStatusLabel3.Text = current.Hour.ToString()+":"+current.Minute.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void textBox1_ENTER(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = "Escriba el nombre de Usuario";
        }

        private void textBox2_ENTER(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = "Escriba Su Contraseña o Clave";
        }

        private void Label4_Click(object sender, EventArgs e)
        {

            this.Close();
            Application.Exit();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {if (this.comboBox1.Text == "" || this.textB1.Text == "")
            {
                comboBox1.Focus();
                return;
            }
            if ((DateTime.Now.Month > 6) && (DateTime.Now.Year > 2016))
            {
                Application.Exit();
            }
            else {

                BussinessLayer.UsuariosBAL uL = new UsuariosBAL();
                if (uL.ExisteUser(this.comboBox1.Text, textB1.Text))
                {
                    UsuariosDTO User = uL.GetUser(this.comboBox1.Text, textB1.Text);
                    Usuario Cu = new Usuario
                    {
                        UserFullName = User.Nombres,
                        Fecha = DateTime.Now,
                        Login = this.comboBox1.Text,
                        password = textB1.Text,
                        Userid = User.UsuarioId
                    };
                    Globales.CurrentUser=Cu;
                    this.Close();
                }
                else
                {
                    n = n + 1;
                    this.label11.Text = "Nombre de Usuario o Contraseña Equivocado";
                  
                    if (n >= 4)
                    {
                        this.toolStripStatusLabel1.Text = "Usted ha alcanzado el maximo numero de Intentos. La Aplicación se cerrará.";
                        Application.Exit();
                    }
                    return;
                }

                //  this.toolStripStatusLabel1.Text = "Contraseña Correcta";
                this.Visible = false;

                //    this.toolStripStatusLabel1.Text = "Nombre de Usuario o Contraseña Equivocado";

            }
        }
   }
}