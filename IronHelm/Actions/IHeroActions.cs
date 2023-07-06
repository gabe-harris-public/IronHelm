using IronHelm.Heroes;
using IronHelm.Inventory;

namespace IronHelm.Actions
{
    public interface IHeroActions
    {
        IHero TrappingUse(IHero hero, IItem trapping);
    }
}