using IronHelm.Heroes;
using IronHelm.Trappings;

namespace IronHelm.Validations
{
    public static class HeroChecks
    {
        public static bool CanAddToInventory(Hero hero, IItem trapping)
        {
            if (hero.EncumbranceMaximum >= EncumbranceTotal(hero) + trapping.Encumbrance) return true;
            else return false;
        }

        public static bool CanPurchase(Hero hero, IItem trapping)
        {
            if (hero.Wealth >= trapping.Cost) return true;
            else return false;
        }

        public static int EncumbranceTotal(Hero hero)
        {
            return hero.Inventory.Sum(x => x.Encumbrance);
        }
    }
}