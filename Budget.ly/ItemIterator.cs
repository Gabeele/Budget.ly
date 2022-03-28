using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget.ly
{
    public class ItemIterator : IIterator
    {
        private List<Item> elements;
        private int index = 0;

        public ItemIterator(Items items)
        {
            elements = new List<Item>(items.GetItems());
        }

        public bool HasNext()
        {
            return index < elements.Count();
        }

        public object Next()
        {
            if (HasNext())
            {
                return elements.ElementAt(index++);
            }
            return null;
        }
    }
}
