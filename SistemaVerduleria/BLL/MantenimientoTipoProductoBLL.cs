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
        public void InsertaTipoProducto(string nombre, string tipoProducto, string tipoPrecio, int cantidad, decimal precio)
        {
            // Agrega un producto

            MantenimientoTipoProductoDAL TipoProductoDAL = new MantenimientoTipoProductoDAL();
            TipoProductoDAL.InsertaTipoProducto(nombre, tipoProducto, tipoPrecio, cantidad, precio);

        }

        public void ActualizaTipoProducto(string nombre, string tipoProducto, string tipoPrecio, int cantidad, decimal precio)
        {
            //Realiza cambios a los productos

            MantenimientoTipoProductoDAL TipoProductoDAL = new MantenimientoTipoProductoDAL();
            TipoProductoDAL.ActualizaTipoProducto(nombre, tipoProducto, tipoPrecio, cantidad, precio);

        }

        public bool ValidaExistenciaProducto(string nombre)
        {
            //Determina si hay existencias

            MantenimientoTipoProductoDAL Producto = new MantenimientoTipoProductoDAL();

            return Producto.ValidaExistenciaProducto(nombre);
        }
    }
}
