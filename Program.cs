using System;
using Projeto_RPG_Csharp.src.Entities;

namespace Projeto_RPG_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
        var clovao = new Mage("Clovao", 80, "Mage", 100, 300);
        var sasha = new Priest("Sasha", 80, "Priest", 120, 120);
        var quietus = new Warrior("Quietus", 80, "Warrior", 300, 0);
        var mus = new Paladin("Muus", 80, "Paladin", 300, 200);

        Console.Write(@"Choose your Hero: 
1 - Mage
2 - Priest
3 - Paladin
4 - Warrior
");
        int hero = int.Parse(Console.ReadLine());

        if (hero == 1)
        {
            Console.WriteLine(clovao);
        }
        else if (hero == 2)    
        {
            Console.WriteLine(sasha);
        }
        else if (hero == 3)
        {
            Console.WriteLine(mus);
        }
        else
        {
            Console.WriteLine(quietus);
        }
        
        Console.WriteLine("Thanks for choosing your hero.");

        }

        
    }
}