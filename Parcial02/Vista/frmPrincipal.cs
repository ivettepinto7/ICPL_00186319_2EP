using System;
using System.CodeDom;
using System.Linq;
using System.Windows.Forms;
using Parcial02.Modelo;

namespace Parcial02
{
    public partial class frmPrincipal : Form
    {
        private AppUser user;
        private int idnegocio, idproducto;
        public frmPrincipal(AppUser pUser)
        {
            InitializeComponent();
            user = pUser;
            idnegocio = 0;
            idproducto = 0;
        }


        void actualizarDatos()
        {
            cmbUsuarios.DataSource = AppUserDAO.GetLista();
            dgUsuarios.DataSource = AppUserDAO.GetLista();
            cmbNegociosProd.DataSource = BusinessDAO.GetLista();
            dgNegocios.DataSource = BusinessDAO.GetLista();
            cmbNegocios.DataSource = BusinessDAO.GetLista();
            dgOrdenes.DataSource = AppOrderDAO.GetLista();
            cmbProds.DataSource = ProducDAO.GetProdsNeg();
        }
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            cmbUsuarios.DataSource = null;
                cmbUsuarios.ValueMember = "password";
                cmbUsuarios.DisplayMember = "username";
                cmbUsuarios.DataSource = AppUserDAO.GetLista();

                cmbNegociosProd.DataSource = null;
                cmbNegociosProd.ValueMember = "idBusiness";
                cmbNegociosProd.DisplayMember = "name";
                cmbNegociosProd.DataSource = BusinessDAO.GetLista();
                
                cmbNegocios.DataSource = null;
                cmbNegocios.ValueMember = "idBusiness";
                cmbNegocios.DisplayMember = "name";
                cmbNegocios.DataSource = BusinessDAO.GetLista();

                cmbProds.DataSource = null;
                cmbProds.ValueMember = "idProduct";
                cmbProds.DisplayMember = "name";
                cmbProds.DataSource = ProducDAO.GetProdsNeg();

                dgUsuarios.DataSource = null;
                dgUsuarios.DataSource = AppUserDAO.GetLista();

                dgNegocios.DataSource = null;
                dgNegocios.DataSource = BusinessDAO.GetLista();
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
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
                    actualizarDatos();
                }
                else
                    MessageBox.Show("Verifique que los datos ingresados sean válidos",
                        "Hugo App", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique que los datos ingresados sean válidos",
                    "Hugo App", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea eliminar el usuario?",
                "Hugo App", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
               AppUserDAO.EliminarUsuario(user.idUser);
               MessageBox.Show("Se eliminó el usuario",
                   "Hugo App", MessageBoxButtons.OK, MessageBoxIcon.Information);
               actualizarDatos();
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text.Length >= 5 && txtDescripcion.Text.Length >= 5)
                {
                    BusinessDAO.CrearNuevoNeg(txtNombre.Text, txtDescripcion.Text);
                    MessageBox.Show(
                        "Negocio agregado con éxito",
                        "Hugo App", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombre.Clear();
                    txtDescripcion.Clear();
                    actualizarDatos();
                }
                else
                    MessageBox.Show("Verifique que los datos ingresados sean válidos",
                        "Hugo App", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique que los datos ingresados sean válidos",
                    "Hugo App", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("¿Seguro que desea eliminar el negocio?",
                    "Hugo App", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes);
                {
                    string sql = String.Format("DELETE FROM business where idbusiness={0};",
                        cmbNegocios.SelectedValue);
                    ConnectionDB.ExecuteNonQuery(sql);
                    MessageBox.Show("Se eliminó el negocio",
                        "Hugo App", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    actualizarDatos();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void btnAddProdtoNeg_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNuevoProd.Text.Length >= 5)
                {
                    int idneg = Convert.ToInt32(cmbNegocios.SelectedValue.ToString());
                    ProducDAO.CrearProd(idneg, txtNuevoProd.Text);
                    MessageBox.Show("Producto agregado",
                        "Hugo App", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNuevoProd.Clear();
                    actualizarDatos();
                }
                else
                {
                    MessageBox.Show("Verifique que los datos sean válidos",
                        "Hugo App", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique que los datos sean válidos",
                    "Hugo App", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnDeleteProd_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("¿Seguro que desea eliminar el producto?",
                    "Hugo App", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes);
                {
                    int id = Convert.ToInt32(cmbProds.SelectedValue.ToString());
                    ProducDAO.EliminarProd(id);
                    MessageBox.Show("Se eliminó el producto",
                        "Hugo App", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    actualizarDatos();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }
    }
}