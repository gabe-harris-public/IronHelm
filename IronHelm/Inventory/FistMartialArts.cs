using IronHelm.Combat;
using IronHelm.Enumerations;
using IronHelm.Heroes;

namespace IronHelm.Inventory
{
    public class FistMartialArts : IItem
    {
        public int Cost => 0;
        public int Encumbrance => 0;
        public EquipableItem.LocationType LocationType => EquipableItem.LocationType.PrimaryHand;
        public string Name => "Martial Arts Fist";
        public void Equip(Hero hero)
        {
            hero.CombatAttacks.Add(new AttackFistMartialArts());
        }

        public void UnEquip(Hero hero)
        {
            hero.CombatAttacks.Remove(new AttackFistMartialArts());
        }
    }
}