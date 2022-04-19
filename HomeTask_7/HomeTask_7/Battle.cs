using HomeTask_7.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace HomeTask_7
{
    internal static class Battle
    {
        public static void FullFight(Monster monster1, Monster monster2)
        {
            StartOfBattle(monster1, monster2);
            OneBattleRound(monster1, monster2);
            Result(monster1, monster2);
        }
        public static void StartOfBattle(Monster monster1, Monster monster2)
        {
            Console.WriteLine(monster1.GetInfo());
            Console.WriteLine();
            Console.WriteLine(monster2.GetInfo());

            Thread.Sleep(2000);

            Console.WriteLine();

            Console.WriteLine(monster1.WarCry);
            Console.WriteLine(monster2.WarCry);

            Thread.Sleep(1000);

            Console.WriteLine();
        }
        public static void OneBattleRound(Monster monster1, Monster monster2)
        {
            int round = 1;

            while (!monster1.IsDie() && !monster2.IsDie())
            {
                Console.WriteLine($"\t\t\t\tРаунд {round++}");
                Console.WriteLine();
                var bonus1 = monster1.BonusDamage();
                var bonus2 = monster2.BonusDamage();

                var damage1 = monster1.GetAttack(bonus1, monster2);
                monster1.ApplyAttackSkills(damage1);
                monster2.Wounds(damage1);
                Console.WriteLine(monster1.GetDamageDoneInfo(damage1, bonus1, monster2.MonsterType));

                if (monster1.IsDie() || monster2.IsDie())
                {
                    Console.WriteLine();
                    break;
                }

                var damage2 = monster2.GetAttack(bonus2, monster1);
                monster2.ApplyAttackSkills(damage2);
                monster1.Wounds(damage2);
                Console.WriteLine(monster2.GetDamageDoneInfo(damage2, bonus2, monster1.MonsterType));

                Console.WriteLine();

                Thread.Sleep(1000);

                Console.WriteLine(monster1.GetTakenDamageInfo(damage2));
                Console.WriteLine(monster1.GetHpInfo());

                Console.WriteLine(monster2.GetTakenDamageInfo(damage1));
                Console.WriteLine(monster2.GetHpInfo());

                Console.WriteLine();

                Thread.Sleep(2000);
            }
        }
        public static void Result(Monster monster1, Monster monster2)
        {
            Thread.Sleep(1000);

            if (monster1.IsDie() && monster2.IsDie())
            {
                Console.WriteLine("Оба монстра пали в битве...");
            }
            else
            {
                Monster winMonster = monster1.IsDie() ? monster2 : monster1;
                Monster loseMonster = !monster1.IsDie() ? monster2 : monster1;

                Console.WriteLine($"{winMonster.WarCry} и побеждает в сражении \n" +
                    $"{loseMonster.DieCry}");
            }
        }
    }
}
