using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget.ly
{
    public class Account : User, Subject
    {

        float accountBalance;
        Goal goal;
        List<Item> finances;
        private List<Observer> observers;

        public Account(float accountBalance)
        {

            this.accountBalance = accountBalance;
            this.goal = goal;
            this.finances = new List<Item>();
            observers = new List<Observer>();

        }

        public Account(float accountBalance, Goal goal, List<Item> finances)
        {

            this.accountBalance=accountBalance;
            this.goal=goal;
            this.finances = new List<Item>();
            this.finances = finances;
            observers = new List<Observer>();
        }

        public void setBalance(float balance)
        {

            this.accountBalance = balance;
            notfiyObservers();
        }

        public float getBalance()
        {

            return this.accountBalance;

        }

        public void setGoal(Goal goal)
        {
            this.goal = goal;
            notfiyObservers();
        }

        public Goal getGoal()
        {
            return this.goal;
        }
        public void registerObserver(Observer o)
        {
            observers.Add(o);
        }

        public void removeObserver(Observer o)
        {
            observers.Remove(o);
        }

        public void notfiyObservers()
        {
            foreach(Observer observer in observers)
            {
                observer.update();
            }
        }

    }
}
