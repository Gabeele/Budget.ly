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

        static public bool IsGoalAttainable(Account account)
        {

            DateTime goalDate = account.GetGoal().GetDate();
            DateTime currDate = new DateTime();

            //Filter for cashflows only within the date-range (between now and 'date').

            float reoccuringCashFlow = (TotalIncome(account) - TotalBill(account));
            float oneTimeCashFlow = (TotalGain(account) - TotalExpense(account));

            if (reoccuringCashFlow + oneTimeCashFlow > 0)
            {
                return true;

            }

            else
            {

                return false;

            }

        }

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

            if(numBills == 0)
            {
                return 0;
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

            if (numExpenses == 0)
            {
                return 0;
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

            if (numIncome == 0)
            {
                return 0;
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

            if (numGain == 0)
            {
                return 0;
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

            if (sumOfBills == 0)
            {
                return 0;
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

            if (sumOfExpenses == 0)
            {
                return 0;
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
            if (sumOfIncome == 0)
            {
                return 0;
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

            if (sumOfGain == 0)
            {
                return 0;
            }

            return sumOfGain;

        }

    }

}
