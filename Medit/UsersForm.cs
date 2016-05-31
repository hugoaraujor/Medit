using BussinessLayer;
using DataEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medit
{
    
    public partial class UsersForm : Form
    {
        private bool edita = false;
        private bool nuevo=false;
        private UsuariosManager um = new UsuariosManager();
        private UsuariosDTO UsuarioActual;
        private int idusuario=0;
        public UsersForm()
        {

            InitializeComponent();
            CargaUsuario(idusuario);
        }

        private void CargaUsuario(int idusuario)
        {
            if (idusuario == 0)
                return;
            else
            {
                UsuarioActual=um.GetUser(idusuario);
                Desplegar(UsuarioActual);
            }
        }
        private void Desplegar(UsuariosDTO usuario)
        {   txtUsuario.Text = usuario.Usuario;
            txtNombre.Text = usuario.Nombres;
            txtContrasena.Text = usuario.password;
            txtCorreo.Text = usuario.Correo;
            chActivo.Checked = usuario.activo;
            txtTelefonos.Text=usuario.telefono;
            txtxid.Text= usuario.UsuarioId.ToString();
            comboRol.SelectedIndex = (int)usuario.Rol;
           
        }
        private void Btn_NuevoCargo_Click(object sender, EventArgs e)
        {
            nuevo = true;
            Utiles.BlanquearControles(this);
            Utiles.HabilitarControles(this);
            txtNombre.Focus();
            Btn_NuevoUsuario.Enabled = false;
            Btn_Guardar.Enabled = true;
            Btn_cancelar.Enabled = true;
            Btn_Edita.Enabled = false;
            Btn_Buscar.Enabled = false;
            BtnEliminar.Enabled = false;

        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {

            if (!Validaforma())
                return;
            UsuariosDTO NewUser = new UsuariosDTO();
          
            if (nuevo)
            {
                NewUser.UsuarioId = 0;
                NewUser.activo = this.chActivo.Checked;
                NewUser.Correo = txtCorreo.Text;
                NewUser.Nombres = txtNombre.Text;
                NewUser.password = txtContrasena.Text;
                NewUser.Rol = comboRol.SelectedIndex;
                NewUser.telefono = txtTelefonos.Text;
                NewUser.Usuario = txtUsuario.Text;
                um.InsertUser(NewUser);
            }
            else
            {
                UsuarioActual.activo = this.chActivo.Checked;
                UsuarioActual.Correo = txtCorreo.Text;
                UsuarioActual.Nombres = txtNombre.Text;
                UsuarioActual.password = txtContrasena.Text;
                UsuarioActual.Rol = comboRol.SelectedIndex;
                UsuarioActual.telefono = txtTelefonos.Text;
                UsuarioActual.Usuario = txtUsuario.Text;
                um.Edit(UsuarioActual);
            }
            finalizaedicion();
        }

        private bool Validaforma()
        {
            bool resp=true;
            if (this.txtNombre.Text=="")
            {
                resp = false;
            }
            if (this.txtContrasena.Text=="")
            {
                resp = false;
            }
            if (this.comboRol.Text == "")
            {
                resp = false;
            }
            if (this.txtUsuario.Text == "")
            {
                resp = false;
            }
            return resp;
        }

        private void finalizaedicion()
        {if (edita)
                Btn_Edita.Enabled = true; 
        else
                Btn_Edita.Enabled = false;
            edita = false;
            nuevo = false;
            Utiles.DesHabilitarControles(this);
            Btn_NuevoUsuario.Enabled = true;
            Btn_Guardar.Enabled = false;
            Btn_cancelar.Enabled = false;
            Btn_Buscar.Enabled = true;
            BtnEliminar.Enabled = true;
          
            
        }
        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            
            finalizaedicion();
            this.errorProvider1.SetError(txtNombre, "");
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (txtxid.Text != "")
            {
                DialogResult resp = MessageBox.Show("Esta Seguro de Eliminar Registro", "Confirmación", MessageBoxButtons.YesNoCancel);
                if (resp == DialogResult.Yes)
                {
                   
                    um.Delete(Convert.ToInt16(txtxid.Text));
                    Utiles.BlanquearControles(this);
                }
            }
            else
                MessageBox.Show("Debe seleccionar un Usuario. Utilize el Boton de Buscar.");
            
        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            string errorMessage="";
            if (txtNombre.Text.Length == 0)
            {
                errorMessage = "Nombre no puede dejarse en Blanco.";
                e.Cancel = true;
            }
          
            this.errorProvider1.SetError(txtNombre, errorMessage);
        }

        public bool ValidEmailAddress(string emailAddress, out string errorMessage)
        {
            // no esta en Blanco
            if (emailAddress.Length == 0)
            {
                errorMessage = "La Direccion de Correo o e-mail address es necesaria.";
                return false;
            }

          //formato de correo
            if (emailAddress.IndexOf("@") > -1)
            {
                if (emailAddress.IndexOf(".", emailAddress.IndexOf("@")) > emailAddress.IndexOf("@"))
                {
                    errorMessage = "";
                    return true;
                }
            }

            errorMessage = "La Direccion de Correo e-mail no tiene el formato adecuado.\n" +
               "por ejemplo 'juan@gmail.com' ";
            return false;
        }

        private void txtCorreo_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidEmailAddress(txtCorreo.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                txtCorreo.Select(0, txtCorreo.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.errorProvider1.SetError(txtCorreo, errorMsg);
            }
        }

        private void txtNombre_Validated(object sender, EventArgs e)
        {
            // Set the ErrorProvider error with the text to display. 
            this.errorProvider1.SetError(txtNombre,"");
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_Validating(object sender, CancelEventArgs e)
        {
            string errorMessage="";
            if (txtUsuario.Text.Length == 0)
            {
                errorMessage = "Nombre no puede dejarse en Blanco.";
                e.Cancel = true;
            }
            if (um.ExisteUser(txtUsuario.Text))
            {
                errorMessage = "Ya existe un Usuario con ese Identificador.";
                e.Cancel = true;
            }
            // Set the ErrorProvider error with the text to display. 
            this.errorProvider1.SetError(txtUsuario, errorMessage);
        }

        private void txtUsuario_Validated(object sender, EventArgs e)
        {
            // Set the ErrorProvider error with the text to display. 
            this.errorProvider1.SetError(txtUsuario, "");
        }

        private void txtCorreo_Validated(object sender, EventArgs e)
        {
            // Set the ErrorProvider error with the text to display. 
            this.errorProvider1.SetError(txtCorreo, "");
        }

        private void txtContrasena_Validating(object sender, CancelEventArgs e)
        {
            string errorMessage = "";
            if (txtContrasena.Text.Length == 0)
            {
                errorMessage = "Contraseña no puede dejarse en Blanco.";
                e.Cancel = true;
            }
            // Set the ErrorProvider error with the text to display. 
            this.errorProvider1.SetError(txtContrasena, errorMessage);
        }

        private void txtContrasena_Validated(object sender, EventArgs e)
        {
            // Set the ErrorProvider error with the text to display. 
            this.errorProvider1.SetError(txtContrasena, "");
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            UsuariosManager cm = new UsuariosManager();
            Busqueda Bu = new Busqueda(cm.GetUsersTable(),"USUARIO+NOMBRE");
            Bu.ShowDialog();
            if (Bu.seleccion!=0)
            CargaUsuario(Bu.seleccion);
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Edita_Click(object sender, EventArgs e)
        {
            edita = true;
            Btn_Guardar.Enabled = true;
            Btn_cancelar.Enabled = true;
            Btn_Edita.Enabled = false;
            Utiles.HabilitarControles(this);
            txtNombre.Focus();
        }
    }

  
}

