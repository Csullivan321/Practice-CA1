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
            p3.IncreaseScore(23);
            p4.IncreaseScore(34);
            p5.IncreaseScore(8);

            Display(allPlayers);

            
        }//end of main


        public static void GetData(List<Player> allPlayers)
        {
            Console.WriteLine("Please enter the number of player you want to add score to ");
            string input = Console.ReadLine();
            int playerNumber = int.Parse(input);

            while (playerNumber != 0)
            {
                //determine player selected
                Player selectedPlayer = allPlayers.ElementAt(playerNumber - 1);//using -1 as index starts at 0

                //increase score for that player
                selectedPlayer.IncreaseScore(1);

                //display results
                Display(allPlayers);

                //ask for another player or 0 to quit
                Console.WriteLine("Please enter the number of player you want to add score to ");
                input = Console.ReadLine();
                playerNumber = int.Parse(input);

            }
        }

        private static void Display(List<Player>players)
        {
            Console.WriteLine("{0,-10}{1,-10}{2,-10}{3,-10}{4,-10}", "Player 1", "Player 2", "Player 3", "Player 4", "Player 5");

            // loop through all players and dispaly score

            foreach(Player player in players)
            {
                Console.Write("{0,-10}",player.Score);
            }

            Console.WriteLine();//add a new line at the end of scores
        }
    }
}
