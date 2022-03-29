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
