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
                TipoIngrediente = proveedor.TipoIngrediente,
                IngredientesIds = proveedor.Ingredientes.Select(i => i.Id).ToList()
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
                    TipoIngrediente = proveedor.TipoIngrediente,
                    IngredientesIds = proveedor.Ingredientes.Select(i => i.Id).ToList()
                })
                .ToList();
        }
        
        //Este metodo Update tuve que modificarlo (a como estaba hecho el de Clientes) para que funcione y no de error.
        public bool Update(ProveedorDTO dto) //Fue modificado respecto al original para solucionar un problema
        {
            ProveedorRepository repository = new ProveedorRepository();
            if (repository.CuitExists(dto.Cuit))
            {
                throw new ArgumentException($"Ya existe un proveedor con el Cuit '{dto.Cuit}'.");
            }
            if (repository.EmailExists(dto.Email))
            {
                throw new ArgumentException($"Ya existe un proveedor con el Email '{dto.Email}'.");
            }

            Proveedor proveedor = new Proveedor(dto.Id, dto.RazonSocial, dto.Cuit, dto.Email, dto.Telefono, dto.TipoIngrediente);

            if(dto.IngredientesIds != null && dto.IngredientesIds.Count > 0)
            {
                IngredienteRepository ingredienteRepository = new IngredienteRepository();
                var ingredientes = dto.IngredientesIds
                    .Select(id => ingredienteRepository.Get(id))
                    .Where(ingrediente => ingrediente != null)
                    .ToList()!;
                proveedor.SetIngredientes(ingredientes!);
            }

            return repository.Update(proveedor);
        }
    }
}
