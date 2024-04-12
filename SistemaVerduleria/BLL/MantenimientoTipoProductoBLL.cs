using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{

    //Capa de Lógica empresarial BLL
    public class MantenimientoTipoProductoBLL
    {
        public void InsertaTipoProducto(string Nombre, string TipoProducto, string TipoPrecio, int Cantidad, decimal Precio)
        {
            // Agrega un productoo

            MantenimientoTipoProductoDAL TipoProductoDAL = new MantenimientoTipoProductoDAL();
            TipoProductoDAL.InsertaTipoProducto(Nombre, TipoProducto, TipoPrecio, Cantidad, Precio);

        }

        public void ActualizaTipoProducto(string Nombre, string TipoProducto, string TipoPrecio, int Cantidad, decimal Precio)
        {
            //Realiza cambios a los productos

            MantenimientoTipoProductoDAL TipoProductoDAL = new MantenimientoTipoProductoDAL();
            TipoProductoDAL.ActualizaTipoProducto(Nombre, TipoProducto, TipoPrecio, Cantidad, Precio);

        }

        public bool ValidaExistenciaProducto(string nombre)
        {
            //Determina si hay existencias

            MantenimientoTipoProductoDAL Producto = new MantenimientoTipoProductoDAL();

            return Producto.ValidaExistenciaProducto(nombre);
        }
    }
}
