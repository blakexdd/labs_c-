using System;
namespace MyClass
{
    public class Book : Item, IPr
    {
        /* initializing class variables */
        private static double price;

        /* book class defautl constructor */
        //public Book()
        //{

        //}

        /* book class constructor */
        public Book(string author, string title, Publisher publisher,
            int pages, int year, long invNumber, bool taken) : base(invNumber, taken)
        {
            this.Author = author;
            this.Title = title;
            this.Pub1 = publisher;
            this.Pages = pages;
            this.Year = year;
        }

        /* book class constructor */
        //public Book(string author, string title, string publisher,
        //    int pages, int year)
        //{
        //    this.Author = author;
        //    this.Title = title;
        //    this.Publisher = publisher;
        //    this.Pages = pages;
        //    this.Year = year;
        //}

        /* overloaded book class constructor */
        //public Book(string author, string title)
        //{
        //    this.Author = author;
        //    this.Title = title;
        //}

        /* book static constructor */
        static Book()
        {
            Price = 9;
        }

        public string Author { get; set; } // author
        public string Title { get; set; } // title
        public Publisher Pub1 { get; set; }
        //public string Publisher { get; set; } // publisher
        public int Pages { get; set; } // pages amount
        public int Year { get; set; } // pubslish date

        /* Automatic property for price */
        public static double Price
        {
            get { return price; }
            set { if (value > 9) price = value; }
        }

        /* setting characteristics method */
        public void SetBook(string author, string title, Publisher publisher,
            int pages, int year)
        {
            this.Author = author;
            this.Title = title;
            this.Pub1 = publisher;
            this.Pages = pages;
            this.Year = year;
        }

        /* setting price method */
        public void SetPrice(double price)
        {
            Book.Price = price;
        }

        /* overloadding to string method */
        public override string ToString()
        {
            string bs = String.Format("\nКнига:\nАвтор: {0}\nНазвание: {1}\n" +
                "Год издания: {2}\n {3} стр.\n Стоимость аренды: {4}\n" +
                "Издательство {5}",
                Author, Title, Year, Pages, Book.price, Pub1.ToString());

            return bs;
        }

        /* printing infomationg about book */
        public override void Print()
        {
            Console.WriteLine(this);
            base.Print();
        }

        /* counting final const method */
        public double PriceBook(int s)
        {
            double cost = s * price;
            return cost;
        }

        /* returning class property */
        public bool returnSrok
        { get; private set; }

        /* retur srok method */
        public void ReturnSrok()
        {
            returnSrok = true;
        }

        /* overriding return method */
        public override void Return()
        {
            if (returnSrok == true)
                taken = true;
            else
                taken = false;
        }

        ///* taking book method */
        //public void TakeItem()
        //{
        //    if (this.IsAvailable())
        //        this.Take();
        //}

    }
}
