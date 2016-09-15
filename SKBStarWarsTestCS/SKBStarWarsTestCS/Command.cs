using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKBStarWarsTestCS
{
    interface Command
    {
        void execute(Clone clone);
    }
}
