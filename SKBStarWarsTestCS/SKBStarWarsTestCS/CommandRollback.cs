using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKBStarWarsTestCS
{
    class CommandRollback : Command
    {
        public CommandRollback()
        {

        }

        public void execute(Clone clone)
        {
            clone.RemoveLastProgram();
            Console.WriteLine("Rollback {0}", clone.GetLastProgram());
        }
    }
}
