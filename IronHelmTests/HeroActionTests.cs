// Ignore Spelling: Shroom

using IronHelm.Actions;
using IronHelm.Heroes;
using IronHelm.Inventory;

namespace IronHelmTests
{
    public class HeroActionTests
    {
        [Fact]
        public void PurchaseAndUseRationTrapping()
        {
            var kilnOlma = new KilnOlma();

            var beforePurchaseWealth = kilnOlma.Wealth;
            HeroActions.ItemPurchase(kilnOlma, new Rations());
            var afterPurchaseWealth = kilnOlma.Wealth;

            var beforeRationCount = kilnOlma.Rations;
            HeroActions.ItemUse(kilnOlma, new Rations());
            var afterRationCount = kilnOlma.Rations;

            Assert.NotEqual(beforePurchaseWealth, afterPurchaseWealth);
            Assert.NotEqual(beforeRationCount, afterRationCount);
        }

        [Fact]
        public void PurchaseAndUseDuskShroom()
        {
            var kilnOlma = new KilnOlma();

            var beforePurchaseWealth = kilnOlma.Wealth;
            IronHelm.Actions.HeroActions.ItemPurchase(kilnOlma, new DuskShroom());
            var afterPurchaseWealth = kilnOlma.Wealth;

            var healthBeforeDarkShroom = kilnOlma.Health;
            var energyBeforeDarkShroom = kilnOlma.Energy;
            HeroActions.HealthDecrease(kilnOlma, 2);
            HeroActions.EnergyDecrease(kilnOlma, 2);
            HeroActions.ItemUse(kilnOlma, new DuskShroom());
            var healthAfterDarkShroom = kilnOlma.Health;
            var energyAfterDarkShroom = kilnOlma.Energy;

            Assert.NotEqual(beforePurchaseWealth, afterPurchaseWealth);
            Assert.Equal(healthBeforeDarkShroom, healthAfterDarkShroom);
            Assert.Equal(energyBeforeDarkShroom, energyAfterDarkShroom);
        }
        [Fact]
        public void BasicAttack()
        {
            var kilnOlma = new KilnOlma();
            var energyBeforeAttack = kilnOlma.Energy;
            var attackBasic = HeroCombatActions.AttackBasic(kilnOlma, 3);
            kilnOlma = (KilnOlma)attackBasic.hero;
            var energyAfterAttack = kilnOlma.Energy;

            Assert.True(attackBasic.damage > 0);
            Assert.True(energyBeforeAttack > energyAfterAttack);
        }

        [Fact]
        public void PurchaseAndThrowAxe()
        {
            var kilnOlma = new KilnOlma();
            var axe = new Axe();
            HeroActions.ItemPurchase(kilnOlma, axe);
            HeroCombatActions.AttackSpecial(KilnOlma, new ThrowAxe());
        }
    }
}