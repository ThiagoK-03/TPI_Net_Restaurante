using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Domain.Model;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Data.Repositories
{
    public class PedidoRepository
    {
        private AppDbContext CreateContext()
        {
            return new AppDbContext();
        }

        public void Add(Pedido pedido)
        {
            using var context = CreateContext();
            context.Attach(pedido.Cliente);
            if(pedido.Empleado != null) context.Attach(pedido.Empleado);
            foreach (Producto producto in pedido.Productos) context.Attach(producto);
            context.Pedidos.Add(pedido);
            context.SaveChanges();
        }

        public bool Delete(int id)
        {
            using var context = CreateContext();
            var pedido = context.Pedidos.Find(id);
            if (pedido != null)
            {
                context.Pedidos.Remove(pedido);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public Pedido? Get(int id)
        {
            using var context = CreateContext();
            return context.Pedidos
                .Include(p => p.Cliente)
                .Include(p => p.Empleado)
                .FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Pedido> GetAll()
        {
            using var context = CreateContext();
            return context.Pedidos
                .Include(p => p.Cliente)
                .Include(p => p.Empleado)
                .Include(p => p.Productos)
                .ToList();
        }

        public bool Update(Pedido pedido)
        {
            using var context = CreateContext();
            var existingPedido = context.Pedidos
                .Include(p => p.Productos)
                .FirstOrDefault(p => p.Id == pedido.Id);


            if (existingPedido != null)
            {


                existingPedido.SetDescripcion(pedido.Descripcion);
                existingPedido.SetEstado(pedido.Estado);
                existingPedido.SetFechaHoraFin(pedido.FechaHoraFin);
                existingPedido.SetFechaHoraFinEstimada(pedido.FechaHoraFinEstimada);


                
                if (pedido.Cliente != null)
                {
                    var cliente = context.Clientes.Find(pedido.Cliente.Id);
                    existingPedido.SetCliente(cliente);
                }
                if (pedido.Empleado != null)
                {
                    var empleado = context.Empleados.Find(pedido.Empleado.Id);
                    existingPedido.SetEmpleado(empleado);
                }

                existingPedido.SetProductos(
                    pedido.Productos
                          .Select(p => context.Productos.Find(p.Id))
                          .Where(p => p != null)
                          .ToList()
                );

                context.SaveChanges();
                return true;
            }
            return false;
        }

        public IEnumerable<Pedido> GetByEstado(EstadoPedido estado)
        {
            using var context = CreateContext();
            return context.Pedidos
                .Include(p => p.Cliente)
                .Include(p => p.Empleado)
                .Where(p => p.Estado == estado)
                .ToList();
        }

        public IEnumerable<Pedido> GetByCliente(int clienteId)
        {
            using var context = CreateContext();
            return context.Pedidos
                .Include(p => p.Empleado)
                .Where(p => p.ClienteId == clienteId)
                .OrderByDescending(p => p.FechaHoraInicio)
                .ToList();
        }

        public IEnumerable<Pedido> GetByEmpleado(int empleadoId)
        {
            using var context = CreateContext();
            return context.Pedidos
                .Include(p => p.Cliente)
                .Where(p => p.EmpleadoId == empleadoId)
                .OrderByDescending(p => p.FechaHoraInicio)
                .ToList();
        }

        public IEnumerable<Pedido> GetByFecha(DateTime fecha)
        {
            using var context = CreateContext();
            return context.Pedidos
                .Include(p => p.Cliente)
                .Include(p => p.Empleado)
                .Where(p => p.FechaHoraInicio.Date == fecha.Date)
                .ToList();
        }

        public List<PedidosPorDiaResult> GetPedidosAgrupados()
        {
            using var context = CreateContext();

            var result = context.Pedidos
                .Include(p => p.Productos)
                .GroupBy(p => p.FechaHoraInicio.Date)
                .Select(g => new PedidosPorDiaResult
                {
                    Fecha = g.Key,
                    Cantidad = g.Count(),
                    Total = g.Sum(p => p.Productos.Sum(x => x.Precio))
                })
                .OrderByDescending(x => x.Fecha)
                .Take(20)
                .ToList();

            return result;
        }

        public List<PedidosPorDiaResult> GetPedidosAgrupadosAdo()
        {
            var lista = new List<PedidosPorDiaResult>();

            using var conn = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=TPIRestaurante;Trusted_Connection=True;");
            conn.Open();

            var cmd = new SqlCommand(@"SELECT TOP 20
                CAST(p.FechaHoraInicio AS DATE) AS Fecha,
                COUNT(DISTINCT p.Id) AS CantidadPedidos,
                SUM(prod.Precio) AS TotalDelDia
            FROM Pedidos p
            JOIN PedidoProducto pp ON pp.PedidoId = p.Id
            JOIN Productos prod ON prod.Id = pp.ProductoId
            GROUP BY CAST(p.FechaHoraInicio AS DATE)
            ORDER BY Fecha DESC"
            , conn);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lista.Add(new PedidosPorDiaResult
                {
                    Fecha = reader.GetDateTime(0),
                    Cantidad = reader.GetInt32(1),
                    Total = reader.GetDecimal(2)
                });
            }

            Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(lista));
            return lista;
        }


        public class PedidosPorDiaResult
        {
            public DateTime Fecha { get; set; }
            public int Cantidad { get; set; }
            public decimal Total { get; set; }
        }


    }
}
