using System;
namespace Project
{
    class Worker
    {
        public string name;
        public string surname;
        public int rate;
        public int days;


        public static int GetSalary;
        

       
    }
    class Program
    {
        public Program() 
        {
        
        }
        static void Main()
        {
            Worker Maga = new Worker();
            Maga.name = "Maga";
            Maga.surname = "Magomedov";
            Maga.rate = 600;
            Maga.days = 365;

            Console.WriteLine("Name: " + Maga.name);
            Console.WriteLine("Surname: " + Maga.surname);
            Worker.GetSalary = Maga.rate * Maga.days;
            Console.WriteLine("Maga's salary: " + Worker.GetSalary);
            Console.ReadKey();
        }
    }
}