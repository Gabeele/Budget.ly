using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget.ly
{
    static public class MoneyTracker
    {

        static public DateTime calculate(Account account)
        {
            //Calculates the amount of 'intervals' it will take for the account to reach its goal, based on income and expense items of the account.
            float tempGoalAmount = account.getGoal().getTargetAmount();

            float reoccuringCashFlow = (totalIncome(account) - totalBill(account));
            float oneTimeCashFlow = (totalGain(account) - totalExpense(account));

            return null;    //TODO return the date
        }

        static public float averageItem(Account account)
        {

            return ((averageBill(account) + averageExpense(account) + averageIncome(account) + averageGain(account)) / 4);

        }

        static public float averageBill(Account account)
        {

            float sumOfBills = 0;
            int numBills = 0;

            Items tempFinances = account.getFinances();

            while (tempFinances.iterator().hasNext())
            {

                Item tempItem = (Item)tempFinances.iterator().next();
       
                if (tempItem.GetItemType() == ITEM_TYPE.Bill)
                {

                    sumOfBills += tempItem.GetAmount();
                    numBills++;

                }

            }

            return (sumOfBills / numBills);

        }

        static public float averageExpense(Account account)
        {

            float sumOfExpenses = 0;
            int numExpenses = 0;

            Items tempFinances = account.getFinances();

            while (tempFinances.iterator().hasNext())
            {

                Item tempItem = (Item)tempFinances.iterator().next();

                if (tempItem.GetItemType() == ITEM_TYPE.Expense)
                {

                    sumOfExpenses += tempItem.GetAmount();
                    numExpenses++;

                }

            }

            return (sumOfExpenses / numExpenses);

        }

        static public float averageIncome(Account account)
        {

            float sumOfIncome = 0;
            int numIncome = 0;

            Items tempFinances = account.getFinances();

            while (tempFinances.iterator().hasNext())
            {

                Item tempItem = (Item)tempFinances.iterator().next();

                if (tempItem.GetItemType() == ITEM_TYPE.Income)
                {

                    sumOfIncome += tempItem.GetAmount();
                    numIncome++;

                }

            }

            return (sumOfIncome / numIncome);

        }

        static public float averageGain(Account account)
        {

            float sumOfGain = 0;
            int numGain = 0;

            Items tempFinances = account.getFinances();

            while (tempFinances.iterator().hasNext())
            {

                Item tempItem = (Item)tempFinances.iterator().next();

                if (tempItem.GetItemType() == ITEM_TYPE.Gain)
                {

                    sumOfGain += tempItem.GetAmount();
                    numGain++;

                }

            }

            return (sumOfGain / numGain);

        }

        static public float totalBill(Account account)
        {

            float sumOfBills = 0;

            Items tempFinances = account.getFinances();

            while (tempFinances.iterator().hasNext())
            {

                Item tempItem = (Item)tempFinances.iterator().next();

                if (tempItem.GetItemType() == ITEM_TYPE.Gain)
                {

                    sumOfBills += tempItem.GetAmount();

                }

            }

            return sumOfBills;

        }

        static public float totalExpense(Account account)
        {

            float sumOfExpenses = 0;

            Items tempFinances = account.getFinances();

            while (tempFinances.iterator().hasNext())
            {

                Item tempItem = (Item)tempFinances.iterator().next();

                if (tempItem.GetItemType() == ITEM_TYPE.Expense)
                {

                    sumOfExpenses += tempItem.GetAmount();

                }

            }

            return sumOfExpenses;

        }

        static public float totalIncome(Account account)
        {

            float sumOfIncome = 0;

            Items tempFinances = account.getFinances();

            while (tempFinances.iterator().hasNext())
            {

                Item tempItem = (Item)tempFinances.iterator().next();

                if (tempItem.GetItemType() == ITEM_TYPE.Income)
                {

                    sumOfIncome += tempItem.GetAmount();

                }

            }

            return sumOfIncome;

        }

        static public float totalGain(Account account)
        {

            float sumOfGain = 0;

            Items tempFinances = account.getFinances();


            while (tempFinances.iterator().hasNext())
            {

                Item tempItem = (Item)tempFinances.iterator().next();

                if (tempItem.GetItemType() == ITEM_TYPE.Gain)
                {

                    sumOfGain += tempItem.GetAmount();

                }

            }

            return sumOfGain;

        }

    }

}
