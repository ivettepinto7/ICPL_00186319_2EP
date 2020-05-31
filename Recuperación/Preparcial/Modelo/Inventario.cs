using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preparcial.Modelo
{
    public class Inventario
    {
        //Corrección: agregar modificador de acceso
         public string idArticulo { get; }
         //Corrección: agregar modificador de acceso
         public string producto { get; }
         //Corrección: agregar modificador de acceso
         public string descripcion { get; }
         //Corrección: agregar modificador de acceso
         public string precio { get; }
         //Corrección: agregar modificador de acceso
         public string stock { get; }

        //Corrección: orden de parámetros
        public Inventario(string idArticulo, string producto, string precio, string descripcion, string stock)
        {
            this.idArticulo = idArticulo;
            this.producto = producto;
            this.descripcion = descripcion;
            this.precio = precio;
            this.stock = stock;
        }
    }
}
