using System;
using System.CodeDom;
using System.Windows.Forms;
using Parcial02.Modelo;

namespace Parcial02
{
    public partial class frmPrincipal : Form
    {
        private AppUser user;
        public frmPrincipal(AppUser pUser)
        {
            InitializeComponent();
            user = pUser;
        }


        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            if (user.userType)
            {
                cmbUsuarios.DataSource = null;
                cmbUsuarios.ValueMember = "password";
                cmbUsuarios.DisplayMember = "username";
                cmbUsuarios.DataSource = AppUserDAO.GetLista();

                dgUsuarios.DataSource = null;
                dgUsuarios.DataSource = AppUserDAO.GetLista();

            }
            else
            {
                tabControl1.TabPages[0].Parent = null;
                tabControl1.TabPages[0].Parent = null;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool tipo;
            if (rbAdmin.Checked)
            {
                tipo = true;
            }
            else
                tipo = false;
            if (txtFullName.Text.Length >= 5 && txtUsername.Text.Length >= 5 && (rbAdmin.Checked || rbUser.Checked))
            {
                AppUserDAO.CrearNuevo(txtFullName.Text, txtUsername.Text,txtUsername.Text, tipo);
                MessageBox.Show(
                        "Usuario agregado, los valores por defecto, la contraseña es el mismo usuario",
                        "Hugo App", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFullName.Clear();
                txtUsername.Clear();
            }
            /*else
                MessageBox.Show("Verifique que los datos ingresados sean válidos",
                    "Hugo App", MessageBoxButtons.OK, MessageBoxIcon.Error);*/
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea eliminar el usuario?",
                "Hugo App", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
               AppUserDAO.EliminarUsuario(user.idUser, cmbUsuarios.Text);
               MessageBox.Show("Se eliminó el usuario",
                   "Hugo App", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", 
                "Hugo App", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}