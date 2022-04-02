using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget.ly
{
    public class Milestone
    {
        private List<Items> mementos;

        public Milestone(Items list)
        {
            this.mementos = new List<Items>() {};
            mementos.Add(list);

        }

        public void SetList(List<Items> list)
        {

            this.mementos = list;

        }

        public List<Items> GetList()
        {

            return this.mementos;

        }

        public Items GetItemsFromList()
        {

            int count = mementos.Count;
            return mementos[count - 1];

        }

    }

}
