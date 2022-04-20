using MonsterRPG_2._0.Creatures;
using MonsterRPG_2._0.Monsters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using MonsterRPG_2._0.Interfaces;

namespace MonsterRPG_2._0
{
    internal static class Battle
    {
        public static void FullFight(ICombatan creature1, ICombatan creature2)
        {
            StartOfBattle(creature1, creature2);
            OneBattleRound(creature1, creature2);
            Result(creature1, creature2);
        }
        public static void StartOfBattle(ICombatan creature1, ICombatan creature2)
        {
            Console.WriteLine(creature1.GetInfo());
            Console.WriteLine();
            Console.WriteLine(creature2.GetInfo());

            Thread.Sleep(2000);

            Console.WriteLine();

            Console.WriteLine(creature1.WarCry);
            Console.WriteLine(creature2.WarCry);

            Thread.Sleep(1000);

            Console.WriteLine();
        }
        public static void OneBattleRound(ICombatan creature1, ICombatan creature2)
        {
            int round = 1;

            while (!creature1.IsDie && !creature2.IsDie)
            {
                Console.WriteLine($"\t\t\t\tРаунд {round++}");
                Console.WriteLine();

                var (damage1, bonus1) = creature1.Attack(creature2);
                creature1.ApplyAttackSkills(damage1, creature2);
                creature2.Wounds(damage1);
                Console.WriteLine(creature1.GetDamageDoneInfo(damage1, bonus1, creature2.CreatureType));

                var (damage2, bonus2) = creature2.Attack(creature1);
                creature2.ApplyAttackSkills(damage2, creature1);
                creature1.Wounds(damage2);
                Console.WriteLine(creature2.GetDamageDoneInfo(damage2, bonus2, creature1.CreatureType));

                Console.WriteLine();

                Thread.Sleep(1000);

                Console.WriteLine(creature1.GetTakenDamageInfo(damage2));
                Console.WriteLine(creature1.GetHpInfo());

                Console.WriteLine(creature2.GetTakenDamageInfo(damage1));
                Console.WriteLine(creature2.GetHpInfo());

                Console.WriteLine();

                Thread.Sleep(2000);
            }
        }
        public static void Result(ICombatan creature1, ICombatan creature2)
        {
            Thread.Sleep(1000);

            if (creature1.IsDie && creature2.IsDie)
            {
                Console.WriteLine("Оба существа пали в битве...");
            }
            else
            {
                ICombatan winCrearure = !creature1.IsDie ? creature1 : creature2;
                ICombatan loseCreature = creature1.IsDie ? creature1 : creature2;

                Console.WriteLine($"{winCrearure.WarCry} и побеждает в сражении \n" +
                    $"{loseCreature.DieCry}");
            }
        }
    }
}
