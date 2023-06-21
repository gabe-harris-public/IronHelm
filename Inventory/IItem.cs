﻿using IronHelm.Heroes;

namespace IronHelm.Trappings
{
    public interface IItem
    {
        string Name { get; }
        int Cost { get; }
        int Encumbrance { get; }

        IHero Affect(IHero hero);
    }
}