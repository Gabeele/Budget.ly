using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Budget.ly
{
    public class AccountHandler : IObserver
    {
        private Account acc;
        private float balance;
        private Goal goal;
        private Items finances;


        public AccountHandler(Account acc)
        {
            this.acc = acc;
            acc.RegisterObserver(this);
        }

        public void Update()
        {
            this.balance = acc.GetBalance();
            this.goal = acc.GetGoal();
            this.finances = acc.GetFinances();
            //write
        }

       
    }
}
