using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqProblems
{
    class ProblemOne
    {
        public void Run()
        {
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            var wordsThatContainTh = words.Where(w => w.Contains("th"));
            foreach (string word in wordsThatContainTh)
            {
                Console.WriteLine(word);
            }
            Console.ReadLine();
        }
    }
}
