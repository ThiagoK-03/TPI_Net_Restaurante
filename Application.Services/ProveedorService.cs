using Domain.Model;
using Data;
using DTOs;

namespace Application.Services
{
    public class ProveedorService
    {
        //create, retrieve, update, delete, getall, getone
        public ProveedorDTO Add(ProveedorDTO dto)
        {
            // Validar que el email no esté duplicado
            if (ProveedorInMemory.Proveedores.Any(p => p.Email.Equals(dto.Email, StringComparison.OrdinalIgnoreCase)))
            {
                throw new ArgumentException($"Ya existe un cliente con el Email '{dto.Email}'.");
            }

            var id = GetNextId();

            Proveedor proveedor = new Proveedor(id, dto.RazonSocial, dto.Cuit, dto.Email, dto.Telefono, dto.TipoIngrediente);
            ProveedorInMemory.Proveedores.Add(proveedor);

            dto.Id = proveedor.Id;

            return dto;
        }

        public bool Delete(int id)
        {
            Proveedor? proveedorToDelete = ProveedorInMemory.Proveedores.Find(x => x.Id == id);

            if(proveedorToDelete != null)
            {
                ProveedorInMemory.Proveedores.Remove(proveedorToDelete);
                return true;
            }
            else
            {
                return false;
            }
        }


        
        public ProveedorDTO? Get(int id)
        {
            Proveedor? proveedor = ProveedorInMemory.Proveedores.Find(x => x.Id == id);
            if (proveedor == null)
                return null;

            return new ProveedorDTO
            {
                Id = proveedor.Id,
                RazonSocial = proveedor.RazonSocial,
                Cuit = proveedor.Cuit,
                Email = proveedor.Email,
                Telefono = proveedor.Telefono,
                TipoIngrediente = proveedor.TipoIngrediente
            };
        }
        public IEnumerable<ProveedorDTO> GetAll()
        {
            return ProveedorInMemory.Proveedores
                .Select(proveedor => new ProveedorDTO
                {
                    Id = proveedor.Id,
                    RazonSocial = proveedor.RazonSocial,
                    Cuit = proveedor.Cuit,
                    Email = proveedor.Email,
                    Telefono = proveedor.Telefono,
                    TipoIngrediente = proveedor.TipoIngrediente
                })
                .ToList();
        }
        
        //Este metodo Update tuve que modificarlo (a como estaba hecho el de Clientes) para que funcione y no de error.
        public bool Update(ProveedorDTO dto) //Fue modificado respecto al original para solucionar un problema
        {
            // Buscar el proveedor por Id
            Proveedor? proveedorToUpdate = ProveedorInMemory.Proveedores.Find(x => x.Id == dto.Id);
            
            if (proveedorToUpdate != null)
            {
                // Validar que el nuevo email no esté duplicado en otro proveedor
                if (ProveedorInMemory.Proveedores.Any(p => p.Id != dto.Id && p.Email.Equals(dto.Email, StringComparison.OrdinalIgnoreCase)))
                {
                    throw new ArgumentException($"Ya existe un proveedor con el Email '{dto.Email}'.");
                }

                // Actualizar los campos
                proveedorToUpdate.SetNombre(dto.RazonSocial);
                proveedorToUpdate.SetCuit(dto.Cuit);
                proveedorToUpdate.SetEmail(dto.Email);
                proveedorToUpdate.SetTelefono(dto.Telefono);
                proveedorToUpdate.setTipoIngrediente(dto.TipoIngrediente);
                //proveedorToUpdate.setCompañia(dto.Compañia);

                return true;
            }
            else
            {
                return false;
            }
            /* Esta comentado para saber si esto se deja o no
                // Retornar el DTO actualizado
                return new ProveedorDTO
                {
                    Id = proveedor.Id,
                    RazonSocial = proveedor.RazonSocial,
                    Cuit = proveedor.Cuit,
                    Email = proveedor.Email,
                    Telefono = proveedor.Telefono,
                    TipoIngrediente = proveedor.TipoIngrediente
                };
            */
        }

        private static int GetNextId()
        {
            int nextId;

            if (ProveedorInMemory.Proveedores.Count > 0)
            {
                nextId = ProveedorInMemory.Proveedores.Max(x => x.Id) + 1;
            }
            else
            {
                nextId = 1;
            }

            return nextId;
        }
    }
}
