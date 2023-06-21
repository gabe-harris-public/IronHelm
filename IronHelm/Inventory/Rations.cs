using IronHelm.Actions;
using IronHelm.Heroes;

namespace IronHelm.Trappings
{
    public class Rations : IItem
    {
        public int Cost => 1;
        public int Encumbrance => 0;
        public string Name => "Rations";

        public IHero Affect(IHero hero)
        {
            hero = HeroActions.RationsIncrease(hero, 2);
            hero = HeroActions.ItemRemoveFromInventory(hero, new Rations());
            return hero;
        }
    }
}