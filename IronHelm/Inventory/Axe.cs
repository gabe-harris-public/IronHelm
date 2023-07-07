
using IronHelm.Actions;
using IronHelm.Combat;
using IronHelm.Enumerations;
using IronHelm.Heroes;
using IronHelm.Inventory;

namespace IronHelm.Inventory
{
    public class Axe : IItem
    {
        public int Cost => 2;
        public int Encumbrance => 2;
        public EquipableItem.LocationType LocationType => EquipableItem.LocationType.PrimaryHand;
        public string Name => "Axe";
        public Hero Equip(Hero hero)
        {
            hero.CombatAttacks.Add(new AttackAxe());
            hero.CombatAttacks.Add(new AttackAxeThrow());
            return hero;
        }

        public Hero UnEquip(Hero hero)
        {
            hero.CombatAttacks.Remove(new AttackAxe());
            hero.CombatAttacks.Remove(new AttackAxeThrow());
            return hero;
        }
    }
}
