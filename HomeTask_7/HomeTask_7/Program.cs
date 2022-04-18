using HomeTask_7.Models;
using System;
using System.Threading;

namespace HomeTask_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            Battle.FullFight(CreateMonsters()[rand.Next(0, CreateMonsters().Length)],
                  CreateMonsters()[rand.Next(0,CreateMonsters().Length)]);

            Console.ReadKey();
        }   

        static Monster[] CreateMonsters()
        {
            Monster dragon = new Dragon("Green Dragon", 600, 19, 85);
            Monster vampire = new Undead("Vampire lord", 400, 20, 65);        
            Monster construct = new Construct("Rock golem", 365, 15, 45);
            Monster demon = new Demon("Alastor the demon lord", 333, 13, 66);
            Monster orc = new Orc("Orc warrior", 425, 18, 54);
            Monster mutant = new Mutant("Poisoned mutant", 275, 7, 21);
            Monster animal = new Animal("Forest wolf", 235, 12, 37);
            Monster ghost = new Ghost("Wraith of death", 100, 1, 50);

            Monster[] monsters = new Monster[8] { dragon, vampire, construct, demon, orc, mutant, animal, ghost };

            return monsters;
        }
    }
}
