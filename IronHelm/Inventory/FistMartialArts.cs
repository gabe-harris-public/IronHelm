﻿using IronHelm.Enumerations;
using IronHelm.Heroes;
using IronHelm.Inventory;

namespace IronHelm.Inventory
{
    internal class FistMartialArts : IItem
    {
        public string Name => "Martial Arts Fist";

        public int Cost => 0;

        public int Encumbrance => 0;

        public EquipableItem.LocationType LocationType => EquipableItem.LocationType.PrimaryHand;

        public Hero Equip(Hero hero)
        {
            //todo add martial arts fist attack
            return hero;
        }

        public Hero UnEquip(Hero hero)
        {
            //todo Remove martial arts fist attack
            return hero;
        }
    }
}