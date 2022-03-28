using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget.ly
{
    public class Account : User
    {

        private float accountBalance;
        private Goal goal;
        private Items finances;
        private AccountHistory accountHistory;

        public Account()
        {

            this.setFirstName("");
            this.setLastName("");
            this.accountBalance = 0;
            this.goal = null;
            this.finances = new Items();
            this.accountHistory = new AccountHistory() {};

        }

        public Account(string firstName, string lastName, float accountBalance) : base (firstName, lastName)
        {
          
            this.accountBalance = accountBalance;
            this.goal = null;
            this.finances = new Items();
            this.accountHistory = new AccountHistory() {};
        
        }

        public Account(string firstName, string lastName, float accountBalance, Goal goal, ItemList finances, AccountHistory accountHistory) : base (firstName, lastName)
        {

            this.accountBalance=accountBalance;
            this.goal=goal;
            this.finances = new Items();
            this.finances = finances;
            this.accountHistory = new AccountHistory() {};
            this.accountHistory = accountHistory;

        }

        public void setBalance(float balance)
        {

            this.accountBalance = balance;

        }

        public float getBalance()
        {

            return this.accountBalance;

        }

        public void setGoal(Goal goal)
        {

            this.goal = goal;

        }

        public Goal getGoal()
        {

            return this.goal;

        }
        public void setFinances(Items finances)
        {
            
            this.finances = new Items();
            this.finances = finances;

        }

        public Items getFinances()
        {

            return this.finances;

        }

        public void setAccountHistory(AccountHistory accountHistory)
        {

            this.accountHistory = accountHistory;

        }

        public AccountHistory getAccountHistory()
        {

            return this.accountHistory;

        }

        private void createMilestone()
        {

            Milestone milestone = new Milestone(this.accountBalance);
            this.accountHistory.addMilestone(milestone);

        }

        public void updateHistory()
        {

            createMilestone();

        }

    }
}
