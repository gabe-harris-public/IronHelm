namespace IronHelm.Trappings
{
    public interface ITrapping
    {
        string Name { get; }
        int Cost { get; }
        int Encumbrance { get; }
    }
}