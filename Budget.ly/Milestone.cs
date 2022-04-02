using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget.ly
{
    public class Milestone
    {
        private List<Items> list;

        public Milestone(Items list)
        {
            this.list = new List<Items> {};
            this.list.Add(list);

        }

        //public Items GetRecent()
        //{

        //    return this.list;

        //}




    }

}
