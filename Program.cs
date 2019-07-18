using System;
using System.Collections.Generic;

namespace DiggersAndFliers
{
    class Program
    {
        static void Main(string[] args)
        {
            var Bear = new LandAnimal() { Name = "Bear" };

            var Parakeet = new FlyingAnimal() { Name = "Parakeet" };

            var Earthworms = new LandAnimal() { Name = "Earthworms" };

            var Dog = new LandAnimal() { Name = "Dog" };

            var BettaFish = new SwimmingAnimal() { Name = "Betta Fish" };

            var CopperheadSnake = new Amphibian() { Name = "Copper Head" };

            var Groundhog = new LandAnimal() { Name = "Groundhog" };


            var FlierContainer = new FlierContainer();
            FlierContainer.Fliers = new List<IFlyable>() { Parakeet };

            var DiggerContainer = new DiggerContainer();
            DiggerContainer.Digger = new List<IDiggable>() { Bear, Earthworms, Dog, Groundhog };

            var SwimmerContainer = new SwimmerContainer();
            SwimmerContainer.Swimmers = new List<ISwimable>() { BettaFish, CopperheadSnake };

            var WalkerContainer = new WalkerContainer();
            WalkerContainer.Walkers = new List<IWalkable>() { Bear, Dog, Groundhog, Parakeet };

            Dog.Run();
            BettaFish.Swim();
            Bear.Walk();
            Groundhog.Dig();
        }
    }
}
