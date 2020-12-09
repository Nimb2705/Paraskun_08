using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab08
{
    public class Class1
    {
        public string ourAircraftName;
        public string ourNumberSeats;
        public int ourEge;
        public string ourAirlineName;
        public int Price;
        public string ourCountry;
        public bool Autopilot;

        public static void Aircraft()
        {
            Console.WriteLine("Введіть назву літака: ");
            string aircraftName = Console.ReadLine();
            Console.WriteLine("Введiть кількість місць: ");
            string numberSeats = Console.ReadLine();
            Console.WriteLine("Введiть рік випуску: ");
            string age = Console.ReadLine();
            Console.WriteLine("Введiть назву авіа-компанії: ");
            string airlineName = Console.ReadLine();
            Console.WriteLine("Введiть ціну на білет: ");
            string sPrice = Console.ReadLine();
            Console.WriteLine("Введiть країну виготовлення: ");
            string Country = Console.ReadLine();
            Console.Write("Має автопілот?(t - так , n - ні) ");
            ConsoleKeyInfo keyAutopilot = Console.ReadKey();

            Class1 OurAircraft = new Class1
            {
                ourAircraftName = aircraftName,
                ourNumberSeats = numberSeats,
                ourEge = int.Parse(age),
                ourAirlineName = airlineName,
                Price = int.Parse(sPrice),
                ourCountry = Country,
                Autopilot = keyAutopilot.Key == ConsoleKey.T,
            };

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Данi про об`ект: ");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Назва літака: " + OurAircraft.ourAircraftName);
            Console.WriteLine("Кількість місць: " + OurAircraft.ourNumberSeats);
            Console.WriteLine("Рік випуску: " + OurAircraft.ourEge);
            Console.WriteLine("Назву авіа-компанії: " + OurAircraft.ourAirlineName);
            Console.WriteLine("Ціна на білет: " + OurAircraft.Price + "грн.");
            Console.WriteLine("Країна виготовлення: " + OurAircraft.ourCountry);
            Console.WriteLine(OurAircraft.Autopilot ? "Цей літак має автопілот" : "Цей літак не має автопілоту");
            Console.ReadKey();

        }
    }
}
