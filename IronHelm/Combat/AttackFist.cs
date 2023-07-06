using IronHelm.Inventory;

namespace IronHelm.Combat
{
    public class AttackFist : IHeroAttack
    {
        public AttackFist()
        {
            Item = new Fist();
            ConsumesEnergy = false;
            ConsumesItem = false;
            Damage = 1;
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
