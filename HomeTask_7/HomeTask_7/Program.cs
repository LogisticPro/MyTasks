using System;
using System.Threading;

namespace HomeTask_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            Fight(CreateMonsters()[0], 
                  CreateMonsters()[7]);

            Console.ReadKey();
        }

        static void Fight(Monster monster1, Monster monster2)
        {
            Console.WriteLine(monster1.GetInfo());
            Console.WriteLine();
            Console.WriteLine(monster2.GetInfo());

            Thread.Sleep(2000);

            Console.WriteLine();

            Console.WriteLine(monster1.GetWarCry());
            Console.WriteLine(monster2.GetWarCry());

            Thread.Sleep(1000);

            Console.WriteLine();

            while(!monster1.IsDie() && !monster2.IsDie())
            {
                var damage1 = monster1.GetAttack(monster1.BonusDamage());
                var damage2 = monster2.GetAttack(monster2.BonusDamage());

                Thread.Sleep(2000);

                monster1.Wounds(damage2);
                Console.WriteLine(monster1.GetFightInfo(damage2));
                if (monster1.IsDie()) break;
                monster2.Wounds(damage1);              
                Console.WriteLine(monster2.GetFightInfo(damage1));
                Console.WriteLine();               
            }

            Console.WriteLine();

            Monster winMonster = monster1.IsDie() ? monster2 : monster1;
            Monster loseMonster = !monster1.IsDie() ? monster2 : monster1;

            Thread.Sleep(1000);

            Console.WriteLine($"{winMonster.GetWarCry()} и побеждает в сражении \n" +
                $"{loseMonster.GetDieCry()}");
        }

        static Monster[] CreateMonsters()
        {
            Monster dragon = new Monster(MonsterTypeEnum.Dragon, "Green Dragon", 450, 19, 95, "Arrrrggghhh", "Aaaaaaaaaaaaaaaaahhh");
            Monster undead = new Monster(MonsterTypeEnum.Undead, "Ghoul", 220, 10, 45, "Assssshhaaaaa", "ppphhrrhpphh");
            Monster orc = new Monster(MonsterTypeEnum.Orc, "Orc warrior", 280, 12, 50, "Rrrraaaaaaaa", "Aghhh");
            Monster construct = new Monster(MonsterTypeEnum.Construct, "Rock golem", 300, 10, 40, "Wrrr wrrr", "Cracking mechanizm sounds");
            Monster demon = new Monster(MonsterTypeEnum.Demon, "Alastor the demon lord", 375, 16, 66, "Aaaaaaarrraaaa", "I will reborn....aaaagh");
            Monster mutant = new Monster(MonsterTypeEnum.Mutant, "Poisoned mutant", 250, 8, 35, "Prhaaaaarrr", "pprrrrhhhhhhhh");
            Monster animal = new Monster(MonsterTypeEnum.Animal, "Forest wolf", 175, 12, 37, "Rrrrrrrrrr", "aaauuuuuuuuufff");
            Monster ghost = new Monster(MonsterTypeEnum.Ghost, "Wraith of death", 1500, 1, 75, "Ooaaaaaaaaaaahh", "foooooooooofff");

            Monster[] monsters = new Monster[8] { dragon, undead, orc, construct, demon, mutant, animal, ghost };

            return monsters;
        }
    }
}
