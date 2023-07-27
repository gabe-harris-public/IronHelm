using IronHelm.Enumerations;
using IronHelm.Inventory;
using IronHelm.SkillProficiencies;
using IronHelm.Skills;
using IronHelm.Combat;

namespace IronHelm.Heroes
{
    public abstract class Hero : IHero, IBeing
    {

        private delegate void EquipItem(Hero hero);
        private EquipItem equipItem;

        private delegate void UnEquipItem(Hero hero);
        private UnEquipItem unEquipItem;


        public void Equip(IItem item)
        {
            if (Inventory.Contains(item))
            {
                equipItem = item.Equip;
                equipItem(this);
            };
        }

        public void UnEquip(IItem item)
        {
            if (Inventory.Contains(item))
            {

            };
        }


        public Hero()
        {
            Inventory.Add(new Fist());
        }

        public int Attack(IHeroAttack? requestedAttack)
        {
            if (requestedAttack is null) { throw new Exception($"No Attack specified"); }

            var foundAttack = CombatAttacks.Find(a => a.Name == requestedAttack.Name)
                ?? throw new Exception($"Attack {requestedAttack.Name} not available");

            int damage;

            if (foundAttack.ConsumesEnergy)
            {
                Energy -= foundAttack.Energy;
                damage = Combat.Actions.Roll6SidedDice(foundAttack.Energy);
            }
            else
            {
                damage = foundAttack.Damage;
            }

            if (foundAttack.ConsumesItem)
                Inventory.Remove(foundAttack.Item);

            return damage;
        }

        public List<IHeroAttack> CombatAttacks { get; set; } = new List<IHeroAttack>();
        public List<HeroConditions.Type> Conditions { get; set; } = new List<HeroConditions.Type>();
        public int Encumbrance { get; set; }
        public int EncumbranceMaximum { get; set; }
        public int Energy { get; set; }
        public int EnergyMaximum { get; set; }
        public int Health { get; set; }
        public int HealthMaximum { get; set; }
        public List<IItem> Inventory { get; set; } = new List<IItem>();
        public string Name { get; set; } = string.Empty;
        public int Rations { get; set; }
        public List<ISkill> SkillList { get; set; } = new List<ISkill>();
        public List<ISkillProficiency> SkillProficiencies { get; set; } = new List<ISkillProficiency>();
        public int Wealth { get; set; }
    }
}