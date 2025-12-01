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
using Domain.Model;
using System.Text.Json;
using Microsoft.Reporting.WinForms;

namespace WindowsForms.Pedido
{
    public partial class PedidoVista : MenuBase
    {
        public PedidoVista()
        {
            InitializeComponent();
        }

        private void PedidoVista_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            PedidoDetalle pedidoDetalle = new PedidoDetalle();

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
                PedidoDetalle pedidoDetalle = new PedidoDetalle(); ;
                var id = (int)dgvPedidos.CurrentRow.Cells["Id"].Value;

                //                int id = this.SelectedItem().Id;

                PedidoDTO pedido = await PedidoApi.GetAsync(id);

                pedidoDetalle.Pedido = pedido;
                pedidoDetalle.Mode = FormMode.Update;

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
                //int id = this.SelectedItem().Id;
                var id = (int)dgvPedidos.CurrentRow.Cells["Id"].Value;

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

        private async Task<string> GetProductosName(List<int> productosIds)
        {
            string nombres = "";
            foreach (int prodId in productosIds)
            {
                var producto = await ProductoApi.GetAsync(prodId);
                nombres += producto.Nombre + ", ";
            }
            return nombres;
        }


        private async void GetAllAndLoad()
        {
            try
            {
                this.dgvPedidos.DataSource = null;

                var pedidos = await PedidoApi.GetAllAsync();

                var pedidosTasks = pedidos.Select(async p => new
                {
                    p.Id,
                    p.Descripcion,
                    p.Estado,
                    p.FechaHoraInicio,
                    p.FechaHoraFin,
                    p.FechaHoraFinEstimada,
                    p.Subtotal,
                    Productos = await GetProductosName(p.ProductosIds),
                    p.ClienteId,
                    p.ClienteNombre,
                    p.EmpleadoId,
                    p.EmpleadoNombre
                });

                // Espera todos los tasks y obtiene un array de objetos listos
                var pedidosParaMostrar = await Task.WhenAll(pedidosTasks);

                this.dgvPedidos.DataSource = pedidosParaMostrar.ToList();

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
                MessageBox.Show($"Error: {ex.Message}");
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

        private async void btnInforme_Click(object sender, EventArgs e)
        {
            var dt = await PedidoApi.ObtenerPedidosMensualesAsync();

            var reporteMensual = new Reporte();
            reporteMensual.CrearReporteMensual(dt);

            reporteMensual.ShowDialog();
        }
    }

}
