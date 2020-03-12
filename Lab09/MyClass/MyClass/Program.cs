using System;
using MyClass;

namespace MyClassTest
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /* setting language */
            //Console.OutputEncoding = System.Text.Encoding.UTF8;

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

            /* running audit */
            Audit.RunAudit();

            /* initializing maganize class variable */
            Magazine mag1 = new Magazine("О природе", 5, "Земля и мы",
                2014, 1235, true);

            /* initializing publisher class varaible */
            Publisher pub2 = new Publisher("Слабоумие и отвага", "otvaga@mail.ru",
            234, new DateTime(2015, 11, 11));

            /* initializing book class instance */
            Book b3 = new Book("Дж. Селинджер", "Над пропастью во ржи",
                pub2, 1236, 2014, 101, true);

            /* taking magazine item and printing information */
            mag1.TakeItem();
            mag1.Print();
            mag1.Subs();
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

            /* creating list of links to Item class */
            System.Collections.Generic.List<Item> itlist = new System.Collections.Generic.List<Item>();

            /* adding items to item list */
            itlist.AddRange(new Item[] { b2, b3, mag1 });

            /* sorting list */
            itlist.Sort();

            /* printing sorted items */
            Console.WriteLine("\nСортировка по инвентарному номеру");

            foreach (Item x in itlist)
            {
                x.Print();
            }

            /* to keep console awake */
            Console.Read();
        }
    }
}
