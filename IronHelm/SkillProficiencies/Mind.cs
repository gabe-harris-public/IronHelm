using IronHelm.Enumerations;

namespace IronHelm.SkillProficiencies
{
    public class Mind : ISkillProficiency
    {
        public HeroSkillProficiencies.Type proficiency => HeroSkillProficiencies.Type.Mind;
    }
}