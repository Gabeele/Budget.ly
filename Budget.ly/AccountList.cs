using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget.ly
{
    public class AccountList
    {

        List<Account> accounts;

        public AccountList()
        {

            this.accounts = new List<Account>() {};

        }

        public void addAccount(Account account)
        {

            this.accounts.Add(account);

        }

        void removeUser(Account rmAcc)
        {

            foreach (Account account in this.accounts)
            {

                if (account == rmAcc)
                {

                    this.accounts.Remove(account);

                }

            }

        }

        //TODO Call on the account handeler

    }
}
