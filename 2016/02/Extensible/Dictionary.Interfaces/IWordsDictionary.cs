using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary.Interfaces
{
    public interface IWordsDictionary 
    {    
           
        IList<string> GetAllWrods();
        IList<string> GetFilterWords(Func<string, bool> fiter);            
    }
}
