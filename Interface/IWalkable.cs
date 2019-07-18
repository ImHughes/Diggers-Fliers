namespace DiggersAndFliers
{
    public interface IWalkable
    {
        string Name { get; set; }
        void Walk();
        void Run();
    }
}