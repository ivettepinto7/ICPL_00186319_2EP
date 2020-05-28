using System;
using System.Windows.Forms;
using Parcial02.Modelo;

namespace Parcial02
{
    public partial class frmUsuario : Form
    {
        private AppUser user;
        private Address address;
        private AppOrder apporder;
        public frmUsuario(AppUser pUser)
        {
            InitializeComponent();
            user = pUser;
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            cmbAddress.DataSource = null;
            cmbAddress.ValueMember = "idAddress";
            cmbAddress.DisplayMember = "address";
            cmbAddress.DataSource = AddressDAO.GetLista();

            dgAddress.DataSource = null;
            dgAddress.DataSource = AddressDAO.GetLista();
            cmbProductos.DataSource = null;
            cmbProductos.ValueMember = "idProduct";
            cmbProductos.DisplayMember = "name";
            cmbProductos.DataSource = ProducDAO.GetLista();

            cmbDirecciones.DataSource = null;
            cmbDirecciones.ValueMember = "idAddress";
            cmbDirecciones.DisplayMember = "address";
            cmbDirecciones.DataSource = AddressDAO.GetLista();

            dgOrders.DataSource = null;
            dgOrders.DataSource = AppOrderDAO.GetLista();
            
        }

        void actualizarDatos()
        {
            cmbAddress.DataSource = AddressDAO.GetLista();
            dgAddress.DataSource = AddressDAO.GetLista();
            cmbProductos.DataSource = ProducDAO.GetLista();
            cmbDirecciones.DataSource = AddressDAO.GetLista();
            dgOrders.DataSource = AppOrderDAO.GetLista();
        }


        private void btnAddAddress_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAddress.Text.Length > 5)
                {
                    AddressDAO.CrearNueva(user.idUser, txtAddress.Text);
                    MessageBox.Show("Se agregó la dirección", "Hugo App",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAddress.Clear();
                    actualizarDatos();
                }
                else
                {
                    MessageBox.Show("Verifique los datos ingresados", "Hugo App",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique los datos ingresados", "Hugo App",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizarDireccion_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNewAddress.Text.Length > 5)
                {
                    int id = Convert.ToInt32(cmbAddress.SelectedValue.ToString());
                    AddressDAO.ActualizarDire(id,txtNewAddress.Text);
                    MessageBox.Show("Se actualizó la dirección", "Hugo App",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAddress.Clear();
                    actualizarDatos();
                }
                else
                {
                    MessageBox.Show("Verifique los datos ingresados", "Hugo App",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique los datos ingresados", "Hugo App",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            int idprod = Convert.ToInt32(cmbProductos.SelectedValue.ToString());
            int iddir = Convert.ToInt32(cmbAddress.SelectedValue.ToString());
            AppOrderDAO.AgregarOrden(date, idprod, iddir);
            actualizarDatos();
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