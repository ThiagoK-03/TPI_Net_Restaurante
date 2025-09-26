using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Domain.Model;
using DTOs;

namespace Application.Services
{
    public class IngredienteService
    {
        public IngredienteDTO Add(IngredienteDTO dto)
        {
            var id = GetNextId();

            Ingrediente ingrediente = new Ingrediente(id, dto.Nombre, dto.Descripcion, dto.Stock, dto.UnidadMedida, dto.Origen, dto.LimiteBajoStock);

            IngredienteInMemory.Ingredientes.Add(ingrediente);

            dto.Id = ingrediente.Id;
            

            return dto;
        }

        public bool Delete(int id)
        {
            Ingrediente? ingredienteToDelete = IngredienteInMemory.Ingredientes.Find(x => x.Id == id);

            if (ingredienteToDelete != null)
            {
                IngredienteInMemory.Ingredientes.Remove(ingredienteToDelete);

                return true;
            }
            else
            {
                return false;
            }
        }

        public IngredienteDTO Get(int id)
        {
            Ingrediente? ingrediente = IngredienteInMemory.Ingredientes.Find(x => x.Id == id);

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
            return IngredienteInMemory.Ingredientes.Select(ingrediente => new IngredienteDTO
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
            Ingrediente? ingredienteToUpdate = IngredienteInMemory.Ingredientes.Find(x => x.Id == dto.Id);

            if (ingredienteToUpdate != null)
            {                

                ingredienteToUpdate.SetNombre(dto.Nombre);
                ingredienteToUpdate.SetDescripcion(dto.Descripcion);
                ingredienteToUpdate.SetStock(dto.Stock);
                ingredienteToUpdate.SetunidadMedida(dto.UnidadMedida);
                ingredienteToUpdate.SetLimiteBajoStock(dto.LimiteBajoStock);

                return true;
            }
            else
            {
                return false;
            }
        }

        //No es ThreadSafe pero sirve para el proposito del ejemplo        
        private static int GetNextId()
        {
            int nextId;

            if (IngredienteInMemory.Ingredientes.Count > 0)
            {
                nextId = IngredienteInMemory.Ingredientes.Max(x => x.Id) + 1;
            }
            else
            {
                nextId = 1;
            }

            return nextId;
        }
    }
}
