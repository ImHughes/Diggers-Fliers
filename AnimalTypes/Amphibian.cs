namespace DiggersAndFliers
{
    public class Amphibian : Animal, IWalkable, ISwimable
    {
        public int MaxDepth { get; set; }
        public int Speed { get; set; }

        public void Run()
        {
            System.Console.WriteLine($"{Name} is running");
        }

        public void Walk()
        {
            System.Console.WriteLine($"{Name} is walking");
        }

        public void Swim()
        {
            System.Console.WriteLine($"{Name} is swimming");
        }

    }
}