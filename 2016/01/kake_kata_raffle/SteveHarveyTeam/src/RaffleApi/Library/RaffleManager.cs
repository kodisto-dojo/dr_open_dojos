using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaffleApi.Library
{
    public class RaffleManager
    {
       private List<String> _players = new List<String>();
        public RaffleManager()
        {
            _players = Repository.GetPlayer();
        }

        internal string GetRandom()
        {
            Random rd = new Random();            
            _players = _players.OrderBy(p => rd.Next(0, _players.Count-1)).ToList();

            return _players[rd.Next(0, _players.Count - 1)];
        }
    }
}
