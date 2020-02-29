using System;

namespace MyClass
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /* setting language */
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /* initializing book class variable */
            Book b1 = new Book();

            /* setting book properties */
            b1.SetBook("Пушкин А.С.", "Капитанская дочка", "Вильямс",
                123, 2018);

            /* setting price */
            Book.SetPrice(12);

            /* printing information about book */
            b1.Print();

            /* printing price of the book for 3 days */
            Console.WriteLine($"\n Итоговая стоимость аренды: {b1.PriceBook(3)} р.");

            /* initliazing Book class variable */
            Book b2 = new Book("Толстой Л.Н.", "Война и мир", "Наука и жизнь",
                1234, 2013);

            /* printing information about book */
            b2.Print();

            /* initializing book class variable */
            Book b3 = new Book("Лермонтов М.Ю.", "Мцыри");

            /* printing information about book */
            b3.Print();

            /* initializing triangle class variable */
            Triangle t = new Triangle(4, 5, 6);

            /* printing out sides of triangle */
            t.Print();

            /* figuring out if triangle exists */
            t.Exists();

            /* evaluating square and perimeter of triangle */
            Console.WriteLine($"Perimeter of triangle: {t.Perimeter()}");
            Console.WriteLine($"Square of triagle: {t.Square()}");
        }
    }
}
