using MonsterRPG_2._0.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using MonsterRPG_2._0.InventoryModels;
using MonsterRPG_2._0.Monsters;

namespace MonsterRPG_2._0.Creatures
{   
    public class Hero : Humanoid, ICombatan
    {
        private Inventory inv;
        private Item item;
        public string WarCry => $"Герой {Name} кричит: За честь и отвагу!";
        public string DieCry => $"Герой {Name} издаёт предсмертный хрип: Нееееееееет!";

        public Hero(RacesEnum race, string name, int intelligence, int agility, int strength)
            : base(race, name)
        {
            inv = new Inventory();         
            item = ItemCollection.GetItem()[rand.Next(0, 8)];
            inv.AddItem(item);

            Intelligence = intelligence + item.Intelligence;
            Agility = agility + item.Agility;
            Strength = strength + item.Strength;
            MaxHP = Strength * 25;
            CurrentHP = MaxHP;
        }

        public string GetInfo()
        {
            var info = ($" Тип героя: {Race}\r \n " +
                $"Имя героя: {Name}\r \n" +
                $" Минимальный урон: {MinAttackDamage()}\r \n" +
                $" Максимальный урон: {MaxAttackDamage()}\r \n" +
                $" Здоровье: {MaxHP}\r \n" +
                $" Сила: {Strength}\r \n" +
                $" Ловкость: {Agility}\r \n" +
                $" Интеллект {Intelligence}\r \n" +
                $" Aртефакт: {item.Name} ({item.Intelligence} к интеллекту, {item.Agility} к ловкости, {item.Strength} к силе)");
            return info;
        }

        public string GetHpInfo()
        {
            return $"  Текущее здоровье героя {Race}: {CurrentHP}";
        }

        public string GetDamageDoneInfo(int damage, int bonusDamage, CreatureTypeEnum monsterType)
        {
            if (damage == 0)
            {
                return ($" Герой {Name} промахнулся в врагу");
            }
            else if(Race == RacesEnum.Elf && bonusDamage == 50)
            {
                return ($" Герой {Name} попадает в голову животному, нанося урон {damage}");
            }
            else if (Race == RacesEnum.Human && bonusDamage == 50)
            {
                return ($" Герой {Name} причиняет дополнительный ущерб силам тьмы, нанося урон {damage}");
            }
            else if (Race == RacesEnum.Orc && bonusDamage >= 40)
            {
                return ($" Герой {Name} наносит сокрушительный удар, урон {damage}");
            }
            else
            {
                return ($" Герой {Name} наносит удар: урон {damage} ");
            }
        }

        public string GetTakenDamageInfo(int damage)
        {
            if (damage == 0)
            {
                return ($" Герой {Name} увернулся от удара");
            }
            else if (Race == RacesEnum.Dwarf && damage != 0)
            {
                return ($" Герой {Name} заблокировал часть полученного урона ({damage - ((int)(damage * GetBlockModifier()))}) и получил урон {damage}");
            }
            else
            {
                return ($" Герой {Name} получил урон {damage}");
            }
        }

        public override int MinAttackDamage()
        {
            return Strength;
        }

        public override int MaxAttackDamage()
        {
            return Strength * 3;
        }

        public override bool IsEvade()
        {
            var dodjeChance = rand.Next(1, 101);

            if (dodjeChance <= Agility)
            {
                return true;
            }

            return false;
        }

        public override int GetBaseAttack(int bonusDamage)
        {
            return rand.Next(MinAttackDamage(), MaxAttackDamage() + 1) + bonusDamage;
        }

        public override int BonusDamage(CreatureTypeEnum monsterType)
        {
            var bonusDamage = rand.Next(1, 101) + Intelligence;

            if (Race == RacesEnum.Elf && bonusDamage >= 75 && 
                (monsterType == CreatureTypeEnum.Animal || monsterType == CreatureTypeEnum.Dragon || monsterType == CreatureTypeEnum.Ogre))
            {
                return 50;
            }  
            else if (Race == RacesEnum.Human && bonusDamage >= 75 &&
                (monsterType == CreatureTypeEnum.Demon || monsterType == CreatureTypeEnum.Undead || monsterType == CreatureTypeEnum.Ghost))
            {
                return 50;
            }
            else if (Race == RacesEnum.Orc && bonusDamage >= 80)
            {
                return bonusDamage / 2;
            }
            else return 0;
        }

        private bool _lastStandUsed = false;

        private void LastStand()
        {
            if (CurrentHP == 0 && !_lastStandUsed)
            {
                CurrentHP = 1;
                _lastStandUsed = true;
            }
        }

        public override double GetBlockModifier()
        {
            if (Race == RacesEnum.Elf)
            {
                return 1.1;
            }
            if(Race == RacesEnum.Dwarf)
            {
                double modifier = (100 - Intelligence) * 0.01;
                return modifier;
            }
            else return 1;
        }

        public override void Wounds(int damage)
        {          
            if (Race == RacesEnum.Orc)
            {
                CurrentHP -= damage;
                LastStand();
                return;
            }

            CurrentHP -= Convert.ToInt32(damage * GetBlockModifier());           
        }


    }
}
