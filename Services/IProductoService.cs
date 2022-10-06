using Hamber.ClienteBlazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hamber.ClienteBlazor.Services
{
    public interface IProductoService
    {
        Task<IEnumerable<Producto>>GetAll();
        Task<IEnumerable<Producto>> GetByCategoria(int idCateg);
        Task<IEnumerable<Producto>> GetByMarca(int idMarc);
        Task<Producto> GetById(int id);

    }
}
