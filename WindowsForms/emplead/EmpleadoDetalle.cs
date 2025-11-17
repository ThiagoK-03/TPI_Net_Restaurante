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
                    System.Diagnostics.Debug.WriteLine($"HORAS TRABAJADASS - {txbHorasTrabajadas.Text}");
                    this.Empleado.PrecioPorHora = decimal.Parse(txbPrecioPorHora.Text);
                    this.Empleado.Sueldo = decimal.Parse(txbSueldo.Text); 
                    this.Empleado.Username = tbxUsername.Text;
                    this.Empleado.Password = tbxContraseña.Text;
                    this.Empleado.Email = tbxEmail.Text;
                    this.Empleado.Telefono = tbxTelefono.Text;
                    this.Empleado.Apellido = tbxApellido.Text;
                    this.Empleado.Nombre = txbNombre.Text;

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
            this.tbxUsername.Text = this.Empleado.Username;
            this.tbxContraseña.Text = this.Empleado.Password;
            this.tbxEmail.Text = this.Empleado.Email;
            this.tbxTelefono.Text = this.Empleado.Telefono;
            this.tbxApellido.Text = this.Empleado.Apellido;
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
            errorProvider.SetError(tbxUsername, string.Empty);
            errorProvider.SetError(tbxContraseña, string.Empty);
            errorProvider.SetError(tbxEmail, string.Empty);
            errorProvider.SetError(tbxTelefono, string.Empty);
            errorProvider.SetError(tbxApellido, string.Empty);

            // Razon Social
            if (string.IsNullOrWhiteSpace(txbNombre.Text))
            {
                isValid = false;
                errorProvider.SetError(txbNombre, "El nombre es requerido");
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

            if (string.IsNullOrWhiteSpace(tbxUsername.Text))
            {
                isValid = false;
                errorProvider.SetError(tbxUsername, "El Nombre de Usuario es requerido");
            }

            if (string.IsNullOrWhiteSpace(tbxContraseña.Text) && (Mode == FormMode.Add))
            {
                isValid = false;
                errorProvider.SetError(tbxContraseña, "La Contraseña es requerida");
            }

            if (string.IsNullOrWhiteSpace(tbxEmail.Text))
            {
                isValid = false;
                errorProvider.SetError(tbxEmail, "El Email es requerido");
            }

            if (string.IsNullOrWhiteSpace(tbxTelefono.Text))
            {
                isValid = false;
                errorProvider.SetError(tbxTelefono, "El Teléfono es requerido");
            }

            if (string.IsNullOrWhiteSpace(tbxApellido.Text))
            {
                isValid = false;
                errorProvider.SetError(tbxApellido, "El Apellido es requerido");
            }

            return isValid;
        }



    }
}
