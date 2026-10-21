//PROGRAMA 10 
///CONVERTIR UN NUMERO ENTERO NO NEGATIVO A SU REPRESENTACION BINARIA USANDO DOS METODOS QUE SE LLAMAM MUTUAMENTE
//RECURSIVIDAD INDIRECTA 
using System;

class Program
{
    static void BinarioA(int n)
    {
        if(n<2)
        {
            Console.Write(n);
            return;

        }

        BinarioB(n / 2);
        Console.Write(n % 2);
    }
    static void BinarioB(int n )
    {
        if(n < 2)
        {
            Console.Write(n);
            return;
        }

        BinarioA(n / 2);
        Console.Write(n % 2);
    }
    static void Main()
    {
        Console.Write("Ingresa un numero entero: ");
        int n = int.Parse(Console.ReadLine());

        if(n < 0)
        {
            Console.WriteLine("Ingresa un numero no negativo: ");
            return;

        }

        Console.Write("Binario: ");

        if (n == 0)
            Console.Write("0");
        else
            BinarioA(n);

        Console.WriteLine();
    }
}
