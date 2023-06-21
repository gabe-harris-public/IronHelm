﻿// Ignore Spelling: Olma

<<<<<<< Updated upstream
using IronHelm.Actions;
=======
using IronHelm.Enumerations;
>>>>>>> Stashed changes
using IronHelm.SkillProficiencies;
using IronHelm.Skills;
using IronHelm.Trappings;

namespace IronHelm.Heroes
{
    public class KilnOlma : IHero
    {
        public KilnOlma()
        {
            Name = "Kiln-Olma";
            
            HealthMaximum = 11;
            Health = HealthMaximum;

            EnergyMaximum = 13;
            Energy = EnergyMaximum;

            EncumbranceMaximum = 10;
            Wealth = 2;
            Rations = 2;
            Inventory = new List<IItem>            {
                new DuskShroom()
            };
            SkillList = new List<ISkill>            {
                new MartialArts()
            };
            SkillProficiencies = new List<ISkillProficiency>            {
                new Mind()
            };
            HeroConditions = new List<HeroConditions.Type> {
                new HeroConditions.Type()
            };
        }

        public int EncumbranceMaximum { get; set; }
        public int Energy { get; set; }
        public int Health { get; set; } 
        public string Name { get; }
        public int Rations { get; set; }
        public List<ISkill> SkillList { get; set; }
        public List<ISkillProficiency> SkillProficiencies { get; set; }
        public List<IItem> Inventory { get; set; }
        public int Wealth { get; set; }
        public int EnergyMaximum { get; set; }
        public int HealthMaximum { get; set; }
        public List<HeroConditions.Type> HeroConditions { get; set; }
    }
}