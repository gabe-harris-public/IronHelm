﻿using IronHelm.Inventory;

namespace IronHelm.Combat
{
    public interface IHeroAttack
    {
        bool ConsumesEnergy { get; }
        bool ConsumesItem { get; }
        bool HasPredeterminedDamage { get; }
        int Damage { get; }
        int Energy { get; }
        string Name { get; }
        bool ConsumesAttack { get; }
    }
}
