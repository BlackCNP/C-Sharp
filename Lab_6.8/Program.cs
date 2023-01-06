using System;
class Program    /*ЛаБ 6, Завдання 8*/
{
    static void Resize(ref int[] array, int newSize)
    {
        int[] newArray = new int[newSize];
        for (int i = 0; i < array.Length && i < newArray.Length; i++)
        {
            newArray[i] = array[i];
        }
        array = newArray;
    }
    static void Main(string[] args)
    {
        int[] mayArray = { 1, 5, 7, 2, 8, 4 };
        int size = 0;
        Console.WriteLine("масив");
        for (int i = 0; i < 6; i++)
        {
            Console.Write(mayArray[i]);
            Console.Write(" ");
        }
        Console.WriteLine();
        Console.WriteLine("Введiть число на яке змiнити довжину масиву");
        size = int.Parse(Console.ReadLine());
        Array.Resize(ref mayArray, size);
        for (int i = 0; i < mayArray.Length; i++)
        {
            Console.Write(mayArray[i]);
            Console.Write(" ");
        }
    }
}