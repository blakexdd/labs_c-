using System;
namespace MyClass
{
    public class Magazine : Item
    {
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

        /* overriding to string method */
        public override string ToString()
        {
            string bs = String.Format($"\nЖурнал:\n Том: {Volume}," +
                $"Номер: {Number}\n Название: {Title}\n Год выпуска: {Year}");

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
