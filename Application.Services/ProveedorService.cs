using Domain.Model;
using DTOs;
using Data.Repositories;

namespace Application.Services
{
    public class ProveedorService : CrudService<ProveedorDTO>
    {
        //create, retrieve, update, delete, getall, getone
        public ProveedorDTO Add(ProveedorDTO dto)
        {
            ProveedorRepository repository = new ProveedorRepository();
            if (repository.CuitExists(dto.Cuit)){
                throw new ArgumentException($"Ya existe un cliente con el Cuit '{dto.Cuit}'.");
            }
            if (repository.EmailExists(dto.Email))
            {
                throw new ArgumentException($"Ya existe un cliente con el Email '{dto.Email}'.");
            }

            Proveedor proveedor = new Proveedor(0, dto.RazonSocial, dto.Cuit, dto.Email, dto.Telefono, dto.TipoIngrediente);
            repository.Add(proveedor);
            dto.Id = proveedor.Id;

            return dto;
        }

        public bool Delete(int id)
        {
            ProveedorRepository repository = new ProveedorRepository();
            return repository.Delete(id);
        }


        
        public ProveedorDTO? Get(int id)
        {
            ProveedorRepository repository = new ProveedorRepository();
            Proveedor proveedor = repository.Get(id);
            
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
            ProveedorRepository repository = new ProveedorRepository();


            return repository.GetAll()
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
            ProveedorRepository repository = new ProveedorRepository();
            if (repository.CuitExists(dto.Cuit))
            {
                throw new ArgumentException($"Ya existe un cliente con el Cuit '{dto.Cuit}'.");
            }
            if (repository.EmailExists(dto.Email))
            {
                throw new ArgumentException($"Ya existe un cliente con el Email '{dto.Email}'.");
            }

            Proveedor proveedor = new Proveedor(dto.Id, dto.RazonSocial, dto.Cuit, dto.Email, dto.Telefono, dto.TipoIngrediente);
            return repository.Update(proveedor);
        }
    }
}
