// Ignore Spelling: Shroom

using IronHelm.Actions;
using IronHelm.Heroes;

namespace IronHelm.Trappings
{
    public class DuskShroom : IItem
    {
        public int Cost => 2;
        public int Encumbrance => 1;
        public string Name => "Dusk Shroom";

        public IHero Affect(IHero hero)
        {
            hero = HeroActions.HealthIncrease(hero, 2);
            hero = HeroActions.EnergyIncrease(hero, 2);
            hero = HeroActions.ItemRemoveFromInventory(hero, new DuskShroom());
            return hero;
        }
    }
}