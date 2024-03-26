using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class _3
    {
        private string университет;
        private string направление;
        private int семестр;
        public string Университет
        {
            get { return университет; }
            set { университет = value; }
        }
        public string Направление
        {
            get { return направление; }
            set { направление = value; }
        }
        public int Семестр
        {
            get { return семестр; }
            set { семестр = value; }
        }
        public void Информация()
        {
            Console.WriteLine("Университет:" + университет + "|Техникум:" + направление + "|Семестр:" + семестр);
        }
    }
}
