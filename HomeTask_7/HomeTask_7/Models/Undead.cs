using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask_7.Models
{
    internal class Undead : Monster
    {
        public Undead(string name, int hp, int minAttackDamage, int maxAttackDamage) : base(name, hp, minAttackDamage, maxAttackDamage){ }
        public Undead() : base("Вампир", 400, 20, 70) { }

        Random rand = new Random();
        public override string MonsterType => "Нежить";

        public override string WarCry => $"Монстр {Name} шипит: Assssshhaaaaa!";
        public override string DieCry => $"Монстр {Name} издаёт предсмертный хрип: ppphhrrhpphh!";

        public override string GetInfo()
        {
            var info = ($" Тип монста: {MonsterType}\r \n " +
                $"Имя монстра: {Name}\r \n" +
                $" Минимальный урон: {MinAttackDamage}\r \n" +
                $" Максимальный урон: {MaxAttackDamage}\r \n" +
                $" Здоровье: {HP}\r \n" +
                $" Умения : Вампиризм - когда HP вампира падает ниже 50% его атаки \r \n" +
                $"          восстанавливают 50% от нанесённого урона \r \n");
            return info;
        }

        public override string GetDamageDoneInfo(int damage, int bonusDamage, string monsterType)
        {
            if (damage == 0)
            {
                return ($" Moнстр {Name} промахнулся по врагу");
            }
            else if (damage != 0 && CurrentHP <(HP * 0.5) && monsterType != "Механизм")
            {
                return ($" Moнстр {Name} наносит удар: урон {damage} ({(int)(damage * 0.5)} восстановлено вампиризмом)");
            }
            else
            {
                return ($" Moнстр {Name} наносит удар: урон {damage}");
            }
        }

        public override void ApplyAttackSkills(int damage)
        {
            if (CurrentHP != 0)
            {
                LifeSteal(damage);
            }          
        }

        private void LifeSteal(int damage)
        {           
            if (CurrentHP < (HP * 0.5))
            {
                CurrentHP += damage / 2;
            }
        }
    }
}
