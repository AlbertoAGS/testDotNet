using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tests
{
    public class ListaNumerosPrimos
    {
        public ListaNumerosPrimos()
        {
        }

        public void otenerListaPrimos(int numero)
        {
            for (int i = 1; i < numero+1; i++)
            {
                numerosPrimos nroPrimo = new numerosPrimos();
                nroPrimo.verificarPrimo(i);
            }
        }
    }
}