//PROGRAMA 4
//CALCULAR LA POTENCIA ENTERA NO NEGATIVA UTILIZANDO RECURSIVIDAD.

using System;

class Program
{
    static long Potencia(int baseNum, int exponente)
    {
        if (exponente == 0)
            return 1;

        return baseNum * Potencia(baseNum, exponente - 1);
    }
    static void Main()
    {
        Console.Write("Ingrese la base: ");
        int baseNum = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el exponente (0 a 30): ");
        int exponente = int.Parse(Console.ReadLine());

        if(exponente < 0 || exponente > 30)
        {
            Console.WriteLine("Exponente fuera de rango. ");
            return;
        }
        Console.WriteLine("Resultado: " + Potencia(baseNum, exponente));

    }
}