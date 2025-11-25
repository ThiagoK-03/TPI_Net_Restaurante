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
using Microsoft.Reporting.WinForms;

namespace WindowsForms.Pedido
{
    public partial class PedidoDetalleCliente : MenuBase
    {
        private PedidoDTO pedido;
        private FormMode mode;


        public PedidoDTO Pedido
        {
            get { return pedido; }
            set
            {
                pedido = value;
            }
        }

        public FormMode Mode
        {
            get { return mode; }
            set { SetFormMode(value); }
        }

        public PedidoDetalleCliente()
        {
            InitializeComponent();

            Mode = FormMode.Add;

        }

        private async void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (this.ValidatePedido())
            {
                try
                {
                    this.Pedido.Descripcion = TxtBoxDescripcion.Text;
                    this.pedido.Estado = (PedidoDTO.EstadoPedido.Pendiente);
                    this.Pedido.FechaHoraInicio = DateTime.Now;
                    //this.Pedido.FechaHoraFinEstimada = dtPickerFinEstimado.Value;
                    this.Pedido.ProductosIds = clistboxProductos.CheckedItems
                        .Cast<ProductoDTO>()
                        .Select(p => p.Id)
                        .ToList();
                    //this.Pedido.EmpleadoId = cboxEmpleado.SelectedValue != null ? (int)cboxEmpleado.SelectedValue : default;
                    this.Pedido.ClienteId = (int)cboxCliente.SelectedValue!;
                    this.Pedido.FechaHoraFinEstimada = DateTime.Today.AddDays(1); // Por defecto 1 día para el cliente

                    if (this.Mode == FormMode.Update)
                    {
                        MessageBox.Show("Updateando");
                        await PedidoApi.UpdateAsync(this.Pedido);
                    }
                    else
                    {
                        await PedidoApi.AddAsync(this.Pedido);
                    }

                    MessageBox.Show("A PUNTO DE CREAR INFORME");
                    //ClienteDTO cli = await ClienteApi.GetAsync(this.Pedido.ClienteId);
                    //GenerateReportFacturaCli generateReportFacturaCli = new GenerateReportFacturaCli();


                    //generateReportFacturaCli.GenerarReciboDesdePedido(
                    //    this.Pedido,
                    //    cli
                    //);
                    LoadReport();



                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadReport()
        {
            Reporte reporteForm = new Reporte();
            reporteForm.CrearReporte(this.Pedido);
            reporteForm.ShowDialog();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetPedido()
        {

            TxtBoxId.Text = this.Pedido.Id.ToString();
            TxtBoxDescripcion.Text = this.Pedido.Descripcion;
            cboxCliente.SelectedValue = this.Pedido.ClienteId;

            foreach (var item in this.Pedido.ProductosIds) clistboxProductos.SetItemChecked(item, true);

            //dtPickerFinEstimado.Value = this.Pedido.FechaHoraFinEstimada ?? DateTime.Now;

        }

        private async void OnLoad(object sender, EventArgs e)
        {
            var productos = await ProductoApi.GetAllAsync();

            //ListBox
            clistboxProductos.DataSource = productos;
            clistboxProductos.DisplayMember = "Nombre";
            clistboxProductos.ValueMember = "Id";

            //Cliente picker
            var clientes = await ClienteApi.GetAllAsync();
            cboxCliente.DataSource = clientes;
            cboxCliente.DisplayMember = "Nombre";
            cboxCliente.ValueMember = "Id";

            if (Mode == FormMode.Update)
            {
                this.SetPedido();
            }
        }


        private void SetFormMode(FormMode value)
        {
            mode = value;

            if (mode == FormMode.Add)
            {
                lblId.Visible = false;
                TxtBoxId.Visible = false;

            }
            if (Mode == FormMode.Update)
            {
                lblId.Visible = true;
                TxtBoxId.Visible = true;
                TxtBoxId.Enabled = false;
            }
        }

        private bool ValidatePedido()
        {
            return true;
        }
    }
}
