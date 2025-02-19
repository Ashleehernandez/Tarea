using Da_banc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neg_banc
{
    public class MenuBanco
        
    {
        private int cantidad;
        private int total;
        private int saldo;

        public void MenuBancoer()
        {
            int opcion = 0;

            mEbanc methh = new mEbanc();
            do
            {


                switch (opcion)
                {
                    case 1:
                        //LLAMAR A SU METO CORRESPONDIENTE
                        methh.depositar(cantidad, total, saldo);

                        break;

                        case 2:
                        //LLAMAR A SU METO CORRESPONDIENTE
                        methh.Retirar(cantidad, total, saldo);
                        break;

                        case 3:
                        //LLAMAR A SU METO CORRESPONDIENTE  
                        methh.SaldoActual(saldo);
                        break;

                        case 4:
                        //LLAMAR A SU METO CORRESPONDIENTE  

                        methh.salir();
                        break;

                    default:
                        Console.WriteLine("elija una opcion correspondiente ");

                        break;
                }
            }while (true);

        }
    }
}
