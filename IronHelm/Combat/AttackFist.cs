using IronHelm.Inventory;

namespace IronHelm.Combat
{
    public class AttackFist : IHeroAttack
    {
        public AttackFist()
        {
            Item = new Fist();
            Damage = 1;
            HasPredeterminedDamage = true;
            Name = nameof(AttackFist);
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
