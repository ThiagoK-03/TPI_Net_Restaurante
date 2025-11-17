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
    public class IngredienteApi
    {
        private static HttpClient client = new HttpClient();
        static IngredienteApi()
        {
            client.BaseAddress = new Uri("http://localhost:5205/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }


        public static async Task<IngredienteDTO> GetAsync(int id)
        {
            IngredienteDTO ingrediente = null;
            HttpResponseMessage response = await client.GetAsync("ingredientes/" + id);
            if (response.IsSuccessStatusCode)
            {
                ingrediente = await response.Content.ReadFromJsonAsync<IngredienteDTO>();
            }
            return ingrediente;
        }

        public static async Task<IEnumerable<IngredienteDTO>> GetAllAsync()
        {
            IEnumerable<IngredienteDTO> ingredientes = null;
            HttpResponseMessage response = await client.GetAsync("ingredientes");
            if (response.IsSuccessStatusCode)
            {
                ingredientes = await response.Content.ReadFromJsonAsync<IEnumerable<IngredienteDTO>>();
            }
            return ingredientes;
        }

        public async static Task AddAsync(IngredienteDTO ingrediente)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("ingredientes", ingrediente);
            response.EnsureSuccessStatusCode();
        }

        public static async Task DeleteAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync("ingredientes/" + id);
            response.EnsureSuccessStatusCode();
        }

        public static async Task UpdateAsync(IngredienteDTO ingrediente)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync($"ingredientes/{ingrediente.Id}", ingrediente);
            response.EnsureSuccessStatusCode();
        }
    }
}
