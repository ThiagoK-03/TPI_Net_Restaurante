using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Domain.Model
{
    public class Producto
    {
        public int Id { get; private set; }
        public string Nombre { get; private set; }
        public string Descripcion { get; private set; }

        public string Imagen { get; private set; }

        public int Calificacion { get; private set; }

        public float Precio { get; private set; }

        public Producto(int id, string nombre, string descripcion, string imagen, int calificacion, float precio)
        {
            SetId(id);
            SetNombre(nombre);
            SetDescripcion(descripcion);
            SetImagen(imagen);
            SetCalificacion(calificacion);
            SetPrecio(precio);
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
                throw new ArgumentException("La descripcion no puede ser nula o vacía.", nameof(descripcion));
            Descripcion = descripcion;
        }

        public void SetImagen(string imagen)
        {
            if (string.IsNullOrWhiteSpace(imagen))
                throw new ArgumentException("La imagen no puede ser nula o vacía.", nameof(imagen));
            Imagen = imagen;
        }

        public void SetCalificacion(int calificacion)
        {
            if (calificacion < 0)
                throw new ArgumentException("La calificacion debe ser mayor o igual que 0.", nameof(calificacion));
            Calificacion = calificacion;
        }

        public void SetPrecio(float precio)
        {
            if (precio < 0)
                throw new ArgumentException("El precio debe ser mayor o igual que 0.", nameof(precio));
            Precio = precio;
        }

    }
}
