using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaffleApi
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new Library.RaffleManager();
            var winner = manager.GetRandom();
            
            Console.WriteLine("The winner is {0}", winner);

            Console.ReadLine();         

        }
    }
}
