using System;
using System.Collections.Generic;
using System.Data;

namespace Parcial02.Modelo
{
    public static class AppUserDAO
    {
        public static AppUser GetUsuario(string usuario, string contra)
        {
            string sql = string.Format(
                "SELECT * FROM appuser WHERE username='{0}' AND password='{1}';",
                usuario, contra);

            DataTable dt = ConnectionDB.ExecuteQuery(sql);
            
            AppUser u = new AppUser();
            foreach (DataRow fila in dt.Rows)
            {
                u.idUser = Convert.ToInt32(fila[0].ToString());
                u.fullname = fila[1].ToString();
                u.username = fila[2].ToString();
                u.password = fila[3].ToString();
                u.userType = Convert.ToBoolean(fila[4].ToString());
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
                u.idUser = Convert.ToInt32(fila[0].ToString());
                u.fullname = fila[1].ToString();
                u.username = fila[2].ToString();
                u.password = fila[3].ToString();
                u.userType = Convert.ToBoolean(fila[4].ToString());
                
                lista.Add(u);
            }

            return lista;
        }

        public static void ActualizarContra(int iduser, string ncontra)
        {
            string sql = string.Format(
                "UPDATE appuser SET password='{0}' WHERE idUser={1};",
                ncontra, iduser);
            
            ConnectionDB.ExecuteNonQuery(sql);
        }

        public static void CrearNuevo(string fullname, string username,string password, bool usertype)
        {
            string sql = string.Format(
                "INSERT INTO appuser(fullname, username, password, userType) VALUES('{0}', '{1}', '{2}', {3});",
                fullname, username,password, usertype ? "true" : "false");
            
            ConnectionDB.ExecuteNonQuery(sql);
        }

        public static void EliminarUsuario(int iduser)
        {
            string sql = string.Format(
                "DELETE FROM appuser WHERE idUser={0};",
                iduser);
            ConnectionDB.ExecuteNonQuery(sql);
        }
    }
}