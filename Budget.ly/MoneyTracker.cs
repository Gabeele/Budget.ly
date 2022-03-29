using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget.ly
{
    static public class MoneyTracker
    {

        //static public int CalculateDaysToReachGoal(Account account)
        //{
        //    int daysToReachGoal;
            
        //    //Calculates the amount of 'intervals' it will take for the account to reach its goal, based on income and expense items of the account.
        //    float tempGoalAmount = account.GetGoal().GetTargetAmount();

        //    float reoccuringCashFlow = (TotalIncome(account) - TotalBill(account));
        //    float oneTimeCashFlow = (TotalGain(account) - TotalExpense(account));



        //    return daysToReachGoal;    //TODO return the date
        //}

        static public float AverageItem(Account account)
        {

            return ((AverageBill(account) + AverageExpense(account) + AverageIncome(account) + AverageGain(account)) / 4);

        }

        static public float AverageBill(Account account)
        {

            float sumOfBills = 0;
            int numBills = 0;

            Items tempFinances = account.GetFinances();

            while (tempFinances.Iterator().HasNext())
            {

                Item tempItem = (Item)tempFinances.Iterator().Next();
       
                if (tempItem.GetItemType() == ITEM_TYPE.Bill)
                {

                    sumOfBills += tempItem.GetAmount();
                    numBills++;

                }

            }

            return (sumOfBills / numBills);

        }

        static public float AverageExpense(Account account)
        {

            float sumOfExpenses = 0;
            int numExpenses = 0;

            Items tempFinances = account.GetFinances();

            while (tempFinances.Iterator().HasNext())
            {

                Item tempItem = (Item)tempFinances.Iterator().Next();

                if (tempItem.GetItemType() == ITEM_TYPE.Expense)
                {

                    sumOfExpenses += tempItem.GetAmount();
                    numExpenses++;

                }

            }

            return (sumOfExpenses / numExpenses);

        }

        static public float AverageIncome(Account account)
        {

            float sumOfIncome = 0;
            int numIncome = 0;

            Items tempFinances = account.GetFinances();

            while (tempFinances.Iterator().HasNext())
            {

                Item tempItem = (Item)tempFinances.Iterator().Next();

                if (tempItem.GetItemType() == ITEM_TYPE.Income)
                {

                    sumOfIncome += tempItem.GetAmount();
                    numIncome++;

                }

            }

            return (sumOfIncome / numIncome);

        }

        static public float AverageGain(Account account)
        {

            float sumOfGain = 0;
            int numGain = 0;

            Items tempFinances = account.GetFinances();

            while (tempFinances.Iterator().HasNext())
            {

                Item tempItem = (Item)tempFinances.Iterator().Next();

                if (tempItem.GetItemType() == ITEM_TYPE.Gain)
                {

                    sumOfGain += tempItem.GetAmount();
                    numGain++;

                }

            }

            return (sumOfGain / numGain);

        }

        static public float TotalBill(Account account)
        {

            float sumOfBills = 0;

            Items tempFinances = account.GetFinances();

            while (tempFinances.Iterator().HasNext())
            {

                Item tempItem = (Item)tempFinances.Iterator().Next();

                if (tempItem.GetItemType() == ITEM_TYPE.Gain)
                {

                    sumOfBills += tempItem.GetAmount();

                }

            }

            return sumOfBills;

        }

        static public float TotalExpense(Account account)
        {

            float sumOfExpenses = 0;

            Items tempFinances = account.GetFinances();

            while (tempFinances.Iterator().HasNext())
            {

                Item tempItem = (Item)tempFinances.Iterator().Next();

                if (tempItem.GetItemType() == ITEM_TYPE.Expense)
                {

                    sumOfExpenses += tempItem.GetAmount();

                }

            }

            return sumOfExpenses;

        }

        static public float TotalIncome(Account account)
        {

            float sumOfIncome = 0;

            Items tempFinances = account.GetFinances();

            while (tempFinances.Iterator().HasNext())
            {

                Item tempItem = (Item)tempFinances.Iterator().Next();

                if (tempItem.GetItemType() == ITEM_TYPE.Income)
                {

                    sumOfIncome += tempItem.GetAmount();

                }

            }

            return sumOfIncome;

        }

        static public float TotalGain(Account account)
        {

            float sumOfGain = 0;

            Items tempFinances = account.GetFinances();


            while (tempFinances.Iterator().HasNext())
            {

                Item tempItem = (Item)tempFinances.Iterator().Next();

                if (tempItem.GetItemType() == ITEM_TYPE.Gain)
                {

                    sumOfGain += tempItem.GetAmount();

                }

            }

            return sumOfGain;

        }

    }

}
