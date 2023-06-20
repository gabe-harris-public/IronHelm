using IronHelm.Heroes;

namespace IronHelm.Trappings
{
    public class Rations : ITrapping
    {
        public int Cost => 1;
        public int Encumbrance => 0;
        public string Name => "Rations";

        public IHero Affect(IHero hero)
        {
            hero.Encumbrance -= Encumbrance;
            hero.Rations += 2;
            return hero;
        }

        public IHero Purchase(IHero hero)
        {
            hero.Wealth -= 1;
            return hero;
        }
    }
}