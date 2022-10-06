using Hamber.ClienteBlazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;

namespace Hamber.ClienteBlazor.Services
{
    public class CategoriaService : ICategoriaService
    {
        private readonly HttpClient _httpClient;
        public CategoriaService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        JsonSerializerOptions options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        public async Task<IEnumerable<Categoria>> GetAll()

        {
            //var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            string resp = await _httpClient.GetStringAsync($"Categoria");
            return JsonSerializer.Deserialize<IEnumerable<Categoria>>(resp, options);


        }
    }
}
