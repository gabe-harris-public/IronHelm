using IronHelm.Enumerations;
using IronHelm.SkillProficiencies;
using IronHelm.Skills;
using IronHelm.Trappings;

namespace IronHelm.Heroes
{
    public interface IHero
    {
        int Encumbrance { get; set; }
        int EncumbranceMaximum { get; set; }
        int Energy { get; set; }
        int EnergyMaximum { get; set; }
        int Health { get; set; }
        int HealthMaximum { get; set; }
        string Name { get; }
        int Rations { get; set; }
        List<ISkill> SkillList { get; set; }
        List<ISkillProficiency> SkillProficiencies { get; set; }
        List<IItem> Inventory { get; set; }
        int Wealth { get; set; }
        List<HeroConditions.Type> Conditions { get; set; }
    }
}