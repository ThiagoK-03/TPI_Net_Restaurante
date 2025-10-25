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
    public class ProductoApi
    {
        private static HttpClient client = new HttpClient();
        static ProductoApi()
        {
            client.BaseAddress = new Uri("http://localhost:5205/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }


        public static async Task<ProductoDTO> GetAsync(int id)
        {
            ProductoDTO producto = null;
            HttpResponseMessage response = await client.GetAsync("productos/" + id);
            if (response.IsSuccessStatusCode)
            {
                producto = await response.Content.ReadFromJsonAsync<ProductoDTO>();
            }
            return producto;
        }

        public static async Task<IEnumerable<ProductoDTO>> GetAllAsync()
        {
            IEnumerable<ProductoDTO> productos = null;
            HttpResponseMessage response = await client.GetAsync("productos");
            if (response.IsSuccessStatusCode)
            {
                productos = await response.Content.ReadFromJsonAsync<IEnumerable<ProductoDTO>>();
            }
            return productos;
        }

        public async static Task AddAsync(ProductoDTO producto)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("productos", producto);
            response.EnsureSuccessStatusCode();
        }

        public static async Task DeleteAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync("productos/" + id);
            response.EnsureSuccessStatusCode();
        }

        public static async Task UpdateAsync(ProductoDTO producto)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync("productos", producto);
            response.EnsureSuccessStatusCode();
        }
    }
}
