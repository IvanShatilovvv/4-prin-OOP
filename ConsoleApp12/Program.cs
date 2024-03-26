using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp12._1;
using static ConsoleApp12._2;
using static ConsoleApp12._3;

namespace ConsoleApp12
{
    internal class Program
    {
        public class ЭВМ
        {
            public string цена;
            public string мощность;
            public ЭВМ(string цена, string мощность)
            {
                this.цена = цена;
                this.мощность = мощность;
            }
            public void запуск()
            {
                Console.WriteLine("Компьютер включается");
            }
            public void выключение()
            {
                Console.WriteLine("Компьютер выключается");
            }
            public void работает()
            {
                Console.WriteLine("ПК работает");
            }
        }
        public class ноутбук : ЭВМ
        {
            public ноутбук(string цена, string мощность) : base(цена, мощность)
            {

            }
            public void шум()
            {
                Console.WriteLine("Ноутбук шумит");
            }
            public void ЦенаиМощностьНоутбука()
            {
                Console.WriteLine("Мощность: " + this.мощность);
                Console.WriteLine("Цена: " + this.цена);
            }
            public class PC : ЭВМ
            {
                public PC (string цена, string мощность) : base(цена, мощность)
                { 
                
                }
                public void загрязняется()
                {
                    Console.WriteLine("PC загрязнятеся");
                }
                public void ЦенаиМощностьPC()
                {
                    Console.WriteLine("Мощность: " + this.мощность);
                    Console.WriteLine("Цена: " + this.цена);
                }    
            }
            static void Main(string[] args)
            {
                Console.WriteLine("Пример наследования - метода ООП");
                ноутбук Ноут = new ноутбук("MSI", "18HX");
                Ноут.ЦенаиМощностьНоутбука();
                Ноут.запуск();
                Ноут.работает();
                Ноут.шум();
                Ноут.выключение();
                Console.WriteLine("------------------------------------------------------");
                PC MyPC = new PC("iRUGame", "intel");
                MyPC.ЦенаиМощностьPC();
                MyPC.запуск();
                MyPC.работает();
                MyPC.загрязняется();
                MyPC.выключение();
                Console.WriteLine("////////////////////////////////////////////////////////////");
                _1 один = new _1();
                Console.WriteLine("Пример полиморфизма - метода ООП");
                Животные Жив = new Животные();
                Жив.движение();
                Животные корова = new cow();
                корова.движение();
                Животные лошадь = new horse();
                лошадь.движение();
                Console.WriteLine("////////////////////////////////////////////////////////////");
                Console.WriteLine("Пример абстракции - метода ООП");
                круг x = new круг(10);
                Console.WriteLine("Площадь круга получается: " + x.площадь());
                квадрат y = new квадрат(6);
                Console.WriteLine("Площадь крадрата получается: " + y.площадь());
                Console.WriteLine("////////////////////////////////////////////////////////////");
                Console.WriteLine("Пример инкапсуляции - метода ООП");
                _3 p = new _3();
                p.Университет = "ОГУ";
                p.Направление = "Инженерия";
                p.Семестр = 5;
                p.Информация();
                Console.ReadKey();  
            }
        }
    }
}
