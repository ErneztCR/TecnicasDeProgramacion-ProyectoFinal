using System;
using DAL;

namespace BLL
{
    // Capa de Lógica Empresarial (BLL)
    public class MantenimientoTipoProductoBLL
    {
        private readonly MantenimientoTipoProductoDAL _tipoProductoDAL;

        public MantenimientoTipoProductoBLL()
        {
            _tipoProductoDAL = new MantenimientoTipoProductoDAL();
        }

        public void InsertarTipoProducto(string nombre, string tipoProducto, string tipoPrecio, int cantidad, decimal precio)
        {
            // Agrega un producto
            _tipoProductoDAL.InsertaTipoProducto(nombre, tipoProducto, tipoPrecio, cantidad, precio);
        }

        public void ActualizarTipoProducto(string nombre, string tipoProducto, string tipoPrecio, int cantidad, decimal precio)
        {
            // Realiza cambios a los productos
            _tipoProductoDAL.ActualizaTipoProducto(nombre, tipoProducto, tipoPrecio, cantidad, precio);
        }

        public bool ValidarExistenciaProducto(string nombre)
        {
            // Determina si hay existencias
            return _tipoProductoDAL.ValidaExistenciaProducto(nombre);
        }
    }
}
