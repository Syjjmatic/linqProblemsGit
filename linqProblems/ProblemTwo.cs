using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqProblems
{
    class ProblemTwo
    {
        List<string> names;

        public ProblemTwo()
        {
            names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
        }

        public void Run()
        {

            var notDuplicate = names.Distinct();
            foreach (string name in notDuplicate)
            {
                Console.WriteLine(name);
            }
        }
    }
}
