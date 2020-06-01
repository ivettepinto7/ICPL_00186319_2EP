using Preparcial.Controlador;
using Preparcial.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Preparcial.Vista
{
    public partial class FrmPassword : Form
    {
        public FrmPassword()
        {
            InitializeComponent();
        }

        private void FrmPassword_Load(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Image.FromFile("../../Recursos/UCA.png");
pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;

ActualizarControlers();
}

private void ActualizarControlers()
{
//Corrección: el datasource primero debe ser null por buena practica
    comboBox1.DataSource = null;
    comboBox1.ValueMember = "Contrasena";
    //Correección: Display member antes de DataSource
    comboBox1.DisplayMember = "NombreUsuario";
    comboBox1.DataSource = ControladorUsuario.GetUsuarios();
}

private void Button1_Click(object sender, EventArgs e)
{
if (txtOldPassword.Text.Equals(comboBox1.SelectedValue.ToString()))
{       
var obtenerUsuario = (Usuario)comboBox1.SelectedItem;

ControladorUsuario.ActualizarContrasena(obtenerUsuario.IdUsuario,
txtNewPassword.Text);
//Corrección: actualizar controles despues de actualizar contraseña
ActualizarControlers();
//Corrección: Cerrar ventana para volver al login
this.Close();
}
else
    MessageBox.Show("Contrasena actual incorrecta");
        }
    }
}
