using System;
namespace MyClass
{
    public interface IPubs
    {
        /* subs class method */
        void Subs();

        /* users subscription */
        bool IfSubs { get; set; }

    }
}
