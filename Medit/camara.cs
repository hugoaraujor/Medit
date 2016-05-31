using System;
using System.Drawing;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing.Drawing2D;
using System.IO;
using Medit.Properties;

namespace Medit
{
    public partial class camara : Form
    {//Variables para el Scan
     //Crop rectangle
        Rectangle rectCropArea = new Rectangle();
        public String filename;
        private int pix;
        private int piy;
        private int pfx;
        private int pfy;
        //Dimensiones
        private int oWidth = 0;
        private int oHeight = 0;
        //Acciones del usuario
        private bool drag = false;
        private bool scaneo = false;
        //imagenes
        private bool ExisteDispositivo = false;
        private FilterInfoCollection DispositivoDeVideo;
        private VideoCaptureDevice FuenteDeVideo = null;
        //Id del paciente a la que pertenece esta imagen
        public long Currentpac = 2;
        public long Currentdocument = 2;

        public camara()
        {
            InitializeComponent();
            BuscarDispositivos();
            
        }
   
        public void CargarDispositivos(FilterInfoCollection Dispositivos)
        {
            for (int i = 0; i < Dispositivos.Count; i++) ;
            
                cbxDispositivos.Items.Add(Dispositivos[0].Name.ToString());
                cbxDispositivos.Text = cbxDispositivos.Items[0].ToString();
            
        }

        public void BuscarDispositivos()
        {
            DispositivoDeVideo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (DispositivoDeVideo.Count == 0)
            {
                ExisteDispositivo = false;
            }

            else
            {
                ExisteDispositivo = true;
                CargarDispositivos(DispositivoDeVideo);

            }
        }

        public void TerminarFuenteDeVideo()
        { 
        if (!(FuenteDeVideo==null))
            if(FuenteDeVideo.IsRunning)
            {
            FuenteDeVideo.SignalToStop();
            FuenteDeVideo= null;
            }

        }

       public  void Video_NuevoFrame( object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();
            img.Image = Imagen;
          
           
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (btnIniciar.Text == "Iniciar")
                
            {
                if (ExisteDispositivo)
                {

                    FuenteDeVideo = new VideoCaptureDevice(DispositivoDeVideo[cbxDispositivos.SelectedIndex].MonikerString);
                    FuenteDeVideo.NewFrame += new NewFrameEventHandler(Video_NuevoFrame);
                    FuenteDeVideo.Start();
                    Estado.Text = "Ejecutando Dispositivo...";
                    btnIniciar.Text = "Detener";
                    cbxDispositivos.Enabled = false;
                    groupBox1.Text = DispositivoDeVideo[cbxDispositivos.SelectedIndex].Name.ToString();
                }
                else
                {
                    Estado.Text = "Error: No se encuenta el Dispositivo";
                    scaneo = false;
                }
            }
            else
            {
            //    if (FuenteDeVideo == null) { TerminarFuenteDeVideo(); }
              //  if (FuenteDeVideo.IsRunning)
               //     {
                        TerminarFuenteDeVideo();
                        Estado.Text = "Dispositivo Detenido...";
                        btnIniciar.Text = "Iniciar";
                        cbxDispositivos.Enabled = true;

                 //   }
            
              
                scaneo = true;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (btnIniciar.Text == "Detener")
                btnIniciar_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

       
        #region Mouse Control Crop
        private void img_MouseUp(object sender, MouseEventArgs e)
        {
            if (drag && scaneo)
            {
                pfx = e.X;
                pfy = e.Y;
                drag = false;
      
                this.Refresh();
            }
        }

        private void img_MouseDown(object sender, MouseEventArgs e)
        {
            if (drag == false && scaneo)
            {
                pix = e.X;
                piy = e.Y;
                drag = true;
              
            }
        }

        private void img_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag && scaneo) { pfx = e.X; pfy = e.Y; }
        }

        private void img_Paint(object sender, PaintEventArgs e)
        {
            Rectangle ee = new Rectangle(pix, piy, (int)(pfx - pix), (int)((pfy - piy)));
            using (Pen pen = new Pen(Color.Crimson, 2))
            {
                e.Graphics.DrawRectangle(pen, ee);
            }
        }

        private void img_MouseHover(object sender, EventArgs e)
        {
            Rectangle ee = new Rectangle(pix, piy, pfx - pix, pfy - piy);
            Graphics gr = this.CreateGraphics();
            using (Pen pen = new Pen(Color.Crimson, 2))
            {
                gr.DrawRectangle(pen, ee);
            }
        }
        private void initUI()
        {
            pix = 0;
            piy = 0;
            pfx = 0;
            pfy = 0;
            button3.Enabled = true;
            rectCropArea = new Rectangle(0, 0, 0, 0);

            var path = @"c:\corinto\photo.png";

            try
            {
                if (File.Exists(path))
                {
                    img.Image = (Bitmap)Image.FromFile(path);
                    img.Tag = "1";
                    if (oWidth > 0)
                    {
                        img.Width = oWidth;
                        img.Height = oHeight;
                    }
                    else
                    {
                        oWidth = img.Width;
                        oHeight = img.Height;
                    }


                }
            }
            catch { }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (pix > 0)
            {
                rectCropArea = new Rectangle(pix, piy, pfx - pix, pfy - piy);
                try
                {
                    img.Refresh();
                    //Prepare a new Bitmap on which the cropped image will be drawn
                    Bitmap sourceBitmap = new Bitmap(img.Image, img.Width, img.Height);
                    Graphics g = img.CreateGraphics();
                    g.SmoothingMode = SmoothingMode.HighQuality;
                    g.CompositingQuality = CompositingQuality.HighQuality;
                    g.DrawImage(sourceBitmap, new Rectangle(pix, piy, rectCropArea.Width, rectCropArea.Height), rectCropArea, GraphicsUnit.Pixel);
                    img.Image = sourceBitmap.Clone(rectCropArea, img.Image.PixelFormat);
                    img.Width = rectCropArea.Width;
                    img.Height = rectCropArea.Height;
                    drag = false;
                    pix = 0;
                    piy = 0;
                    pfx = 0;
                    pfy = 0;
                    img.Refresh();
                }

                catch (Exception ex)
                {

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            initUI();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initUI();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {

            int consecutivo = 0;
            
            
            Properties.Settings s = new Settings();
            string path = s.DirectorioImagenes;
             filename = path + "\\photo-" + Currentpac.ToString() + "-" + Currentdocument.ToString();
             string filenameO = filename;
            while (File.Exists(filename + ".jpg"))
            {
                consecutivo++;
                filename = filenameO + "(" + consecutivo.ToString() + ")";
            }

                  img.Image.Save(filename + ".jpg");
            filename = filename.ToUpper().Replace(path.ToUpper(),"") + ".jpg";

            this.Close();
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            Properties.Settings s = new Properties.Settings();
            openFileDialog1.Filter = "Imagenes(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            openFileDialog1.InitialDirectory = s.DirectorioImagenes;
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName.ToString().Length > 0)
            {
                string archivo="";
                archivo = openFileDialog1.FileName.ToString();
                string archivoname = openFileDialog1.SafeFileName;
                string directorio= archivo.Substring(0, archivo.LastIndexOf('\\'));
                if (File.Exists(archivo)==true&&archivo.ToUpper().IndexOf(s.DirectorioImagenes.ToUpper())<0)
                {
                    DialogResult resp = MessageBox.Show("La Imagen seleccionada se copiara en el directorio de Imagenes", "Confime", MessageBoxButtons.YesNo);
                    if (resp == DialogResult.Yes)
                        File.Copy(archivo, s.DirectorioImagenes + "\\"+archivoname);
                }
           

                filename = archivoname;
                this.Close();
            }
            }
    }

    #endregion

}
