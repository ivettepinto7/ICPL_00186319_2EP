using System;
using System.Collections.Generic;
using System.Data;
using Npgsql;
using System.Windows.Forms;
namespace Parcial02.Modelo
{
    public static class ProducDAO
    {
        public static List<Product> GetLista()
        {
            List <Product> lista = new List<Product>();
            
            string sql = "SELECT idproduct,name FROM product";
                DataTable dt = ConnectionDB.ExecuteQuery(sql);
                foreach (DataRow fila in dt.Rows)
                {
                    Product p = new Product();
                    p.idProduct = Convert.ToInt32(fila[0].ToString());
                    p.name= fila[1].ToString(); 
                    lista.Add(p);
                }
            return lista;
        }
        
        public static List<Product> GetProdsNeg()
        {
            List <Product> lista= new List<Product>();
            string sql = "SELECT pro.idproduct,bu.name,pro.name FROM product pro, business bu WHERE pro.idbusiness=bu.idbusiness";
                DataTable dt = ConnectionDB.ExecuteQuery(sql);
                foreach (DataRow fila in dt.Rows)
                {
                    Product p = new Product();
                    p.idProduct = Convert.ToInt32(fila[0].ToString());
                    p.name= fila[2].ToString();
                    p.idBusiness = fila[1].ToString(); 
                    lista.Add(p);
                }
                return lista;
        }
        public static void CrearProd(int idbusi,string nombre)
        {
            string sql = String.Format(
                "INSERT INTO product(idbusiness,name) VALUES({0},'{1}');", 
                idbusi, nombre);
                
            ConnectionDB.ExecuteNonQuery(sql);
            
        }
        public static void EliminarProd(int idprod)
        {
            string sql = String.Format(
                "DELETE from product WHERE idproduct={0};",
                    idprod);
                
            ConnectionDB.ExecuteNonQuery(sql);
            
        }
    }
}