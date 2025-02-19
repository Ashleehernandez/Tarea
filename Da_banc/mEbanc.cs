using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Da_banc
{
   public class mEbanc
    {
        public mEbanc()
        {
        }

        public void depositar(int cantidad, int total , int saldo )
        {
            //depositar 
            if (cantidad == 0)
            {
                Console.WriteLine("deve de depositar un monto mayor que cero");
            }

            else
            {
                //LLAMAR A SU METO CORRESPONDIENTE  
                cantidad += saldo ;

                total = saldo ;


                Console.WriteLine("Deposito exitoso "+total);
                Console.ReadKey();  
            }


        }
        ///////////////////////////////////////////////////////////

        public void Retirar(int cantidad, int total, int saldo )
        //LLAMAR A SU METO CORRESPONDIENTE  

        {
            if (cantidad > saldo)
            {
                Console.WriteLine("saldo insufisiente  ");
                return;
                
            }
            else
            {
                cantidad -= saldo ;
                total = saldo ;

                Console.WriteLine("Retir Realisado "+cantidad);
                Console.ReadKey();  
            }
        }
        ///////////////////////////////////////////////////////////
        public void SaldoActual(int saldo)
        {
            //LLAMAR A SU METO CORRESPONDIENTE  

            Console.WriteLine("El saldo actual es "+saldo);
        }
        ///////////////////////////////////////////////////////
       
        public void salir()
        {
            Console.WriteLine("saliendo.............");
            return ;
        }
    }
}
