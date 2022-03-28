using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget.ly
{
    public class Milestone
    {
        private float accountBalance;

        public Milestone(float accountBalance)
        {

            this.accountBalance = accountBalance;

        }

        public void SetAccountBalance(float accountBalance)
        {
            
            this.accountBalance = accountBalance;

        }

        public float GetAccountBalance()
        {

            return this.accountBalance;

        }


    }

}
