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

        public void setDescription(string description)
        {

            this.description = description;

        }

        public string getDescription()
        {

            return this.description;

        }

        public void setTargetAmount(float targetAmount)
        {

            this.targetAmount = targetAmount;

        }

        public void setTargetAmount(int targetAmount)
        {

            this.targetAmount = (float)targetAmount;

        }

        public float getTargetAmount()
        {

            return this.targetAmount;

        }

        public void setDate(DateTime date)
        {

            this.date = date;

        }

        public DateTime getDate()
        {

            return this.date;

        }

    }
}
