// Ignore Spelling: Olma

using IronHelm.Enumerations;
using IronHelm.Heroes;
using IronHelm.Inventory;

namespace IronHelm.Actions
{
    public static class HeroActions
    {
        public static Hero EncumbranceDecrease(Hero hero, IItem item)
        {
            hero.Encumbrance -= item.Encumbrance;
            if (hero.Encumbrance < 0) hero.Encumbrance = 0;
            return hero;
        }

        public static Hero EncumbranceIncrease(Hero hero, IItem item)
        {
            hero.Encumbrance += item.Encumbrance;
            if (hero.Encumbrance > hero.EncumbranceMaximum)
            {
                hero.Conditions.Add(HeroConditions.Type.OverEncumbered);
            }
            return hero;
        }

        public static Hero EnergyDecrease(Hero hero, int amount)
        {
            hero.Energy -= amount;
            if (hero.Energy <= 0)
            {
                hero.Energy = 0;
                hero.Conditions.Add(HeroConditions.Type.Weakened);
            }
            return hero;
        }

        public static Hero EnergyIncrease(Hero hero, int amount)
        {
            hero.Energy += amount;
            if (hero.Energy > hero.EnergyMaximum) hero.Energy = hero.EnergyMaximum;
            return hero;
        }

        public static Hero HealthDecrease(Hero hero, int amount)
        {
            hero.Health -= amount;

            if (hero.Health <= 0)
            {
                hero.Health = 0;
                hero.Conditions.Add(HeroConditions.Type.Death);
            }
            return hero;
        }

        public static Hero HealthIncrease(Hero hero, int amount)
        {
            hero.Health += amount;
            if (hero.Health > hero.HealthMaximum) hero.Health = hero.HealthMaximum;
            return hero;
        }

        public static Hero ItemAddToInventory(Hero hero, IItem item)
        {
            hero.Inventory.Add(item);
            return hero;
        }

        public static Hero ItemPurchase(Hero hero, IItem item)
        {
            if (Validations.HeroChecks.CanAddToInventory(hero, item) 
                && Validations.HeroChecks.CanPurchase(hero, item))
            {
                hero.Coins -= item.Cost;
                hero.Encumbrance -= item.Encumbrance;
                hero.Inventory.Add(item);
            }

            return hero;
        }
        public static Hero ItemRemoveFromInventory(Hero hero, IItem item)
        {
            hero.Inventory.Remove(item);

            return hero;
        }

        public static Hero ItemUse(Hero hero, IItem item)
        {
            if (hero.Inventory.Any(i => i.GetType() == item.GetType())) item.Equip(hero);
            return hero;
        }

        public static Hero RationsDecrease(Hero hero, int amount)
        {
            hero.Rations += amount;
            if (hero.Rations < 0) hero.Rations = 0;
            return hero;
        }

        public static Hero RationsIncrease(Hero hero, int amount)
        {
            hero.Rations += amount;
            return hero;
        }
    }
}