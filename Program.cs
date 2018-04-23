using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practicum1DotNetEngine;

namespace Practicum1DotNet
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            TicTacToeEngine t = new TicTacToeEngine();

            Console.WriteLine(t.Board());
        }
    }
}
