using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget.ly
{
    public class Items : IAggregate
    {
        List<Item> items;

        public Items()
        {

            this.items = new List<Item>() { };

        }

        public Items(Items otherItems)
        {

            if (items == null)
            {

                otherItems.items = this.items;

            }

            else {

                foreach (Item item in items)
                {
                    otherItems.add(item);
                }

            }

        }

        public IIterator Iterator()
        {
            return new ItemIterator(this);
        }

        public List<Item> GetItems()
        {
            return items;
        }

        public void SetItems(List<Item> list)
        {

            this.items = list;

        }

        public void add(Item item)
        {
            items.Add(item);
            
        }

        public Milestone createMemento()
        {
            Items tempItem = new Items(this){};
            return new Milestone(tempItem);

        }

        //public void restoreMemento(Object o)
        //{
            
        //    Milestone m = (Milestone)o;
        //    this.items = m.GetRecent();

        //}


    }
}
