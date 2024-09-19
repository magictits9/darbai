using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savarankiška_užd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            List<Player> allPlayers = InOutUtils.ReadPlayers(@"Player.csv");
            Console.WriteLine("Lietuvos rinktinės žaidėjų sąrašas:");
            InOutUtils.PrintPlayer(allPlayers);
            Player youngest = TaskUtils.FindYoungestPlayer(allPlayers);
            Console.WriteLine("Jauniausias zaidejas: ");
            Console.WriteLine("Vardas: {0}, Pavarde: {1}, Amžius: {2}, Pozicija: {3}", youngest.firstName, youngest.lastName, youngest.CalculateAge(), youngest.position);
            Console.WriteLine();
            List<Player> zalgirisPlayers = TaskUtils.FindExactTeam(allPlayers);
            Console.WriteLine("Zaidejai is Zalgirio klubo: ");
            if (zalgirisPlayers.Count > 0)
            {
                foreach (Player player in zalgirisPlayers)
                {
                    Console.WriteLine("Vardas: {0}, Pavarde: {1}, Pozicija: {2}", player.firstName, player.lastName, player.position);
                }
            }
            else
            {
                Console.WriteLine("No players found from Zalgiris club.");
            }


            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
