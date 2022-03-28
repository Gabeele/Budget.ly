using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Budget.ly
{
    static public class FileIO
    {
        private static string name = @"\Account.txt";

        public static void write(float balance, Goal g, List<Item> fin)
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

        public static void write(Account acc)
        {

        }

        public static Account ReadFromFile()
        {
            Account newAcc = new();

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
