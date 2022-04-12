using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask_7
{
    public static class Extensions
    {
        public static string EngToRusMonsterType(this MonsterTypeEnum monsterType)
        {
            switch (monsterType)
            {
                case MonsterTypeEnum.Dragon: return "Дракон";
                case MonsterTypeEnum.Orc: return "Орк";
                case MonsterTypeEnum.Undead: return "Нежить";
                case MonsterTypeEnum.Construct: return "Механизм";
                case MonsterTypeEnum.Demon: return "Демон";
                case MonsterTypeEnum.Mutant: return "Мутант";
                case MonsterTypeEnum.Animal: return "Животное";
                case MonsterTypeEnum.Ghost: return "Дух";
                default: return "";
            }
        }
    }
}
