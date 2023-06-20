using IronHelm.Heroes;
using IronHelm.Trappings;

namespace IronHelm.Actions
{
    public interface IHeroActions
    {
        IHero TrappingUse(IHero hero, IItem trapping);
    }
}