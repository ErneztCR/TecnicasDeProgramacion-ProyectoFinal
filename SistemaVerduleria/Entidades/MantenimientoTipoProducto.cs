using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MantenimientoTipoProducto
    {
        //Se dejan las variables con mayuscula para que no haya conflictos con las otras variables
        public String Nombre { set; get; }
        public String TipoProducto { set; get; }
        public String TipoPrecio { set; get; }
        public int Cantidad { set; get; }
        public float Precio { set; get; }
    }
}
