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
        private static string name = "Account.txt";

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
                string line = allLines[0];

                    string[] words = line.Split(" ");


                    newAcc = new (words[0], words[1], float.Parse(words[2]));

                    string[] date_str = words[4].Split('/');

                    DateTime date = new(int.Parse(date_str[2]), int.Parse(date_str[1]), int.Parse(date_str[0]));

                    Goal goal = new(words[3], float.Parse(words[7]), date);

                    newAcc.SetGoal(goal);


                    //Read in all items
                   foreach (string meh in allLines){
                        //Start reding after 1
                
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
