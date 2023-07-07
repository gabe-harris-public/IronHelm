using IronHelm.Combat;
using IronHelm.Heroes;

namespace IronHelm.Actions
{
    static public class HeroCombatActions
    {
        public static (Hero hero, int damage) Attack(Hero hero, IHeroAttack attack)
        {
            if (attack == null) { throw new Exception($"Attack not found"); }

            int damage;
            
            if (attack.ConsumesEnergy)
            {
                hero.Energy -= attack.Energy;
                damage = Combat.Actions.Roll6SidedDice(attack.Energy);
            }
            else
            {
                damage = attack.Damage;
            }

            if (attack.ConsumesItem)
                hero.Inventory.Remove(attack.Item);

            return (hero, damage);
        }
    }
}
