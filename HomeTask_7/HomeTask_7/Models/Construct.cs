using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask_7.Models
{
    internal class Construct : Monster
    {
        public Construct(string name, int hp, int minAttackDamage, int maxAttackDamage) : base(name, hp, minAttackDamage, maxAttackDamage) { }
        public Construct() : base("Каменный голем", 370, 15, 55) { }

        Random rand = new Random();
        public override string WarCry => $"Монстр {Name} издает звук: Wrrr wrrr!";
        public override string DieCry => $"Монстр {Name} издаёт предсмертный хрип: Cracking mechanizm sounds!";

        public override string MonsterType => "Механизм";

        public override string GetInfo()
        {
            var info = ($" Тип монста: {MonsterType}\r \n " +
                $"Имя монстра: {Name}\r \n" +
                $" Минимальный урон: {MinAttackDamage}\r \n" +
                $" Максимальный урон: {MaxAttackDamage}\r \n" +
                $" Здоровье: {HP}\r \n" +
                $" Умения : Блокирует 40% входяшего урона, пока у голема более 50% HP\r \n" +
                $"          Невосприимчивость к способностям любого типа");
            return info;
        }

        public override string GetTakenDamageInfo(int damage)
        {
            if (CurrentHP > HP / 2 && damage != 0)
            {
                return ($" Moнстр {Name} заблокировал часть полученного урона ({damage / 5 * 2}) и получил урон { damage }");
            }
            else if (damage == 0)
            {
                return ($" Moнстр {Name} увернулся от удара");
            }
            else
            {
                return ($" Moнстр {Name} получил урон {damage}");
            }
        }

        public override bool IsEvade()
        {
            var dodjeChance = rand.Next(1, 101);

            if (dodjeChance <= 1)
            {
                return true;
            }

            return false;
        }
        public override bool HasResist()
        {
            return true;
        }

        public override bool HasBlock()
        {
            return true;
        }
    }
}
