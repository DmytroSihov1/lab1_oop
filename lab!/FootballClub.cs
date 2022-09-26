using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_
{
    class FootballClub
    {
        public List<Player> Players { get; set; }

        public List<Player> findPlayersByCountry(Country country){
            List<Player> players = new List<Player>();
            foreach(Player player in Players)
            {
                if (player.Country.Equals(country)){
                    players.Add(player);
                }
            }
            return players;
        }

        public List<Player> findPlayersByRole(string role)
        {
            List<Player> players = new List<Player>();
            foreach (Player player in Players)
            {
                if (player.Role.Equals(role))
                {
                    players.Add(player);
                }
            }
            return players;
        }

        public void printAllPlayers()
        {
            Console.WriteLine("All players: ");
            foreach (Player player in Players)
            {
                Console.WriteLine(player);
            }
        }
    }
}
