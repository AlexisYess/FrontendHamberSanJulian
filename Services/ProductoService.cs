using Hamber.ClienteBlazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace Hamber.ClienteBlazor.Services
{
    public class ProductoService : IProductoService
    {
        private readonly HttpClient _httpClient;

        public ProductoService (HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        JsonSerializerOptions options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

        public async Task<IEnumerable<Producto>> GetAll()
        {

            string resp = await _httpClient.GetStringAsync($"Producto");
            return JsonSerializer.Deserialize<IEnumerable<Producto>>(resp, options);

        }

        public async Task<IEnumerable<Producto>> GetByCategoria(int idCateg)
        {
            var resp = await _httpClient.PostAsJsonAsync($"Producto/Buscar", new { IdCategoria = idCateg });
            string respstring = await resp.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<IEnumerable<Producto>>(respstring, options);
        }

    

        public  async Task<IEnumerable<Producto>> GetByMarca(int idMarc)
        {
            var resp = await _httpClient.PostAsJsonAsync($"Producto/Buscar", new { IdMarca = idMarc });
            string respstring = await resp.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<IEnumerable<Producto>>(respstring, options);
        }
        public async Task<Producto> GetById(int id)
        {
            string resp = await _httpClient.GetStringAsync($"Producto/{id}");
            return JsonSerializer.Deserialize < Producto > (resp, options);
        }
    }
}
