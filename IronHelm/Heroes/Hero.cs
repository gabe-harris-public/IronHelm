using IronHelm.Enumerations;
using IronHelm.Inventory;
using IronHelm.SkillProficiencies;
using IronHelm.Skills;
using IronHelm.Inventory;

namespace IronHelm.Heroes
{
    public abstract class Hero : IHero, IBeing
    {
        public Hero()
        {
            Inventory.Add(new Fist());
        }

        public List<HeroConditions.Type> Conditions { get; set; } = new List<HeroConditions.Type>();
        public int Encumbrance { get; set; }
        public int EncumbranceMaximum { get; set; }
        public int Energy { get; set; }
        public int EnergyMaximum { get; set; }
        public int Health { get; set; }
        public int HealthMaximum { get; set; }
        public List<IItem> Inventory { get; set; } = new List<IItem>();
        public string Name { get; set; } = string.Empty;
        public int Rations { get; set; }
        public List<ISkill> SkillList { get; set; } = new List<ISkill>();
        public List<ISkillProficiency> SkillProficiencies { get; set; } = new List<ISkillProficiency>();
        public int DamageModifier { get; set; }
        public int Wealth { get; set; }
    }
}