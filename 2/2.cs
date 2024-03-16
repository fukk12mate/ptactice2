using System;
namespace Project
{
    class Train
    {
        private string destination;
        private int trainNumber;
        private string departureTime;
        class Program
        {
            static void Main()
            {
                Train poezd1 = new Train();
                poezd1.destination = "Samara";
                poezd1.trainNumber = 22;
                poezd1.departureTime = "13:00";

                Train poezd2 = new Train();
                poezd2.destination = "Mahachkala";
                poezd2.trainNumber = 23;
                poezd2.departureTime = "14:33";

                Train poezd3 = new Train();
                poezd3.destination = "Tomsk";
                poezd3.trainNumber = 24;
                poezd3.departureTime = "15:48";

                Console.WriteLine("Trains for today: "+poezd1.trainNumber + " " + poezd2.trainNumber + " " + poezd3.trainNumber+"\n");
                Console.Write("Write the train number to see information: ");
                int answer = Convert.ToInt32(Console.ReadLine());
                switch (answer)
                {
                    case 22:
                        Console.WriteLine("\n" + "Train number: " + poezd1.trainNumber);
                        Console.WriteLine("Destination: " + poezd1.destination);
                        Console.WriteLine("Departure time: " + poezd1.departureTime);break;
                    case 23:
                        Console.WriteLine("\n" + "Train number: " + poezd2.trainNumber);
                        Console.WriteLine("Destination: " + poezd2.destination);
                        Console.WriteLine("Departure time: " + poezd2.departureTime); break;
                    case 24:
                        Console.WriteLine("\n" + "Train number: " + poezd3.trainNumber);
                        Console.WriteLine("Destination: " + poezd3.destination);
                        Console.WriteLine("Departure time: " + poezd3.departureTime); break;
                    default: Console.WriteLine("This number does not exist!");break;     
                }
                
                
                
                
                Console.ReadKey();

            }

        }

    }

}