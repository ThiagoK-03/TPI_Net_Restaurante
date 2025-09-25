using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;

namespace Data
{
    public class ProductoInMemory
    {
        public static List<Producto> Productos;

        static ProductoInMemory()
        {
            Productos = new List<Producto>
            {
                new Producto(1, "Cuchilla", "Corta mucho", "una imagen de un cuchillo...", 7, 40000.32f),
                new Producto(2, "Cuchilla", "Corta mucho", "una imagen de un cuchillo...", 7, 40000.32f),
                new Producto(3, "Cuchilla", "Corta mucho", "una imagen de un cuchillo...", 7, 40000.32f),
                new Producto(4, "Cuchilla", "Corta mucho", "una imagen de un cuchillo...", 7, 40000.32f),
                new Producto(5, "Cuchilla", "Corta mucho", "una imagen de un cuchillo...", 7, 40000.32f),
            };
        }
    }
}
