// Ignore Spelling: Olma

using IronHelm.Enumerations;
using IronHelm.SkillProficiencies;
using IronHelm.Skills;
using IronHelm.Trappings;
using IronHelm.Actions;
using IronHelm.Inventory;

namespace IronHelm.Heroes
{
    public class KilnOlma : Hero
    {
        public KilnOlma()
        {
            DamageModifier = 0;
            Name = "Kiln-Olma";

            HealthMaximum = 11;
            Health = HealthMaximum;

            EnergyMaximum = 13;
            Energy = EnergyMaximum;

            EncumbranceMaximum = 10;
            Encumbrance = 0;

            Wealth = 2;
            Rations = 2;

            Inventory = new List<IItem> {
                new DuskShroom(),
                new FistMartialArts()
            };
            Inventory.Remove(new Fist());

            SkillList = new List<ISkill> {
                new MartialArts()
            };
            SkillProficiencies = new List<ISkillProficiency> {
                new Mind()
            };
            Conditions = new List<HeroConditions.Type> {
                new HeroConditions.Type()
            };
            Conditions.Add(new HeroConditions.Type.Normal);
        }
    }
}