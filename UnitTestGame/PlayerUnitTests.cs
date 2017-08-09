using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Game;
using System.Collections.Generic;
using Game.Units;

namespace UnitTestGame
{
    [TestClass]
    public class PlayerUnitTests
    {
        [TestMethod]
        public void TestPlayerArmyDecleration()
        {
            var unit = new IUnit []{ new Barbarian(25, 10), new Archer(25, 10), new Wizard(25, 10) };
            var army = new List<IUnit>() { unit. };
            var player = new Player("Name", new Army(army));

            Assert.AreEqual(unit.GetType(), player.Army.GetFirstUnit().GetType());
        }
    }
}
