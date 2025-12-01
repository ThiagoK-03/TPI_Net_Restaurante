using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOs;

namespace Application.Services
{
    public interface CrudService<T>
    {
        //IEnumerable<T> GetAllByUserId(int userId);
        IEnumerable<T> GetAll();
        T? Get(int id);
        T Add(T entity);
        bool Update(T entity);
        bool Delete(int id);
    }

    public interface IPedidoService : CrudService<PedidoDTO>
    {
        IEnumerable<PedidoDTO> GetAllByClientId(int clienteId);
    }

    public interface IClienteService : CrudService<ClienteDTO>
    {
        ClienteDTO GetByUserId(int userId);
    }

}
