using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;

namespace Data
{
    
    public class PedidoInMemory
    {
        public static List<Pedido> Pedidos;

        static PedidoInMemory()
        {
            Pedidos = new List<Pedido>
        {
            new Pedido(
                id: 1,
                descripcion: "Pedido de pizza",
                estado: EstadoPedido.Pendiente,
                fechaHoraInicio: DateTime.Now,
                fechaHoraFinEstimada: DateTime.Now.AddHours(1)
                //productos: new List<Producto>
                //{
                //    new Ingrediente("Hamburguesa")
                //}
            ),
            new Pedido(
                id: 2,
                descripcion: "Pedido de hamburguesa",
                estado: EstadoPedido.EnProceso,
                fechaHoraInicio: DateTime.Now.AddMinutes(-30),
                fechaHoraFinEstimada: DateTime.Now.AddMinutes(30)

            ),
            new Pedido(
                id: 3,
                descripcion: "Pedido de ensalada",
                estado: EstadoPedido.Completado,
                fechaHoraInicio: DateTime.Now.AddHours(-2),
                fechaHoraFinEstimada: DateTime.Now.AddHours(-1)
 
            ),
            new Pedido(
                id: 4,
                descripcion: "Pedido de gaseosa",
                estado: EstadoPedido.Cancelado,
                fechaHoraInicio: DateTime.Now.AddHours(-1),
                fechaHoraFinEstimada: DateTime.Now

            )
        };
        }
    }

}
