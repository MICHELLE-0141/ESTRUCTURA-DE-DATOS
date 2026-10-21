//PROGRAMA 6
//SUMAR TODOS LOS DIGITOS DE UN NUMERO ENTERO POSITIVO,
//COMO FUNCIONA EL METODO SUMAR DIGITO, SUMA EL ULTIMO DIGITO CON EL RESULTADO DE LLAMARSE A SI MISMO USANDO EL NUMERO SIN ESE DIGITO

using System;

class Program
{
    static int SumarDigitos(int n)
    {
        if(n==0)
            return 0;
        return n % 10 + SumarDigitos(n / 10);
    }

    static void Main()
    {
        Console.Write("Ingresa un numero: ");
        int n = int.Parse(Console.ReadLine()); 

        if(n < 0)
            {
            Console.WriteLine("Ingrese un numero positivo. ");
            return;
        }

        Console.WriteLine("Suma los digitos: " +
            SumarDigitos(n));
    }
}