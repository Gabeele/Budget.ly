using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget.ly
{
    class Income : Gain
    {
        private int billInterval;

        public Income(int amount, string label, DateTime date, int billInterval) : base(amount, label, date)
        {
            SetBillInterval(billInterval);
        }

        public void SetBillInterval(int billInterval)
        {
            if (billInterval <= 0)
                this.billInterval = billInterval;
            else
                this.billInterval = 0;
        }

        public int GetBillInterval()
        {
            return billInterval;
        }
    }
}
