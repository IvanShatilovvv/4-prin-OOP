using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public class _1
    {
        public class Животные
        {
            public virtual void движение()
            {
                Console.WriteLine("Животные двигаются");
            }
        }  
        public class cow : Животные
        {
            public override void движение()
            {
                Console.WriteLine("Корова ходит");
            }
        }
        public class horse : Животные
        {
            public override void движение()
            {
                Console.WriteLine("Лошадь бегает");
            }
        }
    }
}
