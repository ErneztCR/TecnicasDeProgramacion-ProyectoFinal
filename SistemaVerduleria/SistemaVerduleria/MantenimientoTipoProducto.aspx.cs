using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace SistemaVerduleria
{
    public partial class MantenimientoTipoProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            //Variables required for alerts
            Type cstype = this.GetType();
            ClientScriptManager cs = Page.ClientScript;
            string cstext = "";

            //Validate that all fields are completed
            if ((!string.IsNullOrEmpty(txtNombreProducto.Text)) && (!string.IsNullOrEmpty(txtNombreProducto.Text)) &&
                   (!string.IsNullOrEmpty(txtCantidad.Text)) && (ListaTipoPrecio.SelectedValue != "---Seleccione una Opción---") && (ListaTipoProducto.SelectedValue != "---Seleccione una Opción---"))
            {
                string TipoProductoTemp = ListaTipoProducto.SelectedValue.ToString();
                string TipoPrecioTemp = ListaTipoPrecio.Text.ToString();
                int CantidadTemp = Convert.ToInt32(txtCantidad.Text);
                decimal PrecioTemp = Convert.ToDecimal(txtPrecio.Text);

                //Validates that the product type already exists
                MantenimientoTipoProductoBLL ValidaTipoProductoBLL = new MantenimientoTipoProductoBLL();
                bool Validacion = ValidaTipoProductoBLL.ValidaExistenciaProducto(txtNombreProducto.Text);


                if (Validacion == true)
                {
                    //Update the product type
                    MantenimientoTipoProductoBLL TipoProductoBLL = new MantenimientoTipoProductoBLL();
                    TipoProductoBLL.ActualizaTipoProducto(txtNombreProducto.Text, TipoProductoTemp, TipoPrecioTemp, CantidadTemp, PrecioTemp);

                    LimpiaCampos();

                    cstext = "alert('Producto Actualizado Exitosamente');";
                    cs.RegisterStartupScript(cstype, "PopupScript", cstext, true);

                }
                else
                {
                    //Register new product type
                    MantenimientoTipoProductoBLL TipoProductoBLL = new MantenimientoTipoProductoBLL();
                    TipoProductoBLL.InsertaTipoProducto(txtNombreProducto.Text, TipoProductoTemp, TipoPrecioTemp, CantidadTemp, PrecioTemp);

                    LimpiaCampos();

                    cstext = "alert('Se ha agregado correctamente un nuevo producto');";
                    cs.RegisterStartupScript(cstype, "PopupScript", cstext, true);
                }
            }
            cstext = "alert('Debe completar todos los campos para poder almacenar la información');";
            cs.RegisterStartupScript(cstype, "PopupScript", cstext, true);

        }
        private void LimpiaCampos()
        {
            //clears fields post processing
            txtNombreProducto.Text = "";
            txtCantidad.Text = "";
            txtPrecio.Text = "";
            ListaTipoPrecio.SelectedValue = "---Seleccione una Opción---";
            ListaTipoProducto.SelectedValue = "---Seleccione una Opción---";
        }
    }
}