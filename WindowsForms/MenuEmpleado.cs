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
using WinFormsControlLibrary1;

namespace WindowsForms
{
    public partial class MenuEmpleado : Form
    {
        public MenuEmpleado()
        {
            InitializeComponent();
            FormHelper.EnableDrag(this, topBar);
        }

        private void btnIngredientes_Click(object sender, EventArgs e)
        {
            IngredienteVistaEmpleado ingredienteVista = new IngredienteVistaEmpleado();
            ingredienteVista.ShowDialog();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            ProductoVistaEmpleado productovista = new ProductoVistaEmpleado();
            productovista.ShowDialog();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            PedidoVistaEmpleado pedidoVista = new PedidoVistaEmpleado();
            pedidoVista.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
