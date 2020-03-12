using System;
namespace MyClass
{
    public class Book
    {
        /* initializing class variables */
        private static double price;

        /* book class defautl constructor */
        public Book()
        {

        }

        /* book class constructor */
        public Book(string author, string title, string publisher,
            int pages, int year)
        {
            this.Author = author;
            this.Title = title;
            this.Publisher = publisher;
            this.Pages = pages;
            this.Year = year;
        }

        /* overloaded book class constructor */
        public Book(string author, string title)
        {
            this.Author = author;
            this.Title = title;
        }

        /* book static constructor */
        static Book()
        {
            Price = 9;
        }

        public string Author { get; set; } // author
        public string Title { get; set; } // title
        public string Publisher { get; set; } // publisher
        public int Pages { get; set; } // pages amount
        public int Year { get; set; } // pubslish date

        /* Automatic property for price */
        public static double Price
        {
            get { return price; }
            set { if (value > 9) price = value; }
        }

        /* setting characteristics method */
        public void SetBook(string author, string title, string publisher,
            int pages, int year)
        {
            this.Author = author;
            this.Title = title;
            this.Publisher = publisher;
            this.Pages = pages;
            this.Year = year;
        }

        /* setting price method */
        public static void SetPrice(double price)
        {
            Book.Price = price;
        }

        /* overloadding to string method */
        public override string ToString()
        {
            string bs = String.Format("\nКнига:\nАвтор: {0}\nНазвание: {1}\n" +
                "Год издания: {2}\n {3} стр.\n Стоимость аренды: {4}",
                Author, Title, Year, Pages, Book.price);

            return bs;
        }

        /* printing infomationg about book */
        public void Print()
        {
            Console.WriteLine(this);
        }

        /* counting final const method */
        public double PriceBook(int s)
        {
            double cost = s * price;
            return cost;
        }
        
    }
}
