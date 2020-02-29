using System;

namespace MyClass
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /* setting language */
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /* initializing item class variavle */
            //Item item1 = new Item();

            /* printing information about item */
            //item1.Print();

            /* initializing publisher class variable */
            Publisher pub1 = new Publisher("Наука и жизнь", "nauka@mail.ru",
                1234, new DateTime(2014, 12, 14));

            /* initializing book class instance */
            Book b2 = new Book("Толстой Л.Н.", "Война и мир",
                pub1, 1234, 2013, 101, true);

            /* taking the book and printing information */
            b2.TakeItem();
            b2.Print();

            /* initializing maganize class variable */
            Magazine mag1 = new Magazine("О природе", 5, "Земля и мы",
                2014, 1235, true);

            /* taking magazine item and printing information */
            mag1.TakeItem();
            mag1.Print();

            /* initializing item class variable */
            Console.WriteLine("\n Тестирование полиморфизма");
            Item it;

            /* assigning book variable to item variable */
            it = b2;
            it.TakeItem(); // taking item
            it.Return(); // returning item back
            it.Print(); // printing information about item

            /* reassigning item to magazine */
            it = mag1;
            it.TakeItem();
            it.Return();
            it.Print();

        }
    }
}
