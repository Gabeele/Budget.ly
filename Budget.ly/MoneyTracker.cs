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

            foreach (Bill bill in tempFinances)
            {
                sumOfBills += bill.getAmount();
                numBills++;
            }

            return (sumOfBills / numBills);

        }

        static public float averageExpense(Account account)
        {

            float sumOfExpenses = 0;
            int numExpenses = 0;

            Items tempFinances = account.getFinances();

            foreach (Expense expense in tempFinances)
            {
                sumOfExpenses += expense.getAmount();
                numExpenses++;
            }

            return (sumOfExpenses / numExpenses);

        }

        static public float averageIncome(Account account)
        {

            float sumOfIncome = 0;
            int numIncome = 0;

            Items tempFinances = account.getFinances();

            foreach (Income income in tempFinances)
            {
                sumOfIncome += income.getAmount();
                numIncome++;
            }

            return (sumOfIncome / numIncome);

        }

        static public float averageGain(Account account)
        {

            float sumOfGain = 0;
            int numGain = 0;

            Items tempFinances = account.getFinances();

            foreach (Income income in tempFinances)
            {
                sumOfGain += income.getAmount();
                numGain++;
            }

            return (sumOfGain / numGain);

        }

        static public float totalBill(Account account)
        {

            float sumOfBills = 0;

            Items tempFinances = account.getFinances();

            foreach (Bill bill in tempFinances)
            {
                sumOfBills += bill.getAmount();
            }

            return sumOfBills;

        }

        static public float totalExpense(Account account)
        {

            float sumOfExpenses = 0;

            Items tempFinances = account.getFinances();

            foreach (Expense expense in tempFinances)
            {
                sumOfExpenses += expense.getAmount();
            }

            return sumOfExpenses;

        }

        static public float totalIncome(Account account)
        {

            float sumOfIncome = 0;

            Items tempFinances = account.getFinances();

            foreach (Income income in tempFinances)
            {
                sumOfIncome += income.getAmount();
            }

            return sumOfIncome;

        }

        static public float totalGain(Account account)
        {

            float sumOfGain = 0;

            Items tempFinances = account.getFinances();

            foreach (Income income in tempFinances)
            {
                sumOfGain += income.getAmount();
            }

            return sumOfGain;

        }

    }

}
