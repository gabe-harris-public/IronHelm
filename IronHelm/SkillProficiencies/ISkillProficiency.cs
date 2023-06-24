using IronHelm.Enumerations;

namespace IronHelm.SkillProficiencies
{
    public interface ISkillProficiency
    {
        HeroSkillProficiencies.Type proficiency { get; }
    }
}