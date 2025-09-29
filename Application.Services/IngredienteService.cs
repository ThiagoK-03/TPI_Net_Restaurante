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
            IngredienteRepository repository = new IngredienteRepository();

            Ingrediente ingrediente = new Ingrediente(0, dto.Nombre, dto.Descripcion, dto.Stock, dto.UnidadMedida, dto.Origen, dto.LimiteBajoStock);
            repository.Add(ingrediente);
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

            return repository.GetAll().Select(ingrediente => new IngredienteDTO
            {
                Id = ingrediente.Id,
                Nombre = ingrediente.Nombre,
                Descripcion = ingrediente.Descripcion,
                Stock = ingrediente.Stock,
                UnidadMedida = ingrediente.UnidadMedida,
                Origen = ingrediente.Origen,
                LimiteBajoStock = ingrediente.LimiteBajoStock,
            }).ToList();
        }

        public bool Update(IngredienteDTO dto)
        {
            IngredienteRepository repository = new IngredienteRepository();
            Ingrediente ingrediente = new Ingrediente(dto.Id,dto.Nombre, dto.Descripcion,dto.Stock,dto.UnidadMedida,dto.Origen,dto.LimiteBajoStock);
            return repository.Update(ingrediente);
        }


    }
}
