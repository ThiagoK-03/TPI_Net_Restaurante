using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Repositories;
using Domain.Model;
using DTOs;

namespace Application.Services
{
    public class PedidoService : CrudService<PedidoDTO>
    {
        //CREATE
        public PedidoDTO Add(PedidoDTO dto) 
        {
            var pedidoRepository = new PedidoRepository();
            var clienteRepository = new ClienteRepository();
            var productoRepository = new ProductoRepository();
            var empleadoRepository = new EmpleadoRepository();

            // buscar entidades relacionadas
            var cliente = clienteRepository.Get(dto.ClienteId);
            //var empleado = empleadoRepository.Get(dto.EmpleadoId);

            if (cliente == null)
                throw new ArgumentException($"Cliente con Id {dto.ClienteId} no existe");

            // traer productos del pedido
            var productos = new List<Producto>();
            foreach (int productoId in dto.ProductosIds)
            {
                var producto = productoRepository.Get(productoId);
                if (producto == null)
                    throw new ArgumentException($"Producto con Id {productoId} no existe");
                productos.Add(producto);
            }

            // crear pedido
            Pedido pedido = new Pedido(
                0,
                dto.Descripcion,
                DateTime.Now,
                dto.FechaHoraFinEstimada,
                cliente,
                productos
                
            );

            pedidoRepository.Add(pedido);

            dto.Id = pedido.Id;
            return dto;

        }

        //GET ALL
        public IEnumerable<PedidoDTO> GetAll()
        {
            PedidoRepository repository = new PedidoRepository();

            return repository.GetAll().Select(pedido => new PedidoDTO
            {
                Id = pedido.Id,
                Descripcion = pedido.Descripcion,
                FechaHoraInicio = pedido.FechaHoraInicio,
                FechaHoraFinEstimada = pedido.FechaHoraFinEstimada,
                FechaHoraFin = pedido.FechaHoraFin,
                Estado = pedido.Estado.ToString(),
                ClienteId = pedido.ClienteId,
                EmpleadoId = pedido.EmpleadoId,
                ProductosIds = pedido.Productos.Select(prod => prod.Id).ToList(),
                Subtotal = pedido.CalculateTotal()

            }).ToList();
        }

        //GET ONE
        public PedidoDTO? Get(int id)
        {
            PedidoRepository repository = new PedidoRepository();
            Pedido? pedido = repository.Get(id);

            if (pedido == null)
                return null;

            return new PedidoDTO
            {
                Id = pedido.Id,
                Descripcion = pedido.Descripcion,
                FechaHoraInicio = pedido.FechaHoraInicio,
                FechaHoraFinEstimada = pedido.FechaHoraFinEstimada,
                FechaHoraFin = pedido.FechaHoraFin,
                Estado = pedido.Estado.ToString(),
                ClienteId = pedido.ClienteId,
                EmpleadoId = pedido.EmpleadoId,
                ProductosIds = pedido.Productos.Select(prod => prod.Id).ToList(),
                Subtotal = pedido.CalculateTotal()
            };
        }

        //UPDATE
        public bool Update(PedidoDTO pedido)
        {
            PedidoRepository repository = new PedidoRepository();
            ClienteRepository clienteRepository = new ClienteRepository();
            EmpleadoRepository empleadoRepository = new EmpleadoRepository();
            ProductoRepository productoRepository = new ProductoRepository();

            var cliente = clienteRepository.Get(pedido.ClienteId)
                ?? throw new Exception($"Cliente con ID {pedido.ClienteId} no existe.");


                    
            List<Producto> productos = new List<Producto>();
            foreach (int productoId in pedido.ProductosIds)
            {
                var producto = productoRepository.Get(productoId)
                    ?? throw new Exception($"Producto con ID {productoId} no existe.");
                productos.Add(producto);
            }


            Pedido pedidoUpdated = new Pedido(
                pedido.Id, 
                pedido.Descripcion, 
                pedido.FechaHoraInicio,
                pedido.FechaHoraFinEstimada, 
                cliente,
                productos
            );

            if (pedido.EmpleadoId != null)
            {
                var empleado = empleadoRepository.Get((int)pedido.EmpleadoId)
                    ?? throw new Exception($"Empleado con ID {pedido.EmpleadoId} no existe.");
                pedidoUpdated.SetEmpleado(empleado);
            }
            if(Enum.TryParse<EstadoPedido>(pedido.Estado, out var estado))
            {
                pedidoUpdated.SetEstado(estado);
            }

            if(pedido.FechaHoraFin != null)
                pedidoUpdated.SetFechaHoraFin(pedido.FechaHoraFin);

            return repository.Update(pedidoUpdated);
        }

        //DELETE
        public bool Delete(int id)
        {
            PedidoRepository repository = new PedidoRepository();
            return repository.Delete(id);
        }

    }
}
