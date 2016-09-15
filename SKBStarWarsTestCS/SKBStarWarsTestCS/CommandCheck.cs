using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKBStarWarsTestCS
{
    class CommandCheck : Command
    {
        private String lastProgram;

        public void execute(Clone clone)
        {
            lastProgram = clone.GetLastProgram();
            Console.WriteLine("Check {0} {1}", clone.cloneId, GetResult());
        }
         
        public String GetResult()
        {
            return lastProgram;
        }
    }
}
