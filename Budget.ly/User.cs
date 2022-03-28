using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget.ly
{
    public class User
    {
        
        private string firstName;
        private string lastName;

        public User(string firstName, string lastName)
        {

            this.firstName = firstName;
            this.lastName = lastName;

        }

        public void setFirstName(string firstName)
        {

            this.firstName=firstName;

        }

        public void setLastName(string lastName)
        {

            this.lastName=lastName;

        }

        public string getFirstName()
        {

            return this.firstName;

        }

        public string getLastName()
        {

            return this.lastName;

        }

    }

}
