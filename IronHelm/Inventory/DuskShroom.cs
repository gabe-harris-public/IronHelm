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

        public Hero Equip(Hero hero)
        {
            HeroActions.HealthIncrease(hero, 2);
            HeroActions.EnergyIncrease(hero, 2);
            HeroActions.ItemRemoveFromInventory(hero, new DuskShroom());
            return hero;
        }
        public Hero UnEquip(Hero hero)
        {
            //TODO Nothing Happens
            return hero;
        }
    }
}