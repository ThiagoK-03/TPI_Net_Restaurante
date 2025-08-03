using Domain.Model;

namespace Data
{
    public class ProveedorInMemory
    {
        public static List<Proveedor> Proveedores;

        static ProveedorInMemory()
        {
            Proveedores = new List<Proveedor>
            {
                new Proveedor(1, "Sancor", 123, "arcor@gmail.com", 341213457, "Lacteos"),
                new Proveedor(2, "Molinos Rio", 456, "molinos@gmail.com", 341111222, "Harinas"),
                new Proveedor(3, "Coca Cola", 789, "cocacola@gmail.com", 341333444, "Bebidas"),
                new Proveedor(4, "Nestle", 321, "nestle@gmail.com", 341555666, "Chocolates"),
                new Proveedor(5, "Arcor", 654, "arcor2@gmail.com", 341777888, "Golosinas"),
            };
        }
    }
}
