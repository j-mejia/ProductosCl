using Productos.Datos;
using Productos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Productos.Views
{
    public partial class Producto : System.Web.UI.Page
    {
        ProductoAdmin admin = new ProductoAdmin();
        ProductoModel mod = new ProductoModel();
        private void Consultar()
        {
            GridView1.DataSource = admin.Consultar();
            GridView1.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Consultar();
        }

   
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            ProductoModel modelo = new ProductoModel()
            {
                id_marca = int.Parse(tbxMarca.Text),
                id_presentacion = int.Parse(tbxPres.Text),
                id_proveedor = int.Parse(tbxProv.Text),
                id_zona = int.Parse(tbxZona.Text),
                codigo = int.Parse(tbxCod.Text),
                descripcion_producto = txbDesc.Text,
                precio = float.Parse(tbxPrecio.Text),
                stock = int.Parse(tbxStock.Text),
                iva = int.Parse(tbxIVA.Text),
                peso = float.Parse(tbxPeso.Text)

            };
            admin.Guardar(modelo);
            Consultar();
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            ProductoModel modelo = new ProductoModel()
            {
                id_producto = int.Parse(tbxProd.Text),
                id_marca = int.Parse(tbxMarca.Text),
                id_presentacion = int.Parse(tbxPres.Text),
                id_proveedor = int.Parse(tbxProv.Text),
                id_zona = int.Parse(tbxZona.Text),
                codigo = int.Parse(tbxCod.Text),
                descripcion_producto = txbDesc.Text,
                precio = float.Parse(tbxPrecio.Text),
                stock = int.Parse(tbxStock.Text),
                iva = int.Parse(tbxIVA.Text),
                peso = float.Parse(tbxPeso.Text)

            };
            admin.Editar(modelo);
            Consultar();
        }

        protected void tbxProd_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            ProductoModel modelo = new ProductoModel()
            {
                id_producto = int.Parse(tbxProd.Text)
            };
            admin.Eliminar(modelo);
            Consultar();
        }
    }
}