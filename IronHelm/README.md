# IronHelm
This is a game engine that builds upon Jason Glover's Card Game Iron Helm. The repository provides me with an opportunity to showcase complex business logic interactions and abstractions.

# IronHelm
 Game Engine based on Jason Glover's Card Game Iron Helm 

#Classes
classDiagram
class Hero {
    - EquipItem? equipItem
    - UnEquipItem? unEquipItem
    + int Coins
    + List<IHeroAttack> CombatAttacks
    + List<HeroConditions.Type> Conditions
    + int Encumbrance
    + int EncumbranceMaximum
    + int Energy
    + int EnergyMaximum
    + int Health
    + int HealthMaximum
    + List<IItem> Inventory
    + string Name
    + int Rations
    + List<ISkill> SkillList
    + List<ISkillProficiency> SkillProficiencies
    + int Attack(IHeroAttack? requestedAttack)
    + void Equip(IItem item)
    + void UnEquip(IItem item)
}

classDiagram
class HeroActions {
    <<static>>
    +EncumbranceIncrease(hero: Hero, item: IItem): Hero
    +EnergyDecrease(hero: Hero, amount: int): Hero
    +EnergyIncrease(hero: Hero, amount: int): Hero
    +HealthDecrease(hero: Hero, amount: int): Hero
    +HealthIncrease(hero: Hero, amount: int): Hero
    +ItemAddToInventory(hero: Hero, item: IItem): Hero
    +ItemPurchase(hero: Hero, item: IItem): Hero
    +ItemRemoveFromInventory(hero: Hero, item: IItem): Hero
    +ItemUse(hero: Hero, item: IItem): Hero
    +RationsDecrease(hero: Hero, amount: int): Hero
    +RationsIncrease(hero: Hero, amount: int): Hero
    +EncumbranceDecrease(hero: Hero, item: IItem): Hero
}
class Hero
interface IItem

HeroActions --> Hero
HeroActions --> IItem
