using System;
using System.IO;

namespace Budget.ly
{
    class Program
    {
        static void Main(string[] args)
        {
  
            Account account = FileIO.ReadFromFile();
            
            if (account != null)
            {
                account.GetAccountHistory().AddMilestone(account.GetFinances().createMemento());  //Creates the base memento
                UI newUI = new(account);
                newUI.PrintMenu();

            }
            else
            {

                UI newUI = new();
                newUI.createAccount();
                newUI.PrintMenu();

            }

        }
    }
}
