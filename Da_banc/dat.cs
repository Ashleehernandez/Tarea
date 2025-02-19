using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using Microsoft.Data.SqlClient;

namespace Da_banc
{
    public class dat
    {


         string Mail  {  get; set; }
        string Ful_Name {  get; set; }
        string Carrera { get; set; }
        string  Password {  get; set; }


        public dat()
        {

        }
        public bool Registrarse(string Mail, string full_name, string carrera, string password)
        {
            ///////////////////////////////////////////////////

            Console.WriteLine("Ingrese el Mail");
            Mail = Console.ReadLine()!;
            if (string.IsNullOrEmpty(Mail))
            {
                Console.WriteLine("la cadena esta bacia ");

            }
            else
            {
                Console.WriteLine("Campo lleno correctamente  ");

            }
            /////////////////////////////////////////

            Console.WriteLine("ingrese su full_name ");
            full_name = Console.ReadLine()!;
            if (string.IsNullOrEmpty(full_name))
            {

                Console.WriteLine("la cadena esta basia ");
            }
            else
            {
                Console.WriteLine("Campo lleno correctamente ");
            }

            //////////////////////////////////////////////////
            Console.WriteLine("ingrese su career  ");
            carrera = Console.ReadLine()!;

            if (string.IsNullOrEmpty(carrera))
            {
                Console.WriteLine("la cadena esta basia ");
            }
            else
            {
                Console.WriteLine("Campo lleno correctamente  ");
            }
            //////////////////////////////////////////////////////////
            Console.WriteLine("ingrese su password ");
            password = (Console.ReadLine()!);
            if (string.IsNullOrEmpty(password))
            {
                Console.WriteLine("la cadena esta basia ");
            }
            else
            {
                Console.WriteLine("campo lleno correctamente ");
            }

            //insertando datos a la tabla 
            string query = $"INSERT INTO Usuario (MAIL,FULL_NAME,CARRER,PASSWORD)VALUES('{Mail}','{full_name}','{carrera}','{password}') ";

            //using 
            using (SqlConnection connection = connecion.getconnection())
            {
                //abriendo la connecion 
                connection.Open();

                //sirve para ejecuctar los comandos 
                SqlCommand cmd = new SqlCommand(query , connection);

                //sirve para ejecutar el query & debuelbe el numero de filas afectadas 
                
                var resur=cmd.ExecuteNonQuery();
                if (resur > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }
        ///////////////////////////////////////////////////////
        
        public bool Iniciodeseccion(string Mail, string password)
        {
            Console.WriteLine("Iniciar Seccion ");

            Console.WriteLine("ingrese su correo");
            Mail = Console.ReadLine()!;


            Console.WriteLine("Ingrese el password ");
            password = (Console.ReadLine()!);

            //select los campos '' de la tabla #
            string query = $"SELECT MAIL,PASSWORD  FROM Usuario WHERE MAIL='{Mail}' AND PASSWORD='{password}';";

            using (SqlConnection connection = connecion.getconnection())
            {
                //abriendo la connecion 
                connection.Open();

                //sirve para ejecuctar los comandos 
                SqlCommand cmd = new SqlCommand(query, connection);

                //para leer los datos de las filas 

                using (SqlDataReader reader = cmd.ExecuteReader()) {

                    if (reader.Read())
                    {
                        
                        return true;

                    }
                    else
                    {
                        Console.WriteLine("Credenciales incorrectas ");
                        return false;
                    }




                }


            }


        }


    }
}
