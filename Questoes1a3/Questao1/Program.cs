namespace Questao1
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 100; i++)
                if (NumeroPrimo(i))
                    Console.WriteLine(i);

            Console.ReadKey();
        }

        public static bool NumeroPrimo(int numero)
        {
            if (numero == 1)
                return true;

            for (int i = 2; i * i <= numero; i++)
                if (numero % i == 0)
                    return false;

            return true;
        }
    }
}
