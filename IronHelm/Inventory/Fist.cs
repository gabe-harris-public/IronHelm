using IronHelm.Enumerations;
using IronHelm.Heroes;
using IronHelm.Trappings;

namespace IronHelm.Inventory
{
    internal class Fist : IItem
    {
        public string Name => "Bare Fist";

        public int Cost => 0;

        public int Encumbrance => 0;
        public EquipableItem.LocationType LocationType => EquipableItem.LocationType.PrimaryHand;


        public Hero Equip(Hero hero)
        {
            hero.DamageModifier += 1;
            return hero;
        }

        public Hero UnEquip(Hero hero)
        {
            hero.DamageModifier -= 1;
            return hero;
        }
    }
}
