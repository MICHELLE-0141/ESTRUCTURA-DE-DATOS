//PROGRAMA 7
//Determinar si un numero entero no negativo es par o impar
/*Como funciona?
 EsPar() llama es EImpar()
EsImpar () Llama EsPar()
El proceso termina cuando el numero llega a cero*/
using System;
using System.Reflection.Metadata.Ecma335;
class Program
{
    static bool EsPar(int n)
    {
        if (n == 0)
            return true;
        return EsImpar(n - 1);

    }
    static bool EsImpar(int n)
    {
        if (n == 0)
            return false;
        return EsPar(n - 1);

    }
    static void Main()
    {
        Console.Write("Ingresa un numero: ");
        int n = int.Parse(Console.ReadLine());

        if(n<0 || n > 10000)
        {
            Console.WriteLine("Ingresa un numero entre 0 y 10000.");
            return;

        }
        if (EsPar(n))
            Console.WriteLine("Es numero par.");
        else
            Console.WriteLine("El numero es impar.");
    }
}