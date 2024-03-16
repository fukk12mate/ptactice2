using System;
namespace Project
{
    class Worker
    {
        private string name;
        private string surname;
        private int rate;
        private int days;
        public static int GetSalary;
        public string Name 
        { 
            get { return name; }
            set { name = value; }       
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public int Rate
        {
            get { return rate; }
            set { rate = value; }
        }
        public int Days
        {
            get { return days; }
            set { days = value; }
        }
    }
    class Program
    {
        public Program()
        {
        }
        static void Main()
        {
            Worker Maga = new Worker();
            Maga.Name = "Maga";
            Maga.Surname = "Magomedov";
            Maga.Rate = 600;
            Maga.Days = 365;

            Console.WriteLine("Name: " + Maga.Name);
            Console.WriteLine("Surname: " + Maga.Surname);
            Worker.GetSalary = Maga.Rate * Maga.Days;
            Console.WriteLine("Maga's salary: " + Worker.GetSalary);
            Console.ReadKey();
        }
    }
}