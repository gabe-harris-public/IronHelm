using IronHelm.Actions;
using IronHelm.Enumerations;
using IronHelm.Heroes;

namespace IronHelm.Trappings
{
    public class Rations : IItem
    {
        public int Cost => 1;
        public int Encumbrance => 0;
        public EquipableItem.LocationType LocationType => EquipableItem.LocationType.Accessory;
        public string Name => "Rations";
        public Hero Equip(Hero hero)
        {
            hero = HeroActions.RationsIncrease(hero, 2);
            hero = HeroActions.ItemRemoveFromInventory(hero, new Rations());
            return hero;
        }

        public Hero UnEquip(Hero hero)
        {
            return hero;
        }
    }
}