using IronHelm.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronHelm.Combat
{
    public class AttackAxeThrow: IHeroAttack
    {
        public AttackAxeThrow()
        {
            Item = new Axe();
            ConsumesEnergy = false;
            ConsumesItem = true;
            Damage = 0;
            Energy = 3;
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
