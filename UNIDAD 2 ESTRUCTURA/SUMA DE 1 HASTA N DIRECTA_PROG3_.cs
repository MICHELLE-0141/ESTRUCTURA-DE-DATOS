//PROGRAMA 3
//calcular la suma de todos los numeros enteros dede 1 hasta el número ingresado

using System;

class Program
{
    static int Suma(int n)
    {
        if (n <= 0)
            return 0;

        return n + Suma(n - 1);
    }
    static void Main()
    {
        Console.Write("Ingrese un numero:");
        int n = int.Parse(Console.ReadLine());

        if (n < 0 || n > 10000)
        {
            Console.WriteLine("Ingrese un numero entre 0 y 10000.");
            return;
        }

        Console.WriteLine("La suma es: " + Suma(n));
    }
}

