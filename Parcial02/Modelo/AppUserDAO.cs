using System;
using System.Collections.Generic;
using System.Data;

namespace Parcial02.Modelo
{
    public static class AppUserDAO
    {
        public static AppUser GetUsuario(string user, string password)
        {
            string sql = string.Format(
                "SELECT * FROM appuser WHERE username='{0}' AND password='{1}';",
                user, password);

            DataTable dt = ConnectionDB.ExecuteQuery(sql);
            
            AppUser u = new AppUser();
            foreach (DataRow fila in dt.Rows)
            {
                u.username = fila[1].ToString();
                u.password = fila[2].ToString();
            }

            return u;
        }
        public static List<AppUser> GetLista()
        {
            string sql = "SELECT * FROM appuser";

            DataTable dt = ConnectionDB.ExecuteQuery(sql);
            
            List<AppUser> lista = new List<AppUser>();
            foreach (DataRow fila in dt.Rows)
            {
                AppUser u = new AppUser();
                u.fullname = fila[0].ToString();
                u.username = fila[1].ToString();
                u.password = fila[2].ToString();
                u.userType = Convert.ToBoolean(fila[3].ToString());
                
                lista.Add(u);
            }

            return lista;
        }

        public static void ActualizarContra(string usuario, string ncontra)
        {
            string sql = string.Format(
                "UPDATE appuser SET password='{0}' WHERE idUser={1}",
                ncontra, usuario);
            
            ConnectionDB.ExecuteNonQuery(sql);
        }
    }
}