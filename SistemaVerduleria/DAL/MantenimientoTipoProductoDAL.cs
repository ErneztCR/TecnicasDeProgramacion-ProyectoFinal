using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    //Capa de acceso a datos DAL
    public class MantenimientoTipoProductoDAL
    {
        public void InsertaTipoProducto(string nombre, string tipoProducto, string tipoPrecio, int cantidad, decimal precio)
        {

            DataBaseDAL db = new DataBaseDAL();
            SqlCommand comando = new SqlCommand("SP_RegistraTipoProducto");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@Nombre", nombre);
            comando.Parameters.AddWithValue("@TipoProducto", tipoProducto);
            comando.Parameters.AddWithValue("@TipoPrecio", tipoPrecio);
            comando.Parameters.AddWithValue("@Cantidad", cantidad);
            comando.Parameters.AddWithValue("@Precio", precio);

            db.InsercionDatos(comando);
        }

        public void ActualizaTipoProducto(string nombre, string tipoProducto, string tipoPrecio, int cantidad, decimal precio)
        {

            DataBaseDAL db = new DataBaseDAL();
            SqlCommand comando = new SqlCommand("SP_ActualizaTipoProducto");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@Nombre", nombre);
            comando.Parameters.AddWithValue("@TipoProducto", tipoProducto);
            comando.Parameters.AddWithValue("@TipoPrecio", tipoPrecio);
            comando.Parameters.AddWithValue("@Cantidad", cantidad);
            comando.Parameters.AddWithValue("@Precio", precio);

            db.InsercionDatos(comando);
        }

        public bool ValidaExistenciaProducto(string nombre)
        {
            bool existe;

            DataBaseDAL db = new DataBaseDAL();
            SqlCommand comando = new SqlCommand("SP_ConsultaExistenciaProducto");
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", nombre);

            DataSet ds = db.LecturaDatos(comando, "[T_Productos]");

            if (ds.Tables[0].Rows.Count == 0)
            {
                existe = false;
            }
            else
            {
                existe = true;
            }

            return existe;
        }
    }
}
