using Hamber.ClienteBlazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hamber.ClienteBlazor.Services
{
    public interface IClienteService
    {
        Task<IEnumerable<Cliente>> GetAll();
    }
}
