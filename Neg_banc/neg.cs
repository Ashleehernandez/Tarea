using Da_banc;

namespace Neg_banc
{
    public class neg
    {
        public string password;
        public string Mail;
        public string full_name;
        public string Carrera;
        public string carrera;

        public void menu()
        {
            int opcion = 0;
            do
            {
                // menu 
                dat datt = new dat();
                MenuBanco menuBanco = new MenuBanco();
                

                //validacion de la opcion 
                if (opcion > 0)
                {


                    Console.WriteLine("==BIENVENIDO");

                    switch (opcion)
                    {

                        case 1:
                            // llamar a los metodods correspondiente 

                            if (datt.Iniciodeseccion(Mail, password))
                            {
                                
                            }
                            else
                            {
                                Console.WriteLine("Credenciales incorrectas ");
                                return;
                            }
                            
                            break;

                        case 2:
                            // llamar a los metodos correpondiente 
                            if(datt.Registrarse(Mail, full_name, carrera, password))
                            {

                            }
                            else
                            {
                                Console.WriteLine("Credenciales incorrectas");
                                return;
                            }
                            
                            break;

                        default:
                           
                            return;
                    }

                    menuBanco.MenuBancoer();

                }
                else
                {
                    Console.WriteLine("Elija una opcion mayor que cero ");
                }
            }
            while (true);
            

        }
    }
}


        
    

