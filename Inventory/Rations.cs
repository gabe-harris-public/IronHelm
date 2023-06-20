using IronHelm.Heroes;

namespace IronHelm.Trappings
{
    public class Rations : IItem
    {
        public int Cost => 1;
        public int Encumbrance => 0;
        public string Name => "Rations";

        public IHero Affect(IHero hero)
        {
            hero.EncumbranceMaximum -= Encumbrance;
            hero.Rations += 2;
            return hero;
        }

        public IHero Purchase(IHero hero)
        {
            hero.Wealth -= 1;
            hero.EncumbranceMaximum += 0;
            hero.Inventory.Add(new Rations());
            return hero;
        }
    }
}