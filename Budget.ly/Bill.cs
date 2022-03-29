using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget.ly
{
    public class Bill : Expense
    {
        private int billInterval;

        public Bill(float amount, string label, DateTime date, int billInterval) : base (amount, label, date)
        {
            SetBillInterval(billInterval);
            this.SetItemType(ITEM_TYPE.Bill);
        }

        public void SetBillInterval(int billInterval)
        {
            if (billInterval >= 0)
                this.billInterval = billInterval;
            else
                this.billInterval = 0;
        }
        
        public int GetBillInterval()
        {
            return billInterval;
        }

        public override string Stringify()
        {

            return string.Format("{0} {1} {2} {3} {4}", this.amount.ToString(), convertDate(), this.itemType.ToString(), this.label.ToString(), this.billInterval.ToString());

        }

    }
}
