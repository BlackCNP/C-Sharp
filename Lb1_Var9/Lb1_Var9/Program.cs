using System;
namespace Lb1_var9
{
    class Program
    {
        static void Main(string[] args)
        { /* */
            /*S = v0 * t + ½ a * t^2, де S - відстань, v0 - початкова швидкість, а - прискорення, t - час.*/
            string str;
            double V0, t, a, S, S1;
            Console.WriteLine("Поч швидк ");

            str = Console.ReadLine();

            V0 = Convert.ToDouble(str);

            Console.WriteLine("час ");

            str = Console.ReadLine();

            t = Convert.ToDouble(str);

            Console.WriteLine("прискор ");

            str = Console.ReadLine();

            a = Convert.ToDouble(str);
            a = a * 0.5;

            S = V0 * t + a * Math.Pow(t, 2);
            Console.WriteLine($"Вiдстань з прискор= {S}");

            S1 = V0 * t;
            Console.WriteLine($"Вiдстань без прискор {S1}");


        }




    }





}