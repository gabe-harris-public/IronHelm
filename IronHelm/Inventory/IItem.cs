using IronHelm.Enumerations;
using IronHelm.Heroes;

namespace IronHelm.Inventory
{
    public interface IItem
    {
        int Cost { get; }
        int Encumbrance { get; }
        EquipableItem.LocationType LocationType { get; }
        string Name { get; }
        Hero Equip(Hero hero);

        Hero UnEquip(Hero hero);
    }
}