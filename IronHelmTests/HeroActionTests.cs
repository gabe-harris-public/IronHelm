// Ignore Spelling: Shroom

using IronHelm.Actions;
using IronHelm.Combat;
using IronHelm.Heroes;
using IronHelm.Inventory;

namespace IronHelmTests
{
    public class HeroActionTests
    {
        [Fact]
        public void FistMartialArtsAttack()
        {
            var kilnOlma = new KilnOlma();
            var energyBeforeAttack = kilnOlma.Energy;

            //Equip fist
            IItem? fistMartialArts = kilnOlma.Inventory.Find(i => i.GetType() == typeof(FistMartialArts));
            kilnOlma.Equip(fistMartialArts);

            //Attack
            var damage = kilnOlma.Attack(new AttackFistMartialArts());
            var energyAfterAttack = kilnOlma.Energy;

            Assert.True(kilnOlma.CombatAttacks.Count > 0);
            Assert.True(damage > 0);
            Assert.True(energyBeforeAttack == energyAfterAttack);
        }

        [Fact]
        public void PurchaseAndThrowAxe()
        {
            var kilnOlma = new KilnOlma();
            var axe = new Axe();

            var coinsBeforePurchase = kilnOlma.Coins;
            var encumbranceBeforePurchase = kilnOlma.Encumbrance;
            HeroActions.ItemPurchase(kilnOlma, axe);
            Assert.NotEqual(coinsBeforePurchase, kilnOlma.Coins);
            Assert.NotEqual(encumbranceBeforePurchase, kilnOlma.Encumbrance);

            kilnOlma.Equip(axe);

            var attackAxeThrow = new AttackAxeThrow();

            var damage = kilnOlma.Attack(attackAxeThrow);

            Assert.NotEqual(0, damage);
            Assert.DoesNotContain(axe, kilnOlma.Inventory);

            Assert.DoesNotContain(attackAxeThrow, kilnOlma.CombatAttacks);
        }

        [Fact]
        public void PurchaseAndUseDuskShroom()
        {
            var kilnOlma = new KilnOlma();

            var beforePurchaseWealth = kilnOlma.Coins;
            HeroActions.ItemPurchase(kilnOlma, new DuskShroom());
            var afterPurchaseWealth = kilnOlma.Coins;

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
        public void PurchaseAndUseRationTrapping()
        {
            var kilnOlma = new KilnOlma();

            var beforePurchaseWealth = kilnOlma.Coins;
            HeroActions.ItemPurchase(kilnOlma, new Rations());
            var afterPurchaseWealth = kilnOlma.Coins;

            var beforeRationCount = kilnOlma.Rations;
            HeroActions.ItemUse(kilnOlma, new Rations());
            var afterRationCount = kilnOlma.Rations;

            Assert.NotEqual(beforePurchaseWealth, afterPurchaseWealth);
            Assert.NotEqual(beforeRationCount, afterRationCount);
        }
    }
}