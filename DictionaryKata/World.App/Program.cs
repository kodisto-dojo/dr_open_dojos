using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World.App
{
    class Program
    {
        static void Main(string[] args)
        {

            var dictionary = new Dictionary.Implements.WordsDictionary("wordlist.txt");
            var builder = new Dictionary.Implements.WordsBuilder(dictionary);


            Func<string, bool> filter = f => f.Length <= 6;
            foreach (var item in builder.GetCombinedWords(filter))
            {
                Console.WriteLine(item);

            }
            Console.ReadLine();
        }
    }
}
