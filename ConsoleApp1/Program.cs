using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{/// <summary>
/// Задача 1. Ввести массив с клавиатуры, состоящий из 14 элементов целого типа. Найти количество элементов четных по значению.
/// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Input();
            int[] omas = new int[n];
            Vvod(omas);
            int evenCount = EvenNumbers(omas);
            Console.WriteLine($"Количество чётных элементов: {evenCount}");
            Console.Read();
        }
        static int Input()
        {
            Console.Write("n=");
            int n = Convert.ToInt32(Console.ReadLine());
            return n;
        }

        static void Vvod(int[] omas)
        {
            for (int i = 0; i < omas.Length; i++)
            {
                Console.Write($"arr[{i}]= ");
                omas[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        static void Vvivod(int[] omas)
        {
            for (int i = 0; i < omas.Length; i++)
            {
                Console.WriteLine($"arr[{i}]={omas[i]}");
            }
        }
        static int EvenNumbers(int[] array)
        {
            int count = 0;
            foreach (int num in array)
            {
                if (num % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
