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
using WindowsForms.clientes;
using WindowsForms.producto;
using WinFormsControlLibrary1;

namespace WindowsForms.emplead
{
    public partial class EmpleadoVista : MenuBase
    {
        public EmpleadoVista()
        {
            InitializeComponent();
        }

        private void EmpleadoVista_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private async void GetAllAndLoad()
        {
            try
            {
                this.dgvEmpleados.DataSource = null;
                this.dgvEmpleados.DataSource = await EmpleadoApi.GetAllAsync();

                if (this.dgvEmpleados.Rows.Count > 0)
                {
                    this.dgvEmpleados.Rows[0].Selected = true;
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
                MessageBox.Show($"Error al cargar la lista de emplados: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.btnEliminar.Enabled = false;
                this.btnModificar.Enabled = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            EmpleadoDetalle empleadoDetalle = new EmpleadoDetalle();
            EmpleadoDto empleadoNuevo = new EmpleadoDto();

            empleadoDetalle.Mode = FormMode.Add;
            empleadoDetalle.Empleado = empleadoNuevo;

            empleadoDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                EmpleadoDetalle empleadoDetalle = new EmpleadoDetalle();
                ProductoDetalle productoDetalle = new ProductoDetalle();

                int id = this.SelectedItem().Id;

                EmpleadoDto empleado = await EmpleadoApi.GetAsync(id);

                empleadoDetalle.Mode = FormMode.Update;
                empleadoDetalle.Empleado = empleado;

                empleadoDetalle.ShowDialog();

                this.GetAllAndLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar empleado para modificar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private EmpleadoDto SelectedItem()
        {
            EmpleadoDto empleado;

            empleado = (EmpleadoDto)dgvEmpleados.SelectedRows[0].DataBoundItem;

            return empleado;
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = this.SelectedItem().Id;

                var result = MessageBox.Show($"¿Está seguro que desea eliminar el empleado con Id {id}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    await EmpleadoApi.DeleteAsync(id);
                    this.GetAllAndLoad();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar empleado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
