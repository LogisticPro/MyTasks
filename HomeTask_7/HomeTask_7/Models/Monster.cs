using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask_7.Models
{
    internal abstract class Monster
    {
        public Monster(string name, int hp, int minAttackDamage, int maxAttackDamage)
        {
            Name = name;
            HP = hp;
            CurrentHP = hp;
            MinAttackDamage = minAttackDamage;
            MaxAttackDamage = maxAttackDamage;
        }

        public Monster()
        {

        }

        public abstract string MonsterType { get; }
        private string _name;
        private int _HP;
        private int _currentHP;
        private int _minAttackDamage;
        private int _maxAttackDamage;

        public abstract string WarCry { get; }
        public abstract string DieCry { get; }

        Random rand = new Random();

        private const int MinHP = 1;
        private const int MaxHP = 750;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value != null)
                {
                    _name = value;
                }
                else
                {
                    throw new NullReferenceException();
                }
            }
        }
        public int HP
        {
            get
            {
                return _HP;
            }
            set
            {
                if (value < MinHP || value > MaxHP)
                {
                    throw new ArgumentException("Неверное количесто жизненной силы монстра!");
                }
                else
                {
                    _HP = value;
                }
            }
        }
        public int MinAttackDamage
        {
            get
            {
                return _minAttackDamage;
            }
            set
            {
                if (value > 0 && value < 26)
                {
                    _minAttackDamage = value;
                }
                else
                {
                    throw new ArgumentException("Минимальный урон некорректен!");
                }
            }
        }
        public int MaxAttackDamage
        {
            get
            {
                return _maxAttackDamage;
            }
            set
            {
                if (value > 19 && value < 101)
                {
                    _maxAttackDamage = value;
                }
                else
                {
                    throw new ArgumentException("Максимальный урон некорректен!");
                }
            }
        }

        public int CurrentHP
        {
            get
            {
                return _currentHP;
            }
            set
            {
                if (value >= 0)
                {
                    _currentHP = value;
                }
                else
                {
                    _currentHP = 0;
                }
            }
        }

        public virtual string GetInfo()
        {
            var info = ($" Тип монста: {MonsterType}\r \n " +
                $"Имя монстра: {Name}\r \n" +
                $" Минимальный урон: {MinAttackDamage}\r \n" +
                $" Максимальный урон: {MaxAttackDamage}\r \n" +
                $" Здоровье: {HP}");
            return info;
        }

        public string GetHpInfo()
        {
            return $"  Текущее здоровье монстра {MonsterType}: {CurrentHP}";
        }

        public virtual string GetDamageDoneInfo(int damage, int bonusDamage, string monsterType)
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

        public bool IsDie()
        {
            if (CurrentHP < 1) return true;
            else return false;
        }

        protected virtual int GetBaseAttack(int bonusDamage)
        {
            return rand.Next(MinAttackDamage, MaxAttackDamage + 1) + bonusDamage;
        }

        public virtual int GetAttack(int bonusDamage, Monster monster) // (Бонусный урон от способностей, по какому существу бьёт монстр)
        {
            if (monster.IsEvade())
            {
                return 0;              
            }
            else if (monster.HasResist() && monster.HasBlock() && monster.CurrentHP > HP / 2)
            {
                return GetBaseAttack(0) / 5 * 3;
            }
            else if (monster.HasResist())
            {
                return GetBaseAttack(0);
            }
            return GetBaseAttack(bonusDamage);
        }

        public virtual void ApplyAttackSkills(int damage)
        {
            
        }

        public virtual bool HasResist()
        {
            return false;
        }

        public virtual bool HasBlock()
        {
            return false; ;
        } 

        public virtual int BonusDamage()
        {
            return 0;
        }

        public virtual bool IsEvade() // увернулся от удара или нет?
        {
            var dodjeChance = rand.Next(1, 101);

            if (dodjeChance <= 10)
            {
                return true;
            }

            return false;
        }

        public virtual int Wounds(int damage) 
        {
            return CurrentHP -= damage;
        }

        public virtual void Heal()
        {
            CurrentHP = HP;
        }
    }
}
