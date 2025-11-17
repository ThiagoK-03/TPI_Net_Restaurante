using DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsControlLibrary1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using API;

namespace WindowsForms.cliente
{
    public partial class ClienteDetalle : MenuBase
    {
        private ClienteDTO cliente;
        private FormMode mode;

        public ClienteDTO Cliente
        {
            get { return cliente; }
            set
            {
                cliente = value;
                this.SetCliente();
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

        public ClienteDetalle()
        {
            InitializeComponent();

            Mode = FormMode.Add;
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.ValidateCliente())
            {
                try
                {

                    this.Cliente.Nombre = tbxNombre.Text;
                    this.Cliente.Apellido = tbxApellido.Text;
                    this.Cliente.Email = tbxEmail.Text;
                    this.Cliente.FechaAlta = DateTime.Now;
                    this.Cliente.Username = tbxUsername.Text;
                    this.Cliente.Password = tbxPassword.Text;
                    this.Cliente.Telefono = tbxTelefono.Text;

                    //El Detalle se esta llevando la responsabilidad de llamar al servicio
                    //pero tal vez deberia ser solo una vista y que esta responsabilidad quede
                    //en la Lista o tal vez en un Presenter o Controler

                    if (this.Mode == FormMode.Update)
                    {
                        await ClienteApi.UpdateAsync(this.Cliente);
                    }
                    else
                    {
                        await ClienteApi.AddAsync(this.Cliente);
                    }

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetCliente()
        {
            this.tbxId.Text = this.Cliente.Id.ToString();
            this.tbxNombre.Text = this.Cliente.Nombre;
            this.tbxApellido.Text = this.Cliente.Apellido;
            this.tbxEmail.Text = this.Cliente.Email;
            this.tbxTelefono.Text = this.Cliente.Telefono.ToString();
            this.tbxUsername.Text = this.Cliente.Username;
        }

        private void SetFormMode(FormMode value)
        {
            mode = value;

            if (Mode == FormMode.Add)
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

        private bool ValidateCliente()
        {
            bool isValid = true;

            errorProvider.SetError(tbxNombre, string.Empty);
            errorProvider.SetError(tbxApellido, string.Empty);
            errorProvider.SetError(tbxEmail, string.Empty);

            if (this.tbxNombre.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(tbxNombre, "El Nombre es Requerido");
            }

            if (this.tbxApellido.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(tbxApellido, "El Apellido es Requerido");
            }

            if (this.tbxEmail.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(tbxEmail, "El Email es Requerido");
            }
            else if (!EsEmailValido(this.tbxEmail.Text))
            {
                isValid = false;
                errorProvider.SetError(tbxEmail, "El formato del Email no es válido");
            }

            if (this.tbxTelefono.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(tbxTelefono, "El telefono es Requerido");
            }
            if (this.tbxUsername.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(tbxUsername, "El username es Requerido");
            }
            if (this.tbxPassword.Text == string.Empty && Mode == FormMode.Add)
            {
                isValid = false;
                errorProvider.SetError(tbxPassword, "La contraseña es Requerido");
            }


            return isValid;
        }

        private static bool EsEmailValido(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }
    }
}
