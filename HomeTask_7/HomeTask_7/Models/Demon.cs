using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask_7.Models
{
    internal class Demon : Monster
    {
        public Demon(string name, int hp, int minAttackDamage, int maxAttackDamage) : base(name, hp, minAttackDamage, maxAttackDamage) { }
        public Demon() : base("Демон", 333, 13, 66) { }

        Random rand = new Random();
        public override string MonsterType => "Демон";

        public override string WarCry => $"Монстр {Name} кричит: Падите ниц предо мной, смертные!";
        public override string DieCry => $"Монстр {Name} издаёт предсмертный хрип: Я еще вернусь... из пекла... ааааа!";

        public override string GetInfo()
        {
            var info = ($" Тип монста: {MonsterType}\r \n " +
                $"Имя монстра: {Name}\r \n" +
                $" Минимальный урон: {MinAttackDamage}\r \n" +
                $" Максимальный урон: {MaxAttackDamage}\r \n" +
                $" Здоровье: {HP}\r \n" +
                $" Умения : Восстановление - при получении смертельного урона, демон восстанавливает HP до\r \n" +
                $"          максимального значения (1 раз за битву)\r \n" +
                $"          Губительный клинок - шанс ненести урон противнику, который зависит недостающих HP демона");
            return info;
        }

        public override string GetDamageDoneInfo(int damage, int bonusDamage, string monsterType)
        {
            if (damage == 0)
            {
                return ($" Moнстр {Name} промахнулся по врагу");
            }
            else if (bonusDamage > 9 && monsterType != "Механизм")
            {
                return ($" Moнстр {Name} наносит удар: урон {damage} ({bonusDamage} урона от умения Губительный клинок)");
            }
            else
            {
                return ($" Moнстр {Name} наносит удар: урон {damage}");
            }
        }

        public override string GetTakenDamageInfo(int damage)
        {
            if (damage == 0)
            {
                return ($" Moнстр {Name} увернулся от удара");
            }
            else
            {
                return ($" Moнстр {Name} получил урон {damage}");
            }
        }

        public override int BonusDamage()
        {
            var bonus = rand.Next(1, 11);

            if (bonus > 9)
            {
                return DestructiveBlade(bonus);
            }
            return 0;
        }

        private int DestructiveBlade(int bonusDamage)
        {
            if (bonusDamage > 9)
            {
                int damage = (HP - CurrentHP) / 2;
                return damage;
            }
            return 0;
        }
        public override void Heal()
        {
            CurrentHP = HP;
            _hadRisen = true;
        }

        private bool _hadRisen = false;

        public override int Wounds(int damage)
        {
            CurrentHP -= damage;

            if (CurrentHP < 1 && !_hadRisen)
            {
                Heal();
                return CurrentHP;
            }        

            return CurrentHP;

        }
        
    }
}
