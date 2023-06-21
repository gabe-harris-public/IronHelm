// Ignore Spelling: Shroom

using IronHelm.Heroes;
using IronHelm.Trappings;

namespace IronHelmTests
{
    public class HeroActions
    {
        [Fact]
        public void PurchaseAndUseRationTrapping()
        {
            var kilnOlma = new KilnOlma();

            var beforePurchaseWealth = kilnOlma.Wealth;
            kilnOlma = (KilnOlma)IronHelm.Actions.HeroActions.ItemPurchase(kilnOlma, new Rations());
            var afterPurchaseWealth = kilnOlma.Wealth;
            Assert.NotEqual(beforePurchaseWealth, afterPurchaseWealth);

            var beforeRationCount = kilnOlma.Rations;
            kilnOlma = (KilnOlma)IronHelm.Actions.HeroActions.ItemUse(kilnOlma, new Rations());
            var afterRationCount = kilnOlma.Rations;
            Assert.NotEqual(beforeRationCount, afterRationCount);
        }

        [Fact]
        public void PurchaseAndUseDuskShroom()
        {
            var kilnOlma = new KilnOlma();

            var beforePurchaseWealth = kilnOlma.Wealth;
            kilnOlma = (KilnOlma)IronHelm.Actions.HeroActions.ItemPurchase(kilnOlma, new DuskShroom());
            var afterPurchaseWealth = kilnOlma.Wealth;
            Assert.NotEqual(beforePurchaseWealth, afterPurchaseWealth);

            var healthBeforeDarkShroom = kilnOlma.Health;
            var energyBeforeDarkShroom = kilnOlma.Energy;
            kilnOlma = (KilnOlma)IronHelm.Actions.HeroActions.HealthDecrease(kilnOlma, 2);
            kilnOlma = (KilnOlma)IronHelm.Actions.HeroActions.EnergyDecrease(kilnOlma, 2);
            kilnOlma = (KilnOlma)IronHelm.Actions.HeroActions.ItemUse(kilnOlma, new DuskShroom());
            var healthAfterDarkShroom = kilnOlma.Health;
            var energyAfterDarkShroom = kilnOlma.Energy;

            Assert.Equal(healthBeforeDarkShroom, healthAfterDarkShroom);
            Assert.Equal(energyBeforeDarkShroom, energyAfterDarkShroom);
        }
    }
}