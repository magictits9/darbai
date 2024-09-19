using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savarankiška_užd
{
    internal class TaskUtils
    {
        public static Player FindYoungestPlayer(List<Player> Players)
        {
            Player youngest = Players[0];
            for (int i = 1; i < Players.Count; i++)
            {
                if (DateTime.Compare(Players[i].birthDate, youngest.birthDate) > 0)
                {
                    youngest = Players[i];
                }
            }
            return youngest;
        }
        public static List<Player> FindExactTeam(List<Player> Players)
        {
            List<Player> zalgirisPlayers = new List<Player>();
            foreach (Player player in Players)
            {
                string club = player.club;
                if (player.club == "Zalgiris")
                {
                    zalgirisPlayers.Add(player);
                }
            }
            return zalgirisPlayers;
        }
    }
}
