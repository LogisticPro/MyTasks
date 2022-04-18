using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask_7.Models
{
    internal class Orc : Monster
    {
        public Orc(string name, int hp, int minAttackDamage, int maxAttackDamage) : base(name, hp, minAttackDamage, maxAttackDamage) { }
        public Orc() : base("Орк - воин", 425, 18, 54) { }

        Random rand = new Random();
        public override string MonsterType => "Орк";

        public override string WarCry => $"Монстр {Name} кричит: Rrrraaaaaaaa!";
        public override string DieCry => $"Монстр {Name} издаёт предсмертный хрип: Aghhh!";

        public override string GetInfo()
        {
            var info = ($" Тип монста: {MonsterType}\r \n " +
                $"Имя монстра: {Name}\r \n" +
                $" Минимальный урон: {MinAttackDamage}\r \n" +
                $" Максимальный урон: {MaxAttackDamage}\r \n" +
                $" Здоровье: {HP}\r \n" +
                $" Умения : Критический удар - шанс нанести двойной урон по врагу");
            return info;
        }

        public override string GetDamageDoneInfo(int damage, int bonusDamage, string monsterType)
        {
            if (damage == 0)
            {
                return ($" Moнстр {Name} промахнулся по врагу");
            }
            else if (bonusDamage > 7)
            {
                return ($" Moнстр {Name} наносит критический удар: урон {damage}");
            }
            else
            {
                return ($" Moнстр {Name} наносит удар: урон {damage}");
            }
        }

        private int orcBaseAttack;

        protected override int GetBaseAttack(int bonusDamage)
        {
            orcBaseAttack = rand.Next(MinAttackDamage, MaxAttackDamage + 1) + bonusDamage;
            return orcBaseAttack;
        }

        public override int GetAttack(int bonusDamage, Monster monster)
        {
            if (monster.IsEvade())
            {
                return 0;
            }
            else if (monster.HasBlock() && monster.CurrentHP > HP / 2)
            {
                return GetBaseAttack(bonusDamage) / 5 * 3;
            }

            return GetBaseAttack(bonusDamage);
        }

        public override int BonusDamage()
        {
            var bonus = rand.Next(1, 11);

            if (bonus > 7)
            {
                return orcBaseAttack;
            }
            return 0;
        }
    }
}
