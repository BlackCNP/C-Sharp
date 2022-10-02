using System;
namespace Lab4_Var9
{
    class Program                        //Зсунути вправо
    {
        static void Main(string[] args)
        {
            
           
                Console.Write("Array size n = ");
                var arr = new int[int.Parse(Console.ReadLine())];
            Console.WriteLine("Введіть елементи ");
                for (int i = 0; i < arr.Length; ++i)
                    arr[i] = int.Parse(Console.ReadLine());

                ShiftElements(arr);

                
            

            static void ShiftElements(int[] arr)
            {
                int prev = arr[0];
                int next;
                for (int i = 0; i < arr.Length - 1; ++i)
                {
                    next = arr[i + 1];
                    arr[i + 1] = prev;
                    prev = next;
                }
                arr[0] = prev;
            }

            for (int i = 0; i < arr.Length; ++i)
                Console.Write(arr[i]+" ");




        }



    }



}
