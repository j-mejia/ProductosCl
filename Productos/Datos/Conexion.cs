using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Productos.Datos
{
    public class Conexion
    {
        protected SqlConnection cnn;
        protected void Conectar ()
        {
            try
            {
                cnn = new SqlConnection("server=DESKTOP-92Q85IR\\SQLEXPRESS ; database=DB_Inventario ; integrated security = true");
                cnn.Open();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        protected void Desconectar()
        {
            try
            {
                cnn.Close();
                cnn.Dispose();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}