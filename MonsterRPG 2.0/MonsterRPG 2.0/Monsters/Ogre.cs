using MonsterRPG_2._0.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterRPG_2._0.Monsters
{
    internal class Ogre : Monster
    {
        public Ogre(string name, int hp, int minAttackDamage, int maxAttackDamage) : base(name, hp, minAttackDamage, maxAttackDamage) { }
        public Ogre() : base("Огр - воин", 425, 18, 54) { }

        public override CreatureTypeEnum CreatureType => CreatureTypeEnum.Ogre;

        public override string WarCry => $"Монстр {Name} кричит: Rrrraaaaaaaa!";
        public override string DieCry => $"Монстр {Name} издаёт предсмертный хрип: Aghhh!";

        public override string GetInfo()
        {
            var info = ($" Тип монста: {CreatureType}\r \n " +
                $"Имя монстра: {Name}\r \n" +
                $" Минимальный урон: {MinAttackDamage()}\r \n" +
                $" Максимальный урон: {MaxAttackDamage()}\r \n" +
                $" Здоровье: {MaxHP}\r \n" +
                $" Умения : Критический удар - шанс нанести двойной урон по врагу");
            return info;
        }

        public override string GetDamageDoneInfo(int damage, int bonusDamage, CreatureTypeEnum monsterType)
        {
            if (damage == 0)
            {
                return ($" Moнстр {Name} промахнулся по врагу");
            }
            else if (bonusDamage > 7)
            {
                return ($" Moнстр {Name} наносит критический удар: урон {damage}");
            }
            else
            {
                return ($" Moнстр {Name} наносит удар: урон {damage}");
            }
        }

        public override (int, int) Attack(ICombatan enemy)
        {
            var baseAttack = Convert.ToInt32(GetBaseAttack(0) * enemy.GetBlockModifier());

            if (enemy.IsEvade())
            {
                return (0, 0);
            }

            var bonus = rand.Next(1, 11);

            if (bonus > 7)
            {
                return (baseAttack * 2, baseAttack);
            }

            return (baseAttack, 0);
        }

        public override int GetBaseAttack(int bonusDamage)
        {
            var ogreBaseAttack = 0;
            ogreBaseAttack = rand.Next(MinAttackDamage(), MaxAttackDamage() + 1) + bonusDamage;
            return ogreBaseAttack;
        }
    }
}
