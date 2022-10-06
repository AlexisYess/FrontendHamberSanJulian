using Hamber.ClienteBlazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Hamber.ClienteBlazor.Services
{
    public class ClienteService : IClienteService
    {
        private readonly HttpClient _httpClient;
        public ClienteService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<Cliente>> GetAll()
        {
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var resp =  await _httpClient.GetStringAsync($"Cliente");
            return JsonSerializer.Deserialize<IEnumerable<Cliente>>(resp, options);
        }
    }
}
