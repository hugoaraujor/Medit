using System;
using System.Windows.Forms;

namespace Medit
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void customButton2_Click(object sender, EventArgs e)
        {

        }

        private void historiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IdEntry ie = new IdEntry();
            ie.ShowDialog();

        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Historia hh = new Historia();
            hh.ShowDialog();

        }

        private void Form11_Load(object sender, EventArgs e)
        {
         //   var txe= Licencia.GetVolumeSerial("E");
           // MessageBox.Show(txe);
            LOGIN nL = new LOGIN();
               nL.ShowDialog();
            this.UserId.Text = Globales.CurrentUser.Userid.ToString();
            this.Username.Text = Globales.CurrentUser.UserFullName;
            this.Fecha.Text = DateTime.Now.ToShortDateString();

        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void medicamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cargos Cf = new Cargos();
            Cf.ShowDialog();
        }

        private void materialQuirurgicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void examenesLaboratorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
        }

        private void emergenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void otrosCargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsersForm uf = new UsersForm();
            uf.ShowDialog();
        }

        private void configuraciónDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsersForm uf = new UsersForm();
            uf.ShowDialog();
        }

        private void configuraciónSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clinicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clinica cfrm = new Clinica();
            cfrm.ShowDialog();
        }

        private void cargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cargos ccf = new Cargos();
            ccf.ShowDialog();
        }

        private void clasesDeCargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargoClases ccf = new CargoClases();
            ccf.ShowDialog();
        }

        private void acercaDeMedITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.ShowDialog();
        }

        private void empresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Empresas frmE = new Frm_Empresas();
            frmE.ShowDialog();
        }

        private void ingresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ingresofrm inic = new Ingresofrm();
            inic.ShowDialog();
        }

        private void pruebaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarIngresos inic = new BuscarIngresos();
            inic.ShowDialog();
        }

        private void especialidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EspecialidadesFrm inic = new EspecialidadesFrm();
            inic.ShowDialog();
        }

        private void medicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MedicosFrm inic = new MedicosFrm();
            inic.ShowDialog();
        }
    }
    }
    

