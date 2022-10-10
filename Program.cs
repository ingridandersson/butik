using System.Reflection.Emit;
using MinButik;

public class Program : Generator
{
    public static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Magenta;

        int i = 0;

        List<Tshirts> tshirtlista = new List<Tshirts>();
        List<Muggar> mugglista = new List<Muggar>();
        Generator generator = new Generator();

        ButikInfo nyButik = new ButikInfo();
        nyButik.GetAdress();

        Console.WriteLine("Gör ett menyval: ");
        Console.WriteLine("1. Visa T-Shirts");
        Console.WriteLine("2. Visa Muggar");
        Console.WriteLine("3. Exit");

        int menyVal = Convert.ToInt32(Console.ReadLine());

        Console.Clear();

        switch (menyVal)
        {
            case 1:
                Console.WriteLine("Hur många t-shirts vill du välja mellan?\n");
                int tAntal = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.WriteLine($"Nu visas {tAntal} olika t-shirts:\n");

                while (i < tAntal)
                {
                    Tshirts nytshirt = new Tshirts();
                    nytshirt.GetTshirt();
                    tshirtlista.Add(nytshirt);
                    i++;
                }

                break;
               
                //tshirtlista.Sort();
               
            case 2:
                Console.WriteLine("Hur många muggar vill du välja mellan?\n");
                int mAntal = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.WriteLine($"Nu visas {mAntal} olika muggar: \n");

                while (i < mAntal)
                {
                    Muggar nyMugg = new Muggar();
                    nyMugg.GetMugg();
                    mugglista.Add(nyMugg);
                    i++;
                }
                break;

            case 3:
                Console.WriteLine("Tack för ditt besök.\nVälkommen åter!");
                break;

            default:
                Console.WriteLine("Ett fel uppstod. Välkommen åter!");
                break;

        }

        Console.ReadKey();
    }
}