using IronHelm.Combat;
using IronHelm.Enumerations;
using IronHelm.Heroes;

namespace IronHelm.Inventory
{
    public interface IItem
    {
        int Cost { get; }
        int Encumbrance { get; }
        EquipableItem.LocationType LocationType { get; }
        List<IHeroAttack>? Attacks { get; }
        string Name { get; }
        void Equip(Hero hero);
        void UnEquip(Hero hero);
    }
}