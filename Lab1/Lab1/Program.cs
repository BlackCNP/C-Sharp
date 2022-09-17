using System;
namespace Lab1
{
    class Program
    {
        static void Main(string[] arg)
        {


            {

                double U;
                double I;
                double R;
                Console.WriteLine("Введiть I");
                I =double.Parse(Console.ReadLine());
                Console.WriteLine("Введiть R");
                R = double.Parse(Console.ReadLine());
                U = I * R;
                Console.WriteLine($"Сила струму U= {U}");



            }
        }
    }
}



