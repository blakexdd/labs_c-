using System;
namespace MyClass
{
    public delegate void ProcessMagazineDelegate(Magazine mag,
        DateTime dt);

    public class Magazine : Item, IPubs
    {
        /* initializing event */
        public static event ProcessMagazineDelegate Subscribe = null;

        /* automatic class properties */
        public string Volume { get; set; }
        public int Number { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }

        /* magazine class constructor */
        public Magazine(string volume, int number, string title,
            int year, long invNumber, bool taken) : base(invNumber, taken)
        {
            this.Volume = volume;
            this.Number = number;
            this.Title = title;
            this.Year = year;
        }

        /* default magazine constructor */
        public Magazine()
        {
        }

        /* ifsubs property */
        public bool IfSubs { get; set; }

        /* setting subs */
        public void Subs()
        {
            IfSubs = true;

            if (Subscribe != null)
                Subscribe(this, DateTime.Now);
        }

        /* overriding to string method */
        public override string ToString()
        {
            string bs = String.Format($"\nЖурнал:\n Том: {Volume}," +
                $"Номер: {Number}\n Название: {Title}\n Год выпуска: {Year}" +
                $"\nСтатус подписки: {IfSubs}");

            return bs;
        }

        /* printing information about magazine */
        public override void Print()
        {
            Console.WriteLine(this);
            base.Print();
        }

        /* overriding return method */
        public override void Return()
        {
            taken = true;
        }


    }
}
