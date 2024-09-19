using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Savarankiška_užd
{
    internal class InOutUtils
    {
        public static List<Player> ReadPlayers(string fileName)
        {
            List<Player> Player = new List<Player>();
            string[] Lines = File.ReadAllLines(fileName, Encoding.UTF8);
            foreach (string line in Lines)
            {
                string[] Values = line.Split(';');
                string firstName = Values[0];
                string lastName = Values[1];
                DateTime birthDate = DateTime.Parse(Values[2]);
                double height = double.Parse(Values[3]);
                string position = Values[4];
                string club = Values[5];
                bool invited = bool.Parse(Values[6]);
                bool captain = bool.Parse(Values[7]);
               
                Player players = new Player(firstName, lastName, birthDate, height, position, club, invited, captain);
                Player.Add(players);
            }
            return Player;
        }
        public static void PrintPlayer(List<Player> players)
        {
            Console.WriteLine(new string('-', 112));
            Console.WriteLine("| {0,8} | {1,-15} | {2,-12} | {3,-8} | {4,-10} | {5,-15} | {6,-10} | {7,-8}|",
                "Vardas", "Pavarde", "Gimimo data", "Ugis", "Pozicija", "Klubas", "Pakviestas", "Kapitonas");
            Console.WriteLine(new string('-', 112));
            foreach (Player player in players)
            {
                Console.WriteLine("| {0,8} | {1,-15} | {2,-12:yyyy-MM-dd} | {3,8:F2} | {4,-10} | {5,-15} | {6,-10} | {7,-8}|",
                    player.firstName, player.lastName, player.birthDate, player.height, player.position, player.club, player.invited , player.captain,
                    player.invited ? "Yes" : "No", player.captain ? "Yes" : "No");
                Console.WriteLine(new string('-', 112));
            }
            Console.WriteLine();
        }
        public static void PrintPlayerToCSVFile(string fileName, List<Player> players)
        {
            string[] lines = new string[players.Count + 1];
            lines[0] = String.Format("{0};{1};{2};{3};{4}",
            "Vardas", "Pavardė", "Gimimo data", "Pozicija");
            for (int i = 0; i < players.Count; i++)
            {
                lines[i + 1] = String.Format("{0};{1};{2};{3};{4}",
                players[i].firstName, players[i].lastName, players[i].birthDate, players[i].position);
            }
            File.WriteAllLines(fileName, lines, Encoding.UTF8);
        }
        public static void PrintExactTeam(string fileName, List<Player> players)
        {
            string[] lines = new string[players.Count + 1];
            lines[0] = String.Format("{0};{1};{2};{3};{4}",
            "Vardas", "Pavardė", "Pozicija");
            for (int i = 0; i < players.Count; i++)
            {
                lines[i + 1] = String.Format("{0};{1};{2};{3}",
                players[i].firstName, players[i].lastName, players[i].position);
            }
            File.WriteAllLines(fileName, lines, Encoding.UTF8);
        }

    }
}
