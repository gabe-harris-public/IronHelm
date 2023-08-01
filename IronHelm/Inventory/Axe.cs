using IronHelm.Combat;
using IronHelm.Enumerations;
using IronHelm.Heroes;

namespace IronHelm.Inventory
{
    public class Axe : IItem
    {
        public int Cost => 2;
        public int Encumbrance => 2;
        public EquipableItem.LocationType LocationType => EquipableItem.LocationType.PrimaryHand;
        public string Name => "Axe";

        public List<IHeroAttack> Attacks { get; } = new List<IHeroAttack>();

        public Axe()
        {
            Attacks.AddRange(new IHeroAttack[] { new AttackAxe(), new AttackAxeThrow() });
        }

        public void Equip(Hero hero)
        {
            if (Attacks is not null)
                hero.CombatAttacks.AddRange(Attacks);
        }

        public void UnEquip(Hero hero)
        {
            if (Attacks is not null)
                hero.CombatAttacks.RemoveAll(attack => Attacks.Contains(attack));
        }
    }
}