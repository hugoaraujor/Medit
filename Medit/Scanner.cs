using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using WIA;
using System.IO;
using Medit.Properties;
namespace Medit
{
    public partial class Scanner : Form
    {
        public bool erri=false;
        //Variables para el Scan
        //Crop rectangle
        int pix;
        int piy;
        int pfx;
        int pfy;
        //Dimensiones
        int oWidth = 0;
        int oHeight = 0;
        //Acciones del usuario
        bool drag = false;
        bool scaneo = false;
        //imagenes
        public string finalfile="";
        public ImageFile pimagen = new ImageFile();
        private GifImage gifImage;
        //Imageb de espera mientras se escanea
        private string filePath = @"C:\corinto\wait.gif";
        Rectangle rectCropArea = new Rectangle();
        public delegate void apagagif();
   
        //Id del paciente a la que pertenece esta imagen
        public long Currentpac=2;
        public long Currentdocument=2;
        //Originalmente publicado en
        //
        ////"https://danlaho.wordpress.com/2013/03/02/usando-el-scanner-desde-c///"
        //
        public Scanner()
        {
            System.Resources.ResourceManager rm = Resources.ResourceManager;
            gifImage = new GifImage(filePath);
            InitializeComponent();
        }
        //InutUI:reiniciar o cancelar previo scanner
        private void initUI()
        {
            pix = 0;
            piy = 0;
            pfx = 0;
            pfy = 0;
            button1.Enabled = true;
            rectCropArea = new Rectangle(0, 0, 0, 0);

            var path = @"c:\corinto\scan0.jpg";

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
        private void Scanner_Load(object sender, EventArgs e)
        {
            initUI();

            Devices.Items.Clear();
            var deviceManager = new DeviceManager();
            for (int i = 1; i <= deviceManager.DeviceInfos.Count; i++)
            {
                if (deviceManager.DeviceInfos[i].Type != WiaDeviceType.ScannerDeviceType)
                {
                    return;
                }
                Devices.Items.Add(new getScanner(deviceManager.DeviceInfos[i]));
                Devices.SelectedIndex = 0;
            }

        }
        public void gifoff()
        {
            pictureBox1.Visible = false;
            timer1.Enabled = false;
        }
        public void gifon()
        {
            pictureBox1.Visible = true;
            timer1.Enabled = true;
        }

        public class getScanner
        {
            private readonly DeviceInfo _deviceInfo;

            public getScanner(DeviceInfo deviceInfo)
            {
                this._deviceInfo = deviceInfo;
            }

            public ImageFile Scan()
            {
                ImageFile imagefile2=new ImageFile();
                try
                {
                    var device = this._deviceInfo.Connect();
                    var item = device.Items[1];
                    var imageFile = (ImageFile)item.Transfer("{B96B3CAE-0728-11D3-9D7B-0000F81EF32E}");//"{B96B3CAE-0728-11D3-9D7B-0000F81EF32E}"); bmp
                    return imageFile;
                }
                catch (Exception)
                {

                    return imagefile2;
                }
               
               
            }

            public override string ToString()
            {
                return this._deviceInfo.Properties["Name"].get_Value().ToString();
            }
        }

        private void Devices_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void ActionScan()
        {
          
            //   Devices.Items.Clear();
            //var deviceManager = new DeviceManager();
            //for (int i = 1; i <= deviceManager.DeviceInfos.Count; i++)
            //{
            //    if (deviceManager.DeviceInfos[i].Type != WiaDeviceType.ScannerDeviceType)
            //    {
            //        return;
            //    }
            //    Devices.Items.Add(new getScanner(deviceManager.DeviceInfos[i]));
            //    Devices.SelectedIndex = 0;
            //}
            var deviceManager = new DeviceManager();
           getScanner device=null;
   

            try
            {

                device = new getScanner(deviceManager.DeviceInfos[1]);
            }
            catch { }

            if (device == null)
            {
                erri = true;
                MessageBox.Show("Please select a device.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                img.Tag = "3";

            }
            else {

              
                var b = new apagagif(gifon);
           
                var image = new WIA.ImageFile();

                image = device.Scan();


                var path = @"c:\corinto\scan.jpeg";
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                try {
                    image.SaveFile(path);
                }
                catch
                {
                    img.Tag = "3";

                }
                if (File.Exists(path))
                {
                    img.Image = (Bitmap)Image.FromFile(path);
                    img.Tag = "2";
                }


               
            }
        }

        private System.Threading.Thread threadScan;
        private void button1_Click(object sender, EventArgs e)
        {
            
            button1.Enabled = false;
            
            timer1.Enabled = true;
         
                if (threadScan == null)
            {
               
                    threadScan = new System.Threading.Thread(ActionScan);
                    threadScan.Start();
               
            }

           
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            img.Width = (int)(oWidth * ((trackBar1.Value * 20 / 100) + 2));
            img.Height = (int)(oHeight * ((trackBar1.Value * 20 / 100) + 2));
            img.Refresh();
        }
        #region Mouse Control Crop
        private void img_MouseUp(object sender, MouseEventArgs e)
        {
            if (drag && scaneo)
            {
                pfx = e.X;
                pfy = e.Y;
                drag = false;
                groupBox1.Enabled = true;
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
                groupBox1.Enabled = false;
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

        private void button4_Click(object sender, EventArgs e)
        {
            img.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            img.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            img.Image.RotateFlip(RotateFlipType.RotateNoneFlipY);
            img.Refresh();
        }
        #endregion
        private void timer1_Tick(object sender, EventArgs e)
        {
           
            if (this.img.Tag.ToString() == "3")
            {
                img.Refresh();
                trackBar1.Visible = false;
                threadScan = null;
                initUI();
                this.img.Tag = "1";
                button1.Enabled = true;
                groupBox1.Enabled = false;
                scaneo = false;
                pictureBox1.Visible = false;
                timer1.Enabled = false;
                customButton1.Enabled = false;
                return;

            }
            if (this.img.Tag.ToString() == "1")
            {
                pictureBox1.Visible = true;
            

            }
            if (this.img.Tag== "2")
            {
                pictureBox1.Visible = false;
                timer1.Enabled = false;
                trackBar1.Visible = true;
                customButton1.Enabled = true;
                scaneo = true;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            img.Refresh();
            trackBar1.Visible = false;
            threadScan = null;
            initUI();
            this.img.Tag = "1";
            button1.Enabled = true;
            groupBox1.Enabled = false;
            scaneo = false;

        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {

            int consecutivo = 0;
            var finalimage = new WIA.ImageFile();
            finalimage.LoadFile(@"C:\corinto\scan.jpeg");
           Properties.Settings s =new Settings();
            string path = s.DirectorioImagenes;
            string filename = path+"\\Doc-"+Currentpac.ToString()+"-"+Currentdocument.ToString();
            string filenameO = filename;
                while (File.Exists(filename+".jpg"))
                {
                   consecutivo++;
                  filename = filenameO+"("+consecutivo.ToString()+")";
                }

            finalimage.SaveFile(filename+".jpg");
            finalfile = filename.ToUpper().Replace(path.ToUpper()+"\\", "") + ".jpg"; 
            this.Close();
         }
    }
}


