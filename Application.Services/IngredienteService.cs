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
    public class IngredienteService : CrudService<IngredienteDTO>
    {
        public IngredienteDTO Add(IngredienteDTO dto)
        {
            IngredienteRepository _ingredienteRepository = new IngredienteRepository();
            ProveedorRepository _proveedorRepository = new ProveedorRepository();

            var proveedor = _proveedorRepository.Get(dto.ProveedorId) 
                ?? throw new Exception($"Proveedor con ID {dto.ProveedorId} no existe.");

            Ingrediente ingrediente = new Ingrediente(
                0,
                dto.Nombre,
                proveedor,
                dto.Descripcion,
                dto.Stock,
                dto.UnidadMedida,
                dto.Origen,
                dto.LimiteBajoStock
             );

            _ingredienteRepository.Add(ingrediente);
            dto.Id = ingrediente.Id;
            return dto;
        }

        public bool Delete(int id)
        {
            IngredienteRepository repository = new IngredienteRepository();
            return repository.Delete(id);
        }

        public IngredienteDTO Get(int id)
        {
            IngredienteRepository repository = new IngredienteRepository();
            Ingrediente? ingrediente = repository.Get(id);

            if (ingrediente == null)
                return null;

            return new IngredienteDTO
            {
                Id = ingrediente.Id,
                Nombre = ingrediente.Nombre,
                ProveedorId = ingrediente.Proveedor.Id,  
                ProveedorNombre = ingrediente.Proveedor.RazonSocial,
                Descripcion = ingrediente.Descripcion,
                Stock = ingrediente.Stock,
                UnidadMedida = ingrediente.UnidadMedida,
                Origen = ingrediente.Origen,
                LimiteBajoStock = ingrediente.LimiteBajoStock,
            };
        }

        public IEnumerable<IngredienteDTO> GetAll()
        {
            IngredienteRepository repository = new IngredienteRepository();

            ProveedorRepository _proveedorRepository = new ProveedorRepository();

            var ingredientes = repository.GetAll();
            var ingredientesDTO = new List<IngredienteDTO>();

            foreach (var ingrediente in ingredientes)
            {
                var proveedor = _proveedorRepository.Get(ingrediente.ProveedorId);

                ingredientesDTO.Add(new IngredienteDTO
                {
                    Id = ingrediente.Id,
                    Nombre = ingrediente.Nombre,
                    ProveedorNombre = proveedor != null ? proveedor.RazonSocial : "Desconocido",
                    ProveedorId = ingrediente.ProveedorId,
                    Descripcion = ingrediente.Descripcion,
                    Stock = ingrediente.Stock,
                    UnidadMedida = ingrediente.UnidadMedida,
                    Origen = ingrediente.Origen,
                    LimiteBajoStock = ingrediente.LimiteBajoStock,
                });
            }
               
            return ingredientesDTO;
        }

        public bool Update(IngredienteDTO dto)
        {
            IngredienteRepository _ingredienteRepository = new IngredienteRepository();
            ProveedorRepository _proveedorRepository = new ProveedorRepository();
            ProductoRepository _productoRepository = new ProductoRepository();

            var proveedor = _proveedorRepository.Get(dto.ProveedorId)
                ?? throw new Exception($"Proveedor con ID {dto.ProveedorId} no existe.");

            var ingredienteUpdate = _ingredienteRepository.Get(dto.Id)
                ?? throw new Exception($"Ingrediente con ID {dto.Id} no existe.");


            ingredienteUpdate.SetNombre(dto.Nombre);
            ingredienteUpdate.SetProveedor(proveedor);
            ingredienteUpdate.SetDescripcion(dto.Descripcion);
            ingredienteUpdate.SetStock(dto.Stock);
            ingredienteUpdate.SetUnidadMedida(dto.UnidadMedida ?? ingredienteUpdate.UnidadMedida);
            ingredienteUpdate.SetOrigen(dto.Origen ?? ingredienteUpdate.Origen);
            ingredienteUpdate.SetLimiteBajoStock(dto.LimiteBajoStock ?? ingredienteUpdate.LimiteBajoStock);

            if (dto.ProductosIds != null)
            {
                ingredienteUpdate.Productos.Clear(); // Limpiar relaciones actuales

                foreach (var productoId in dto.ProductosIds)
                {
                    var producto = _productoRepository.Get(productoId);
                    if (producto != null)
                        ingredienteUpdate.AgregarProducto(producto);
                }
            }


            return _ingredienteRepository.Update(ingredienteUpdate);
        }


    }
}
