// Ignore Spelling: Shroom

using IronHelm.Heroes;

namespace IronHelm.Trappings
{
    public class DuskShroom : IItem
    {
        public string Name => "Dusk Shroom";

        public int Cost => 2;

        public int Encumbrance => 1;

        public IHero Affect(IHero hero)
        {
            hero.Energy += 2;
            hero.Health += 2;
            hero.EncumbranceMaximum -= 1;
            return hero;
        }

        public IHero Purchase(IHero hero)
        {
            hero.Wealth -= 2;
            hero.EncumbranceMaximum += 1;
            return hero;
        }
    }
}