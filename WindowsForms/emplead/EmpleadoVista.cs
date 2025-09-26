using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms.clientes;
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
                this.dgvEmpleados.DataSource = await ClienteApi.GetAllAsync();

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
                MessageBox.Show($"Error al cargar la lista de clientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.btnEliminar.Enabled = false;
                this.btnModificar.Enabled = false;
            }
        }
    }
}
