using System.Collections.Generic;
using System.Data;
using System;
using Npgsql;

namespace Parcial02.Modelo
{
    public class AppOrderDAO
    {
         public static List<AppOrder> GetOrders(int idorder)
        {
            List <AppOrder> lista= new List<AppOrder>();
            
            string sql =$"SELECT ao.idOrder, ao.createDate, pr.name, au.fullname, ad.addres FROM apporder ao, address ad, product pr, appuser au WHERE ao.idProduct=pr.idProduct AND ao.idAddress=ad.idAddress AND ad.idUser=au.idUser AND au.idUser={idorder} ;";
                DataTable dt = ConnectionDB.ExecuteQuery(sql);
                foreach (DataRow fila in dt.Rows)
                {
                    AppOrder ao = new AppOrder();
                    ao.idOrder = Convert.ToInt32(fila[0].ToString());
                    ao.createDate = Convert.ToDateTime(fila[1].ToString());
                    ao.product= fila[2].ToString();
                    ao.nombre = fila[3].ToString();
                    ao.address = fila[4].ToString(); 
                    lista.Add(ao);
                }
                return lista;
        }
         
         public static List<AppOrder> GetLista()
         {
             List <AppOrder> lista = new List<AppOrder>();
             string sql ="SELECT ao.idOrder, ao.createDate, pr.name, au.fullname, ad.address FROM apporder ao, address ad, product pr, appuser au WHERE ao.idProduct = pr.idProduct AND ao.idAddress = ad.idAddress AND ad.idUser = au.idUser;";
             DataTable dt = ConnectionDB.ExecuteQuery(sql);
             foreach (DataRow fila in dt.Rows)
             {
                 AppOrder o = new AppOrder();
                 o.idOrder= Convert.ToInt32(fila[0].ToString());
                 o.createDate= Convert.ToDateTime(fila[1].ToString());
                 o.product= fila[2].ToString();
                 o.nombre = fila[3].ToString();
                 o.address = fila[4].ToString(); 
                 lista.Add(o);
             }
             return lista;
         }
         
        
        public static void EliminarOrden(int idorder)
        {
            string sql = String.Format(
                "DELETE FROM apporder WHERE idorder={0};",
                    idorder);
                
            ConnectionDB.ExecuteNonQuery(sql);
        }
        
        public static void AgregarOrden(DateTime date,int idprod,int idadress)
        {
            string sql = String.Format(
                "INSERT INTO apporder(createdate,idproduct,idaddress)VALUES('{0}',{1},{2})", 
                date,idprod, idadress);
                
            ConnectionDB.ExecuteNonQuery(sql);
        }
    }
}