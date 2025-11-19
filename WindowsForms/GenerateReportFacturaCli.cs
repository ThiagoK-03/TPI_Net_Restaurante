using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using API;
using Domain.Model;
using DTOs;
using Microsoft.Reporting.WinForms;

namespace WindowsForms
{
    public class GenerateReportFacturaCli
    {
        private LocalReport report;

        public GenerateReportFacturaCli()
        {
            System.Diagnostics.Debug.WriteLine("Inicializando GenerateReportFacturaCli...");

            var asm = typeof(GenerateReportFacturaCli).Assembly;
            foreach (var r in asm.GetManifestResourceNames())
                System.Diagnostics.Debug.WriteLine("Recurso embebido: " + r);

        }

        /// <summary>
        /// Genera un recibo/factura PDF para un pedido específico
        /// </summary>
        /// <param name="pedidoId">ID del pedido</param>
        /// <param name="clienteNombre">Nombre completo del cliente</param>
        /// <param name="clienteEmail">Email del cliente</param>
        /// <param name="productos">Lista de productos del pedido</param>
        /// <param name="observaciones">Observaciones del pedido</param>
        /// <param name="subtotal">Subtotal del pedido</param>
        public void GenerarReciboPedido(
            int pedidoId,
            string clienteNombre,
            string clienteEmail,
            List<ProductoDTO> productos,
            string observaciones,
            decimal subtotal)
        {
            System.Diagnostics.Debug.WriteLine("Cargando GenerateReportFacturaCli...");
            report = new LocalReport();
            try
            {
                
                // PASO 1: Configurar el reporte
                report.ReportEmbeddedResource = "WindowsForms.Report1.rdlc";

                System.Diagnostics.Debug.WriteLine("Configurando recibo .. .");

                // PASO 2: Preparar datos del encabezado
                var datosEncabezado = new List<DatosEncabezado>
                {
                    new DatosEncabezado
                    {
                        NumeroPedido = pedidoId,
                        FechaEmision = DateTime.Now,
                        ClienteNombre = clienteNombre,
                        ClienteEmail = clienteEmail,
                        Observaciones = observaciones ?? "Sin observaciones",
                        Subtotal = subtotal,
                        // Puedes agregar IVA o descuentos si los necesitas
                        IVA = subtotal * 0.21m, // Ejemplo: 21% IVA
                        Total = subtotal * 1.21m
                    }
                };

                try
                {
                    using var s = typeof(GenerateReportFacturaCli).Assembly
                        .GetManifestResourceStream("WindowsForms.Report1.rdlc");

                    if (s == null)
                        System.Diagnostics.Debug.WriteLine("❌ El RDLC NO está embebido o el nombre está mal");
                    else
                        System.Diagnostics.Debug.WriteLine("✔ RDLC encontrado!");
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Error al verificar RDLC: " + ex.Message);
                }


                // PASO 3: Agregar los DataSources
                report.DataSources.Clear();
                report.DataSources.Add(new ReportDataSource("DSEncabezado", datosEncabezado));
                report.DataSources.Add(new ReportDataSource("DSProductos", productos));

                System.Diagnostics.Debug.WriteLine("Data sources agregados . . .");

                // PASO 4: Configurar parámetros adicionales (opcional)
                report.SetParameters(new ReportParameter[]
                {
                    new ReportParameter("NombreRestaurante", "Restaurante Rosario"),
                    new ReportParameter("DireccionRestaurante", "Av. Belgrano 1234, Rosario, Santa Fe"),
                    new ReportParameter("TelefonoRestaurante", "0341-1234567"),
                    new ReportParameter("EmailRestaurante", "info@restaurante-rosario.com")
                });

                // PASO 5: Renderizar a PDF
                byte[] bytes = report.Render("PDF");

                System.Diagnostics.Debug.WriteLine("PDF Rendered");

                // PASO 6: Guardar en carpeta temporal
                string carpetaReportes = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                    "RestauranteRosario",
                    "Facturas"
                );

                // Crear carpeta si no existe
                if (!Directory.Exists(carpetaReportes))
                {
                    Directory.CreateDirectory(carpetaReportes);
                }

                string nombreArchivo = $"Recibo_Pedido_{pedidoId}_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
                string pathCompleto = Path.Combine(carpetaReportes, nombreArchivo);

                File.WriteAllBytes(pathCompleto, bytes);

                // PASO 7: Abrir el PDF
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                {
                    FileName = pathCompleto,
                    UseShellExecute = true
                });

                Console.WriteLine($"Recibo generado exitosamente: {pathCompleto}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw new Exception($"Error al generar el recibo: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Versión simplificada para generar directamente desde un PedidoDTO
        /// (si ya tienes los datos desde tu API)
        /// </summary>
        public void GenerarReciboDesdePedido(PedidoDTO pedido, ClienteDTO cliente)
        {
            List<ProductoDTO> productosPedido = new List<ProductoDTO>();
            foreach (int prodId in pedido.ProductosIds)
            {
                ProductoDTO producto = ProductoApi.GetAsync(prodId).Result;
                productosPedido.Add(producto);
            }


            // ------------------------------------------------
            // Preparar la lista de productos para el reporte
            // ------------------------------------------------

            //    var productos = pedido.Productos.Select((p, index) => new ProductoPedido
            //{
            //    NumeroLinea = index + 1,
            //    NombreProducto = p.Nombre,
            //    Descripcion = p.Descripcion,
            //    PrecioUnitario = p.Precio,
            //    Cantidad = 1, // Ajustar según tu lógica si tienes cantidades
            //    Subtotal = p.Precio
            //}).ToList();

            System.Diagnostics.Debug.WriteLine(" Generando recibo desde pedido... ");

            GenerarReciboPedido(
                pedido.Id,
                $"{cliente.Nombre} {cliente.Apellido}",
                cliente.Email,
                productosPedido,
                pedido.Descripcion,
                pedido.Subtotal
            );
        }
    }

    #region Clases para el DataSource del Reporte

    /// <summary>
    /// Clase para los datos del encabezado del recibo
    /// </summary>
    public class DatosEncabezado
    {
        public int NumeroPedido { get; set; }
        public DateTime FechaEmision { get; set; }
        public string ClienteNombre { get; set; }
        public string ClienteEmail { get; set; }
        public string Observaciones { get; set; }
        public decimal Subtotal { get; set; }
        public decimal IVA { get; set; }
        public decimal Total { get; set; }
    }

    /// <summary>
    /// Clase para cada línea de producto en el recibo
    /// </summary>
    public class ProductoPedido
    {
        public int NumeroLinea { get; set; }
        public string NombreProducto { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioUnitario { get; set; }
        public int Cantidad { get; set; }
        public decimal Subtotal { get; set; }
    }

    #endregion
}