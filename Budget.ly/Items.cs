using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget.ly
{
    public class Items : IAggregate
    {
        List<Item> items = new ();

        public IIterator Iterator()
        {
            return new ItemIterator(this);
        }

        public List<Item> GetItems()
        {
            return items;
        }

        public void add(Item item)
        {
            items.Add(item);
        }
    }
}
