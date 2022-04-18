using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask_7.Models
{
    internal class Mutant : Monster
    {
        public Mutant(string name, int hp, int minAttackDamage, int maxAttackDamage) : base(name, hp, minAttackDamage, maxAttackDamage) { }
        public Mutant() : base("Тварь", 300, 10, 30) { }

        Random rand = new Random();
        public override string MonsterType => "Мутант";

        public override string WarCry => $"Монстр {Name} рычит: Prhaaaaarrr!";
        public override string DieCry => $"Монстр {Name} издаёт предсмертный хрип: Pprrrrhhhhhhhh!";

        public override string GetInfo()
        {
            var info = ($" Тип монста: {MonsterType}\r \n " +
                $"Имя монстра: {Name}\r \n" +
                $" Минимальный урон: {MinAttackDamage}\r \n" +
                $" Максимальный урон: {MaxAttackDamage}\r \n" +
                $" Здоровье: {HP}\r \n" +
                $" Умения : Неестественная выносливость - Чем дольше мунант находится в битве, тем болеше он наносит урона. " +
                $"                        Также повышается шанс увернуться от удара врага");
            return info;
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

        public override bool IsEvade()
        {
            var dodjeChance = rand.Next(1, 101);

            if (CurrentHP < (HP * 0.3) && dodjeChance <= 35)
            {
                return true;
            }
            else if (CurrentHP < (HP * 0.35) && dodjeChance <= 30)
            {
                return true;
            }
            else if (CurrentHP < (HP * 0.4) && dodjeChance <= 25)
            {
                return true;
            }
            else if (CurrentHP < (HP * 0.45) && dodjeChance <= 20)
            {
                return true;
            }
            else if (CurrentHP < (HP * 0.50) && dodjeChance <= 15)
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

        private int mutantBonusDamage;

        public override int BonusDamage()
        {
            mutantBonusDamage += rand.Next(5, 10);
            return mutantBonusDamage;
        }
    }
}
