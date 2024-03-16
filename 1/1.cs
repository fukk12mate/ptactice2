using System;
using System.Collections.Generic;

namespace JewelsAndStones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку драгоценностей (J):");
            string jewels = Console.ReadLine();

            Console.WriteLine("Введите строку камней (S):");
            string stones = Console.ReadLine();

            HashSet<char> jewelsSet = new HashSet<char>(jewels);

            int count = 0;
            foreach (char stone in stones)
            {
                if (jewelsSet.Contains(stone))
                {
                    count++;
                }
            }

            Console.WriteLine($"Количество драгоценностей в камнях: {count}");
            Console.ReadKey();
        }
    }
}