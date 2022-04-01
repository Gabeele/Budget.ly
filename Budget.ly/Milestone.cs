using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget.ly
{
    public class Milestone
    {
        private List<Item> list;

        public Milestone(List<Item> list)
        {

            this.list = list;

        }

        public void SetList(List<Item> list)
        {
            this.list = list;

        }

        public List<Item> GetList()
        {

            return this.list;

        }


    }

}
