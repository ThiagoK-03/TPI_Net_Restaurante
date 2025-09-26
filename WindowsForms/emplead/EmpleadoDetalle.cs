using DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsControlLibrary1;

namespace WindowsForms.emplead
{
    public partial class EmpleadoDetalle : MenuBase
    {
        private EmpleadoDto empleado;
        private FormMode mode;

        public EmpleadoDto Empleado
        {
            get { return empleado; }
            set
            {
                empleado = value;
                this.SetEmpleado();
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

        public EmpleadoDetalle()
        {
            InitializeComponent();

            Mode = FormMode.Add;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }
    }
}
