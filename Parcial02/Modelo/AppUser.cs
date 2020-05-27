namespace Parcial02.Modelo
{
    public class AppUser
    {
        public string fullname { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public bool userType { get; set; }

        public AppUser()
        {
            fullname = "";
            username = "";
            password = "";
            userType = false;
        }
    }
}