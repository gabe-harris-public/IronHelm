using IronHelm.Combat;
using IronHelm.Heroes;

namespace IronHelm.Actions
{
    static public class HeroCombatActions
    {
        public static (Hero hero, int damage) Attack(Hero hero, IHeroAttack attack)
        {
            int damage = Combat.Actions.Roll6SidedDice(attack.Energy);
            if (attack.ConsumesEnergy)
                hero.Energy -= attack.Energy;
            if (attack.ConsumesItem)
                hero.Inventory.Remove(attack.Item);

            return (hero, damage);
        }
    }
}
