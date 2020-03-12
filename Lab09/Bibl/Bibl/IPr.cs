using System;
namespace MyClass
{
    public interface IPr
    {
        /* setting price method */
        void SetPrice(double price);

        /* strring price of the book */
        double PriceBook(int s);
    }
}
