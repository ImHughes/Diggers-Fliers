namespace DiggersAndFliers
{
    public class SwimmingAnimal : Animal, ISwimable
    {
        public int MaxDepth { get; set; }

        public void Swim()
        {
            System.Console.WriteLine($"{Name} is swimming");
        }
    }
}