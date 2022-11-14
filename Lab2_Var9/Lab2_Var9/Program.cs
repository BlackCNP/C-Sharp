using System;
namespace Lab2
{
    class Program     /*Варіант 9 */
    {
        static void Main()
        {
            int nn;
            int nk;
            int k;
            double res = 0;
            nn = int.Parse(Console.ReadLine());
            nk = int.Parse(Console.ReadLine());
            for (k = nn; k <= nk; k++)
            {
                res +=(Math.Pow(k, 2)-(Math.Pow(-1,Math.Pow(k,2)+1))*k)/(Math.Pow(k,2)-2);
            }

            Console.WriteLine($"res={res}");
           


        }

    }
}