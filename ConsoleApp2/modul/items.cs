using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2.modul;

namespace ConsoleApp2.modul
{
    internal class items
    {
        static public item Sword = new item("Пенис", 10);
        static public item Axe = new item("Дилдо", 15);
        static public item bow = new item("Масло", 12);
        public class item
        {
            public string NameW;
            public int Damage;
            public item(string name_d, int block)

            {
                NameW = name_d;
                Damage = block;
            }
        }

    }
}