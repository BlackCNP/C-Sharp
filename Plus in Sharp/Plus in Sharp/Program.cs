 using System;
namespace T1
{
    class Program           //Ввести числа, знайти Max,min,кількість
    {
        static void Main()
        {
            int max = 0, min = 1, i = 0, count = 0, q = 0;
            
            while (true)
            {
                Console.WriteLine("Введіть Числа: ");
                i = Convert.ToInt32(Console.ReadLine());


                if (i < min)
                {
                    min = i;
                }
                if (i > max)
                {
                    max = i;
                }
                count += (i % 1) + 1;
                q = max - min;
                if (i == 0)
                {
                    break;
                }

            }
            Console.WriteLine($"Скiльки=  {count - 1}");
            Console.WriteLine($"Max=  {max}");
            Console.WriteLine($"Min=  {min}");
            Console.WriteLine($"Рiзниця=  {q}");

        }

    }
}