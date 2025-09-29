using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using DTOs;

namespace WindowsForms.Pedido
{
  

    internal class PedidoApi
    {
        private static HttpClient client = new HttpClient();

        static PedidoApi()
        {
            client.BaseAddress = new Uri("http://localhost:5205/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static async Task<PedidoDTO> GetAsync(int id)
        {
            PedidoDTO pedido = null;
            HttpResponseMessage response = await client.GetAsync("pedidos/" + id);
            if (response.IsSuccessStatusCode)
            {
                pedido = await response.Content.ReadFromJsonAsync<PedidoDTO>();
            }
            return pedido;
        }

        public static async Task<IEnumerable<PedidoDTO>> GetAllAsync()
        {
            IEnumerable<PedidoDTO> pedidos = null;
            HttpResponseMessage response = await client.GetAsync("pedidos");
            if (response.IsSuccessStatusCode)
            {
                pedidos = await response.Content.ReadFromJsonAsync<IEnumerable<PedidoDTO>>();
            }
            return pedidos;
        }

        public static async Task AddAsync(PedidoDTO pedido)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("pedidos", pedido);
            response.EnsureSuccessStatusCode();
        }

        public static async Task DeleteAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync("pedidos/" + id);
            response.EnsureSuccessStatusCode();
        }

        public static async Task UpdateAsync(PedidoDTO pedido)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync("pedidos", pedido);
            response.EnsureSuccessStatusCode();
        }
    }

}
