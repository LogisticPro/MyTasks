using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterRPG_2._0.InventoryModels
{
    public static class ItemCollection
    {     
        public static Item[] GetItem()
        {
            Item AxeOfBruteForce = new Item(InventoryItemType.Axe, "AxeOfBruteForce", 50, 30, 0, 0, 3);
            Item BladeOfPressure = new Item(InventoryItemType.Blade, "BladeOfPressure", 25, 20, 0, 0, 2);
            Item KnifeOfSwiftness = new Item(InventoryItemType.Knife, "KnifeOfSwiftness", 50, 30, 0, 5, 0);
            Item ShoesOfMobility = new Item(InventoryItemType.Shoes, "AxeOfBruteForce", 25, 20, 0, 3, 0);
            Item MantleOfBrightness = new Item(InventoryItemType.Mantle, "MantleOfBrightness", 50, 30, 5, 0, 0);
            Item StaffOfWizardy = new Item(InventoryItemType.Staff, "StaffOfWizardy", 25, 20, 3, 0, 0);
            Item RingOfGreatness = new Item(InventoryItemType.Ring, "RingOfGreatness", 100, 50, 3, 3, 3);
            Item CrownOfPower = new Item(InventoryItemType.Crown, "CrownOfPower", 100, 50, 5, 5, 5);

            Item[] ItemArray = new Item[8] { AxeOfBruteForce, BladeOfPressure, KnifeOfSwiftness, ShoesOfMobility,
                                                        MantleOfBrightness, StaffOfWizardy, RingOfGreatness, CrownOfPower };
            return ItemArray;
        }
    }
}
