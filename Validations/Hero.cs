using IronHelm.Heroes;
using IronHelm.Trappings;

namespace IronHelm.Validations
{
    public static class Hero
    {
        public static bool CanAddToInventory(IHero hero, IItem trapping)
        {
            if (hero.EncumbranceMaximum <= EncumbranceTotal(hero) + trapping.Encumbrance) return true;
            else return false;
        }

        public static bool CanPurchase(IHero hero, IItem trapping)
        {
            if (hero.Wealth >= trapping.Cost) return true;
            else return false;
        }

        public static int EncumbranceTotal(IHero hero)
        {
            return hero.Inventory.Sum(x => x.Encumbrance);
        }
    }
}