using System;

namespace DiggersAndFliers
{
    public class FlyingAnimal : Animal, IFlyable, IWalkable
    {
        public int MaximumHight { get; set; }

        public int WingSpan { get; set; }

        public void Fly()
        {
            System.Console.WriteLine($"{Name} is now flying");
        }

        public void Walk()
        {
            System.Console.WriteLine($"{Name} is now walking");
        }

        public void Run()
        {
            System.Console.WriteLine($"{Name} in now running");
        }
    }
}