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
            foreach (ProductoDTO productoDTO in dto.Productos)
            {
                var producto = productoRepository.Get(productoDTO.Id);
                if (producto == null)
                    throw new ArgumentException($"Producto con Id {productoDTO.Id} no existe");
                productos.Add(producto);
            }

            // crear pedido
            Pedido pedido = new Pedido(
                0,
                dto.Descripcion,
                DateTime.Now,
                dto.FechaHoraFinEstimada,
                cliente.Id
                
            );

            //pedido.SetEmpleadoId(0);
            // asignar productos
            pedido.SetProductos(productos);

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
                EmpleadoId = pedido.EmpleadoId

                //Lista Ingredientes?
                //Subtotal
            }).ToList();
        }

        //GET ONE
        public PedidoDTO Get(int id)
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
                EmpleadoId = pedido.EmpleadoId
                
                //Lista ingredientes?
                //Subtotal
            };
        }

        //UPDATE
        public bool Update(PedidoDTO pedido)
        {
            PedidoRepository repository = new PedidoRepository();

            
            Pedido pedidoUpdated = new Pedido(pedido.Id, pedido.Descripcion, pedido.FechaHoraInicio, pedido.FechaHoraFinEstimada, pedido.ClienteId);
            
            //Estado?
            //Lista productos??
            //Empleado????????????

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
