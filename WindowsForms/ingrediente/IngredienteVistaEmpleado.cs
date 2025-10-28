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
    public partial class IngredienteVistaEmpleado : MenuBase
    {
        public IngredienteVistaEmpleado()
        {
            InitializeComponent();
        }

        private void Ingredientes_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
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
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la lista de ingredientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
