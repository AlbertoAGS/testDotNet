// es numero primo:
using Tests;

// Console.Write("Ingrese un número: ");
// int numero = int.Parse(Console.ReadLine());
// numerosPrimos nroPrimo = new numerosPrimos();
// nroPrimo.verificarPrimo(numero);


// lista de núermos primos hasta N
Console.Write("Ingrese la cantidad de numeros primos a generar: ");
int numero = int.Parse(Console.ReadLine());
Console.Write($"Los núemros primos hasta {numero} son:");
ListaNumerosPrimos listaNroPrimo = new ListaNumerosPrimos();
listaNroPrimo.otenerListaPrimos(numero);
