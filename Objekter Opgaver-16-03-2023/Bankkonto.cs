using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Objekter_Opgaver_16_03_2023
{
    public class Bankkonto
    {
        private  decimal saldo { get;  set; } = 1000; 

        public void Skrivsaldo()
        {
            Console.Write(this.saldo.ToString());
        }

        public void withdrawl(decimal input)
        {
            if(input < 0)
            {
                Console.WriteLine("du kan ikke udtrække minus");
            }
            if (input > 0)
            {


                if (saldo - input < 0)
                {
                    Console.WriteLine("du har ikke nok dollares til at hæve makker");
                }
                if (saldo - input > 0)
                {
                    Console.WriteLine($"du har hævet {input} fra din konto og du har {saldo - input} tilbage");
                    saldo -= input;
                }
            }
            
        }
        public Bankkonto(decimal saldo)
        {
           this.saldo = saldo;
        }

        public  void deposit(decimal input)
        {
            if(input < 0)
            {
                Console.WriteLine("du kan ikke sætte minus ind");
            }
            else { Console.WriteLine($"du har sat {input} ind på din konto og den har en ny slado af {saldo + input}"); saldo += input;
            }
        }

    }
}
