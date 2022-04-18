using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask_7.Models
{
    internal class Animal : Monster
    {
        public Animal(string name, int hp, int minAttackDamage, int maxAttackDamage) : base(name, hp, minAttackDamage, maxAttackDamage) { }
        public Animal() : base("Лесной волк", 235, 5, 40) { }

        Random rand = new Random();
        public override string MonsterType => "Животное";

        public override string WarCry => $"Монстр {Name} рычит: Rrrrrrrrrr!";
        public override string DieCry => $"Монстр {Name} издаёт предсмертный хрип: Aaauuuuuuuuf!";

        public override string GetInfo()
        {
            var info = ($" Тип монста: {MonsterType}\r \n " +
                $"Имя монстра: {Name}\r \n" +
                $" Минимальный урон: {MinAttackDamage}\r \n" +
                $" Максимальный урон: {MaxAttackDamage}\r \n" +
                $" Здоровье: {HP}\r \n" +
                $" Умения : Животные инстинкты - когда HP животного падает ниже 35%  шанс увернуться \r \n" +
                $"          от атаки противника возрастает до 50% \r \n" +
                $"          Звериная ярость - шанс нанести бонусный урон от кровотечения");
            return info;
        }

        public override string GetDamageDoneInfo(int damage, int bonusDamage, string monsterType)
        {
            if (damage == 0)
            {
                return ($" Moнстр {Name} промахнулся по врагу");
            }
            else if (bonusDamage > 4 && monsterType != "Механизм" && monsterType != "Дух")
            {
                return ($" Moнстр {Name} наносит удар: урон {damage} ({bonusDamage} урона от кровотечения)");
            }
            else
            {
                return ($" Moнстр {Name} наносит удар: урон {damage}");
            }
        }

        public override string GetTakenDamageInfo(int damage)
        {
            if (damage == 0 && CurrentHP < (HP * 0.35))
            {
                return ($" Животные инстинкты помогают мoнстру {Name} увернуться от удара");
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

            if (CurrentHP < (HP * 0.35) && dodjeChance <= 50)
            {
                return true;
            }
            else if (dodjeChance <= 10)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        public override int BonusDamage()
        {
            var bonus = rand.Next(1, 11);

            if (bonus > 4)
            {
                return FuriousBite(bonus);
            }
            return 0;
        }

        private int FuriousBite(int bonusDamage)
        {
            if (bonusDamage > 4)
            {
                return rand.Next(10, 21);
            }
            return 0;
        }
    }
}
