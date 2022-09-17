using System;
namespace Lab2
{
    class Program
    {
        static void Main()
        {
            int nn;
            int nk;
            int k;
            double res = 0;
            nn = int.Parse(Console.ReadLine());
            nk = int.Parse(Console.ReadLine());
            for(k=nn;k<=nk;k++)
            {
                res+=2* Math.Pow(k,2);
            }
           
            Console.WriteLine($"res={res}");
           


        }

    }
}