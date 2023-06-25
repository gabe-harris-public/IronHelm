using IronHelm.Heroes;
using IronHelm.Trappings;

namespace IronHelm.Inventory
{
    internal class MartialArtsFist : IItem
    {
        public string Name => "Martial Arts Fist";

        public int Cost => 0;

        public int Encumbrance => 0;

        public Hero Equip(Hero hero)
        {
            return hero;
        }

        public Hero UnEquip(Hero hero)
        {
            //Remove From Primary Hand
            return hero;
        }
    }
}
