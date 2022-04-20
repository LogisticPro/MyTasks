using MonsterRPG_2._0.Creatures;
using MonsterRPG_2._0.InventoryModels;
using MonsterRPG_2._0.Monsters;
using System;

namespace MonsterRPG_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Battle.FullFight(CreateHeroes()[rand.Next(0, 4)],
                  CreateMonsters()[rand.Next(0, 8)]);  
            
            Console.ReadKey();
        }

        static Monster[] CreateMonsters()
        {
            Monster dragon = new Dragon("Green Dragon", 600, 25, 85);
            Monster vampire = new Undead("Vampire lord", 400, 20, 65);
            Monster construct = new Construct("Rock golem", 365, 15, 45);
            Monster demon = new Demon("Alastor the demon lord", 333, 13, 66);
            Monster orc = new Ogre("Ogre warrior", 425, 18, 54);
            Monster mutant = new Mutant("Poisoned mutant", 275, 7, 21);
            Monster animal = new Animal("Forest wolf", 235, 12, 37);
            Monster ghost = new Ghost("Wraith of death", 100, 1, 50);

            Monster[] monsters = new Monster[8] { dragon, vampire, construct, demon, orc, mutant, animal, ghost };

            return monsters;
        }

        static Hero[] CreateHeroes()
        {
            Hero elf = new Hero(RacesEnum.Elf,"Legolas", 17, 30, 16);
            Hero dwarf = new Hero(RacesEnum.Dwarf, "Gimli", 15, 10, 22);
            Hero orc = new Hero(RacesEnum.Orc, "Azog", 10, 15, 24);
            Hero human = new Hero(RacesEnum.Human, "Aragorn", 21, 20, 18);

            Hero[] heroes = new Hero[4] { elf, dwarf, orc, human };

            return heroes;
        }
    }
}
