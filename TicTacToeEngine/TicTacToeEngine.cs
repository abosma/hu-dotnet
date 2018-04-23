using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum1DotNetEngine
{
    public enum GameStatus { PlayerOPlays, PlayerXPlays, Equal, PlayerOWins, PlayerXWins }

    public class TicTacToeEngine
    {
        public GameStatus Status {
            get;
            private set;
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
            if(x == 1 && Status.Equals(GameStatus.PlayerOPlays) && representation[0,0] == "1")
            {
                representation[0, 0] = "O";
                Status = GameStatus.PlayerXPlays;
            }else if(x == 1 && Status.Equals(GameStatus.PlayerXPlays) && representation[0, 0] == "1")
            {
                representation[0, 0] = "X";
                Status = GameStatus.PlayerOPlays;
            }else if (x == 2 && Status.Equals(GameStatus.PlayerOPlays) && representation[0, 1] == "2")
            {
                representation[0, 1] = "O";
                Status = GameStatus.PlayerXPlays;
            }
            else if (x == 2 && Status.Equals(GameStatus.PlayerXPlays) && representation[0, 1] == "2")
            {
                representation[0, 1] = "X";
                Status = GameStatus.PlayerOPlays;
            }
            else if (x == 3 && Status.Equals(GameStatus.PlayerOPlays) && representation[0, 2] == "3")
            {
                representation[0, 2] = "O";
                Status = GameStatus.PlayerXPlays;
            }
            else if (x == 3 && Status.Equals(GameStatus.PlayerXPlays) && representation[0, 2] == "3")
            {
                representation[0, 2] = "X";
                Status = GameStatus.PlayerOPlays;
            }
            else if (x == 4 && Status.Equals(GameStatus.PlayerOPlays) && representation[1, 0] == "4")
            {
                representation[1, 0] = "O";
                Status = GameStatus.PlayerXPlays;
            }
            else if (x == 4 && Status.Equals(GameStatus.PlayerXPlays) && representation[1, 0] == "4")
            {
                representation[1, 0] = "X";
                Status = GameStatus.PlayerOPlays;
            }
            else if (x == 5 && Status.Equals(GameStatus.PlayerOPlays) && representation[1, 1] == "5")
            {
                representation[1, 1] = "O";
                Status = GameStatus.PlayerXPlays;
            }
            else if (x == 5 && Status.Equals(GameStatus.PlayerXPlays) && representation[1, 1] == "5")
            {
                representation[1, 1] = "X";
                Status = GameStatus.PlayerOPlays;
            }
            else if (x == 6 && Status.Equals(GameStatus.PlayerOPlays) && representation[1, 2] == "6")
            {
                representation[1, 2] = "O";
                Status = GameStatus.PlayerXPlays;
            }
            else if (x == 6 && Status.Equals(GameStatus.PlayerXPlays) && representation[1, 2] == "6")
            {
                representation[1, 2] = "X";
                Status = GameStatus.PlayerOPlays;
            }
            else if (x == 7 && Status.Equals(GameStatus.PlayerOPlays) && representation[2, 0] == "7")
            {
                representation[2, 0] = "O";
                Status = GameStatus.PlayerXPlays;
            }
            else if (x == 7 && Status.Equals(GameStatus.PlayerXPlays) && representation[2, 0] == "7")
            {
                representation[2, 0] = "X";
                Status = GameStatus.PlayerOPlays;
            }
            else if (x == 8 && Status.Equals(GameStatus.PlayerOPlays) && representation[2, 1] == "8")
            {
                representation[2, 1] = "O";
                Status = GameStatus.PlayerXPlays;
            }
            else if (x == 8 && Status.Equals(GameStatus.PlayerXPlays) && representation[2, 1] == "8")
            {
                representation[2, 1] = "X";
                Status = GameStatus.PlayerOPlays;
            }
            else if (x == 9 && Status.Equals(GameStatus.PlayerOPlays) && representation[2, 2] == "9")
            {
                representation[2, 2] = "O";
                Status = GameStatus.PlayerXPlays;
            }
            else if (x == 9 && Status.Equals(GameStatus.PlayerXPlays) && representation[2, 2] == "9")
            {
                representation[2, 2] = "X";
                Status = GameStatus.PlayerOPlays;
            }
            else
            {
                return false;
            }

            BepaalWinnaar(representation[0, 0], representation[0, 1], representation[0, 2]);
            BepaalWinnaar(representation[1, 0], representation[1, 1], representation[1, 2]);
            BepaalWinnaar(representation[2, 0], representation[2, 1], representation[2, 2]);
            BepaalWinnaar(representation[0, 0], representation[1, 1], representation[2, 2]);
            BepaalWinnaar(representation[0, 2], representation[1, 1], representation[2, 0]);
            BepaalWinnaar(representation[0, 0], representation[1, 0], representation[2, 0]);
            BepaalWinnaar(representation[0, 1], representation[1, 1], representation[2, 1]);
            BepaalWinnaar(representation[0, 2], representation[1, 2], representation[2, 2]);

            return true;
        }

        public void Reset()
        {
            representation = new string[,] { { "1", "2", "3" }, { "4", "5", "6" }, { "7", "8", "9" } };
            Status = GameStatus.PlayerOPlays;
        }

        private bool BepaalWinnaar(String pos1, String pos2, String pos3)
        {
            if (pos1 == pos2 && pos1 == pos3)
            {
                if (pos1 == "X")
                {
                    Console.WriteLine("Player X wins");
                    Reset();
                    return true;
                }
                else if (pos1 == "O")
                {
                    Console.WriteLine("Player O wins");
                    Reset();
                    return true;
                }
            }

            return false;
        }

    }
}
