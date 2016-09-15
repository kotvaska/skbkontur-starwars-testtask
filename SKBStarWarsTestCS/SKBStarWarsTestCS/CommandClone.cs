﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKBStarWarsTestCS
{
    class CommandClone : Command
    {
        public Clone newClone;

        public CommandClone()
        {

        }

        public void execute(Clone clone)
        {
            newClone = clone;
            Console.WriteLine("Clone {0}", clone.cloneId);
        }

        public Clone GetClone()
        {
            return newClone != null ? newClone : new Clone(1);
        }
    }
}
