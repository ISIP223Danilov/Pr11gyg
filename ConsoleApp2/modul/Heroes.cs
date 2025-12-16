using ConsoleApp2.modul;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.modul
{
    internal class Heroes
    {
        public class Hero
        {
            public string Name { get; set; }
            public double Hp { get; set; }
            public double BHp { get; set; }
            public double Damage { get; set; }
            public int Def { get; set; }
            public Hero(string name, int hp, int damage = 0, int def = 0)
            {
                Name = name;
                Hp = hp;
                Damage = damage;
                Def = def;
                BHp = hp;

            }

        }
        static public Hero SetSperminov(string Choose)
        {
            Hero Sperminov = new Hero("ДавидGAY", 100);
            switch (Choose)
            {
                case "1":
                    Sperminov.BHp = 150;
                    Sperminov.Hp = 150;
                    Sperminov.Damage = items.Axe.Damage;
                    Sperminov.Def = Defends.shield.Block;
                    break;
                case "2":
                    Sperminov.BHp = 120;
                    Sperminov.Hp = 120;
                    Sperminov.Damage = items.bow.Damage;
                    Sperminov.Def = Defends.iron_armor.Block;
                    break;
                case "3":
                    Sperminov.Damage = items.Sword.Damage; Sperminov.Def = Defends.leather_armor.Block;
                    break;
                default:
                    Sperminov.Damage = items.bow.Damage; Sperminov.Def = Defends.iron_armor.Block;
                    break;
            }
            return Sperminov;
        }
        static void PrintPersonInfo(Hero p, Enemies.Enemy e)
        {
            Console.WriteLine($"Здоровье DavidGAy = {p.Hp}");
            Console.WriteLine($"Здоровье Врага {e.Name} = {e.Hp}");
            Console.WriteLine("Выбирите действие: 1-атака");
        }
    }
}