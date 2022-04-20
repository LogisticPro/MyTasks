using MonsterRPG_2._0.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterRPG_2._0.Monsters
{
    internal class Undead : Monster
    {
        public Undead(string name, int hp, int minAttackDamage, int maxAttackDamage) : base(name, hp, minAttackDamage, maxAttackDamage) { }
        public Undead() : base("Вампир", 400, 20, 70) { }
        public override CreatureTypeEnum CreatureType => CreatureTypeEnum.Undead;

        public override string WarCry => $"Монстр {Name} шипит: Assssshhaaaaa!";
        public override string DieCry => $"Монстр {Name} издаёт предсмертный хрип: Я должен был жить... вечно... пхххрп!";

        public override string GetInfo()
        {
            var info = ($" Тип монста: {CreatureType}\r \n " +
                $"Имя монстра: {Name}\r \n" +
                $" Минимальный урон: {MinAttackDamage()}\r \n" +
                $" Максимальный урон: {MaxAttackDamage()}\r \n" +
                $" Здоровье: {MaxHP}\r \n" +
                $" Умения : Вампиризм - когда HP вампира падает ниже 50% его атаки \r \n" +
                $"          восстанавливают 50% от нанесённого урона \r \n");
            return info;
        }

        public override string GetDamageDoneInfo(int damage, int bonusDamage, CreatureTypeEnum monsterType)
        {
            if (damage == 0)
            {
                return ($" Moнстр {Name} промахнулся по врагу");
            }
            else if (_isHealWork)
            {
                _isHealWork = false;
                return ($" Moнстр {Name} наносит удар: урон {damage} ({(int)(damage * 0.5)} восстановлено вампиризмом)");
            }
            else
            {
                return ($" Moнстр {Name} наносит удар: урон {damage}");
            }
        }

        public override void ApplyAttackSkills(int damage, ICombatan enemy)
        {
            if (CurrentHP != 0 && !enemy.HasResist())
            {
                LifeSteal(damage);
            }
        }

        private bool _isHealWork = false;

        private void LifeSteal(int damage)
        {
            if (CurrentHP < (MaxHP * 0.5) && damage > 0)
            {
                CurrentHP += damage / 2;
                _isHealWork = true;
            }
        }
    }
}
