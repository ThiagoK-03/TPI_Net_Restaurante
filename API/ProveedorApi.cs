using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using DTOs;

namespace API
{
    public class ProveedorApi
    {
        private static HttpClient client = new HttpClient();
        static ProveedorApi()
        {
            client.BaseAddress = new Uri("http://localhost:5205/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }


        public static async Task<ProveedorDTO> GetAsync(int id)
        {
            ProveedorDTO proveedor = null;
            HttpResponseMessage response = await client.GetAsync("proveedores/" + id);
            if (response.IsSuccessStatusCode)
            {
                proveedor = await response.Content.ReadFromJsonAsync<ProveedorDTO>();
            }
            return proveedor;
        }

        public static async Task<IEnumerable<ProveedorDTO>> GetAllAsync()
        {
            IEnumerable<ProveedorDTO> proveedores = null;
            HttpResponseMessage response = await client.GetAsync("proveedores");
            if (response.IsSuccessStatusCode)
            {
                proveedores = await response.Content.ReadFromJsonAsync<IEnumerable<ProveedorDTO>>();
            }
            return proveedores;
        }

        public async static Task AddAsync(ProveedorDTO proveedor)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("proveedores", proveedor);
            response.EnsureSuccessStatusCode();
        }

        public static async Task DeleteAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync("proveedores/" + id);
            response.EnsureSuccessStatusCode();
        }

        public static async Task UpdateAsync(ProveedorDTO proveedor)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync($"proveedores/{proveedor.Id}", proveedor);
            response.EnsureSuccessStatusCode();
        }
    }
}
