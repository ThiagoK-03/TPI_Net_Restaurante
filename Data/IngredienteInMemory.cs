using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;

namespace Data
{
    public class IngredienteInMemory
    {
        public static List<Ingrediente> Ingredientes;

        static IngredienteInMemory()
        {
            Ingredientes = new List<Ingrediente>
            {
                new Ingrediente(1, "Azucar", "Muy dulce", 100, "Kg", "Un lugar muy muy lejano", 20),
                new Ingrediente(2, "Sal", "Muy salada", 200, "Kg", "La salada", 35),
                new Ingrediente(3, "Arroz", "Muy blanco", 500, "Kg", "Algun arrozal", 100),
                new Ingrediente(4, "Papa", "Muy negra", 1000, "Kg", "De la tierra", 234),
                new Ingrediente(5, "Cebolla", "Lo mejor", 250, "Kg", "Del cielo", 56)
            };
        }
    }
}
