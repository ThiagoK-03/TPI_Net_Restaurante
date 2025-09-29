using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Domain.Model
{
    public class Ingrediente
    {
        public int Id { get; private set; }
        public string Nombre { get; private set; }
        public string Descripcion { get; private set; }

        public int Stock { get; private set; }

        //listaProveedor / Nose como poner esto no me queda claro
        public string UnidadMedida { get; private set; }

        public string Origen { get; private set; }

        public int LimiteBajoStock { get; private set; }


        public Ingrediente(int id, string nombre, string descripcion, int stock, string unidadMedida, string origen, int limiteBajoStock ) {
            SetId(id);
            SetNombre(nombre);
            SetDescripcion(descripcion);
            SetStock(stock);
            SetUnidadMedida(unidadMedida);
            SetOrigen(origen);
            SetLimiteBajoStock(limiteBajoStock);
        }

        public void SetId(int id)
        {
            Id = id;
        }

        public void SetNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre no puede ser nulo o vacío.", nameof(nombre));
            Nombre = nombre;
        }

        public void SetDescripcion(string descripcion)
        {
            if (string.IsNullOrWhiteSpace(descripcion))
                throw new ArgumentException("La descripcion no puede ser nulo o vacío.", nameof(descripcion));
            Descripcion = descripcion;
        }

        public void SetStock(int stock)
        {
            if (stock < 0)
                throw new ArgumentException("El stock debe ser mayor o igual a 0.", nameof(stock));
            Stock = stock;
        }

        public void SetUnidadMedida(string unidadMedida)
        {
            if (string.IsNullOrWhiteSpace(unidadMedida))
                throw new ArgumentException("La unidad de medida no puede ser nula o vacía.", nameof(unidadMedida));
            UnidadMedida = unidadMedida;
        }

        public void SetOrigen(string origen)
        {
            if (string.IsNullOrWhiteSpace(origen))
                throw new ArgumentException("El origen no puede ser nulo o vacío.", nameof(origen));
            Origen = origen;
        }

        public void SetLimiteBajoStock(int limiteBajoStock)
        {
            if (limiteBajoStock < 0)
                throw new ArgumentException("El limiteBajoStock debe ser mayor o igual que 0.", nameof(limiteBajoStock));
            LimiteBajoStock = limiteBajoStock;
        }
    }


}
