using System.ComponentModel;

namespace Parcial02
{
    partial class frmUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgAddress = new System.Windows.Forms.DataGridView();
            this.btnActualizarDireccion = new System.Windows.Forms.Button();
            this.txtNewAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAddress = new System.Windows.Forms.ComboBox();
            this.btnAddAddress = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmbDirecciones = new System.Windows.Forms.ComboBox();
            this.cmbProductos = new System.Windows.Forms.ComboBox();
            this.dgOrders = new System.Windows.Forms.DataGridView();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgAddress)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.Controls.Add(this.dgAddress);
            this.tabPage1.Controls.Add(this.btnActualizarDireccion);
            this.tabPage1.Controls.Add(this.txtNewAddress);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cmbAddress);
            this.tabPage1.Controls.Add(this.btnAddAddress);
            this.tabPage1.Controls.Add(this.txtAddress);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // dgAddress
            // 
            this.dgAddress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAddress.Location = new System.Drawing.Point(425, 42);
            this.dgAddress.Name = "dgAddress";
            this.dgAddress.Size = new System.Drawing.Size(317, 318);
            this.dgAddress.TabIndex = 7;
            // 
            // btnActualizarDireccion
            // 
            this.btnActualizarDireccion.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))), ((int) (((byte) (0)))));
            this.btnActualizarDireccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarDireccion.Location = new System.Drawing.Point(112, 306);
            this.btnActualizarDireccion.Name = "btnActualizarDireccion";
            this.btnActualizarDireccion.Size = new System.Drawing.Size(165, 38);
            this.btnActualizarDireccion.TabIndex = 6;
            this.btnActualizarDireccion.Text = "Actualizar dirección";
            this.btnActualizarDireccion.UseVisualStyleBackColor = false;
            this.btnActualizarDireccion.Click += new System.EventHandler(this.btnActualizarDireccion_Click);
            // 
            // txtNewAddress
            // 
            this.txtNewAddress.Location = new System.Drawing.Point(213, 251);
            this.txtNewAddress.Name = "txtNewAddress";
            this.txtNewAddress.Size = new System.Drawing.Size(136, 20);
            this.txtNewAddress.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(42, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nueva dirección:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbAddress
            // 
            this.cmbAddress.FormattingEnabled = true;
            this.cmbAddress.Location = new System.Drawing.Point(80, 184);
            this.cmbAddress.Name = "cmbAddress";
            this.cmbAddress.Size = new System.Drawing.Size(254, 21);
            this.cmbAddress.TabIndex = 3;
            // 
            // btnAddAddress
            // 
            this.btnAddAddress.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))), ((int) (((byte) (0)))));
            this.btnAddAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAddress.Location = new System.Drawing.Point(126, 107);
            this.btnAddAddress.Name = "btnAddAddress";
            this.btnAddAddress.Size = new System.Drawing.Size(165, 38);
            this.btnAddAddress.TabIndex = 2;
            this.btnAddAddress.Text = "Agregar dirección";
            this.btnAddAddress.UseVisualStyleBackColor = false;
            this.btnAddAddress.Click += new System.EventHandler(this.btnAddAddress_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(199, 60);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(136, 20);
            this.txtAddress.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dirección:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Black;
            this.tabPage2.Controls.Add(this.cmbDirecciones);
            this.tabPage2.Controls.Add(this.cmbProductos);
            this.tabPage2.Controls.Add(this.dgOrders);
            this.tabPage2.Controls.Add(this.btnAddOrder);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Orden";
            // 
            // cmbDirecciones
            // 
            this.cmbDirecciones.FormattingEnabled = true;
            this.cmbDirecciones.Location = new System.Drawing.Point(210, 162);
            this.cmbDirecciones.Name = "cmbDirecciones";
            this.cmbDirecciones.Size = new System.Drawing.Size(135, 21);
            this.cmbDirecciones.TabIndex = 14;
            // 
            // cmbProductos
            // 
            this.cmbProductos.FormattingEnabled = true;
            this.cmbProductos.Location = new System.Drawing.Point(210, 97);
            this.cmbProductos.Name = "cmbProductos";
            this.cmbProductos.Size = new System.Drawing.Size(135, 21);
            this.cmbProductos.TabIndex = 13;
            // 
            // dgOrders
            // 
            this.dgOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrders.Location = new System.Drawing.Point(492, 91);
            this.dgOrders.Name = "dgOrders";
            this.dgOrders.Size = new System.Drawing.Size(253, 287);
            this.dgOrders.TabIndex = 12;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))), ((int) (((byte) (0)))));
            this.btnAddOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOrder.Location = new System.Drawing.Point(149, 241);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(165, 38);
            this.btnAddOrder.TabIndex = 11;
            this.btnAddOrder.Text = "Agregar orden";
            this.btnAddOrder.UseVisualStyleBackColor = false;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(345, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(279, 51);
            this.label5.TabIndex = 10;
            this.label5.Text = "Agregar orden";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(43, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 33);
            this.label4.TabIndex = 9;
            this.label4.Text = "Seleccione dirección:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(43, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 33);
            this.label3.TabIndex = 8;
            this.label3.Text = "Seleccione producto:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmUsuario";
            this.Text = "frmUsuario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgAddress)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgOrders)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnActualizarDireccion;
        private System.Windows.Forms.Button btnAddAddress;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.ComboBox cmbAddress;
        private System.Windows.Forms.ComboBox cmbDirecciones;
        private System.Windows.Forms.ComboBox cmbProductos;
        private System.Windows.Forms.DataGridView dgAddress;
        private System.Windows.Forms.DataGridView dgOrders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtNewAddress;

        #endregion
    }
}