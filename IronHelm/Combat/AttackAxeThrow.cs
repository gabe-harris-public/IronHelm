using IronHelm.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronHelm.Combat
{
    public class AttackAxeThrow : IHeroAttack
    {
        public AttackAxeThrow()
        {
            ConsumesAttack = true;
            ConsumesItem = true;
            Damage = Actions.Roll6SidedDice(2);
            Energy = 3;
            HasPredeterminedDamage = true;
            Item = new Axe();
            Name = nameof(AttackAxeThrow);
        }
        public bool ConsumesAttack { get; }
        public bool ConsumesEnergy { get; }
        public bool ConsumesItem { get; }
        public int Damage { get; }
        public int Energy { get; }
        public bool HasPredeterminedDamage { get; }
        public IItem Item { get; }
        public string Name { get; }
    }
}
