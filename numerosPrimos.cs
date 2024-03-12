using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tests
{
    public class numerosPrimos
    {
        public numerosPrimos()
        {
        }

        public void verificarPrimo(int numero)
        {            
            int divisor = 0;
            for (int i = 1; i < numero+1; i++)
                if (numero % i == 0)
                    divisor = ++ divisor;

            if (divisor == 2)
                Console.WriteLine($"El número {numero} es primo");
            else
                Console.WriteLine( $"El número {numero} NO es primo");
        }
    }
}