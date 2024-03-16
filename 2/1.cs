using System;
namespace Project
{
    class Student
    {
        private string lastName;
        private DateTime dateOfBirth;
        private int groupNumber;
        private int[] academicPerformance;

       class Program
        {
            static void Main()
            {
                Student average = new Student();
                average.lastName = "Vovanov";
                average.dateOfBirth = new DateTime(2001,11,1);
                average.groupNumber = 1;
                average.academicPerformance = new int[] { 1, 2, 3, 4, 5 };

                Console.WriteLine("Last name: " + average.lastName);
                Console.WriteLine("Date of birth: " + average.dateOfBirth.ToShortDateString());
                Console.WriteLine("Group number: " + average.groupNumber);
                Console.WriteLine("Academic performance: " + average.academicPerformance[2]+"\n");

                Console.WriteLine("Do you want to change values?");
                string answer = Convert.ToString(Console.ReadLine());
                switch (answer)
                {
                    case "yes":
                        Console.Write("\n"+"Write last name: ");
                        average.lastName = Convert.ToString(Console.ReadLine());
                        Console.Write("Write date of birth: ");
                        average.dateOfBirth = Convert.ToDateTime(Console.ReadLine());
                        Console.Write("Write group number: ");
                        average.groupNumber = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("\n" + "Last name: " + average.lastName);
                        Console.WriteLine("Date of birth: " + average.dateOfBirth.ToShortDateString());
                        Console.WriteLine("Group number: " + average.groupNumber);
                        Console.WriteLine("Academic performance: " + average.academicPerformance[2]); break;
                    case "no":Console.ReadKey();break;
                    default: Console.WriteLine("Wrong answer!");break;
                }
                Console.ReadKey();
            }
        }
    }
}