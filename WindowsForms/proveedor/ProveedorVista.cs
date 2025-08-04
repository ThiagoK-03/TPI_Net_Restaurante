using DTOs;

namespace WindowsForms
{
    public partial class ProveedorVista : Form
    {
        public ProveedorVista()
        {
            InitializeComponent();
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ProveedorDetalle proveedorDetalle = new ProveedorDetalle();

            ProveedorDTO proveedorNuevo = new ProveedorDTO();

            proveedorDetalle.Mode = FormMode.Add;
            proveedorDetalle.Proveedor = proveedorNuevo;

            proveedorDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                ProveedorDetalle proveedorDetalle = new ProveedorDetalle();

                int id = this.SelectedItem().Id;

                ProveedorDTO proveedor = await ProveedorApi.GetAsync(id);

                proveedorDetalle.Mode = FormMode.Update;
                proveedorDetalle.Proveedor = proveedor;

                proveedorDetalle.ShowDialog();

                this.GetAllAndLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar proveedor para modificar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = this.SelectedItem().Id;

                var result = MessageBox.Show($"¿Está seguro que desea eliminar el proveedor con Id {id}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    await ProveedorApi.DeleteAsync(id);
                    this.GetAllAndLoad();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar proveedor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void GetAllAndLoad()
        {
            try
            {
                this.dgvProveedores.DataSource = null;
                this.dgvProveedores.DataSource = await ProveedorApi.GetAllAsync();

                if (this.dgvProveedores.Rows.Count > 0)
                {
                    this.dgvProveedores.Rows[0].Selected = true;
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
                MessageBox.Show($"Error al cargar la lista de proveedors: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.btnEliminar.Enabled = false;
                this.btnModificar.Enabled = false;
            }
        }

        private ProveedorDTO SelectedItem()
        {
            ProveedorDTO proveedor;

            proveedor = (ProveedorDTO)dgvProveedores.SelectedRows[0].DataBoundItem;

            return proveedor;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
