﻿using IronHelm.Enumerations;
using IronHelm.Heroes;

namespace IronHelm.Trappings
{
    public interface IItem
    {
        string Name { get; }
        int Cost { get; }
        int Encumbrance { get; }
        EquipableItem.LocationType LocationType { get; }

        Hero Equip(Hero hero);

        Hero UnEquip(Hero hero);
    }
}