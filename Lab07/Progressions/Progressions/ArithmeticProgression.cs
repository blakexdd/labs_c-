using System;
namespace Progressions
{
    public class ArithmeticProgression : IProgression
    {
        /* class properties */
        public int start { set; get; }
        public int step { set; get; }

        /* class constructor */
        public ArithmeticProgression(int start, int step)
        {
            this.start = start;
            this.step = step;
        }

        /* overriding get element method */
        public double GetElement(int k)
        {
            return start + step * (k - 1);
        }
    }
}
