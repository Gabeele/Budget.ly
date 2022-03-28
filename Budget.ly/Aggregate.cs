using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget.ly
{
    interface IAggregate
    {
        IIterator Iterator();

    }
}
