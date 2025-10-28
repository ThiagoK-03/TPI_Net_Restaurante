using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using API;
using DTOs;
using WindowsForms.producto;
using WinFormsControlLibrary1;

namespace WindowsForms.producto
{
    public partial class ProductoVistaEmpleado : MenuBase
    {
        public ProductoVistaEmpleado()
        {
            InitializeComponent();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ProductoDetalle productoDetalle = new ProductoDetalle();

            ProductoDTO productoNuevo = new ProductoDTO();

            productoDetalle.Mode = FormMode.Add;
            productoDetalle.Producto = productoNuevo;

            productoDetalle.ShowDialog();

            this.GetAllAndLoad();
        }


        private async void GetAllAndLoad()
        {
            try
            {
                this.dgvProductos.DataSource = null;
                this.dgvProductos.DataSource = await ProductoApi.GetAllAsync();

                if (this.dgvProductos.Rows.Count > 0)
                {
                    this.dgvProductos.Rows[0].Selected = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la lista de productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private ProductoDTO SelectedItem()
        {
            ProductoDTO producto;

            producto = (ProductoDTO)dgvProductos.SelectedRows[0].DataBoundItem;

            return producto;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tittleLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
