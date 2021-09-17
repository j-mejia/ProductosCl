using Productos.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Productos.Datos
{
    public class ProductoAdmin : Conexion
    {
        public void Guardar(ProductoModel modelo)
        {
            Conectar();
            try
            {
                SqlCommand comando = new SqlCommand("GuardarProductos", cnn);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add(new SqlParameter("@id_marca", modelo.id_marca));
                comando.Parameters.Add(new SqlParameter("@id_prese", modelo.id_presentacion));
                comando.Parameters.Add(new SqlParameter("@id_prov", modelo.id_proveedor));
                comando.Parameters.Add(new SqlParameter("@id_zona", modelo.id_zona));
                comando.Parameters.Add(new SqlParameter("@cod", modelo.codigo));
                comando.Parameters.Add(new SqlParameter("@dscprod", modelo.descripcion_producto));
                comando.Parameters.Add(new SqlParameter("@precio", modelo.precio));
                comando.Parameters.Add(new SqlParameter("@stock", modelo.stock));
                comando.Parameters.Add(new SqlParameter("@iva", modelo.iva));
                comando.Parameters.Add(new SqlParameter("@peso", modelo.peso));
                comando.ExecuteNonQuery();
                comando.Dispose();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                Desconectar();
            }
        }

        public void Editar(ProductoModel modelo)
        {
            Conectar();
            try
            {
                SqlCommand comando = new SqlCommand("EditarProductos", cnn);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add(new SqlParameter("@id_prod", modelo.id_producto));
                comando.Parameters.Add(new SqlParameter("@id_marca", modelo.id_marca));
                comando.Parameters.Add(new SqlParameter("@id_prese", modelo.id_presentacion));
                comando.Parameters.Add(new SqlParameter("@id_prov", modelo.id_proveedor));
                comando.Parameters.Add(new SqlParameter("@id_zona", modelo.id_zona));
                comando.Parameters.Add(new SqlParameter("@cod", modelo.codigo));
                comando.Parameters.Add(new SqlParameter("@dscprod", modelo.descripcion_producto));
                comando.Parameters.Add(new SqlParameter("@precio", modelo.precio));
                comando.Parameters.Add(new SqlParameter("@stock", modelo.stock));
                comando.Parameters.Add(new SqlParameter("@iva", modelo.iva));
                comando.Parameters.Add(new SqlParameter("@peso", modelo.peso));
                comando.ExecuteNonQuery();
                comando.Dispose();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                Desconectar();
            }
        }

        public void Eliminar(ProductoModel modelo)
        {
            Conectar();
            try
            {
                SqlCommand comando = new SqlCommand("EliminarProductos", cnn);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add(new SqlParameter("@id_prod", modelo.id_producto));

                comando.ExecuteNonQuery();
                comando.Dispose();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                Desconectar();
            }
        }

        public List<ProductoModel> Consultar ()
        {
            
            List<ProductoModel> lista = new List<ProductoModel>();
            Conectar();
            try
            {
                SqlCommand comando = new SqlCommand("ConsultaProductos", cnn);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    ProductoModel modelo = new ProductoModel()
                    {
                        id_producto = int.Parse(lector[0].ToString()),
                        id_marca = int.Parse(lector[1]+""),
                        id_presentacion = int.Parse(lector[2] + ""),
                        id_proveedor = int.Parse(lector[3] + ""),
                        id_zona = int.Parse(lector[4] + ""),
                        codigo = int.Parse(lector[5] + ""),
                        descripcion_producto = lector[6] + "",
                        precio = float.Parse(lector[7] + ""),
                        stock = int.Parse(lector[8] + ""),
                        iva = int.Parse(lector[9] + ""),
                        peso = float.Parse(lector[10] + "")
                    };
                    lista.Add(modelo);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                Desconectar();
            }
            return lista;
        }
    }
}