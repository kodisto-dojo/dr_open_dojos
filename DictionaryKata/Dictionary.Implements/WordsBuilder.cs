using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dictionary.Interfaces;

namespace Dictionary.Implements
{
    public class WordsBuilder : IWordsBuilder
    {
        private IWordsDictionary Dictionary;
        public WordsBuilder(IWordsDictionary dictionary)
        {
            this.Dictionary = dictionary;
        }

        public IList<string> GetCombinedWords(Func<string, bool> filter)
        {
            List<string> result = new List<string>();
         
            
            var validWords = Dictionary.GetFilterWords(filter);
            foreach (var word in validWords)
            {
                var compositeWords = validWords.Select(w => word + w).Where(filter).ToList();

                foreach (var composite in compositeWords)
                {
                    var real = validWords.FirstOrDefault(w => w.ToLower() == composite.ToLower());

                    if (!string.IsNullOrEmpty(real))
                    {
                        result.Add(real);
                    }
                }
               

                
            }

            return result;
        }
    }
}
