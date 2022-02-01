using System;
using RPG.src.Entities;
namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
           Wizard diogo = new Wizard("Diogo","Mago", 22);
           Knigth nathan = new Knigth("Nathan", "Cavaleiro", 26);
           WhiteMage natali = new WhiteMage("Natali","Maga Branca",33);
           Console.WriteLine(diogo);
           Console.WriteLine(diogo.Attack());
           Console.WriteLine(nathan);
           Console.WriteLine(nathan.Attack());
           Console.WriteLine(natali);
           Console.WriteLine(natali.Attack());
           Console.WriteLine(natali.Escape());
        }
    }
}
