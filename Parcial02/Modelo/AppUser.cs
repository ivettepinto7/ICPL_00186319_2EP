namespace Parcial02.Modelo
{
    public class AppUser
    {
        public int idUser { get; set; }
        public string fullname { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public bool userType { get; set; }

        public AppUser()
        {
            idUser = -1;
            fullname = "";
            username = "";
            password = "";
            userType = false;
        }
    }
}