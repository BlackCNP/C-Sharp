using System;
namespace Lab3_V9  //Варіант 9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, sum;
            Console.WriteLine("Напишiть число");
            d = Convert.ToInt32(Console.ReadLine());
            a = d / 100;
            b = (d / 10) - a * 10;
            c = d - ((d / 10) * 10);
            Console.WriteLine($"Перше число= {a}");
            Console.WriteLine($"Друге= {b}") ;
            Console.WriteLine($"Третє= {c}");
            sum = a+b+c;
            Console.WriteLine($"Sum {sum}");
            sum %= 2;
            if (sum == 1)
            {
                Console.WriteLine("Ne parne");
            }
            else
            {
                Console.WriteLine("Parne");
            }





        }



    }



}
