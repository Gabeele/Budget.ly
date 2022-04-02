using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget.ly
{
    public class AccountHistory
    {

        private List<Milestone> accountHistory;
        int indexOfCurrentMilestone = -1;

        public AccountHistory()
        {

            this.accountHistory = new List<Milestone>();

        }

        public void AddMilestone(Milestone milestone)
        {

            accountHistory.Add(milestone);
            indexOfCurrentMilestone++;

        }

        public Milestone Undo()
        {

            if (indexOfCurrentMilestone <= 0)

            {
                indexOfCurrentMilestone = 0;
                return accountHistory.ElementAt(indexOfCurrentMilestone);
            }

            indexOfCurrentMilestone--;
            return accountHistory.ElementAt(indexOfCurrentMilestone);
        }

    }

}
