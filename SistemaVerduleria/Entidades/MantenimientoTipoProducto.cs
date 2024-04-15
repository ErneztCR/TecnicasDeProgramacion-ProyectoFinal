using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MantenimientoTipoProducto
    {
        // Propiedades con nombres en PascalCase para seguir convenciones de estilo
        public string Nombre { get; set; }
        public string TipoProducto { get; set; }
        public string TipoPrecio { get; set; }
        public int Cantidad { get; set; }
        public float Precio { get; set; }
    }
}
