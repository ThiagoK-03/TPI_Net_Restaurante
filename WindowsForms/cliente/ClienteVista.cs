using DTOs;
using API;
using WinFormsControlLibrary1;

namespace WindowsForms
{
    public partial class ClienteVista : MenuBase
    {
        public ClienteVista()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ClienteDetalle clienteDetalle = new ClienteDetalle();

            ClienteDTO clienteNuevo = new ClienteDTO();

            clienteDetalle.Mode = FormMode.Add;
            clienteDetalle.Cliente = clienteNuevo;

            clienteDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteDetalle clienteDetalle = new ClienteDetalle();

                int id = this.SelectedItem().Id;

                ClienteDTO cliente = await ClienteApi.GetAsync(id);


                clienteDetalle.Mode = FormMode.Update;
                clienteDetalle.Cliente = cliente;

                clienteDetalle.ShowDialog();

                this.GetAllAndLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar cliente para modificar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = this.SelectedItem().Id;

                var result = MessageBox.Show($"�Est� seguro que desea eliminar el cliente con Id {id}?", "Confirmar eliminaci�n", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    await ClienteApi.DeleteAsync(id);
                    this.GetAllAndLoad();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void GetAllAndLoad()
        {
            try
            {
                this.dgvClientes.DataSource = null;
                this.dgvClientes.DataSource = await ClienteApi.GetAllAsync();

                if (this.dgvClientes.Rows.Count > 0)
                {
                    this.dgvClientes.Rows[0].Selected = true;
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
                MessageBox.Show($"Error al cargar la lista de clientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.btnEliminar.Enabled = false;
                this.btnModificar.Enabled = false;
            }
        }

        private ClienteDTO SelectedItem()
        {
            ClienteDTO cliente;

            cliente = (ClienteDTO)dgvClientes.SelectedRows[0].DataBoundItem;

            return cliente;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
