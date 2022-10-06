using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hamber.ClienteBlazor.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public int IdCategoria { get; set; }
        public int IdMarca { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; }
        public string Precio { get; set; }
        public DateTime Fecha { get; set; }

        public Categoria Categoria { get; set; }

        public Marca Marca { get; set; }
    }
}
