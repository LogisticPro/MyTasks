using MonsterRPG_2._0.Creatures;
using System;
using System.Collections.Generic;
using System.Text;
using MonsterRPG_2._0.Interfaces;

namespace MonsterRPG_2._0.Monsters
{
    public abstract class Monster : Creature, ICombatan
    {
        public Monster(string name, int maxHP, int minAttackDamage, int maxAttackDamage) 
        {
            Name = name;
            MaxHP = maxHP;
            CurrentHP = maxHP;
            _minAttackDamage = minAttackDamage;
            _maxAttackDamage = maxAttackDamage;
        }

        public virtual CreatureTypeEnum CreatureType { get; protected set; }
        protected int _minAttackDamage;
        protected int _maxAttackDamage;
        public abstract string WarCry { get; }
        public abstract string DieCry { get; }

        public virtual string GetInfo()
        {
            var info = ($" Тип монста: {CreatureType}\r \n " +
                $"Имя монстра: {Name}\r \n" +
                $" Минимальный урон: {MinAttackDamage()}\r \n" +
                $" Максимальный урон: {MaxAttackDamage()}\r \n" +
                $" Здоровье: {MaxHP}");
            return info;
        }

        public string GetHpInfo()
        {
            return $"  Текущее здоровье монстра {CreatureType}: {CurrentHP}";
        }

        public virtual string GetDamageDoneInfo(int damage, int bonusDamage, CreatureTypeEnum monsterType)
        {
            if (damage == 0)
            {
                return ($" Moнстр {Name} промахнулся в врагу");
            }
            else
            {
                return ($" Moнстр {Name} наносит удар: урон {damage} ");
            }
        }

        public virtual string GetTakenDamageInfo(int damage)
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

        public override int MinAttackDamage()
        {
            return _minAttackDamage;
        }

        public override int MaxAttackDamage()
        {
            return _maxAttackDamage;
        }
     
    }
}
