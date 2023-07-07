using IronHelm.Inventory;

namespace IronHelm.Combat
{
    public class AttackAxe : IHeroAttack
    {
        public AttackAxe()
        {
            Item = new Axe();
            ConsumesEnergy = true;
            ConsumesItem = false;
            Damage = 0;
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
