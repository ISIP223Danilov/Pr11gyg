using ConsoleApp2.modul;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.modul
{
    internal class Cases
    {
        static public void Case(Heroes.Hero p)
        {
            List<double> list = new List<double> { 1.1, 1.15, 1.2, 1.25 };
            Random random = new Random();
            if (Randoms.R2() == 0)
            {
                p.Hp = p.BHp;
                Console.WriteLine("Вам выпало зелье регенерации. Вы исцелены");
            }
            else
            {
                if (Randoms.R2() == 1)
                {
                    int a = Randoms.UpHp();
                    p.BHp += a;
                    Console.WriteLine($"Вам выпало усиление здоровья на {a}");
                }
                else
                {
                    int a = Randoms.UpDamage();
                    p.Damage += a;
                    Console.WriteLine($"Вам выпало усиление урона на {a}");
                }
            }
            Menu.Continue();
        }

    }
}