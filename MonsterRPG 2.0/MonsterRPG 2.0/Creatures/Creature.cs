using MonsterRPG_2._0.Interfaces;
using MonsterRPG_2._0.Monsters;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterRPG_2._0.Creatures
{
    public abstract class Creature
    {
        public string Name { get; protected set; }
        public int MaxHP { get; protected set; }

        public Random rand = new Random();

        protected int _currentHP;
        public int CurrentHP 
        {
            get { return _currentHP; }
            protected set
            {
                if (value < 0)
                {
                    _currentHP = 0;
                }
                else
                {
                    _currentHP = value;
                }
            }
        }
        public bool IsDie => CurrentHP == 0;

        public virtual (int, int) Attack(ICombatan enemy)
        {
            var bonusDamage = BonusDamage(enemy.CreatureType);

            if (enemy.IsEvade())
            {
                return (0, bonusDamage);
            }

            if (enemy.HasResist())
            {
                bonusDamage = 0;
            }

            var baseAttack = GetBaseAttack(bonusDamage);
            var blockModifier = enemy.GetBlockModifier();
            var damage = Convert.ToInt32(baseAttack * blockModifier);

            return ( damage, bonusDamage);
        }
        public abstract int MinAttackDamage();
        public abstract int MaxAttackDamage();

        public virtual int GetBaseAttack(int bonusDamage)
        {
            return rand.Next(MinAttackDamage(), MaxAttackDamage() + 1) + bonusDamage;
        }

        protected virtual int BonusDamage()
        {
            return 0;
        }

        public virtual int BonusDamage(CreatureTypeEnum monsterType)
        {
            return BonusDamage();
        }

        public virtual bool HasResist()
        {
            return false;
        }

        public virtual double GetBlockModifier()
        {
            return 1;
        }

        public virtual void Wounds(int damage)
        {
            CurrentHP -= damage;
        }

        public virtual bool IsEvade()
        {
            return false;
        }

        public virtual void Heal()
        {
            CurrentHP = MaxHP;
        }
        public virtual void ApplyAttackSkills(int damage, ICombatan enemy)
        {

        }
    }
}
