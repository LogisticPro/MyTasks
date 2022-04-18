using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask_7.Models
{
    internal class Ghost : Monster
    {
        public Ghost(string name, int hp, int minAttackDamage, int maxAttackDamage) : base (name, hp, minAttackDamage, maxAttackDamage) { }
        public Ghost() : base("Дух", 100, 1, 35) { }

        Random rand = new Random();
        public override string WarCry => $"Монстр {Name} вопит: Ooaaaaaaaaaaaahh!";
        public override string DieCry => $"Монстр {Name} издаёт предсмертный хрип: foooooooooofff!"; 

        public override string MonsterType => "Дух";

        public override string GetInfo()
        {
            var info = ($" Тип монста: {MonsterType}\r \n " +
                $"Имя монстра: {Name}\r \n" +
                $" Минимальный урон: {MinAttackDamage}\r \n" +
                $" Максимальный урон: {MaxAttackDamage}\r \n" +
                $" Здоровье: {HP}\r \n" +
                $" Умения : Прикосновение смерти - шанс убить существо, лишив его души");
            return info;
        }

        public override string GetDamageDoneInfo(int damage, int bonusDamage, string monsterType)
        {
            if (damage == 0)
            {
                return ($" Moнстр {Name} промахнулся в врагу");
            }
            else if (bonusDamage > 9 && monsterType != "Механизм")
            {
                return ($" Moнстр {Name} наносит удар: урон {damage} и применяет умение Прикосновение смерти");
            }
            else
            {
                return ($" Moнстр {Name} наносит удар: урон {damage} ");
            }
        }

        public override string GetTakenDamageInfo(int damage)
        {
            if (damage == 0)
            {
                return ($" Moнстр {Name} нематериален и не получает урон");
            }
            else
            {
                return ($" Moнстр {Name} получил урон {damage}");
            }
        }
        public override bool IsEvade()
        {
            var dodjeChance = rand.Next(1, 101);

            if (dodjeChance <= 75)
            {
                return true;
            }

            return false;
        }

        public override int BonusDamage()
        {
            var bonus = rand.Next(1, 11);

            if(bonus > 9)
            {
                return DeathTouch(bonus);
            }
            return 0;
        }

        private int DeathTouch(int bonusDamage)
        {
            if (bonusDamage > 9)
            {
                return 750;
            }
            return 0;
        }
    }
}
