using System;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Parcial02.Modelo;

namespace Parcial02
{
    public partial class frmCambiarContra : Form
    {
        public frmCambiarContra()
        {
            InitializeComponent();
        }

        private void btnUpdateContra_Click(object sender, EventArgs e)
        {
            bool actualIgual = AppUserDAO.GetUsuario(txtUser, txtContraActual);
            bool NuevaIgual = txtNcontra.Text.Equals(txtCcontra.Text);
            bool nuevaValida = txtNcontra.Text.Length > 0;
            if (actualIgual && NuevaIgual && nuevaValida)
            {
                try
                {
                    AppUserDAO.ActualizarContra(txtUser.Text, txtNcontra.Text);
                    MessageBox.Show("Contraseña actualizada con éxito",
                        "Hugo App", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Favor verifique que los datos ingresados sean válidos",
                        "Hugo App", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Favor verifique que los datos ingresados sean válidos",
                    "Hugo App", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}