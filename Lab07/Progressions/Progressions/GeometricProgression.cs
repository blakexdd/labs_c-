using System;
namespace Progressions
{
    public class GeometricProgression : IProgression
    {
        /* class properties */
        public int start { set; get; }
        public int step { set; get; }

        /* class constructor */
        public GeometricProgression(int start, int step)
        {
            this.start = start;
            this.step = step;
        }

        /* overriding get element method */
        public double GetElement(int k)
        {
            return start * Math.Pow(step, k - 1);
        }
    }
}
