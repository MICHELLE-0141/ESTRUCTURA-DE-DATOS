# FACTORIAL
FACTORIAL DE UN NUMERO
NOMBRE:ANEL MICHELLE MARTINEZ MARTINEZ
CARRERA:INGENERIA EN SISTEMAS COMPUTACIONALES
MATERIA:ESTRUCTURA DE DATOS

#PROGRAMA 1
###FACTORIAL

class program
{
    static long Factorial(int n)
    {
        if(n == 0) 
            return 1;

        return n * Factorial(n - 1);
    }
    static void Main()
    {
        Console.Write("ingresar un numero:");
        int n = int.Parse(Console.ReadLine());

        if(n<0 || n>20)
        {
            Console.WriteLine("ingresar un numero entero 0 y 20.");
            return;
        }
        Console.WriteLine("Factorial:" + Factorial(n));
    }
}    
