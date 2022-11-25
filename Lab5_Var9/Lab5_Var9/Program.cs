using System;
namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, N, min, min_i, min_j;
            Console.WriteLine("Введiть кiлькiсть рядкiв");
            M = int.Parse(Console.ReadLine());
            Console.WriteLine("Введiть кiлькiсть стовбцiв");
            N = int.Parse(Console.ReadLine());

            int[,] a = new int[M, N];

            Random random = new Random();
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    a[i, j] = random.Next(-100, 100);
                    Console.Write("{0,4}", a[i, j]); //вигляд масиву
                }
                Console.WriteLine();
            }
            for (int i = 0; i < M; i++)
            {        //пошук мінімальник чисел в рядках
                min = a[i, 0];
                min_i = i;
                min_j = 0;
                for (int j = 1; j < N; j++)
                {
                    if (a[i, j] < min)
                    {
                        min = a[i, j];
                        min_i = i;
                        min_j = j;

                    }

                }
                /*Console.WriteLine($"   Мiнiмальний елемент {i + 1}  рядка дорiвнює   {min}");
                Console.WriteLine($"   Вiн знаходиться у {min_j + 1}  стовпцi");*/
                if (min>0)
                {
                    Console.WriteLine($"В {i+1} рядку числа бiльше нуля!");
                }
                else
                {
                    Console.WriteLine($"В {i + 1} рядку числа меньше нуля :("); ;
                }



            }
        }

    }
}
