using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms.ingrediente;
using WindowsForms.producto;

namespace WindowsForms
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            FormHelper.EnableDrag(this, topBar);

        }
        private void btnClientes_Click(object sender, EventArgs e)
        {
            ClienteVista clienteVista = new ClienteVista();
            clienteVista.ShowDialog();
        }
        private void btnProveedores_Click(object sender, EventArgs e)
        {
            ProveedorVista proveedorVista = new ProveedorVista();
            proveedorVista.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void btnIngredientes_Click(object sender, EventArgs e)
        {
            IngredienteVista ingredienteVista = new IngredienteVista();
            ingredienteVista.ShowDialog();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            ProductoVista productovista = new ProductoVista();
            productovista.ShowDialog();
        }
    }
}
