using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget.ly
{
    public interface IIterator
    {
        public bool HasNext();

        public Object Next();
    }
}
