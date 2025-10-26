using DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsControlLibrary1;
using API;

namespace WindowsForms.emplead
{
    public partial class EmpleadoDetalle : MenuBase
    {
        private EmpleadoDto empleado;
        private FormMode mode;

        public EmpleadoDto Empleado
        {
            get 
            {
                return empleado; 
            }
            set
            {
                empleado = value;
                this.SetEmpleado();
            }
        }

        public FormMode Mode
        {
            get
            {
                return mode;
            }
            set
            {
                SetFormMode(value);
            }
        }

        public EmpleadoDetalle()
        {
            InitializeComponent();

            Mode = FormMode.Add;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {

            if (this.ValidateEmpleado())
            {
                try
                {

                    this.Empleado.RazonSocial = txbNombre.Text;
                    this.Empleado.Cuil = int.Parse(txbCuit.Text);
                    this.Empleado.Turno = txbTurno.Text;
                    this.Empleado.HorasTrabajadas = int.Parse(txbHorasTrabajadas.Text);
                    this.Empleado.PrecioPorHora = int.Parse(txbPrecioPorHora.Text);
                    this.Empleado.Sueldo = int.Parse(txbSueldo.Text); 

                    //El Detalle se esta llevando la responsabilidad de llamar al servicio
                    //pero tal vez deberia ser solo una vista y que esta responsabilidad quede
                    //en la Lista o tal vez en un Presenter o Controler

                    if (this.Mode == FormMode.Update)
                    {
                        await EmpleadoApi.UpdateAsync(this.Empleado);
                    }
                    else
                    {
                        await EmpleadoApi.AddAsync(this.Empleado);
                    }

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SetEmpleado()
        {
            this.tbxId.Text = this.Empleado.Id.ToString();
            this.txbNombre.Text = this.Empleado.RazonSocial;
            this.txbCuit.Text = this.Empleado.Cuil.ToString();
            this.txbTurno.Text = this.Empleado.Turno;
            this.txbHorasTrabajadas.Text = this.Empleado.HorasTrabajadas.ToString();
            this.txbPrecioPorHora.Text = this.Empleado.PrecioPorHora.ToString();
            this.txbSueldo.Text = this.Empleado.Sueldo.ToString();
        }

        private void SetFormMode(FormMode value)
        {
            mode = value;

            if (mode == FormMode.Add)
            {
                lblId.Visible = false;
                tbxId.Visible = false;
            }

            if (Mode == FormMode.Update)
            {
                lblId.Visible = true;
                tbxId.Visible = true;
                tbxId.Enabled = false;
            }
        }

        private bool ValidateEmpleado()
        {
            bool isValid = true;

            // Limpio los errores previos
            errorProvider.SetError(txbNombre, string.Empty);
            errorProvider.SetError(txbCuit, string.Empty);
            errorProvider.SetError(txbTurno, string.Empty);
            errorProvider.SetError(txbHorasTrabajadas, string.Empty);
            errorProvider.SetError(txbPrecioPorHora, string.Empty);

            // Razon Social
            if (string.IsNullOrWhiteSpace(txbNombre.Text))
            {
                isValid = false;
                errorProvider.SetError(txbNombre, "La Razón Social es requerida");
            }

            // CUIT
            if (string.IsNullOrWhiteSpace(txbCuit.Text))
            {
                isValid = false;
                errorProvider.SetError(txbCuit, "El CUIT es requerido");
            }
            else if (!long.TryParse(txbCuit.Text, out _))
            {
                isValid = false;
                errorProvider.SetError(txbCuit, "El CUIT debe ser numérico");
            }

            // Turno
            if (string.IsNullOrWhiteSpace(txbTurno.Text))
            {
                isValid = false;
                errorProvider.SetError(txbTurno, "El Turno es requerido");
            }

            // Horas Trabajadas
            if (string.IsNullOrWhiteSpace(txbHorasTrabajadas.Text))
            {
                isValid = false;
                errorProvider.SetError(txbHorasTrabajadas, "Las Horas Trabajadas son requeridas");
            }
            else if (!int.TryParse(txbHorasTrabajadas.Text, out _))
            {
                isValid = false;
                errorProvider.SetError(txbHorasTrabajadas, "Las Horas Trabajadas deben ser un número entero");
            }

            // Precio por Hora
            if (string.IsNullOrWhiteSpace(txbPrecioPorHora.Text))
            {
                isValid = false;
                errorProvider.SetError(txbPrecioPorHora, "El Precio por Hora es requerido");
            }
            else if (!decimal.TryParse(txbPrecioPorHora.Text, out _))
            {
                isValid = false;
                errorProvider.SetError(txbPrecioPorHora, "El Precio por Hora debe ser numérico");
            }

            return isValid;
        }



    }
}
