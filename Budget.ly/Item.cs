using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget.ly
{
    public enum ITEM_TYPE { Expense, Bill, Income, Gain, None };

    public class Item
    {
        protected float amount;
        protected string label;
        protected ITEM_TYPE itemType;

        public Item()
        {
            amount = 0;
            label = "blank";
            itemType = ITEM_TYPE.None;
        }

        public Item(float amount, string label)
        {
            this.amount = amount;
            this.label = label;
            this.itemType = ITEM_TYPE.None;
        }

        public void SetAmount(float amount)
        {
            this.amount = amount;
        }

        public float GetAmount()
        {
            return this.amount;
        }

        public void SetLabel(string label)
        {
            this.label = label;
        }

        public string GetLabel()
        {
            return this.label;
        }

        public void SetItemType(ITEM_TYPE itemType)
        {
            this.itemType = itemType;
        }

        public ITEM_TYPE GetItemType()
        {
            return this.itemType;
        }
    }
}
