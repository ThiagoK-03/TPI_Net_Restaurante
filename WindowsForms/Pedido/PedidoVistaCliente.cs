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
using WinFormsControlLibrary1;
using API;
using Application.Services;
using API.Clients;

namespace WindowsForms.Pedido
{
    public partial class PedidoVistaCliente : MenuBase
    {
        public PedidoVistaCliente()
        {
            InitializeComponent();
        }

        private void PedidoVista_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            PedidoDetalleCliente pedidoDetalle = new PedidoDetalleCliente();

            PedidoDTO pedidoNuevo = new PedidoDTO();

            pedidoDetalle.Mode = FormMode.Add;
            pedidoDetalle.Pedido = pedidoNuevo;

            pedidoDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                PedidoDetalleCliente pedidoDetalle = new PedidoDetalleCliente();

                int id = this.SelectedItem().Id;

                PedidoDTO pedido = await PedidoApi.GetAsync(id);

                pedidoDetalle.Mode = FormMode.Update;
                pedidoDetalle.Pedido = pedido;

                pedidoDetalle.ShowDialog();

                this.GetAllAndLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar pedido para modificar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = this.SelectedItem().Id;

                var result = MessageBox.Show($"¿Está seguro que desea eliminar el pedido con Id {id}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    await PedidoApi.DeleteAsync(id);
                    this.GetAllAndLoad();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar pedido: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void GetAllAndLoad()
        {
            try
            {
                this.dgvPedidos.DataSource = null;

                var authService = AuthServiceProvider.Instance;
                var userId = (int)await authService.GetUserIdFromTokenAsync();
                var cliente = await ClienteApi.GetByUserIdAsync(userId);

                this.dgvPedidos.DataSource = await PedidoApi.GetAllByClientIdAsync(cliente.Id);




                if (this.dgvPedidos.Rows.Count > 0)
                {
                    this.dgvPedidos.Rows[0].Selected = true;
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
                MessageBox.Show($"Error al cargar la lista de pedidos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.btnEliminar.Enabled = false;
                this.btnModificar.Enabled = false;
            }
        }

        private PedidoDTO SelectedItem()
        {
            PedidoDTO pedido;

            pedido = (PedidoDTO)dgvPedidos.SelectedRows[0].DataBoundItem;

            return pedido;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            Reporte reporteCliente = new Reporte();
            reporteCliente.CrearReporteFactura(this.SelectedItem());
            reporteCliente.ShowDialog();

        }
    }

}
