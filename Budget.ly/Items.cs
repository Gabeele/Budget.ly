using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget.ly
{
    public class Items : Aggregate
    {
        List<Item> items = new List<Item>();

        public Iterator iterator()
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
