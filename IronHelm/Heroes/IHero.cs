﻿using IronHelm.Enumerations;
using IronHelm.SkillProficiencies;
using IronHelm.Skills;
using IronHelm.Trappings;

namespace IronHelm.Heroes
{
    public interface IHero
    {
        List<HeroConditions.Type> Conditions { get; set; }
        int Encumbrance { get; set; }
        int EncumbranceMaximum { get; set; }
        int Energy { get; set; }
        int EnergyMaximum { get; set; }
        List<IItem> Inventory { get; set; }
        int Rations { get; set; }
        List<ISkill> SkillList { get; set; }
        List<ISkillProficiency> SkillProficiencies { get; set; }
    }
}