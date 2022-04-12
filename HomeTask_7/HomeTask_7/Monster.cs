using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask_7
{
    internal class Monster
    {
        public Monster(MonsterTypeEnum monsterType, string name, int hp, int minAttackDamage, int maxAttackDamage, string warCry, string dieCry)
        {
            _monsterType = monsterType;
            Name = name;
            HP = hp;
            CurrentHP = hp;
            MinAttackDamage = minAttackDamage;
            MaxAttackDamage = maxAttackDamage;
            WarCry = warCry;
            DieCry = dieCry;
        }

        public Monster()
        {

        }

        protected MonsterTypeEnum _monsterType;
        private string _name;
        private int _HP;
        private int _currentHP;
        private int _minAttackDamage;
        private int _maxAttackDamage;
        public string WarCry { get; set; }
        public string DieCry { get; set; }

        Random rand = new Random();

        private const int MinHP = 1;
        private const int MaxHP = 500;

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
            private set
            {
                if (value < MinHP && value > MaxHP)
                {
                    throw new ArgumentOutOfRangeException("Неверное количесто жизненной силы монстра!");
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
                if (value > 0 && value < 20)
                {
                    _minAttackDamage = value;
                }
                else
                {
                    throw new NullReferenceException("Минимальный урон некорректен!");
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
                    throw new NullReferenceException("Максимальный урон некорректен!");
                }
            }
        }

        public string MonsterType
        {
            get
            {
                return Extensions.EngToRusMonsterType(_monsterType);
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
                if(value >= 0)
                {
                    _currentHP = value;
                }
                else
                {
                    _currentHP = 0;
                }
            }
        }

        public string GetWarCry()
        {
            return ($"Монстр {Name} кричит: {WarCry}!");
        }

        public string GetDieCry()
        {
            return ($"Монстр {Name} издаёт предсмертный хрип: {DieCry}!");
        }

        public string GetInfo()
        {
            var info = ($" Тип монста: {MonsterType}\r \n " +
                $"Имя монстра: {_name}\r \n" +
                $" Минимальный урон: {_minAttackDamage}\r \n" +
                $" Максимальный урон: {_maxAttackDamage}\r \n" +
                $" Здоровье: {_HP}");
            return info;
        }

        public string GetFightInfo(int damage)
        {
            if (damage == 0 && MonsterType == "Дух")
            {
                return ($" Moнстр {Name} нематериален и не получил урон \r \n" +
                $" Текущее здоровье монстра: {CurrentHP}");
            }
            else if (damage == 0)
            {
                return ($" Moнстр {Name} увернулся от удара \r \n" +
                $" Текущее здоровье монстра: {CurrentHP}");
            }
            else 
            {
                return ($" Moнстр {Name} получил урон {damage} \r \n" +
                $" Текущее здоровье монстра: {CurrentHP}");
            }
        }

        public bool IsDie()
        {
            if (CurrentHP < 1) return true;
            else return false;
        }

        private int GetBaseAttack(int bonusDamage)
        {
             return rand.Next(MinAttackDamage, MaxAttackDamage + 1) + bonusDamage;         
        }

        public int GetAttack(int bonusDamage)
        {
            if (HitChance() == true)
            {
                return GetBaseAttack(bonusDamage);
            }

            return 0;
        }

        public int BonusDamage()
        {
            return rand.Next(1, 11);
        }

        public bool HitChance()
        {
            var hitChance = rand.Next(1, 101);

            if (hitChance <= 15)
            {
                return false;
            }

            return true;
        }

        public int Wounds(int damage)
        {
            return CurrentHP -= damage;
        }

        public void Heal()
        {
            CurrentHP = HP;
        }
    }
}
