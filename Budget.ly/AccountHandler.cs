using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Budget.ly
{
    public class AccountHandler : Observer
    {
        private Account acc;
        private float balance;
        private Goal goal;
        private Items finances;
        private string name = @"\Account.txt";

        public AccountHandler(Account acc)
        {
            this.acc = acc;
            acc.registerObserver(this);
        }

        public void update()
        {
            this.balance = acc.getBalance();
            this.goal = acc.getGoal();
            this.finances = acc.getFinances();
        }

        void writeToFile(float balance, Goal g, List<Item> fin)
        {
            TextWriter writer = new StreamWriter(name);
           
            if (!File.Exists(name))
            {
                File.Create(name);
            }

            writer.WriteLine(balance + ", " + g + ", " + fin);
            writer.Flush();
            writer.Close();
        }

        Account readFromFile()
        {
            Account newAcc = new Account();

            string[] allLines = File.ReadAllLines(name);

            foreach (string line in allLines)
            {

                string[] words = line.Split(',');

                //TODO: Change how the words are processed
                //newAcc.setBalance(words[0]);
                //newAcc.setGoal(words[1]);
                //newAcc.setFinance(words[2]);
            }

            return newAcc;
        }
    }
}
