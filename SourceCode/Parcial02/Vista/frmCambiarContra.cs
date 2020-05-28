using System;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Parcial02.Modelo;

namespace Parcial02
{
    public partial class frmCambiarContra : Form
    {
        private AppUser user;
        public frmCambiarContra(AppUser pUsuario)
        {
            InitializeComponent();
            user = pUsuario;
        }
        
        private void btnUpdateContra_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNcontra.Text.Equals(txtCcontra.Text))
                {
                    AppUserDAO.ActualizarContra(user.idUser, txtCcontra.Text);
                    MessageBox.Show("Se actualizó la contraseña",
                        "Hugo App", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Datos incorrectos", "Hugo App",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique que los datos ingresados sean válidos",
                    "Hugo App", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCambiarContra_Load(object sender, EventArgs e)
        {
            labelUser.Text = user.username;
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