namespace Parcial02.Modelo
{
    public class Business
    {
        public int idBusiness { get; set; }
        public string name { get; ste; }
        public string description { get; set; }

        public Business()
        {
            idBusiness = -1;
            name = "";
            description = "";
        }
    }
}