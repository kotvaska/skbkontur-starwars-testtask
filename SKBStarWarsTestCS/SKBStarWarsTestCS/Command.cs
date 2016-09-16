using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKBStarWarsTestCS
{
    interface ICommand
    {
        void Execute(Clone clone);
    }
}
