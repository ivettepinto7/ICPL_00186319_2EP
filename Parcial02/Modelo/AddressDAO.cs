using System;
using System.Data;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using Npgsql;
namespace Parcial02.Modelo
{
    public static class AddressDAO
    {
        public static List<Address> GetLista()
        {
            string sql = "SELECT * FROM address";

            DataTable dt = ConnectionDB.ExecuteQuery(sql);
            
            List<Address> lista = new List<Address>();
            foreach (DataRow fila in dt.Rows)
            {
                Address a = new Address();
                a.idAddress = Convert.ToInt32(fila[0].ToString());
                a.idUser = Convert.ToInt32(fila[1].ToString());
                a.address = fila[2].ToString();

                lista.Add(a);
            }

            return lista;
        }
        
        public static void CrearNueva(int idUser, string address)
        {
            string sql = string.Format(
                "INSERT INTO address(idUser, address) VALUES({0}, '{1}');",
                idUser, address);
            
            ConnectionDB.ExecuteNonQuery(sql);
        }

        public static void ActualizarDire(int idaddress, string naddress)
        {
            string sql = string.Format(
                "UPDATE address SET address='{0}' WHERE idAddress = {1};",
                naddress, idaddress);
            
            ConnectionDB.ExecuteNonQuery(sql);
        }

        public static void EliminarDire(int idaddress, string address)
        {
            string sql = string.Format(
                "DELETE FROM address WHERE idAddress = {0};",
                idaddress,address);
            ConnectionDB.ExecuteNonQuery(sql);
        }
    }
}