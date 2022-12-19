using System;

namespace Lab7_Var9
{
    class Program
    {
        static void Main(string[] args)
        {
            int K;
            int size;
            int a = 0;
            int b = 0;
            int n = 0;
            List<int> list = new List<int>();
            do
            {
                Console.Write("Розмiр списка:");
                size = int.Parse(Console.ReadLine());
                if (size < 1)
                    Console.WriteLine("Список повинен бути >0");
            } while (size < 1);
            int N = size;
            int[] arr = new int[N];
            do
            {
                do
                {
                    Console.Write("Числа якi потрiбно добавити в список(1 чи 2):");
                    K = int.Parse(Console.ReadLine());
                    if ((K != 1) && (K != 2))
                        Console.WriteLine("Числа повиннi бути 1 та 2");
                } while ((K != 1) && (K != 2));
                list.Add(K);
                size--;
            } while (size != 0);
            foreach (int i in list)
            {
                Console.Write("{0}  ", i);
            }
            foreach (int i in list)
            {
                if (i == 1)
                    a++;
                else
                    b++;
            }
            Console.WriteLine();
            Console.WriteLine("Кiлькiсть 1 = {0}", a);
            Console.WriteLine("Кiлькiсть 2 = {0}", b);

            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (i == 1 || i == 2 || i == 4 || i == 2 || i == 6 || i == 10 || i == 12 || i == 16 || i == 18 || i == 22 || i == 28
                     || i == 30 || i == 36|| i == 40 || i == 42 || i == 46 || i == 52 || i == 58 || i == 60 || i == 66 || i == 70
                      || i == 72 || i == 78 || i == 82 || i == 88 || i == 96 )
                {
                    list.RemoveAt(i);
                    Console.WriteLine($"Видаленнi iндекси  {i}");
                }
            }
            Console.WriteLine("Результат ");

            Console.WriteLine(String.Join(", ", list));



        }
    }
}