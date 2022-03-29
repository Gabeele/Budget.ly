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

        }

        public bool PrintMenu()
        {
            bool isRunning = true;

            do
            {
                Console.WriteLine("Budget.ly - Budget Goal Software\n\n");
                Console.WriteLine("Balance: {0} Goal: {1}\n", account.GetBalance(), account.GetGoal());
                Console.WriteLine("Avg Expense: {0} Avg Gain: {1} On target: {2}\n", ExpenseAverage(), GainAverage(), GoalStatus());
                Console.WriteLine("\t1] Add expense\n\t2] Add Gain\n\t3] View reoccuring bills\n\t4] View reoccuring income\n\t5] Set a goal\n\t0] Exit\n\t");

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
                        addExpense(getAmount(), getLabel(), getDate());
                        break;
                    case 2:
                        addGainz(getAmount(), getLabel(), getDate());
                        break;
                    //case 3:
                    //    addRecurringGainz(getAmount(), getLabel(), getDate());
                    //    break;
                    //case 4:
                    //    addRecurringGainz(getAmount(), getLabel(), getDate());
                    //    break;
                    case 5:
                        viewRecurringBill();
                        break;
                    case 6:
                        viewRecurringIncome();
                        break;
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
            //Determine the goal status 
            return null;
        }

        private void addExpense(float amount, string label, DateTime date)
        {

            Expense exp = new Expense(amount, label , date);
            account.GetFinances().add(exp);
        }

        private void addGainz(float amount, string label, DateTime date)
        {
            Gain gain = new Gain(amount, label, date);
            account.GetFinances().add(gain);

        }

        private string getLabel()
        {
            string label;

            Console.WriteLine("Enter in label: ");
            label = Console.ReadLine();

            return label;
        }
        
        private float getAmount()
        {
            string amount_str;
            float amount;
            bool isDigit = false;

            do
            {
                
                Console.WriteLine("Enter in the amount: ");
                if(!float.TryParse(Console.ReadLine(), out amount))
                {
                    isDigit = true;
                    break;
                }

            } while (!isDigit);

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
