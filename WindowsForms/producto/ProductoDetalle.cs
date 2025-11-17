using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTOs;
using WinFormsControlLibrary1;
using API;

namespace WindowsForms.producto
{
    public partial class ProductoDetalle : MenuBase
    {
        private ProductoDTO producto;
        private FormMode mode;

        public ProductoDTO Producto
        {
            get { return producto; }
            set
            {
                producto = value;
                this.SetProducto();
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

        public ProductoDetalle()
        {
            InitializeComponent();

            Mode = FormMode.Add;
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.ValidateProducto())
            {
                try
                {
                    this.Producto.Nombre = tbxNombre.Text;
                    this.Producto.Descripcion = tbxDescripcion.Text;
                    this.Producto.Imagen = tbxImagen.Text;
                    this.Producto.Calificacion = int.Parse(tbxCalificacion.Text);
                    this.Producto.Precio = decimal.Parse(tbxPrecio.Text);

                    if (this.Mode == FormMode.Update)
                    {
                        await ProductoApi.UpdateAsync(this.Producto);
                    }
                    else
                    {
                        await ProductoApi.AddAsync(this.Producto);
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

        private void SetProducto()
        {
            this.tbxId.Text = this.Producto.Id.ToString();
            this.tbxNombre.Text = this.Producto.Nombre;
            this.tbxDescripcion.Text = this.Producto.Descripcion;
            this.tbxImagen.Text = this.Producto.Imagen;
            this.tbxCalificacion.Text = this.Producto.Calificacion.ToString();
            this.tbxPrecio.Text = this.Producto.Precio.ToString();
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

        private bool ValidateProducto()
        {
            bool isValid = true;

            errorProvider.SetError(tbxNombre, string.Empty);
            errorProvider.SetError(tbxDescripcion, string.Empty);
            errorProvider.SetError(tbxImagen, string.Empty);
            errorProvider.SetError(tbxCalificacion, string.Empty);
            errorProvider.SetError(tbxPrecio, string.Empty);

            if (this.tbxNombre.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(tbxNombre, "El Nombre es Requerido");
            }

            if (this.tbxDescripcion.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(tbxDescripcion, "La Descripcion es Requerida");
            }

            if (this.tbxImagen.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(tbxImagen, "La Imagen es Requerida");
            }

            if (this.tbxCalificacion.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(tbxCalificacion, "La Calificacion es Requerida");
            }

            if (this.tbxPrecio.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(tbxPrecio, "El Precio es Requerido");
            }

            return isValid;
        }

        private async void onLoad(object sender, EventArgs e)
        {
            var ingredientes = await IngredienteApi.GetAllAsync();
            cboxIngredientes.DataSource = ingredientes;
            cboxIngredientes.DisplayMember = "Nombre";
            cboxIngredientes.ValueMember = "Id";
        }

        private void lblPrecio_Click(object sender, EventArgs e)
        {

        }

        private void lblCalificacion_Click(object sender, EventArgs e)
        {

        }
    }
}
