// Ignore Spelling: Olma

using IronHelm.Heroes;
using IronHelm.Trappings;

namespace IronHelm.Actions
{
    public static class HeroActions
    {
        public static IHero EncumbranceDecrease(IHero hero, IItem item)
        {
            hero.Encumbrance = hero.Encumbrance - item.Encumbrance;
            if (hero.Encumbrance < 0) hero.Encumbrance = 0;
            return hero;
        }

        public static IHero EncumbranceIncrease(IHero hero, IItem item)
        {
            hero.Encumbrance = hero.Encumbrance + item.Encumbrance;
            //TODO What to do if player is over encumbered
            return hero;
        }

        public static IHero EnergyDecrease(IHero hero, int amount)
        {
            hero.Energy -= amount;
            if (hero.Energy < 0) hero.Energy = 0;
            //TODO apply weakened Enum
            return hero;
        }

        public static IHero EnergyIncrease(IHero hero, int amount)
        {
            hero.Energy += amount;
            if (hero.Energy > hero.EnergyMaximum) hero.Energy = hero.EnergyMaximum;
            return hero;
        }

        public static IHero HealthDecrease(IHero hero, int amount)
        {
            hero.Health -= amount;

            if (hero.Health < 0) hero.Health = 0;
            //TODO apply Death Enum
            return hero;
        }

        public static IHero HealthIncrease(IHero hero, int amount)
        {
            hero.Health += amount;
            if (hero.Health > hero.HealthMaximum) hero.Health = hero.HealthMaximum;
            return hero;
        }

        public static IHero ItemPurchase(IHero hero, IItem item)
        {
            if (Validations.Hero.CanAddToInventory(hero, item) && Validations.Hero.CanPurchase(hero, item))
            {
                hero.Wealth -= item.Cost;
                hero.Inventory.Add(item);
            }

            return hero;
        }

        public static IHero ItemRemoveFromInventory(IHero hero, IItem item)
        {
            hero.Inventory.Remove(item);

            return hero;
        }

        public static IHero ItemUse(IHero hero, IItem item)
        {
            if (hero.Inventory.Any(i => i.GetType() == item.GetType())) item.Affect(hero);
            return hero;
        }

        public static IHero RationsIncrease(IHero hero, int amount)
        {
            hero.Rations += amount;
            return hero;
        }

        public static IHero RationsDecrease(IHero hero, int amount)
        {
            hero.Rations += amount;
            if (hero.Rations < 0) hero.Rations = 0;
            return hero;
        }
    }
}