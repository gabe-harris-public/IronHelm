// Ignore Spelling: Olma

using IronHelm.Heroes;
using IronHelm.Trappings;

namespace IronHelm.Actions
{
    public static class HeroActions
    {
        public static IHero ItemPurchase(IHero hero, IItem item)
        {
            if (Validations.Hero.CanAddToInventory(hero, item) && Validations.Hero.CanPurchase(hero, item))
                return item.Purchase(hero);
            else
                return hero;
        }

        public static IHero ItemUse(IHero hero, IItem item)
        {
            if (hero.Inventory.Contains(item))
                return item.Affect(hero);
            else
                return hero;
        }
    }
}