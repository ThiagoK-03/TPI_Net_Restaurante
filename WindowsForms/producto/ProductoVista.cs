using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTOs;
using WindowsForms.clientes;
using WinFormsControlLibrary1;

namespace WindowsForms.producto
{
    public partial class ProductoVista : MenuBase
    {
        public ProductoVista()
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

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                ProductoDetalle productoDetalle = new ProductoDetalle();

                int id = this.SelectedItem().Id;

                ProductoDTO producto = await ProductoApi.GetAsync(id);

                productoDetalle.Mode = FormMode.Update;
                productoDetalle.Producto = producto;

                productoDetalle.ShowDialog();

                this.GetAllAndLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar producto para modificar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = this.SelectedItem().Id;

                var result = MessageBox.Show($"¿Está seguro que desea eliminar el producto con Id {id}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    await ProductoApi.DeleteAsync(id);
                    this.GetAllAndLoad();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    this.btnEliminar.Enabled = true;
                    this.btnModificar.Enabled = true;
                }
                else
                {
                    this.btnEliminar.Enabled = false;
                    this.btnModificar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la lista de productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.btnEliminar.Enabled = false;
                this.btnModificar.Enabled = false;
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
