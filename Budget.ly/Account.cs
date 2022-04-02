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
        private ItemHistory history;
        private List<IObserver> observers;

        public Account()
        {

            this.accountBalance = 0;
            this.goal = null;
            this.finances = new Items() { };
            this.history = new ItemHistory() { };
            observers = new List<IObserver>();

        }

        public Account(string firstName, string lastName, float accountBalance) : base(firstName, lastName)
        {

            this.accountBalance = accountBalance;
            this.goal = null;
            this.finances = new Items() { };
            this.history = new ItemHistory() { };
            observers = new List<IObserver>();

        }

        public Account(string firstName, string lastName, float accountBalance, Goal goal, Items finances, ItemHistory history) : base(firstName, lastName)
        {

            this.accountBalance = accountBalance;
            this.goal = goal;
            this.finances = new Items() { };
            this.finances = finances;

            this.history = new ItemHistory() { };
            this.history = history;


            observers = new List<IObserver>();
           

        }

        public void SetFirstName(string firstName)
        {
            this.firstName = firstName;
            NotfiyObservers();
        }

        public void SetLastName(string lastName)
        {
            this.lastName = lastName;
            NotfiyObservers();
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

        public void add(Item item)
        {
            //make a new item list (Items) and copy values from current
            Items tempfinances = new Items(this.finances);
  
            //make a milestone out of this templist, so that memory is different.
            history.AddMilestone(tempfinances.createMemento());

            //now add the item to the actual account item list (finances).
            
            this.finances.add(item);
            NotfiyObservers();
        }

        public void SetItemHistory(ItemHistory history)
        {

            this.history = history;

        }

        public ItemHistory GetAccountHistory()
        {

            return this.history;

        }

        public string Stringify()
        {

            return string.Format("{0} {1} {2} {3}", this.firstName, this.lastName, this.accountBalance.ToString(), this.goal.Stringify());

        }

    }

}

