using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    /// <summary>
    /// Задача 1. Ввести массив с клавиатуры, состоящий из 14 элементов целого типа. Найти количество элементов четных по значению.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] omas = new int[14];
            VvodMass(omas);
            Elements(omas);
            Console.ReadKey();
        }
        public static void VvodMass(int[] omas)
        {
            for (int i = 0; i < omas.Length; i++)
            {
                Console.Write($"omas[{i}]=");
                omas[i] = int.Parse(Console.ReadLine());
            }
        }
        public static void Elements(int[] omas)
        {
            int f = 0;
            foreach (int element in omas)
            {
                if ((element & 1) == 0)
                {
                   f++;
                }
            }
            Console.WriteLine($"Количество чётных елементов={f}");
        }
    }
}
