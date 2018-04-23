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

            Console.WriteLine(t.Board());
        }
    }
}
