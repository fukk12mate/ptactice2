using System;
using System.Collections.Generic;

class Program
{
    static bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> set = new HashSet<int>();

        foreach (int num in nums)
        {
            if (set.Contains(num))
            {
                return true;
            }
            else
            {
                set.Add(num);
            }
        }

        return false;
    }

    static void Main()
    {
        int[] numbers1 = { 1, 2, 3, 4};
        int[] numbers2 = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2};
        int[] numbers3 = { 1, 2, 3, 1 };

        Console.WriteLine(ContainsDuplicate(numbers1)); 
        Console.WriteLine(ContainsDuplicate(numbers2)); 
        Console.WriteLine(ContainsDuplicate(numbers3));
        Console.ReadKey(); 
    }
}