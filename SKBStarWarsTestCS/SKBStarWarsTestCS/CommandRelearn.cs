using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKBStarWarsTestCS
{
    class CommandRelearn : ICommand
    {
        public void Execute(Clone clone)
        {
            if (clone.GetHistory().Count != 0)
            {
                clone.AddProgram(this, clone.GetLastDeletedProgram());
                Console.WriteLine("Relearn {0}", clone.GetLastDeletedProgram());
            }
        }
    }
}
