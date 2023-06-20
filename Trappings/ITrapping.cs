using IronHelm.Heroes;

namespace IronHelm.Trappings
{
    public interface ITrapping
    {
        string Name { get; }
        int Cost { get; }
        int Encumbrance { get; }

        IHero Affect(IHero hero);
        IHero Purchase(IHero hero);
    }
}