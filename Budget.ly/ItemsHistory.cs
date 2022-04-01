using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget.ly
{
    public class ItemHistory
    {

        private List<Milestone> itemsHistory;
        int indexOfCurrentMilestone = -1;

        public ItemHistory()
        {

            this.itemsHistory = new List<Milestone>();

        }

        public void AddMilestone(Milestone milestone)
        {

            itemsHistory.Add(milestone);
            indexOfCurrentMilestone++;

        }

        public Object undo()
        {

            if (indexOfCurrentMilestone <= 0)

            {
                indexOfCurrentMilestone = 0;
                return itemsHistory.ElementAt(indexOfCurrentMilestone);
            }

            indexOfCurrentMilestone--;
            return itemsHistory.ElementAt(indexOfCurrentMilestone);
        }

    }

}
