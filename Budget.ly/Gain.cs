using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget.ly
{
    public class Gain : Item
    {
        protected DateTime date;

        public Gain(float amount, string label, DateTime date) : base(amount, label)
        {
            this.date = date;
        }

        new public void SetAmount(float amount)
        {
            if (amount < 0)
                this.amount = amount;
            else
                this.amount = 0;
        }
    }
}
