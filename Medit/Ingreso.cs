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
namespace Medit
{
    public partial class Ingresofrm : Form
    {
        EntryView ev { get; set; }
        int iddependiente = 0;
        long idcurrent = 0;
        PacientesManager pm = new PacientesManager();
        IngresosManager im = new IngresosManager();
        MedicosManager mM = new MedicosManager();
        public Ingresofrm()
        {
            InitializeComponent();
        }

        private void Ingreso_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            this.comboBox1.SelectedIndex = 0;
        }

        private void textB1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                      getrecord();
            }


        }

        private void getrecord()
        {   
            ev = im.getDataView(this.textB1.Text);
            cargaform(ev);
           
        }

        private void cargaform(EntryView ev)
        {if (ev.Cedula == null)
            {
                Mensaje.Text = "Cedula no corresponde a ningun Autorizado/Beneficiario";
                groupBox3.Enabled = false;
                groupBox1.Enabled = false;
                groupBox5.Enabled = false;
                groupBox4.Enabled = false;

                return;
            }

            if (ev.idaseguradora != 0&& ev.idaseguradora != null)
            {
                comboBox1.Items.Add("ASEGURADORA");
            }
            if (ev.idempresa !=0)
            {
                comboBox1.Items.Add("EMPRESA");
            }
            
            this.textB2.Text = ev.nombreAutorizado.ToUpper();
            groupBox3.Enabled = true;
            groupBox1.Enabled = true;
            groupBox5.Enabled = true;
            groupBox4.Enabled = true;
            if (ev.esbeneficiario)
            {
                textB4.Text = ev.Cedula;
                this.textB3.Text = ev.nombreBeneficiario;
                textB5.Text = ev.cedulabeneficiario;
            }
            else
            {
                idcurrent = ev.idpaciente;
                this.textB3.Text = textB2.Text.ToUpper(); ;
                textB4.Text = textB1.Text;
                textB5.Text = textB1.Text;
            }
            PacienteDTO historiapac = new PacienteDTO();
            historiapac = pm.GetPaciente(ev.idpaciente);
          //  comboBox1.SelectedIndex = historiapac.TIPO;
            if (historiapac.ASEGURADORA2 != null)
            {
                comboBox2.DataSource = im.GetSeguros(historiapac);
                comboBox2.ValueMember = "Id";
                comboBox2.DisplayMember = "Seguro";
            }
            if (ev.esbeneficiario == true)
                textB3.Visible =true;
            else
                textB3.Visible = false;
        }

        private void textB1_TextChanged(object sender, EventArgs e)
        {
            iddependiente = 0;
            idcurrent = 0;
            ev = null;
            this.textB2.Text = "";
            this.textB3.Text = "";
            textB4.Text = "";
            textB5.Text = "";
        }

        private void comboPlus1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int caseSwitch = comboPlus1.SelectedIndex;
            switch (caseSwitch)
            {
                // CONSULTA MEDICINA GENERAL
                //CONSULTA ESPECIALISTA
                //LABORATORIO
                //ECOGRAFIA
                //ELECTROCARDIOGRAMA
                //EMERGENCIA CON TRATAMIENTO
                //HOSPITALIZACION
                case 0:

                    //CONSULTA MEDICINA GENERAL($)
                    comboBox3.DataSource = null;
                    comboBox3.DataSource = mM.GetDoctorTable("$");
                    comboBox3.DisplayMember = "Médico";
                    comboBox3.ValueMember = "Id";
                    comboBox3.Visible = true;
                    break;
                case 1:
                    //CONSULTA ESPECIALISTA(*)
                    comboBox3.DataSource = null;
                    comboBox3.DataSource = mM.GetDoctorTable("*");
                    comboBox3.DisplayMember = "Médico";
                    comboBox3.ValueMember = "Id";
                    comboBox3.Visible = true;
                    break;
                case 2:
                    //LABORATORIO
                    comboBox3.Visible = false;
                    break;
                case 3:
                    //ECOGRAFIA
                    comboBox3.Visible = false;
                    break;
                case 4:
                    //ELECTROCARDIOGRAMA
                    comboBox3.Visible = false;
                    break;
                case 5:
                    //ELECTROCARDIOGRAMA
                    comboBox3.Visible = false;
                    break;
                case 6:
                    //EMERGENCIA CON TRATAMIENTO
                    comboBox3.Visible = false;
                    break;
                case 7:
                    //HOSPITALIZACION
                    comboBox3.DataSource = null;
                    comboBox3.DataSource = mM.GetDoctorTable("");
                    comboBox3.DisplayMember = "Médico";
                    comboBox3.ValueMember = "Id";
                    comboBox3.Visible = true;
                    
                    break;

            }

            if (comboPlus1.SelectedIndex < 6)
            {
                textB6.Visible = false;
                label4.Visible = false;

            }
            else
            {
                textB6.Visible = true;
                label4.Visible = true;

            }
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            Buscadependientes bd = new Buscadependientes(idcurrent);
            bd.ShowDialog();
            if (bd.DialogResult == DialogResult.OK && bd.idresult != 0)
            {
                iddependiente = bd.idresult;
                Actualizadependiente();
            }

        }

        private void Actualizadependiente()
        {
            if (iddependiente != 0)
            {
                ev.idbeneficiario = iddependiente;
                DependientesManager dm = new DependientesManager();
                DependientesDTO dependiente = dm.GetDependiente(iddependiente);
                ev.nombreBeneficiario = dependiente.Nombre;
                ev.idbeneficiario = iddependiente;
                ev.esbeneficiario = true;
                ev.parentesco = dependiente.Parentesco;
                textB5.Text = ev.cedulabeneficiario;
                textB3.Text = ev.nombreBeneficiario;
                textB3.Visible = true;
             
            }
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            if (comboPlus1.SelectedIndex >= 6 && textB6.Text == "")
            {
                Mensaje.Text = "No ha ingresado el Numero de TIcket requerido";
                return;
            }
            if (ev != null && (comboPlus1.Text != "") && (textB7.Text != ""))
            {


                DialogResult resp = MessageBox.Show("Esta Seguro de Realizar este Ingreso", "Confirmación", MessageBoxButtons.YesNo);
                if (resp == DialogResult.Yes)
                {
                    IngresosManager im = new IngresosManager();
                    im.InsertIngreso(new IngresosDTO
                    {
                        ceduladebeneficiario = textB5.Text,
                        cedulapaciente = textB5.Text,
                        cedulatrabajador = textB1.Text,
                        clave = textB7.Text,
                        dependienteid = ev.idbeneficiario,
                        esbeneficiario = ev.esbeneficiario,
                        fechaingreso = ev.Fecha,
                        fechasalida = null,
                        motivo = comboPlus1.SelectedIndex,
                        nombrepaciente = ev.nombreBeneficiario,
                        observaciones = observaciones.Text,
                        procesada = null,
                        refieremedico = null,
                        tipodeingreso = comboBox1.SelectedIndex,
                        trabajadorid = ev.idpaciente,
                        ticket = textB6.Text,
                        usuarioid = Medit.Globales.CurrentUser.Userid,
                        aseguradoraid = ev.idaseguradora,
                        empresaid = ev.idempresa
                    });
                    this.timer1.Enabled = false;
                    this.Close();
                }
            }
            else
            {
                Mensaje.Text = "Debe ingresar la información solicitada";
            }
        }

        private void customButton3_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = false;
            this.Close();
        }
      
    
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ev != null)
            {
                PacienteDTO historiapac = new PacienteDTO();
                historiapac = pm.GetPaciente(ev.idpaciente);
                if (comboBox1.Text == "PARTICULAR")
                {
                    label10.Text = "";
                    Mensaje.Text = "";
                }
       
             
                if (comboBox1.Text == "EMPRESA")
                {
                    EmpresasManager em = new EmpresasManager();
                    label10.Text = em.GetEmpresa((int)historiapac.EMPRESA).Empresa;

                }
                if (historiapac.ASEGURADORA2 != null)
                {
                    if (historiapac.ASEGURADORA2 != null && comboBox1.Text == "ASEGURADORA")
                    {
                        comboBox2.Visible = true;
                        comboBox2.Tag = "1";
                        label10.Text = "";
                    }
                }
                if (historiapac.ASEGURADORA != null)
                {
                    if (historiapac.ASEGURADORA2 == null && comboBox1.Text == "ASEGURADORA")
                    {
                        EmpresasManager em = new EmpresasManager();
                        label10.Text = em.GetEmpresa((int)historiapac.ASEGURADORA).Empresa;

                    }
                }

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {try
            {
                ev.idaseguradora = (int)comboBox2.SelectedValue;
            }catch { }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_VisibleChanged(object sender, EventArgs e)
        {
         
                label9.Visible = comboBox3.Visible;
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString();
        }

        private void Ingresofrm_Enter(object sender, EventArgs e)
        {
            Control sen =(Control) sender;
            if (sen.GetType().ToString() == "TextB")
            {
                if (((TextB)sender).Text == "")
                    Mensaje.Text = ((TextB)sender).Sugerencia;
                else
                    Mensaje.Text = "";
            }
            if (sen.GetType().ToString() == "Medit.ComboPlus")
            {
                if (((ComboPlus)sender).Text == "")
                    Mensaje.Text = ((ComboPlus)sender).Sugerencia;
                else
                    Mensaje.Text = "";
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
