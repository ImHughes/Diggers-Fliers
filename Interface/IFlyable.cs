namespace DiggersAndFliers
{
    public interface IFlyable
    {
        string Name { get; set; }

        void Fly();

        int MaximumHight { get; }

    }
}