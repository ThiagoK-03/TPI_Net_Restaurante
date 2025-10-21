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

namespace WindowsForms.ingrediente
{
    public partial class IngredienteDetalle : MenuBase
    {

        private IngredienteDTO ingrediente;
        private FormMode mode;

        public IngredienteDTO Ingrediente
        {
            get { return ingrediente; }
            set
            {
                ingrediente = value;
                this.SetIngrediente();
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

        public IngredienteDetalle()
        {
            InitializeComponent();

            Mode = FormMode.Add;
        }

        
        

        

        private async void btnAceptar_click(object sender, EventArgs e) //Boton de aceptar
        {
            if (this.ValidateIngrediente())
            {
                try
                {


                    this.Ingrediente.Nombre = tbxNombre.Text;
                    this.Ingrediente.Descripcion = tbxDescripcion.Text;
                    this.Ingrediente.Stock = int.Parse(tbxStock.Text);
                    this.Ingrediente.UnidadMedida = tbxUnidadMedida.Text;
                    this.Ingrediente.Origen = tbxOrigen.Text;
                    this.Ingrediente.LimiteBajoStock = int.Parse(tbxLimiteBajoStock.Text);

                    if (this.Mode == FormMode.Update)
                    {
                        await IngredienteApi.UpdateAsync(this.Ingrediente);
                    }
                    else
                    {
                        await IngredienteApi.AddAsync(this.Ingrediente);
                    }

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_click(object sender, EventArgs e)  //Boton de Cancelar
        {
            this.Close();
        }

        private void SetIngrediente()
        {
            this.tbxId.Text = this.Ingrediente.Id.ToString();
            this.tbxNombre.Text = this.Ingrediente.Nombre;
            this.tbxDescripcion.Text = this.Ingrediente.Descripcion;
            this.tbxStock.Text = this.Ingrediente.Stock.ToString();
            this.tbxUnidadMedida.Text = this.Ingrediente.UnidadMedida;
            this.tbxOrigen.Text = this.Ingrediente.Origen;
            this.tbxLimiteBajoStock.Text = this.Ingrediente.LimiteBajoStock.ToString();
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

        private bool ValidateIngrediente()
        {
            bool isValid = true;

            errorProvider.SetError(tbxNombre, string.Empty);
            errorProvider.SetError(tbxDescripcion, string.Empty);
            errorProvider.SetError(tbxStock, string.Empty);
            errorProvider.SetError(tbxUnidadMedida, string.Empty);
            errorProvider.SetError(tbxOrigen, string.Empty);
            errorProvider.SetError(tbxLimiteBajoStock, string.Empty);

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

            if (this.tbxStock.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(tbxStock, "El Stock es Requerido");
            }

            if (this.tbxUnidadMedida.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(tbxUnidadMedida, "La Unidad de Medida es Requerida");
            }

            if (this.tbxOrigen.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(tbxOrigen, "El Origen es Requerido");
            }

            if (this.tbxLimiteBajoStock.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(tbxLimiteBajoStock, "El Limite de Bajo Stock es Requerido");
            }

            return isValid;
        }

    }
}
