namespace IronHelm.Combat
{
    public static class Actions
    {
        public static int Roll6SidedDice(int energy)
        {
            int[] diceRolls = Enumerable.Range(1, energy)
                .Select(_ => new Random().Next(1, 6))
                .ToArray();

            return diceRolls.Sum();
        }
    }
}
