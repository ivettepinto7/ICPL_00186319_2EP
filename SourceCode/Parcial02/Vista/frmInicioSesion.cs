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
                if (user.username.Equals(" ") || user.password.Equals(" "))
                {
                    MessageBox.Show("Usuario y/o contraseña incorrectos",
                        "Hugo App", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("!Bienvenido!", "Hugo App",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    if (user.userType == true)
                    {
                        frmPrincipal ventana = new frmPrincipal(user);
                        ventana.Show();
                        this.Hide();
                    }else if (user.userType == false)
                    {
                        frmUsuario ventana2 = new frmUsuario(user);
                        ventana2.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Error", "Hugo App",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error", "Hugo App",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnActualizarContra_Click(object sender, EventArgs e)
        {
            try
            { 
                var user = AppUserDAO.GetUsuario(txtUsername.Text, txtPassword.Text);
                if (txtUsername.Text.Equals("") || txtPassword.Text.Equals(""))
                {
                    MessageBox.Show("Usuario y/o contraseña inválida",
                        "Hugo App", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    frmCambiarContra ventana2 = new frmCambiarContra(user);
                    ventana2.ShowDialog();
                    this.Hide();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
                throw;
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