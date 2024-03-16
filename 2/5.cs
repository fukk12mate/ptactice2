using System;
namespace Project
{
    class CAT
    {
        private string average_meow;
        private string loud_meow;
        private string quiet_meow;


        public CAT(string _average_meow, string _loud_meow, string _quiet_meow)
        {
            Console.WriteLine("The cat's here!");
        }
        public static string CaT = "The cat is gone!";
        


        public void setValues(string _average_meow, string _loud_meow, string _quiet_meow)
        {
            average_meow = _average_meow;
            loud_meow = _loud_meow;
            quiet_meow = _quiet_meow;

        }
        static void Main(string[] args)
        {
            CAT meow = new CAT("meow", "MEOW", "mew");
            meow.setValues("meow", "MEOW", "mew");

            Console.WriteLine("Do you want to hear kittie?"+"\n");
            string answer = Convert.ToString(Console.ReadLine());
            if (answer == "yes")
            {
                Console.WriteLine("\n" + meow.average_meow + "\n");
            }
            else if (answer == "no")
            {
                Console.WriteLine("\n" + meow.quiet_meow + "\n");
            }
            else
                Console.WriteLine("\n" + meow.loud_meow + "\n" + meow.loud_meow + "\n" + meow.loud_meow + "\n" + meow.loud_meow + "\n" + meow.loud_meow + "\n" + meow.loud_meow+ "\n");
           Console.ReadKey();
           Console.ReadKey();
           Console.ReadKey();
           Console.ReadKey();
           Console.ReadKey();
           Console.WriteLine("\n" + CAT.CaT);
           Console.ReadKey();
        }
    }
}