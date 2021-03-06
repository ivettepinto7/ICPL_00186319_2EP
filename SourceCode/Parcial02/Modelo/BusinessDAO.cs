﻿using System;
using System.Data;
using System.Collections.Generic;
namespace Parcial02.Modelo
{
    public static class BusinessDAO
    {
        public static List<Business> GetLista()
        {
            string sql = "SELECT * FROM business";

            DataTable dt = ConnectionDB.ExecuteQuery(sql);
            
            List<Business> lista = new List<Business>();
            foreach (DataRow fila in dt.Rows)
            { 
                Business b = new Business();
                b.idBusiness = Convert.ToInt32(fila[0].ToString());
                b.name = fila[1].ToString();
                b.description = fila[2].ToString();

                lista.Add(b);
            }

            return lista;
        }
        
        public static void CrearNuevoNeg(string name, string description)
        {
            string sql = string.Format(
                "INSERT INTO business(name, description)VALUES ('{0}', '{1}');",
                name, description);
            
            ConnectionDB.ExecuteNonQuery(sql);
        }
    }
}