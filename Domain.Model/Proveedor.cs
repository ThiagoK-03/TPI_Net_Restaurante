using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Proveedor
    {
        [Key]
        public int Id { get; private set; }

        [Required]
        public string RazonSocial { get; private set; }

        [Required]
        public int Cuit {  get; private set; }

        [Required]
        public string Email { get; private set; }
        
        [Required]
        public int Telefono { get; private set; }

        [Required]
        public string TipoIngrediente {  get; private set; }

        public List<Ingrediente> Ingredientes { get; private set; } = new List<Ingrediente>();

        protected Proveedor() { } // Requerido por EF

        public Proveedor(int id, string razonSocial, int cuit, string email, int telefono, string tipoIngrediente)
        {
            SetId(id);
            SetNombre(razonSocial);
            SetCuit(cuit);
            SetEmail(email);
            SetTelefono(telefono);
            SetTipoIngrediente(tipoIngrediente);
        }

        public void SetIngredientes(List<Ingrediente> ingredientes)
        {
            if (ingredientes == null || ingredientes.Count == 0)
                throw new ArgumentException("Debe tener al menos un ingrediente .", nameof(ingredientes));
            foreach (var ingrediente in ingredientes)
            {
                AgregarIngrediente(ingrediente);
            }
        }

        private void AgregarIngrediente(Ingrediente ingrediente)
        {
            if (ingrediente == null)
                throw new ArgumentException("El ingrediente no puede ser nulo.", nameof(ingrediente));
            Ingredientes.Add(ingrediente);
        }

        public void SetId(int id)
        {
            Id = id;
        }

        public void SetNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre no puede ser nulo o vacío.", nameof(nombre));
            RazonSocial = nombre;
        }

        public void SetCuit(int cuit)
        {
            if (cuit < 0)
                throw new ArgumentException("El cuit debe ser mayor que 0.", nameof (cuit));
            Cuit = cuit;
        }

        public void SetEmail(string email)
        {
            if (!EsEmailValido(email))
                throw new ArgumentException("El email no tiene un formato válido.", nameof(email));
            Email = email;
        }

        private static bool EsEmailValido(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        public void SetTelefono(int telefono)
        {
            Telefono = telefono;
        }

        public void SetTipoIngrediente(string tipoIngrediente)
        {
            if (string.IsNullOrWhiteSpace(tipoIngrediente)){
                throw new ArgumentException("El tipo de ingrediente no puede ser nulo o vacio.", nameof(tipoIngrediente));
            }
            TipoIngrediente = tipoIngrediente;
        }
      
    }
}
