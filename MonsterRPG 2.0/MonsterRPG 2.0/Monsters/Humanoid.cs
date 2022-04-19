using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterRPG_2._0.Monsters
{
    internal class Humanoid : Creatures
    {
        public override void Wounds(int damage)
        {
            CurrentHP -= damage;
        }
    }
}
