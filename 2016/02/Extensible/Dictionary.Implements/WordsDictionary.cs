using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dictionary.Interfaces;

namespace Dictionary.Implements
{
    public class WordsDictionary: IWordsDictionary
    {
        private List<string> words;
        public WordsDictionary(string path)
        {
            words = System.IO.File.ReadAllLines(path).ToList();

        }

        public IList<string> GetAllWrods()
        {
            return words;
        }

        public IList<string> GetFilterWords(Func<string, bool> fiter)
        {
            return words.Where(fiter).ToList();
        }
    }
}
