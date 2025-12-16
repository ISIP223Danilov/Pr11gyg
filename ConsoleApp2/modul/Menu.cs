
using ConsoleApp2.modul;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.modul
{
    internal class Menu
    {
        static public void PrintMenu()
        {
            Console.WriteLine("Добро пожаловать в игру ДавидGay против нежити");
            Console.WriteLine("Выбирите уровень сложности");
            Console.WriteLine("1 - easy GAY mode");
            Console.WriteLine("2 - normal Gay mode");
            Console.WriteLine("3 - hard Gay sex mode");
        }
        static public void Continue()
        {
            Console.WriteLine("Нажмите для продолжения\n");
            Console.ReadKey();
            Console.Clear();
        }
        static public void PrintPersonInfo(Heroes.Hero p, Enemies.Enemy e)
        {
            Console.WriteLine($"Здоровье ДавидGay = {p.Hp}");
            Console.WriteLine($"Здоровье Врага {e.Name} = {e.Hp}");
            Console.WriteLine("Выбирите действие: 1-атака");
        }
    }
}