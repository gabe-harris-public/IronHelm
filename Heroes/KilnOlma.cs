using IronHelm.SkillProficiencies;
using IronHelm.Skills;
using IronHelm.Trappings;

namespace IronHelm.Heroes
{
    public class KilnOlma : IHero
    {
        public KilnOlma()
        {
            Name = "Kiln-Olma";
            Health = 11;
            Energy = 13;
            Encumbrance = 10;
            Wealth = 2;
            Rations = 2;
            TrappingList = new List<ITrapping>
            {
                new DuskShroom()
            };
            SkillList = new List<ISkill>
            {
                new MartialArts()
            };
            SkillProficiencies = new List<ISkillProficiency>
            {
                new Mind()
            };
        }

        public int Encumbrance { get; set; }
        public int Energy { get; set; }
        public int Health { get; set; }
        public string Name { get; }
        public int Rations { get; set; }
        public List<ISkill> SkillList { get; set; }
        public List<ISkillProficiency> SkillProficiencies { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<ITrapping> TrappingList { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Wealth { get; set; }
    }
}