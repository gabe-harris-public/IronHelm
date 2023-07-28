﻿using IronHelm.Enumerations;
using IronHelm.Inventory;
using IronHelm.SkillProficiencies;
using IronHelm.Skills;
using IronHelm.Combat;

namespace IronHelm.Heroes
{
    public abstract class Hero : IHero, IBeing
    {

        private delegate void EquipItem(Hero hero);
        private EquipItem? equipItem;

        private delegate void UnEquipItem(Hero hero);
        private UnEquipItem? unEquipItem;


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
                //TODO Finish unequip
            };
        }


        public Hero()
        {
            Inventory.Add(new Fist());
        }

        public int Attack(IHeroAttack? requestedAttack)
        {
            switch (requestedAttack)
            {
                case null:
                    throw new ArgumentNullException(nameof(requestedAttack), "No attack specified");
                case IHeroAttack attack when !CombatAttacks.Any(x => x.Name == attack.Name):
                    throw new ArgumentException($"Attack {attack.GetType()} not available", nameof(requestedAttack));
            }

            int damage;

            if (requestedAttack.ConsumesEnergy)
                Energy -= requestedAttack.Energy;

            if (requestedAttack.HasPredeterminedDamage)
                damage = requestedAttack.Damage;
            else
                damage = Combat.Actions.Roll6SidedDice(requestedAttack.Energy);

            if (requestedAttack.ConsumesItem)
            {
                var attackItem = Inventory.Find(i => i.Name == requestedAttack.Item.Name);
                if (attackItem is not null)
                    Inventory.Remove(attackItem);
                else throw new Exception($"{requestedAttack.Item.GetType()} not found in inventory");
            }

            if (requestedAttack.ConsumesAttack)
            {
                var combatAttack = CombatAttacks.Find(i => i.Name == requestedAttack.Name);
                if (combatAttack is not null)
                    CombatAttacks.Remove(requestedAttack);
                //BUG Should also remove the Axe attack.
                //Find the item and retrive all it's attacks and remove them.
                else throw new Exception($"{requestedAttack.Item.GetType()} not found in combat attacks");
            }

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
        public int Coins { get; set; }
    }
}