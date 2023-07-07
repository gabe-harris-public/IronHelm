using IronHelm.Combat;
using IronHelm.Enumerations;
using IronHelm.Heroes;
using IronHelm.Inventory;

namespace IronHelm.Inventory
{
    public class Fist : IItem
    {
        public string Name => "Bare Fist";

        public int Cost => 0;

        public int Encumbrance => 0;
        public EquipableItem.LocationType LocationType => EquipableItem.LocationType.PrimaryHand;

        public Hero Equip(Hero hero)
        {
            hero.CombatAttacks.Add(new AttackFist());
            return hero;
        }

        public Hero UnEquip(Hero hero)
        {
            hero.CombatAttacks.Remove(new AttackFist());
            return hero;
        }
    }
}