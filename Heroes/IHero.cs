using IronHelm.SkillProficiencies;
using IronHelm.Skills;
using IronHelm.Trappings;

namespace IronHelm.Heroes
{
    public interface IHero
    {
        int Encumbrance { get; set; }
        int Energy { get; set; }
        int Health { get; set; }
        string Name { get; }
        int Rations { get; set; }
        List<ISkill> SkillList { get; set; }
        List<ISkillProficiency> SkillProficiencies { get; set; }
        List<ITrapping> TrappingList { get; set; }
        int Wealth { get; set; }
    }
}