// Ignore Spelling: Olma

using IronHelm.Enumerations;
using IronHelm.Inventory;
using IronHelm.SkillProficiencies;
using IronHelm.Skills;
using IronHelm.Trappings;

namespace IronHelm.Heroes
{
    public class KilnOlma : Hero
    {
        public KilnOlma()
        {
            Conditions = new List<HeroConditions.Type>
            {
                HeroConditions.Type.Normal
            };
            DamageModifier = 0;
            Encumbrance = 0;
            EncumbranceMaximum = 10;
            Energy = EnergyMaximum;
            EnergyMaximum = 13;
            Health = HealthMaximum;
            HealthMaximum = 11;
            Inventory = new List<IItem> {
                new DuskShroom(),
                new FistMartialArts()
            };
            Inventory.Remove(new Fist());
            Name = "Kiln-Olma";
            Rations = 2;
            SkillList = new List<ISkill> {
                new MartialArts()
            };
            SkillProficiencies = new List<ISkillProficiency> {
                new Mind()
            };
            Wealth = 2;
        }
    }
}