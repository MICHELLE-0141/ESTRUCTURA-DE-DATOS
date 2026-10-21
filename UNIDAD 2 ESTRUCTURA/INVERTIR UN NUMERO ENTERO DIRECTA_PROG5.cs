//PROGRAMA 5
//Invertir el orden de los digitos de un numero entero positivo

using System;

class Program
{
    static long Invertir(long n, long resultado = 0)
    {
        if (n == 0)
            return resultado;

        return Invertir(n / 10, resultado * 10 + n % 10);

    }
    static void Main()
    {
        Console.Write("Ingresa un numero positivo: ");
        long n = long.Parse(Console.ReadLine());

        if(n < 0)

        {
            Console.Write("Elm numero debe ser positivo");
            return;
        }

        Console.WriteLine("Numero invertuido: " +
            Invertir(n));

    }
}
