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

        // ...

        async public void CrearReporte(PedidoDTO pedido)
        {
            //Cargar el RDLC
            using var fs = new FileStream("Pedido/ReportCliente.rdlc", FileMode.Open);
            reportViewer.LocalReport.LoadReportDefinition(fs);

            ClienteDTO cliente = (await ClienteApi.GetAsync(pedido.ClienteId));

            // Mostrar el objeto cliente como JSON en una sola línea por consola
            Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(cliente));
            System.Diagnostics.Debug.WriteLine(System.Text.Json.JsonSerializer.Serialize(cliente));

            // Usuario
            var usuarioLista = new List<UsuarioReporte>
            {
                new UsuarioReporte
                {
                    Id = cliente.Id,
                    Username = cliente.Username,
                    Email = cliente.Email
                }
            };

            // Productos

            List<ProductoDTO> productos = (await Task.WhenAll(
                pedido.ProductosIds.Select(
                    async p => await ProductoApi.GetAsync(p))
                )).ToList();

            var productosLista = productos.Select(p => new ProductoReporte
            {
                Id = p.Id,
                Nombre = p.Nombre,
                Precio = p.Precio
            }).ToList();

            // 3 - Agregar datasources EXACTAMENTE con los nombres del RDLC
            reportViewer.LocalReport.DataSources.Clear();

            reportViewer.LocalReport.DataSources.Add(
                new ReportDataSource("UsuarioDataSet", usuarioLista)
            );

            reportViewer.LocalReport.DataSources.Add(
                new ReportDataSource("ProductoDataSet", productosLista)
            );

            // 4 - Render
            reportViewer.RefreshReport();
        }


        private class UsuarioReporte
        {
            public int Id { get; set; }
            public string Username { get; set; }
            public string Email { get; set; }
        }

        public class ProductoReporte
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public decimal Precio { get; set; }
        }


    }
}
