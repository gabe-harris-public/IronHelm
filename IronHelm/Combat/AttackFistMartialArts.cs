using IronHelm.Inventory;

namespace IronHelm.Combat
{
    public class AttackFistMartialArts : IHeroAttack
    {
        public AttackFistMartialArts()
        {
            Item = new FistMartialArts();
            ConsumesEnergy = false;
            ConsumesItem = false;
            Damage = 2;
            Energy = 0;
            Name = Item.Name;
        }
        public IItem Item { get; }

        public bool ConsumesEnergy { get; }

        public bool ConsumesItem { get; }

        public int Damage { get; }

        public int Energy { get; }

        public string Name { get; }
    }
}
