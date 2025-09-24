using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
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
    }
}
