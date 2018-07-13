namespace Questao2
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int number = 10;

            if (ContainsNumber(vector,number))
                Console.WriteLine($"o Numero: {number} pertence ao vetor");
            else
                Console.WriteLine($"o Numero: {number} não pertence ao vetor");

            Console.ReadKey();
        }

        public static bool ContainsNumber(int[] vector, int number)
        {
            int m;
            int e = 0;
            int d = vector.Length - 1;

            while (e <= d)
            {
                m = (e + d) / 2;
                if (vector[m] == number)
                    return true;

                if (vector[m] < number)
                    e = m + 1;
                else
                    d = m - 1;
            }

            return false;
        }
    }
}
