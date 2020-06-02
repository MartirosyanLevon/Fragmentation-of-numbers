using System;

namespace Fragmentation_of_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please write a digit (from 1 to 1234567890) = ");
            int m = Convert.ToInt32(Console.ReadLine());
            int tvanshan = 0;
            int mm = m;
            int k = 0;

            while (m > 0)
            {
                m = m / 10;
                k++;
            }
            Console.WriteLine("The numbre of digits = " + k);

            int kk = 1;
            for (int i = 1; i < k; i++)
            {
                kk = kk *= 10;
            }
            Console.WriteLine("The order of the digits = " + kk);



            for (int i = 0; i < k; i++)
            {
                tvanshan = mm / kk;
                mm = mm % kk;
                kk = kk / 10;
                Console.Write(tvanshan + " ");
            }

            Console.WriteLine();

        }
    }
}
