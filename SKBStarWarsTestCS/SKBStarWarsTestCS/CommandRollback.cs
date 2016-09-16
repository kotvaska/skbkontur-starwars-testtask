using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKBStarWarsTestCS
{
    class CommandRollback : ICommand
    {
        public CommandRollback()
        {

        }

        public void Execute(Clone clone)
        {
            clone.RemoveLastProgram();
            Console.WriteLine("Rollback {0}", clone.GetLastProgram());
        }
    }
}
