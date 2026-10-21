//PROGRAMA 2
//PROGRAMA QUE DETERMINE EL VALOR DE UNA POSECION ENTRE (0 Y 40) DE LA SERIE FIBONACCI
using System;
class program
{
    static long Fibonacci(int n)
    {
        if (n <= 1)
            return n;
        return Fibonacci(n - 1) + Fibonacci(n-2);
    }
    static void Main()
    {
        Console.Write("Ingrese la posición: ");
        int n = int.Parse(Console.ReadLine());

        if (n < 0 || n > 40)
        {
            Console.WriteLine("Ingrese un numero de 0 y 40.");
            return;
        }
        Console.WriteLine("Fibonacci:" + Fibonacci(n));
    }
}

