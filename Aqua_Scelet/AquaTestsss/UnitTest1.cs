using Aqua;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using System;

namespace AquaTestsss
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FishConstructorShouldInicializeCorrectly()
        {
            Fish fish = new Fish("Salmon",40);

            Assert.AreEqual("Salmon", fish.Type);
            Assert.AreEqual(40, fish.Price);
        }
        [Test]

        public void AquariumConstructorShouldInicializeCorrectly()
        {
            Aquarium aquarium = new Aquarium("Square",100);

            Assert.AreEqual("Square", aquarium.Shape);
            Assert.AreEqual(100, aquarium.Capacity);
        }
        [Test]

        public void RemoveMethodShoudThrowExIfListIsEmpty()
        {
            Aquarium aquarium = new Aquarium("Square");

            Assert.Throws<InvalidOperationException>(() => aquarium.RemoveFish(aquarium.Fishes));
        }
        [Test]

        public void RemoveMethodShoudThrowExactExceptionMessageIfListIsEmpty()
        {
            Aquarium aquarium = new Aquarium("Square");

            var ex = Assert.Throws<InvalidOperationException>(() => aquarium.RemoveFish(aquarium.Fishes));

            Assert.AreEqual(ex.Message, "Invalid Operation");
        }

        [Test]

        public void RemoveMethodShoudThrowExeptionIfFishIsMissing()
        {

            Assert.Throws<InvalidOperationException>(());
        }
        [Test]
        public void RemoveMethodShoudThrowExactMessageIfFishIsMissing()
        {

            var ex = Assert.Throws<InvalidOperationException>(());

            Assert.AreEqual();
        }

        [Test]
        public void RemoveMethodShoudWorkCorrectlyAndDecreseNumberOfFishesInTheList()
        {
            Aquarium aquarium = new Aquarium("Square");

        }

        [Test]
        public void EmptyMethodShoudWorkCorrectly()
        {
            Aquarium aquarium = new Aquarium("Square");

            Assert.IsEmpty(aquarium.Fishes.Count);
        }

    }
}