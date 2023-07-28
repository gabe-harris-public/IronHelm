using IronHelm.Inventory;

namespace IronHelm.Combat
{
    public class AttackFistMartialArts : IHeroAttack
    {
        public AttackFistMartialArts()
        {
            Item = new FistMartialArts();
            Damage = 2;
            HasPredeterminedDamage = true;
            Name = nameof(AttackFistMartialArts);
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
