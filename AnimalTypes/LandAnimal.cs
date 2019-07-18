namespace DiggersAndFliers
{
    public class LandAnimal : Animal, IWalkable, IDiggable
    {
        public int Speed { get; set; }
        public int NumberOfLegs { get; set; }

        public void Run()
        {
            System.Console.WriteLine($"{Name} is running");
        }
        public void Walk()
        {
            System.Console.WriteLine($"{Name} is now running");
        }

        public void Dig()
        {
            System.Console.WriteLine($"{Name} is now digging");
        }
    }
}