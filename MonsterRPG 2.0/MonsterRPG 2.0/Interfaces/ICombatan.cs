using System;
using System.Collections.Generic;
using System.Text;
using MonsterRPG_2._0.Monsters;

namespace MonsterRPG_2._0.Interfaces
{
    public interface ICombatan
    {
        public CreatureTypeEnum CreatureType { get; }
        public bool IsDie { get; }
        public string WarCry { get; }
        public string DieCry { get; }

        public int MinAttackDamage();
        public int MaxAttackDamage();
        public string GetInfo();
        public string GetHpInfo();
        public string GetDamageDoneInfo(int damage, int bonusDamage, CreatureTypeEnum creatureType);
        public string GetTakenDamageInfo(int damage);
        public (int, int) Attack(ICombatan enemy);
        public int GetBaseAttack(int bonusDamage);
        public int BonusDamage(CreatureTypeEnum monsterType);
        public bool HasResist();
        public double GetBlockModifier();    
        public void Wounds(int damage);
        public bool IsEvade();
        public void Heal();
        public void ApplyAttackSkills(int damage, ICombatan enemy); 
    }
}
