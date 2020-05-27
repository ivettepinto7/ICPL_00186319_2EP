using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parcial02.Modelo;

namespace Parcial02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                var user = AppUserDAO.GetUsuario(txtUsername.Text, txtPassword.Text);
                if (user.username.Equals("") || user.password.Equals(""))
                {
                    MessageBox.Show("Usuario y/o contraseña incorrectos",
                        "Hugo App", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("!Bienvenido!", "Hugo App",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    frmPrincipal ventana = new frmPrincipal(user);
                    ventana.Show();
                    this.Hide();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
                throw;
            }
        }


        private void btnActualizarContra_Click(object sender, EventArgs e)
        {
            frmCambiarContra ventana2 = new frmCambiarContra();
            ventana2.ShowDialog();
        }
    }
}