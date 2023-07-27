using IronHelm.Combat;
using IronHelm.Enumerations;
using IronHelm.Heroes;

namespace IronHelm.Inventory
{
    public class Axe : IItem
    {
        public int Cost => 2;
        public int Encumbrance => 2;
        public EquipableItem.LocationType LocationType => EquipableItem.LocationType.PrimaryHand;
        public string Name => "Axe";

        public void Equip(Hero hero)
        {
            hero.CombatAttacks.Add(new AttackAxe());
            hero.CombatAttacks.Add(new AttackAxeThrow());
        }

        public void UnEquip(Hero hero)
        {
            hero.CombatAttacks.Remove(new AttackAxe());
            hero.CombatAttacks.Remove(new AttackAxeThrow());
        }
    }
}