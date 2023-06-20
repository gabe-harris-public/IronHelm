// Ignore Spelling: Olma

using IronHelm.Heroes;
using IronHelm.Trappings;

namespace IronHelm.Actions
{
    public static class HeroActions
    {
        public static IHero TrappingPurchase(KilnOlma kilnOlma, ITrapping trapping)
        {
            return trapping.Purchase(kilnOlma);
        }

        public static IHero TrappingUse(KilnOlma kilnOlma, ITrapping trapping)
        {
            return trapping.Affect(kilnOlma);
        }
    }
}