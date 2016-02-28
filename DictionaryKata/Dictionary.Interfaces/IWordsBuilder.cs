using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary.Interfaces
{
    public interface IWordsBuilder
    {
       IList<string> GetCombinedWords(Func<String, bool> filter);
    }
}
