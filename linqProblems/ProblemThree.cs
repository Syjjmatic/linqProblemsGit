using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqProblems
{
    class ProblemThree
    {
        List<string> classGrades;

        public ProblemThree()
        {
            classGrades = new List<string>
            {"80, 100, 92, 89, 65",
            "93, 81, 78, 84, 69",
            "73, 88, 83, 99, 64",
            "98, 100, 66, 74, 55"};
        }

        public double Run()
        {
            var doublesList = classGrades.Select(x => x.Split(',').Select(y => Convert.ToDouble(y)).ToList().ToList()).Where(z => z.Remove(z.Min()));            
            var average = doublesList.Select(x => x.Average()).Average();
            return average;
        }
    }
}
