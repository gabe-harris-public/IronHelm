using IronHelm.Heroes;
using IronHelm.Inventory;

namespace IronHelm.Validations
{
    public static class HeroChecks
    {
        public static bool CanAddToInventory(Hero hero, IItem item)
        {
            if (hero.EncumbranceMaximum >= EncumbranceTotal(hero) + item.Encumbrance) return true;
            else return false;
        }

        public static bool CanPurchase(Hero hero, IItem item)
        {
            if (hero.Coins >= item.Cost) return true;
            else return false;
        }

        public static int EncumbranceTotal(Hero hero)
        {
            return hero.Inventory.Sum(x => x.Encumbrance);
        }
    }
}