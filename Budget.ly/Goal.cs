using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget.ly
{
    public class Goal
    {

        private string description;
        private float targetAmount;
        private DateTime date;

        public Goal(string description, float targetAmount, DateTime date)
        {

            this.description = description;
            this.targetAmount = targetAmount;
            this.date = date;

        }

        public Goal(string description, float targetAmount)
        {

            this.description = description;
            this.targetAmount = targetAmount;

        }

        public void SetDescription(string description)
        {

            this.description = description;

        }

        public string GetDescription()
        {

            return this.description;

        }

        public void SetTargetAmount(float targetAmount)
        {

            this.targetAmount = targetAmount;

        }

        public float GetTargetAmount()
        {

            return this.targetAmount;

        }

        public void SetDate(DateTime date)
        {

            this.date = date;

        }

        public DateTime GetDate()
        {

            return this.date;

        }
        public string Stringify()
        {

            return string.Format("{0} {1} {2}", this.description.ToString(), convertDate(), this.targetAmount.ToString());

        }

        protected string convertDate()
        {
            string date_str;

            date_str = this.date.Day.ToString() + "/" + this.date.Month.ToString() + "/" + this.date.Year.ToString();

            return date_str;
        }
    }
}
