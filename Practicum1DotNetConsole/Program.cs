using Practicum1DotNetEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum1DotNetConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            TicTacToeEngine t = new TicTacToeEngine();
            while (!t.Status.Equals(GameStatus.Equal) || !t.Status.Equals(GameStatus.PlayerOWins) || !t.Status.Equals(GameStatus.PlayerXWins))
            {
                Console.WriteLine("Type a number from 1-9, new or quit");
                Console.WriteLine("Status: " + t.Status);
                Console.WriteLine(t.Board());

                string x = Console.ReadLine();

                if (!string.IsNullOrEmpty(x))
                {
                    if(x == "new")
                    {
                        t.Reset();
                        continue;
                    }

                    if(x == "quit")
                    {
                        Environment.Exit(0);
                    }

                    int parsedInt;

                    if (int.TryParse(x, out parsedInt))
                    {
                        if (!t.ChooseCell(parsedInt))
                        {
                            Console.WriteLine("Invalid Choice");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Choice");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                }
            }
        }
    }
}
