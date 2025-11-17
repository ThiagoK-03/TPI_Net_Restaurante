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
    public partial class PedidoDetalleEmpleado : MenuBase
    {
        private PedidoDTO pedido;
        private FormMode mode;

        public PedidoDTO Pedido
        {
            get { return pedido; }
            set
            {
                pedido = value;
                this.SetPedido();
            }
        }

        public FormMode Mode
        {
            get { return mode; }
            set { SetFormMode(value); }
        }

        public PedidoDetalleEmpleado()
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
                    this.Pedido.ClienteId = int.Parse(TxtBoxClienteId.Text);
                    this.Pedido.EmpleadoId = int.Parse(TxtBoxEmpleadoId.Text);
                    this.Pedido.Estado = Enum.Parse<PedidoDTO.EstadoPedido>(TxtBoxEstado.Text);
                    this.Pedido.FechaHoraInicio = DateTime.Parse(TxtBoxFechaHoraInicio.Text);


                    if (this.Mode == FormMode.Update)
                    {
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
            TxtBoxClienteId.Text = this.Pedido.ClienteId.ToString();
            TxtBoxEmpleadoId.Text = this.Pedido.EmpleadoId.ToString();
            TxtBoxEstado.Text = this.Pedido.Estado.ToString();
            TxtBoxFechaHoraInicio.Text = this.Pedido.FechaHoraInicio.ToString("yyyy-MM-dd");
        }

        private void SetFormMode(FormMode value)
        {
            mode = value;

            if (mode == FormMode.Add)
            {
                LblId.Visible = false;
                TxtBoxId.Visible = false;
            }
            if (Mode == FormMode.Update)
            {
                LblId.Visible = true;
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
