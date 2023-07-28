// Ignore Spelling: Olma

using IronHelm.Enumerations;
using IronHelm.Inventory;
using IronHelm.SkillProficiencies;
using IronHelm.Skills;

namespace IronHelm.Heroes
{
    public class KilnOlma : Hero
    {
        public KilnOlma()
        {
            CombatAttacks = new List<Combat.IHeroAttack> { };
            Conditions = new List<HeroConditions.Type>
            {
                HeroConditions.Type.Normal
            };

            Encumbrance = 10;
            EncumbranceMaximum = 10;
            Energy = 13;
            EnergyMaximum = 13;
            Health = 11;
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
            Coins = 2;
        }
    }
}