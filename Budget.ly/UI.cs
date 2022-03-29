using System;
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

        public UI(Account account)
        {
            this.account = account;
            AccountHandler newAccountHandler = new(this.account);
        }

        public void createAccount()
        {

            Console.WriteLine("We've detected a first-time user. Please enter some basic information");

            Console.WriteLine("Enter in first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter in last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter in your account balance: ");
            float acctBalance = float.Parse(Console.ReadLine());

            this.account = new Account(firstName, lastName, acctBalance);

            AccountHandler newAccountHandler = new(this.account);

        }

        public bool PrintMenu()
        {
            bool isRunning = true;

            do
            {
                Console.WriteLine("Budget.ly - Budget Goal Software\n\n");
                if (this.account.GetGoal() != null)
                {
                    Console.WriteLine("Goal: {0}\n", GoalStatus());
                    Console.WriteLine("Balance: ${0} Goal Target: ${1}\n", account.GetBalance(), account.GetGoal().GetTargetAmount());
                }
                else if (this.account.GetGoal() == null)
                {

                    Console.WriteLine("Goal: Not set.\n");
                    Console.WriteLine("Balance: ${0} Goal Target: Not set.\n", account.GetBalance());

                }
                
                Console.WriteLine("Avg Bill: ${0}\nAvg Income: ${1}\nAvg Expense: ${2}\nAvg Gain: ${3}\n", averageBill(), averageIncome(), averageExpense(), averageGain());
                Console.WriteLine("\t1] Add Expense\n\t2] Add Gain\n\t3] Add Income\n\t4] Add Bill\n\t5] Set a goal\n\t0] Exit\n\t");

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
                Console.WriteLine("Enter in Option: ");
                string input = Console.In.ReadLine();
                if (input.All(Char.IsDigit))
                {
                    option = int.Parse(input);

                    isNumber = true;
                }

            } while (!isNumber);

            return option;
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
                        //One time outflow
                        addExpense(getAmount(), getLabel(), getDate());
                        break;
                    case 2:
                        //One time inflow
                        addGainz(getAmount(), getLabel(), getDate());
                        break;
                    case 3:
                        addIncome(getAmount(), getLabel(), getDate(), getInterval());
                        break;
                    case 4:
                        addBill(getAmount(), getLabel(), getDate(), getInterval());
                        break;
                    case 5:
                        createAGoal(getLabel(), getAmount(), getDate());
                        break;
                    //case 6:
                    //    viewRecurringIncome();
                    //    break;
                    case 0:
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
            if (MoneyTracker.IsGoalAttainable(this.account))
            {
                return "On track!";

            }
            else
            {
                return "Uh oh! Bank account is crying :'(";
            }

        }

        private void createAGoal(string description, float targetAmount, DateTime date)
        {
                       
            Goal newGoal = new(description, targetAmount, date);
            this.account.SetGoal(newGoal);

        }

        private void addExpense(float amount, string label, DateTime date)
        {

            Expense exp = new Expense(amount, label , date);
            account.GetFinances().add(exp);
        }

        private void addIncome(float amount, string label, DateTime date, int interval)
        {

            Income inc = new Income(amount, label, date, interval);
            account.GetFinances().add(inc);

        }

        private void addBill(float amount, string label, DateTime date, int interval)
        {

            Bill b = new Bill(amount, label, date, interval);
            account.GetFinances().add(b);

        }

        private void addGainz(float amount, string label, DateTime date)
        {
            Gain gain = new Gain(amount, label, date);
            account.GetFinances().add(gain);

        }

        private string getLabel()
        {
            string label;

            Console.WriteLine("Enter a description for the item: ");
            label = Console.ReadLine();

            return label;
        }
        
        private float getAmount()
        {
            string amount_str;
            float amount = 0;
            bool isDigit = false;

            do
            {
                
                Console.WriteLine("Enter in the amount: ");
                if(float.TryParse(Console.ReadLine(), out amount))
                {
                    isDigit = true;
                    break;
                }

            } while (!isDigit);

            return amount;
        }

        private DateTime getDate()
        {
           
            Console.Write("Enter a month (1-12): ");
            int month = int.Parse(Console.ReadLine());

            Console.Write("Enter a day: ");
            int day = int.Parse(Console.ReadLine());

            Console.Write("Enter a year: ");
            int year = int.Parse(Console.ReadLine());

            DateTime date = new DateTime(year, month, day);

            return date;

        }

        private int getInterval()
        {

            int interval;
            bool isDigit = false;

            do
            {

                Console.Write("How many times does this item re-occur in a month:");
                if (int.TryParse(Console.ReadLine(), out interval))
                {
                    isDigit = true;
                    break;
                }

            } while (!isDigit);

            return interval;

        }

        private void viewRecurringBill()
        {
        
        }

        private void viewRecurringIncome()
        {

        }

        private float averageExpense()
        {
            return  MoneyTracker.AverageExpense(this.account);
            
        }

        private float averageGain()
        {
            return MoneyTracker.AverageGain(this.account);
        }

        private float averageIncome()
        {
            return MoneyTracker.AverageIncome(this.account);
        }

        private float averageBill()
        {
            return MoneyTracker.AverageBill(this.account);
        }

        private void terminate()
        {

            FileIO.write(this.account);

        }

    }
}
