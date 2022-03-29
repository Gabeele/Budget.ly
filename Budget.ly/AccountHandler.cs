﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Budget.ly
{
    public class AccountHandler : IObserver
    {
        private Account acc;
        private string firstName;
        private string lastName;
        private float balance;
        private Goal goal;
        private Items finances;

        public AccountHandler(Account acc)
        {
            this.acc = acc;
            acc.RegisterObserver(this);
        }

        public void Update()
        {
            this.balance = acc.GetBalance();
            this.goal = acc.GetGoal();
            this.finances = acc.GetFinances();
            this.firstName = acc.GetFirstName();
            this.lastName = acc.GetLastName();

            FileIO.write(acc);  //TODO for some reason it is not calling

        }
               
    }

}
