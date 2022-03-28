using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget.ly
{
    class Expense :  Item
    {
        protected DateTime date;

        public Expense(int amount, string label, DateTime date) : base(amount, label)
        {
            this.date = date;
        }

        new public void SetAmount(int amount)
        {
            if (amount < 0)
                this.amount = amount;
            else
                this.amount = 0;
        }

    }
}
