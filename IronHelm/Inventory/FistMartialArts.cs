using IronHelm.Combat;
using IronHelm.Enumerations;
using IronHelm.Heroes;

namespace IronHelm.Inventory
{
    public class FistMartialArts : IItem
    {
        public string Name => "Martial Arts Fist";

        public int Cost => 0;

        public int Encumbrance => 0;

        public EquipableItem.LocationType LocationType => EquipableItem.LocationType.PrimaryHand;

        public Hero Equip(Hero hero)
        {
            hero.CombatAttacks.Add(new AttackFistMartialArts());
            return hero;
        }

        public Hero UnEquip(Hero hero)
        {
            hero.CombatAttacks.Remove(new AttackFistMartialArts());
            return hero;
        }
    }
}