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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace WindowsForms
{
    public partial class ProveedorDetalle : Form
    {
        private ProveedorDTO proveedor;
        private FormMode mode;

        public ProveedorDTO Proveedor
        {
            get { return proveedor; }
            set
            {
                proveedor = value;
                this.SetProveedor();
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
        public ProveedorDetalle()
        {
            InitializeComponent();

            Mode = FormMode.Add;
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.ValidateProveedor())
            {
                try
                {
                    this.Proveedor.RazonSocial = tbxRazonSocial.Text;
                    if (int.TryParse(tbxCuit.Text, out int cuit))
                    {
                        this.Proveedor.Cuit = cuit;
                    }
                    else
                    {
                        MessageBox.Show("El CUIT ingresado no es válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    this.Proveedor.Email = tbxEmail.Text;
                    if (int.TryParse(tbxTelefono.Text, out int telefono))
                    {
                        this.Proveedor.Telefono = telefono;
                    }
                    else
                    {
                        MessageBox.Show("El teléfono ingresado no es válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    //Hacer Validaciones
                    this.Proveedor.TipoIngrediente = tbxTipoIng.Text;
                    //this.Proveedor.Compañia = tbxCompania.Text;

                    //El Detalle se esta llevando la responsabilidad de llamar al servicio
                    //pero tal vez deberia ser solo una vista y que esta responsabilidad quede
                    //en la Lista o tal vez en un Presenter o Controler

                    if (this.Mode == FormMode.Update)
                    {
                        await ProveedorApi.UpdateAsync(this.Proveedor);
                    }
                    else
                    {
                        await ProveedorApi.AddAsync(this.Proveedor);
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

        private void SetProveedor()
        {
            this.tbxId.Text = this.Proveedor.Id.ToString();
            this.tbxCuit.Text = this.Proveedor.Cuit.ToString();
            this.tbxRazonSocial.Text = this.Proveedor.RazonSocial;
            this.tbxEmail.Text = this.Proveedor.Email;
            this.tbxTelefono.Text = this.Proveedor.Telefono.ToString();
            this.tbxTipoIng.Text = this.Proveedor.TipoIngrediente;
            //this.tbxCompania.Text = this.Proveedor.Compañia;
        }

        private void SetFormMode(FormMode value)
        {
            mode = value;
            
            //momentaneo, hasta definir que hacer con Compañia
            lblCompania.Visible = false;
            tbxCompania.Visible = false;

            if (Mode == FormMode.Add)
            {
                lblId.Visible = false;
                tbxId.Visible = false;
                /*lblRazonSocial.Visible = false;
                tbxRazonSocial.Visible = false;*/
            }

            if (Mode == FormMode.Update)
            {
                lblId.Visible = true;
                tbxId.Visible = true;
                tbxId.Enabled = false;
                /*lblRazonSocial.Visible = true;
                tbxRazonSocial.Visible = true;
                tbxRazonSocial.Enabled = false;*/
            }
        }
        //Los comentados de arriba son para bloquearlos en el menu para no setearle ningun dato, por ahora los comente para no olvidar que hay algunos atributos
        //que no deben de ser modificados, pero es solo eso.

        private bool ValidateProveedor()
        {
            bool isValid = true;

            errorProvider.SetError(tbxRazonSocial, string.Empty);
            errorProvider.SetError(tbxCuit, string.Empty);
            errorProvider.SetError(tbxEmail, string.Empty);

            if (this.tbxRazonSocial.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(tbxRazonSocial, "La Razon Social es Requerida");
            }

            if (this.tbxCuit.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(tbxCuit, "El Cuit es Requerido");
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
