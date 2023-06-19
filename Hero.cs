namespace IronHelm
{
    public class Hero
    {
        public int Encumbrance { get; set; }
        public int Energy { get; set; }
        public int Health { get; set; }
        public string Name { get; set; }
        public int Rations { get; set; }
        public List<Skill> SkillList { get; set; } = new List<Skill>();
        public List<SkillProficiency> SkillProficiencies { get; set; } = new List<SkillProficiency>();
        public List<Trapping> TrappingList { get; set; } = new List<Trapping>();
        public int Wealth { get; set; }
    }
}