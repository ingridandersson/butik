using System;
namespace MinButik
{
    public class ButikInfo
    {
        public static string? BAdress { get; set; }
        public static string? FAdress { get; set; }


        public ButikInfo()
        {
            BAdress = "Butik xxx  Nygatan 19 11122 Nyköping";
            FAdress = "Butik xxx \nUppgatan 12\n22211 Uppköping";

            Console.WriteLine($"Välkommen till xxx's online shop. " +
                $"\nHär kan du beställa muggar och t-shirts med 30 olika motiv.");
            Console.WriteLine();
            Console.WriteLine($"Dagens datum: {DateTime.UtcNow.AddHours(2)}");
            Console.WriteLine("(Tänk på att beställa dina varor i tid)");

        }

        public void GetAdress()
        {
            Console.WriteLine("________________________________");
            Console.WriteLine();
            Console.WriteLine("Besöksadress: \n" + BAdress);
            Console.WriteLine("________________________________");

            Console.WriteLine();
            Console.WriteLine("Faktureringsadress: \n" + FAdress);
            Console.WriteLine("________________________________\n");

        }
    }
}

