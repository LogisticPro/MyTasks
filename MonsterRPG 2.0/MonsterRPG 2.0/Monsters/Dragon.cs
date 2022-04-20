using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterRPG_2._0.Monsters
{
    internal class Dragon : Monster
    {
        public Dragon(string name, int hp, int minAttackDamage, int maxAttackDamage) : base(name, hp, minAttackDamage, maxAttackDamage) { }
        public Dragon() : base("Дракон", 750, 25, 100) { }

        public override CreatureTypeEnum CreatureType => CreatureTypeEnum.Dragon;

        public override string WarCry => $"Монстр {Name} рычит: Arrrrggghhh!";
        public override string DieCry => $"Монстр {Name} издаёт предсмертный хрип: Aaaaaaaaaaaaaaaaahhh!";

        public override string GetInfo()
        {
            var info = ($" Тип монста: {CreatureType}\r \n " +
                $"Имя монстра: {Name}\r \n" +
                $" Минимальный урон: {MinAttackDamage()}\r \n" +
                $" Максимальный урон: {MaxAttackDamage()}\r \n" +
                $" Здоровье: {MaxHP}\r \n" +
                $" Умения : Воспламенение - шанс нанести дополнительный урон огнём");
            return info;
        }

        public override string GetDamageDoneInfo(int damage, int bonusDamage, CreatureTypeEnum monsterType)
        {
            if (damage == 0)
            {
                return ($" Moнстр {Name} промахнулся по врагу");
            }
            else if (bonusDamage > 7 && monsterType != CreatureTypeEnum.Construct)
            {
                return ($" Moнстр {Name} наносит удар: урон {damage} ({bonusDamage} урона от горения)");
            }
            else
            {
                return ($" Moнстр {Name} наносит удар: урон {damage}");
            }
        }

        protected override int BonusDamage()
        {
            var bonus = rand.Next(1, 11);

            if (bonus > 7)
            {
                return FireBreath(bonus);
            }
            return 0;
        }

        private int FireBreath(int bonusDamage)
        {
            if (bonusDamage > 7)
            {
                return rand.Next(30, 41);
            }
            return 0;
        }
    }
}
