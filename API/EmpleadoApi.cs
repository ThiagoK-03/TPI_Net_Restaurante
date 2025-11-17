using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOs;

namespace API
{
    using System.Net.Http.Headers;
    using System.Net.Http.Json;
    using DTOs;

    public class EmpleadoApi
    {
        private static HttpClient client = new HttpClient();

        static EmpleadoApi()
        {
            client.BaseAddress = new Uri("http://localhost:5205/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static async Task<EmpleadoDto?> GetAsync(int id)
        {
            EmpleadoDto? empleado = null;
            HttpResponseMessage response = await client.GetAsync("empleados/" + id);
            if (response.IsSuccessStatusCode)
            {
                empleado = await response.Content.ReadFromJsonAsync<EmpleadoDto>();
            }
            return empleado;
        }

        public static async Task<IEnumerable<EmpleadoDto>?> GetAllAsync()
        {
            IEnumerable<EmpleadoDto>? empleados = null;
            HttpResponseMessage response = await client.GetAsync("empleados");
            if (response.IsSuccessStatusCode)
            {
                empleados = await response.Content.ReadFromJsonAsync<IEnumerable<EmpleadoDto>>();
            }
            return empleados;
        }

        public static async Task AddAsync(EmpleadoDto empleado)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("empleados", empleado);
            response.EnsureSuccessStatusCode();
        }

        public static async Task DeleteAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync("empleados/" + id);
            response.EnsureSuccessStatusCode();
        }

        public static async Task UpdateAsync(EmpleadoDto empleado)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync($"empleados/{empleado.Id}", empleado);
            response.EnsureSuccessStatusCode();
        }
    }

}
