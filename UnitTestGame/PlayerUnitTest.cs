using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Game;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace UnitTestGame
{
    [TestClass]
    public class PlayerUnitTest
    {
        [TestMethod]
        public void TestPlayer()
        {
            var army = new List<IUnit>() { new Barbarian(25, 10), new Archer(25, 10), new Wizard(25, 10) };
            var player = new Player("Tyler", new Army(army));

            Assert.AreEqual(army.ElementAt(0).GetType(), player.Army.Units.ElementAt(0).GetType());
            System.Console.WriteLine($"Expected: {army.ElementAt(0).GetType()} Actual: {player.Army.Units.ElementAt(0).GetType()}");
            Assert.AreEqual(army.ElementAt(1).GetType(), player.Army.Units.ElementAt(1).GetType());
            System.Console.WriteLine($"Expected: {army.ElementAt(1).GetType()} Actual: {player.Army.Units.ElementAt(1).GetType()}");
            Assert.AreEqual(army.ElementAt(2).GetType(), player.Army.Units.ElementAt(2).GetType());
            System.Console.WriteLine($"Expected: {army.ElementAt(2).GetType()} Actual: {player.Army.Units.ElementAt(2).GetType()}");
        }
    }
}
