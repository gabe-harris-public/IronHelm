using IronHelm.Inventory;

namespace IronHelm.Combat
{
    public class AttackAxe : IHeroAttack
    {
        public AttackAxe()
        {
            Item = new Axe();
            Name = nameof(AttackAxe);
        }
        public IItem Item { get; }

        public bool ConsumesEnergy { get; }

        public bool ConsumesItem { get; }

        public int Damage { get; }

        public int Energy { get; }

        public string Name { get; }

        public bool HasPredeterminedDamage { get; }

        public bool ConsumesAttack { get; }
    }
}
