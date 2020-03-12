using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqProblems
{
    class ProblemOne
    {
        List<string> words;
        public ProblemOne()
        {
            words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
        }

        public List<string> Run()
        {
            var wordsThatContainTh = words.Where(w => w.Contains("th")).ToList();
            return wordsThatContainTh;
        }
    }
}
