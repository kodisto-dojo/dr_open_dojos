using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RaffleApi.Library
{
    internal class Repository
    {
        internal static List<string> GetPlayer()
        {
            List<string> players = new List<string>();

            var lines = File.ReadAllLines("tickets.dat");
            foreach (string item in lines)
            {               
                var names = item.Split('=');
                var tickets = int.Parse(names[1]);
                for (int i = 0; i < tickets; i++)
                {
                    players.Add(names[0]);
                }                    
            }

            return players;
        }
    }
}
