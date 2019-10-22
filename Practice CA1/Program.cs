using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_CA1
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new Player(1, "Mike", 0);
            Player p2 = new Player(2, "Sarah", 0);
            Player p3 = new Player(3, "Jack", 0);
            Player p4 = new Player(4, "Chris", 0);
            Player p5 = new Player(5, "Matt", 0);

            List<Player> allPlayers = new List<Player>();

            allPlayers.Add(p1);
            allPlayers.Add(p2);
            allPlayers.Add(p3);
            allPlayers.Add(p4);
            allPlayers.Add(p5);

            p1.IncreaseScore(1);
            p2.IncreaseScore(10);
        }
    }
}
