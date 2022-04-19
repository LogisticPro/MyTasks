using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterRPG_2._0.Monsters
{
    abstract class Creatures
    {
        public string Name { get; private set; }
        public int MaxHP { get; private set; }

        private int _currentHP;
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
        public abstract void Wounds(int damage);
    }
}
