namespace IronHelm.Combat
{
    public static class Actions
    {
        public static int Roll6SidedDice(int stamina)
        {
            int[] diceRolls = Enumerable.Range(1, stamina)
                .Select(_ => new Random().Next(1, 6))
                .ToArray();

            return diceRolls.Sum();
        }
    }
}
