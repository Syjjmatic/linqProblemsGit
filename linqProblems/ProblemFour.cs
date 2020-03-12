using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqProblems
{
    class ProblemFour
    {
        public string name;
        public ProblemFour()
        {
            name = "Terrill";
        }

        public string Run()
        {
            var letters = name.ToUpper().ToCharArray().OrderBy(x => x).ToList();
            var numbers = letters.Distinct().Select(x => (letters.LastIndexOf(x) - letters.IndexOf(x)) + 1);
            var varZip = letters.Distinct().Zip(numbers, (x, y) => String.Concat(x, y)).ToList();
            return String.Join("", varZip);
        }

    }
}
