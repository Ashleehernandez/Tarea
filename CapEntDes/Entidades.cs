namespace CapEntDes
{
    public class Entidades
    {
        string Mail { get; set; }
        string Ful_Name { get; set; }
        string Carrera { get; set; }
        string Password { get; set; }

        public Entidades(string mail , string full_name , string carrera , string password)
        {
            this.Mail = mail;
            this.Ful_Name = full_name;
            this.Carrera = carrera;
            this.Password = password;
        }
    }
}
