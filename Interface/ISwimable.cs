namespace DiggersAndFliers
{
    public interface ISwimable
    {
        string Name { get; set; }

        void Swim();

        int MaxDepth { get; }
    }
}