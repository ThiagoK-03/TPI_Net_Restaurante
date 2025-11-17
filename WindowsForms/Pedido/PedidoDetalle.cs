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

namespace WindowsForms.Pedido
{
    public partial class PedidoDetalle : MenuBase
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

        public PedidoDetalle()
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
                    this.Pedido.Estado = (PedidoDTO.EstadoPedido)cboxEstado.SelectedItem!;
                    this.Pedido.FechaHoraInicio = DateTime.Now;
                    this.Pedido.FechaHoraFinEstimada = dtPickerFinEstimado.Value;
                    this.Pedido.ProductosIds = clistboxProductos.CheckedItems
                        .Cast<ProductoDTO>()
                        .Select(p => p.Id)
                        .ToList();
                    this.Pedido.EmpleadoId = cboxEmpleado.SelectedValue != null ? (int)cboxEmpleado.SelectedValue : default;
                    this.Pedido.ClienteId = (int)cboxCliente.SelectedValue!;

                    if (this.Mode == FormMode.Update)
                    {
                        MessageBox.Show("Updateando");
                        await PedidoApi.UpdateAsync(this.Pedido);
                    }
                    else
                    {
                        await PedidoApi.AddAsync(this.Pedido);
                    }

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
            cboxEmpleado.SelectedValue = this.Pedido.EmpleadoId ?? 0;

            foreach (var item in this.Pedido.ProductosIds) clistboxProductos.SetItemChecked(item, true);
            

            cboxEstado.Text = this.Pedido.Estado.ToString();
            dtPickerFinEstimado.Value = this.Pedido.FechaHoraFinEstimada ?? DateTime.Now;
            if (mode == FormMode.Update)
                dtPickerFechaHoraFin.Value = this.Pedido.FechaHoraFin ?? DateTime.Now;

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

            //Empleado picker
            var empleados = await EmpleadoApi.GetAllAsync();
            cboxEmpleado.DataSource = empleados;
            cboxEmpleado.DisplayMember = "Nombre";
            cboxEmpleado.ValueMember = "Id";

            // Enum EstadoPedido como DataSource
            cboxEstado.DataSource = Enum.GetValues(typeof(PedidoDTO.EstadoPedido));

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
                LblId.Visible = false;
                TxtBoxId.Visible = false;
                dtPickerFechaHoraFin.Enabled = false;
                dtPickerFechaHoraFin.Visible = false;
                lblFechaHoraFin.Visible = false;
            }
            if (Mode == FormMode.Update)
            {
                LblId.Visible = true;
                TxtBoxId.Visible = true;
                TxtBoxId.Enabled = false;
                dtPickerFechaHoraFin.Enabled = true;
                dtPickerFechaHoraFin.Visible = true;
                lblFechaHoraFin.Visible = true;
            }
        }

        private bool ValidatePedido()
        {
            return true;
        }
    }
}
