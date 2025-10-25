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

namespace WindowsForms
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
                    this.Cliente.FechaAlta = DateTime.Parse(tbxFechaAlta.Text);

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
            this.tbxFechaAlta.Text = this.Cliente.FechaAlta.ToString();
            this.tbxEmail.Text = this.Cliente.Email;
        }

        private void SetFormMode(FormMode value)
        {
            mode = value;

            if (Mode == FormMode.Add)
            {
                lblId.Visible = false;
                tbxId.Visible = false;
                lblFechaAlta.Visible = false;
                tbxFechaAlta.Visible = false;
            }

            if (Mode == FormMode.Update)
            {
                lblId.Visible = true;
                tbxId.Visible = true;
                tbxId.Enabled = false;
                lblFechaAlta.Visible = true;
                tbxFechaAlta.Visible = true;
                tbxFechaAlta.Enabled = false;
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
