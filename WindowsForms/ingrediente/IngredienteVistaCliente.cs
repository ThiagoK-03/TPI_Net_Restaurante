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
using WindowsForms.ingrediente;
using WinFormsControlLibrary1;
using API;

namespace WindowsForms.ingrediente
{
    public partial class IngredienteVistaCliente : MenuBase
    {
        public IngredienteVistaCliente()
        {
            InitializeComponent();
        }

        private void Ingredientes_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            IngredienteDetalle ingredienteDetalle = new IngredienteDetalle();

            IngredienteDTO ingredienteNuevo = new IngredienteDTO();

            ingredienteDetalle.Mode = FormMode.Add;
            ingredienteDetalle.Ingrediente = ingredienteNuevo;

            ingredienteDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                IngredienteDetalle ingredienteDetalle = new IngredienteDetalle();

                int id = this.SelectedItem().Id;

                IngredienteDTO ingrediente = await IngredienteApi.GetAsync(id);

                ingredienteDetalle.Mode = FormMode.Update;
                ingredienteDetalle.Ingrediente = ingrediente;

                ingredienteDetalle.ShowDialog();

                this.GetAllAndLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar ingrediente para modificar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = this.SelectedItem().Id;

                var result = MessageBox.Show($"¿Está seguro que desea eliminar el ingrediente con Id {id}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    await IngredienteApi.DeleteAsync(id);
                    this.GetAllAndLoad();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar ingrediente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void GetAllAndLoad()
        {
            try
            {
                this.dgvIngredientes.DataSource = null;
                this.dgvIngredientes.DataSource = await IngredienteApi.GetAllAsync();

                if (this.dgvIngredientes.Rows.Count > 0)
                {
                    this.dgvIngredientes.Rows[0].Selected = true;
                    this.btnEliminar.Enabled = true;
                    this.btnModificar.Enabled = true;
                }
                else
                {
                    this.btnEliminar.Enabled = false;
                    this.btnModificar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la lista de ingredientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.btnEliminar.Enabled = false;
                this.btnModificar.Enabled = false;
            }
        }

        private IngredienteDTO SelectedItem()
        {
            IngredienteDTO ingrediente;

            ingrediente = (IngredienteDTO)dgvIngredientes.SelectedRows[0].DataBoundItem;

            return ingrediente;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
