using System;
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

        public AccountHandler(Account acc)
        {
            this.acc = acc;
            acc.RegisterObserver(this);
        }

        public void Update()
        {

            FileIO.write(acc);  //TODO for some reason it is not calling

        }
               
    }

}
