using IronHelm.Heroes;

namespace IronHelm.Trappings
{
    public interface IItem
    {
        string Name { get; }
        int Cost { get; }
        int Encumbrance { get; }

        Hero Equip(Hero hero);

        Hero UnEquip(Hero hero);
    }
}