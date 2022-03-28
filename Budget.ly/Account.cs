using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget.ly
{
    internal class Account
    {

        float accountBalance;
        Goal goal;
        List<Item> finances;

        public Account(float accountBalance)
        {

            this.accountBalance = accountBalance;
            this.goal = goal;
            this.finances = new List<Item>();

        }

        public Account(float accountBalance, Goal goal, List<Item> finances)
        {

            this.accountBalance=accountBalance;
            this.goal=goal;
            this.finances = new List<Item>();
            this.finances = finances;
                        
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

    }
}
