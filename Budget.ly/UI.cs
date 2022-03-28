﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget.ly
{
    public class UI
    {
        private Account account;


        public UI()
        {
           
        }

        public void selectAccount()
        {
            //Option to select the account
        }

        public bool PrintMenu()
        {
            bool isRunning = true;

            do
            {
                Console.WriteLine("Budget.ly - Budget Goal Software\n\n");
                Console.WriteLine("Balance: %d Goal: %d\n", account.getBalance(), account.getGoal());
                Console.WriteLine("Avg Expense: %d Avg Gain: %d On target: %d\n", ExpenseAverage(), GainAverage(), GoalStatus());
                Console.WriteLine("\t1] Add expense\n\t2] Add Gain\n\t3] View reoccuring bills\n\t4] View reoccuring income\n0] Exit\n\t");

                isRunning = optionSelect();

            } while (isRunning);

            return false;
        }

        private int getOption()
        {
            bool isNumber = false;
            int option = -1;

            do
            {
                string input = Console.In.ReadLine();
                if (input.All(Char.IsDigit))
                {
                    option = int.Parse(input);

                    isNumber = true;
                }

            } while (isNumber);

            return 0;
        }

        private bool optionSelect()
        {
            bool rerun = false;

            do
            {
                rerun = false;
                int option = getOption();
                

                switch (option)
                {
                    case 1:
                        addExpense();
                        break;
                    case 2:
                        addGainz();
                        break;
                    case 3:
                        viewRecurringBill();
                        break;
                    case 4:
                        viewRecurringIncome();
                        break;
                    case 5:
                        terminate();
                        return false;
                    default:
                        rerun = true;
                        break;
                }


            } while (rerun);

            return true;
        }

        private string GoalStatus()
        {
            //Determine the goal status 
            return null;
        }

        private void addExpense()
        {

            Expense exp = new Expense(amount, label , date);
            account.item.Add(exp);
        }

        private void addGainz(int amount, string label, DateTime date)
        {
            Gain gain = new Gain(amount, label, date);
            account.item.Add(gain);
        }

        private void itemInput()
        {
            string label, amount_str;
            int amount;
            DateTime date;

            Console.WriteLine("Enter in label: ");
            label = Console.ReadLine();

            do
            {
                Console.WriteLine("Enter in the amount: ");
                amount_str = Console.ReadLine();

            } while (amount_str.All(char.IsDigit));

            amount = int.Parse(amount_str);

            date = getDate();

        }

        private float getAmount()
        {
            string amount_str;
            int amount;

            do
            {
                Console.WriteLine("Enter in the amount: ");
                float.TryParse(Console.ReadLine(), out amount);

            } while (amount_str.All(char.IsDigit));

            amount = float.TryParse(amount_str);

            return amount;
        }

        private DateTime getDate()
        {
           
            Console.Write("Enter a month: ");
            int month = int.Parse(Console.ReadLine());

            Console.Write("Enter a day: ");
            int day = int.Parse(Console.ReadLine());

            Console.Write("Enter a year: ");
            int year = int.Parse(Console.ReadLine());

            DateTime date = new DateTime(year, month, day);

            return date;

        }

        private void viewRecurringBill()
        {
        
        }

        private void viewRecurringIncome()
        {

        }

        private int ExpenseAverage()
        {

            return 1;
        }

        private int GainAverage()
        {
            return 1;
        }

        private void terminate()
        {

        }

    }
}
