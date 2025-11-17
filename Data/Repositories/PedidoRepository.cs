using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;


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
            var existingPedido = context.Pedidos.Find(pedido.Id);
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

    }
}
