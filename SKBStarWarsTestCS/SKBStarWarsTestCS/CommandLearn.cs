using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKBStarWarsTestCS
{
    class CommandLearn : Command
    {
        public String program;

        public CommandLearn(String program)
        {
            this.program = program;
        }

        public void execute(Clone clone)
        {
            clone.AddProgram(this, program);
            Console.WriteLine("Learn {0} {1}", clone.cloneId, program);
        }
    }
}
