using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class _2
    {
        public abstract class фигура
        {
            public abstract double площадь();
        }
        public class круг : фигура
        {
            private double радиус;
            public круг(double радиус)
            {
                this.радиус = радиус;
            }
            public override double площадь()
            {
                return Math.PI * радиус * радиус;
            }
        }
        public class квадрат : фигура
        {
            private double сторона;
            public квадрат(double сторона)
            {
                this.сторона = сторона;
            }
            public override double площадь()
            {
                return сторона * сторона;
            }
        }
    }
}
