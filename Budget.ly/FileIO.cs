using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Budget.ly
{
    public static class FileIO
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
            TextWriter writer = new StreamWriter(name);

            if (!File.Exists(name))
            {
                File.Create(name);
            }

            writer.WriteLine(acc.Stringify());

            while (acc.GetFinances().Iterator().HasNext())
            {

               Item tempItem = (Item)acc.GetFinances().Iterator().Next();

               writer.WriteLine(tempItem.Stringify());

            }

            writer.Flush();
            writer.Close();

        }

        public static Account ReadFromFile()
        {
            Account newAcc = new();

            if (File.Exists(name))
            {

                string[] allLines = File.ReadAllLines(name);

                foreach (string line in allLines)
                {

                    string[] words = line.Split(" ");

                    newAcc = new (words[0], words[1], float.Parse(words[2]));
                }

            }

            else
            {
                newAcc = null;
            }

            return newAcc;
        }
    }
}
