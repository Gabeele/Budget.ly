using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget.ly
{


    public class Account : User, ISubject
    {

        private float accountBalance;
        private Goal goal;
        private Items finances;
        private AccountHistory accountHistory;
        private List<IObserver> observers;

        public Account()
        {

            this.accountBalance = 0;
            this.goal = null;
            this.finances = new Items();
            this.accountHistory = new AccountHistory() { };
            observers = new List<IObserver>();

        }

        public Account(string firstName, string lastName, float accountBalance) : base(firstName, lastName)
        {

            this.accountBalance = accountBalance;
            this.goal = null;
            this.finances = new Items();
            this.accountHistory = new AccountHistory() { };

        }

        public Account(string firstName, string lastName, float accountBalance, Goal goal, Items finances, AccountHistory accountHistory) : base(firstName, lastName)
        {

            this.accountBalance = accountBalance;
            this.goal = goal;
            this.finances = new Items();
            this.finances = finances;

            this.accountHistory = new AccountHistory() { };
            this.accountHistory = accountHistory;


            observers = new List<IObserver>();

        }

        public void SetBalance(float balance)
        {

            this.accountBalance = balance;
            NotfiyObservers();
        }

        public float GetBalance()
        {

            return this.accountBalance;

        }

        public void SetGoal(Goal goal)
        {
            this.goal = goal;
            NotfiyObservers();
        }

        public Goal GetGoal()
        {
            return this.goal;
        }
        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }

        public void NotfiyObservers()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update();
            }
        }
        public void SetFinances(Items finances)
        {

            this.finances = new Items();
            this.finances = finances;

        }

        public Items GetFinances()
        {

            return this.finances;

        }

        public void SetAccountHistory(AccountHistory accountHistory)
        {

            this.accountHistory = accountHistory;

        }

        public AccountHistory GetAccountHistory()
        {

            return this.accountHistory;

        }

        private void CreateMilestone()
        {

            Milestone milestone = new (this.accountBalance);
            this.accountHistory.AddMilestone(milestone);

        }

        public void UpdateHistory()
        {

            CreateMilestone();

        }

    }

}

