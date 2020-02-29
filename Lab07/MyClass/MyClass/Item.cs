using System;
namespace MyClass
{
    public abstract class Item
    {
        /* declarating class variables */
        protected long invNumber; // inventory number
        protected bool taken; // state of the item

        /* default item constructor */
        public Item()
        {
            this.taken = true;
        }

        /* item constructor */
        public Item(long invNumber, bool taken)
        {
            this.invNumber = invNumber;
            this.taken = taken;
        }

        /* checking avaliability of item method */
        public bool IsAvailable()
        {
            if (taken == true)
                return true;
            else
                return false;
        }

        /* getting inventory number method */
        public long GetInvNumber()
        {
            return invNumber;
        }

        /* taking item method */
        private void Take()
        {
            taken = false;
        }

        /* returning item method */
        //public void Return()
        //{
        //    taken = true;
        //}
        //public virtual void Return()
        //{
        //    taken = true;
        //}
        public abstract void Return();

        /* printing information about item method */
        public virtual void Print()
        {
            Console.WriteLine($"Состояние единицы хранения:\n Инвентарный номер:" +
                $"{invNumber}\n Наличие: {taken}");
        }

        /* taking book method */
        public void TakeItem()
        {
            if (this.IsAvailable())
                this.Take();
        }

        /* default item class constructor */
        //public Item()
        //{
        //}
    }
}
