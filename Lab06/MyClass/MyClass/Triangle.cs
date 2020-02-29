using System;
namespace MyClass
{
    public class Triangle
    {
        /* setting first side automatic property */
        public double First_side
        {
            set;
            get;
        }

        /* setting second side automatic property */
        public double Second_side
        {
            set;
            get;
        }

        /* setting third side automatic property */
        public double Third_side
        {
            set;
            get;
        }

        /* default triangle constructor */
        public Triangle()
        {
        }

        /* triangle constructor */
        public Triangle(double a, double b, double c)
        {
            this.First_side = a;
            this.Second_side = b;
            this.Third_side = c;
        }

        /* overloading tostring method */
        public override string ToString()
        {
            return $"First side {this.First_side}\nSecond side {this.Second_side}\n" +
                $"Third side {this.Third_side}";
        }

        /* printing sides of triangle method */
        public void Print()
        {
            Console.WriteLine(this);
        }

        /* evaluating perimeter of the triangle method */
        public double Perimeter()
        {
            return this.First_side + this.Second_side + this.Third_side;
        }

        /* evaluating square of the triangle */
        public double Square()
        {
            /* initializing half of perimeter */
            double p = Perimeter() / 2;

            return Math.Sqrt(p * (p - this.First_side) * (p - this.Second_side) * (p - this.Third_side));
        }

        /* method figuring out if triangle exists */
        public void Exists()
        {
            if (this.First_side < this.Second_side + this.Third_side &&
                this.Second_side < this.First_side + this.Third_side &&
                this.Third_side < this.First_side + this.Second_side)
                Console.WriteLine("Triangle exists");
            else
                Console.WriteLine("Triangle doesn't exist");
        }
    }
}
