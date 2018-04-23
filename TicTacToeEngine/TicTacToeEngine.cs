using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum1DotNetEngine
{
    public class TicTacToeEngine
    {
        public enum GameStatus { PlayerOPlays, PlayerXPlays, Equal, PlayerOWins, PlayerXWins}

        public GameStatus Status {
            get { }
            private set { }
        }

        public string[,] representation = new string[,] { { "1", "2", "3" }, { "4", "5", "6" }, { "7", "8", "9" } };

        public String Board()
        {
            return "-------------\n" +
                    "| " + representation[0, 0] + " | " + representation[0, 1] + " | " + representation[0, 2] + " |\n" +
                    "-------------\n" +
                    "| " + representation[1, 0] + " | " + representation[1, 1] + " | " + representation[1, 2] + " |\n" +
                    "-------------\n" +
                    "| " + representation[2, 0] + " | " + representation[2, 1] + " | " + representation[2, 2] + " |\n" +
                    "-------------";
        }

        public bool ChooseCell(int x)
        {
            if(x == 1 && Status.Equals(PlayerOPlays))
            {

            }

            return true;
        }

        public void Reset()
        {
            representation = new string[,] { { "1", "2", "3" }, { "4", "5", "6" }, { "7", "8", "9" } };
        }

    }
}
