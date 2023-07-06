
using IronHelm.Actions;
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
            HeroCombatActions.AttackSpecialAddAxeThrow(hero);
            return hero;
        }

        public Hero UnEquip(Hero hero)
        {
            HeroCombatActions.AttackSpecialRemoveAxeThrow(hero);
            return hero;
        }
    }
}
