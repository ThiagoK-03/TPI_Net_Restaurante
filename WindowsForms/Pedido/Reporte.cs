using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using API;
using Domain.Model;
using DTOs;
using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.Diagnostics.Internal;

namespace WindowsForms.Pedido
{
    public partial class Reporte : Form
    {
        private readonly ReportViewer reportViewer;
        public Reporte()
        {

            

            
            reportViewer = new ReportViewer();
            reportViewer.Dock = DockStyle.Fill;
            Controls.Add(reportViewer);

            InitializeComponent();
        }

        public void CrearReporte(PedidoDTO pedido)
        {
            using var fs = new FileStream("Pedido/ReportCliente.rdlc", FileMode.Open);
            reportViewer.LocalReport.LoadReportDefinition(fs);
            //reportViewer.LocalReport.SetParameters(new ReportParameter("PedidoId", this.Pedido.Id.ToString()));

            var dataSource = new ReportDataSource("TPIRestauranteDataSetCompleto", new List<PedidoDTO> { pedido });
            reportViewer.LocalReport.DataSources.Add(dataSource);

            System.Diagnostics.Debug.WriteLine("Pedido ID: " + pedido.Id);

            //var TPIRestauranteDataSetCompleto = new ReportDataSource("TPIRestauranteDataSetCompleto", pedido);


            //reportViewer.LocalReport.DataSources.Add(TPIRestauranteDataSetCompleto);

            reportViewer.RefreshReport();

            System.Diagnostics.Debug.WriteLine("Mostrando reporte");
        }
    }
}
