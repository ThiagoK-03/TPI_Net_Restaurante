using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms.emplead;
using WindowsForms.Pedido;
using WindowsForms.producto;
using WindowsForms.ingrediente;

namespace WindowsForms
{
    public partial class MenuCliente : Form
    {
        public MenuCliente()
        {
            InitializeComponent();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            ProductoVistaCliente productovista = new ProductoVistaCliente();
            productovista.ShowDialog();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            PedidoVistaCliente pedidoVista = new PedidoVistaCliente();
            pedidoVista.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
