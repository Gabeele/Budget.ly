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

        public void addMilestone(Milestone milestone)
        {

            accountHistory.Add(milestone);
            indexOfCurrentMilestone++;

        }

    }

}
