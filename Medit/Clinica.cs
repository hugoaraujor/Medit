using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLayer;
using DataEntities;
using System.IO;
namespace Medit
{
    public partial class Clinica : Form
    {
        private ClinicaManager cm = new ClinicaManager();
        public Clinica()
        {  
            InitializeComponent();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            bool updts = cm.Edit(cm.NewClinicaDTO(1, TRIF.Text, TDireccion1.Text, TDireccion2.Text, TDireccion3.Text, TDireccion4.Text, TCiudad.Text, TTelefonos.Text, TResponsable.Text, TCorreo.Text, TClinica.Text, TDirImagenes.Text, TDirExportados.Text, TArchivo.Text));
            if (!updts) { 
                MessageBox.Show("Algunos de los Valores no son Adecuados para la actualización.\n no se efectuaron los cambios solicitados");
                return;
        }
          this.Close();
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clinica_Load(object sender, EventArgs e)
        {
           ClinicaDTO Cdto= cm.GetClinica(1);
            TArchivo.Text = Cdto.ArchivoLogo;

            if ((Cdto.DirectorioImagenes!= null)&& Cdto.ArchivoLogo!= null)
                if (File.Exists(Cdto.DirectorioImagenes + "\\" + Cdto.ArchivoLogo))
            pictureBox1.Image = Image.FromFile(Cdto.DirectorioImagenes + "\\" + Cdto.ArchivoLogo);
            TClinica.Text = Cdto.CLINICA1;
            TRIF.Text = Cdto.RIF;
            TDireccion1.Text = Cdto.Direccion1;
           TDireccion2.Text = Cdto.Direccion2;
            TDireccion3.Text = Cdto.Direccion3;
            TDireccion4.Text = Cdto.Direccion4;
            TCiudad.Text = Cdto.Ciudad;
            TTelefonos.Text = Cdto.Telefonos;
            TResponsable.Text = Cdto.responsable;
            TCorreo.Text = Cdto.Correo;
            TDirExportados.Text = Cdto.DirectorioExportados;
            TDirImagenes.Text = Cdto.DirectorioImagenes;

        }

        private void customButton3_Click(object sender, EventArgs e)
        {
            Properties.Settings s = new Properties.Settings();
            openFileDialog1.Filter = "Imagenes(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            openFileDialog1.InitialDirectory = s.DirectorioImagenes;
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName.ToString().Length > 0)
            {
                string archivo = "";
                archivo = openFileDialog1.FileName.ToString();
                string archivoname = openFileDialog1.SafeFileName;
                string directorio = archivo.Substring(0, archivo.LastIndexOf('\\'));
                if (File.Exists(archivo) == true && archivo.ToUpper().IndexOf(s.DirectorioImagenes.ToUpper()) < 0)
                {
                    DialogResult resp = MessageBox.Show("La Imagen seleccionada se copiara en el directorio de Imagenes", "Confime", MessageBoxButtons.YesNo);
                    if (resp == DialogResult.Yes)
                        File.Copy(archivo, s.DirectorioImagenes + "\\" + archivoname);
                 
                }
                this.pictureBox1.Image = Image.FromFile(s.DirectorioImagenes + "\\" + archivoname);
                TArchivo.Text = archivoname;


            }
        }
    }
    }

