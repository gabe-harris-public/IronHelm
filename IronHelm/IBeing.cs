namespace IronHelm
{
    public interface IBeing
    {
        int Health { get; set; }
        int HealthMaximum { get; set; }
        string Name { get; }
        int Wealth { get; set; }
    }
}