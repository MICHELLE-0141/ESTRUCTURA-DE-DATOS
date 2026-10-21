//PROGRAMA 1
//calcular el factorial mayor de 0 a 20 

    class program
{
    static long Factorial(int n)
    {
        if (n==0)
            return 1;
        return n * Factorial (n - 1);
    }
    static void Main()
    {
        Console.Write("Ingrese un numero: ");
        int n = int.Parse(Console.ReadLine());

        if(n < 0 || n > 20)
        {
            Console.WriteLine("Ingrese un numero de 0 y 20.");
            return;
        }
        Console.WriteLine("Factorial:" + Factorial(n));
    }
}
