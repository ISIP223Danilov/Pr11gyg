using ConsoleApp2.modul;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static ConsoleApp2.modul.Enemies;



namespace ConsoleApp2.modul
{

    internal class Battle
    {
        static public void StartGame()
        {
            Random rand = new Random();
            Menu.PrintMenu();
            string Choose = Console.ReadLine();
            Heroes.Hero Sperminov = Heroes.SetSperminov(Choose);
            Menu.Continue();
            Console.Clear();
            battlesystem(Sperminov, enemies, Bosses);

        }
        static void battle(Heroes.Hero p, Enemy e)
        {
            while (p.Hp > 0 && e.Hp > 0)
            {
                if (p.Hp <= 0) { Console.WriteLine("Вы проиграли"); break; }
                Console.WriteLine($"Здоровье DavidGay = {p.Hp}");
                Console.WriteLine($"Здоровье Врага {e.Name} = {e.Hp}");
                Console.WriteLine("Выбирите действие: 1-атака");
                string Choose = Console.ReadLine();

                switch (Choose)
                {
                    case "1": if (Randoms.Freze() && e.Type == "M") { Console.WriteLine("Маг отразил вашу атаку"); break; } else { defend2(p, e); break; }
                    default:
                        defend2(p, e); break;
                }
                if (e.Hp > 0)
                {
                    defend(p, e);
                }
            }
        }
        static void attack(Heroes.Hero p, Enemy e, double attack, bool flag)
        {

            if (flag) { e.Hp -= attack; }
            else { p.Hp -= attack; }
        }

        static void defend(Heroes.Hero p, Enemy e)
        {
            double damage = e.Damage * (100 - e.Def) / 100;

            switch (e.Type)
            {
                case "G":

                    if (Randoms.DoubleDamage())
                    {
                        Console.WriteLine("Гоблин наносит двойной урон");
                        damage *= 2;
                        break;
                    }
                    else { break; }
                case "С":
                    damage -= 2;
                    break;

                case "S":
                    Console.WriteLine("Скелет игнорирует защиту");
                    damage = e.Damage; break;
            }
            attack(p, e, damage, false);
        }
        static void defend2(Heroes.Hero p, Enemy e)
        {
            double damage = p.Damage * (100 - e.Def) / 100;
            attack(p, e, damage, true);
        }
        static void CaseorBattle(Heroes.Hero p, Enemy e)
        {
            Thread.Sleep(1000);
            Console.Clear();
            if (Randoms.R2() == 1)
            {
                Console.WriteLine("Бой начинается");
                battle(p, e);
            }
            else
            {
                Console.WriteLine("Вам выпал кейс");
                Cases.Case(p);
            }
        }
        static void battlesystem(Heroes.Hero p, List<Enemies.Enemy> enemies, List<Enemies.Enemy> bosses)
        {
            int round = 0;
            while (p.Hp > 0)
            {
                foreach (Enemies.Enemy a in enemies)
                {
                    a.Hp = a.BHp;
                }
                foreach (Enemies.Enemy a in enemies)
                {
                    a.Hp = a.BHp;
                }
                round += 1;
                Console.WriteLine($"бой номер {round}");
                if (round == 10) { Console.WriteLine($"Битва с босом"); battle(p, Bosses[Randoms.R5()]); }
                else { CaseorBattle(p, enemies[Randoms.R4()]); }
            }
            Console.WriteLine("Вы проиграли");
        }

        private static void battle(Heroes.Hero p, object value)
        {
            throw new NotImplementedException();
        }
    }
}