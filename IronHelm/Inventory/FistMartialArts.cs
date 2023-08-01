using IronHelm.Combat;
using IronHelm.Enumerations;
using IronHelm.Heroes;

namespace IronHelm.Inventory
{
    public class FistMartialArts : IItem
    {
        public int Cost => 0;
        public int Encumbrance => 0;
        public EquipableItem.LocationType LocationType => EquipableItem.LocationType.PrimaryHand;
        public string Name => "Martial Arts Fist";

        public List<IHeroAttack> Attacks { get; } = new List<IHeroAttack>();

        public FistMartialArts()
        {
            Attacks.Add(new AttackFistMartialArts());
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