using Hamber.ClienteBlazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Hamber.ClienteBlazor.Services
{
    public class MarcaService : IMarcaService
    {
        private readonly HttpClient _httpClient;

        public MarcaService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        JsonSerializerOptions options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        public async Task<IEnumerable<Marca>> GetAll()
        {
            //var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            string resp = await _httpClient.GetStringAsync($"Marca");
            return JsonSerializer.Deserialize<IEnumerable<Marca>>(resp, options);
        }
    }
}
