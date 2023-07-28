using IronHelm.Actions;
using IronHelm.Combat;
using IronHelm.Enumerations;
using IronHelm.Heroes;

namespace IronHelm.Inventory
{
    public class Rations : IItem
    {
        public int Cost => 1;
        public int Encumbrance => 0;
        public EquipableItem.LocationType LocationType => EquipableItem.LocationType.Accessory;
        public string Name => "Rations";

        public List<IHeroAttack>? Attacks { get; }

        public void Equip(Hero hero)
        {
            HeroActions.RationsIncrease(hero, 2);
            HeroActions.ItemRemoveFromInventory(hero, new Rations());
        }

        public void UnEquip(Hero hero)
        {
            // Nothing happens
        }
    }
}