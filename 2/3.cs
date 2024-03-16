using System;
class Numbers
{
    private int average;
    private int average1;

    class Program
    {
        static void Main()
        {
            Numbers first = new Numbers();
            first.average = 2;
            
            Numbers second = new Numbers();
            second.average1 = 1;

            Console.WriteLine("First number is: " + first.average);
            Console.WriteLine("Second number is: " + second.average1);

            if (first.average > second.average1)
            {
                Console.WriteLine("First number is bigger than second: " + first.average + " > " + second.average1);
            }
            else if (first.average == second.average1)
            {
                Console.WriteLine("Numbers are equals: " + first.average + " = " + second.average1);
            }
            else
            {
                Console.WriteLine("Second number is bigger than first: " + second.average1 + " > " + first.average);
            }
            Console.WriteLine("\n"+"Do you want to change numbers?");
            string answer = Convert.ToString(Console.ReadLine());
            switch (answer)
            {
                case "yes": Console.WriteLine("\n" + "Write first number: ");
                    first.average = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Write second number: ");
                    second.average1 = Convert.ToInt16(Console.ReadLine());
                    int sum = first.average + second.average1;
                    Console.WriteLine("\n"+"First number is: " + first.average);
                    Console.WriteLine("Second number is: " + second.average1);
                    if (first.average > second.average1)
                    {
                        Console.WriteLine("First number is bigger than second number: " + first.average + " > " + second.average1);
                    }
                    else if (first.average == second.average1)
                    {
                        Console.WriteLine("Numbers are equals: " + first.average + " = " + second.average1);
                    }
                    else
                    {
                        Console.WriteLine("Second number is bigger than first number: " + second.average1 + " > " + first.average);
                    }
                    Console.WriteLine("\n" + "Well, look at the sum of them: " + sum);
                    break;
                case "no":
                    int sum1 = first.average + second.average1;
                    Console.WriteLine("\n"+"Well, then look at the sum of them: " + sum1);
                    
                    break;
                
                default: Console.WriteLine("Wrong Answer!"); break;
            }
            Console.ReadKey();

        }
    }
}