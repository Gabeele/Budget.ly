using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget.ly
{
    public class Expense :  Item
    {
        protected DateTime date;

        public Expense(float amount, string label, DateTime date) : base(amount, label)
        {
            this.date = date;
            this.SetItemType(ITEM_TYPE.Expense);
        }

        public void SetAmount(int amount)
        {
            if (amount < 0)
                this.amount = amount;
            else
                this.amount = 0;
        }

        public DateTime GetDate()
        {

            return this.date;

        }

        public override string Stringify()
        {

            return string.Format("{0} {1} {2} {3}", this.amount.ToString(), convertDate() , this.itemType.ToString(), this.label.ToString());

        }

        protected string convertDate()
        {
            string date_str;

            date_str = this.date.Day.ToString() + "/" + this.date.Month.ToString() + "/" + this.date.Year.ToString();

            return date_str;
        }


    }

}
