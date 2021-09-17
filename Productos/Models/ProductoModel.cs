using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Productos.Models
{
    public class ProductoModel
    {
        public int id_producto { get; set; }
        public int id_marca { get; set; }
        public int id_presentacion { get; set; }
        public int id_proveedor { get; set; }
        public int id_zona { get; set; }
        public int codigo { get; set; }
        public string descripcion_producto { get; set; } 
        public float precio { get; set; }
        public int stock { get; set; }
        public int iva { get; set; }
        public float peso { get; set; }
    }
}