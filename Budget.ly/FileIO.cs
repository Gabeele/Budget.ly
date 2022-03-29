﻿using System;
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
            IIterator tempIterator = acc.GetFinances().Iterator();
            while (tempIterator.HasNext())
            {

               Item tempItem = (Item)tempIterator.Next();

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

                    string[] date_str = words[4].Split('-');
                    
                    //constructed with Y/M/D
                    DateTime date = new(int.Parse(date_str[0]), int.Parse(date_str[1]), int.Parse(date_str[2]));

                    Goal goal = new(words[3], float.Parse(words[7]), date);

                    newAcc.SetGoal(goal);

                    
                for (int i = 1; i < allLines.Length; i++)
                {

                    string[] item = allLines[i].Split(" ");
                    string itemType = item[4];

                    string[] tempDateStr = item[1].Split('-');
                    DateTime tempDate = new(int.Parse(tempDateStr[0]), int.Parse(tempDateStr[1]), int.Parse(tempDateStr[2]));

                    if (itemType == "Expense")
                    {

                        Expense tempExpense = new(float.Parse(item[0]), item[5], tempDate);
                        newAcc.GetFinances().add(tempExpense);

                    }
                    if (itemType == "Gain")
                    {

                        Expense tempGain = new(float.Parse(item[0]), item[5], tempDate);
                        newAcc.GetFinances().add(tempGain);
                    }
                    if (itemType == "Income")
                    {

                        Income tempIncome = new(float.Parse(item[0]), item[5], tempDate, int.Parse(item[6]));
                        newAcc.GetFinances().add(tempIncome);
                    }
                    if (itemType == "Bill")
                    {

                        Bill tempBill = new(float.Parse(item[0]), item[5], tempDate, int.Parse(item[6]));
                        newAcc.GetFinances().add(tempBill);
                    }

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
